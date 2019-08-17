using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using ITSolution.Framework.Enumeradores;

namespace ITE.DataControl.Company.MAB
{
    public partial class XFrmRealEuro : DevExpress.XtraEditors.XtraForm
    {
        //use any european culture
        //var valorFormatado = string.Format(numberFormatInfo, "de-DE", e.DisplayText);
        ///fr-FR
        private readonly CultureInfo cultureInfoEuropa = CultureInfo.GetCultureInfo("fr-FR");//
        private readonly CultureInfo cultureInfoBrasil = CultureInfo.GetCultureInfo("pt-BR");//
        private TypeMoeda type = TypeMoeda.Real;

        public XFrmRealEuro()
        {
            InitializeComponent();

            //var excel = @"D:\Desktop\Relação de embarques 2016 JST.xlsx";

            //ConnectionExcel e = new ConnectionExcel(excel);

            //e.FillGridControl(gridControl1);


            var lista = new List<ModelControlLancamento>();

            for (int i = 1; i < 20; i++)
            {
                var m = new ModelControlLancamento();

                m.DataLancamento = DateTime.Now;
                m.ValorLancamento = i + 1000 * 2;
                m.DataVencimento = DateTime.Now.AddDays(60).Date;
                m.Observacao = "JST 016/0" + i;

                if (i % 2 == 0)
                    m.Moeda = TypeMoeda.Euro;
                else
                    m.Moeda = TypeMoeda.Real;
                lista.Add(m);
            }

            gridControl1.DataSource = lista;
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column == colMoeda)
            {
                type = (TypeMoeda)e.Value;
            }
            if (e.Column == colValorLancamento)
            {
                if (type == TypeMoeda.Euro)
                    e.DisplayText = string.Format(cultureInfoEuropa, "{0:C}", e.Value);
                else
                    e.DisplayText = string.Format(cultureInfoBrasil, "{0:C}", e.Value);
            }

        }

        private void culture(ModelControlLancamento m)
        {

            // obtém a cultura local
            var cultureInfo = Thread.CurrentThread.CurrentCulture;
            // faz uma cópia das informações de formatação de número da cultura local
            var numberFormatInfo = (NumberFormatInfo)cultureInfo.NumberFormat.Clone();
            // fixa o símbolo da moeda estrangeira
            numberFormatInfo.CurrencySymbol = "US$";
            // obtém o valor em moeda estrangeira formatado conforme a cultura local
            //var valorFormatado = string.Format(numberFormatInfo, "{0:C}", valor);
        }

        private void XFrmRealEuro_Shown(object sender, EventArgs e)
        {
        }
    }
}