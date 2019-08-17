using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO.CE;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Web.Bacen;

namespace ITE.CE.Forms.View
{
    public partial class XFrmAddMercadoria : DevExpress.XtraEditors.XtraForm
    {

        public ItemCusteio Mercadoria { get; private set; }
        private CotacaoCusteio cotacaoMonetaria;

        public XFrmAddMercadoria()
        {
            InitializeComponent();
            this.lookUpNCM1.AfterSelect = AfterSelect();
            //ReflectionIts.ShowComponentsFromGroupControl(this,true);
        }
        public XFrmAddMercadoria(CotacaoCusteio cotacaoMonetaria) : this()
        {
            this.cotacaoMonetaria = cotacaoMonetaria;
            if (this.cotacaoMonetaria != null)
            {
                lbMoedaSelect.Caption = cotacaoMonetaria.Moeda.NomeMoeda;
                txtCotacao.Caption = cotacaoMonetaria.ValorMoeda.ToString("N2");
            }
        }

        private MethodInvoker AfterSelect()

        {
            var method = new MethodInvoker(delegate
            {
                var ncm = this.lookUpNCM1.NCM;
                textEditAliqCofins.Text = ncm.AliquotaCOFINS.ToString("n2");
                textEditAliqPIS.Text = ncm.AliquotaPIS.ToString("n2");
                textEditAliqICMS.Text = ncm.AliquotaICMS.ToString("n2");
                textEditAliqIPI.Text = ncm.AliquotaIPI.ToString("n2");
                textEditAliqICMSST.Text = ncm.AliquotaICMSST.ToString("n2");
                textEditAliqII.Text = ncm.AliquotaII.ToString("n2");
            });

            return method;
        }

        public XFrmAddMercadoria(ItemCusteio mercadoria)
        {
            this.Mercadoria = indexarDados(mercadoria);
        }

        private ItemCusteio indexarDados()
        {
            //Base de calculo e aliquotas
            decimal valorMercadoriaME = ParseUtil.ToDecimal(textEditValorMercadoriaME.Text); //em moeda estrangeira
            decimal valorMercadoriaBrl = valorMercadoriaME * this.cotacaoMonetaria.ValorMoeda;
            txtVlrTotalMn.Text = valorMercadoriaBrl.ToString("n2");
            decimal AliqIcms = ParseUtil.ToDecimal(textEditAliqICMS.Text)/100;
            decimal AliqIcmsST = ParseUtil.ToDecimal(textEditAliqICMSST.Text)/100;
            decimal AliqPis = ParseUtil.ToDecimal(textEditAliqPIS.Text)/100;
            decimal Aliqcofins = ParseUtil.ToDecimal(textEditAliqCofins.Text)/100;
            decimal AliqIi = ParseUtil.ToDecimal(textEditAliqII.Text)/100;
            decimal AliqIpi = ParseUtil.ToDecimal(textEditAliqIPI.Text)/100;

            //valores dos impostos
            var VlrIcms = valorMercadoriaBrl * AliqIcms;
            var VlrIcmsSt = valorMercadoriaBrl * AliqIcmsST;
            var vlrPis = valorMercadoriaBrl * AliqPis;
            var vlrCofins = valorMercadoriaBrl * Aliqcofins;
            var vlrIi = valorMercadoriaBrl * AliqIi;
            var vlrIpi = valorMercadoriaBrl * AliqIpi;

            Ncms Ncm = lookUpNCM1.NCM;

            decimal peso = ParseUtil.ToDecimal(textEditPeso.Text);
            decimal quantidade = ParseUtil.ToDecimal(textEditQuantidade.Text);
            string mercadoria = buttonEditMercadoria.Text;


            var i = new ItemCusteio()
            {
                Ncm = Ncm.CodigoNcm,
                Mercadoria = mercadoria,
                Quantidade = quantidade,
                Peso = peso,
                ValorMoedaEstrangeira = valorMercadoriaME,
                PIS = vlrPis,
                Cofins = vlrCofins,
                II = vlrIi,
                IPI = vlrIpi,
                ICMS = VlrIcms,
                ICMSST = VlrIcmsSt,
                ValorReais = valorMercadoriaBrl
            };

            //total fob do item
            i.TotalFob = (i.ValorReais + vlrPis + vlrCofins + vlrIi + vlrIpi + VlrIcms + VlrIcmsSt);
            i.TotalUnitarioFob = (i.ValorReais + vlrPis + vlrCofins + vlrIi + vlrIpi + VlrIcms + VlrIcmsSt) / quantidade;

            return i;
        }

        private ItemCusteio indexarDados(ItemCusteio mercadoria)
        {
            //indexar campos aqui ;
            lookUpNCM1.FindSetNCM(mercadoria.Ncm);
            buttonEditMercadoria.Text = mercadoria.Mercadoria;
            textEditQuantidade.Text = mercadoria.Quantidade.ToString("n2");
            txtVlrUnitario.Text = (mercadoria.ValorMoedaEstrangeira / mercadoria.Quantidade).ToString("n2");
            textEditPeso.Text = mercadoria.Peso.ToString("n2");
            textEditValorMercadoriaME.Text = mercadoria.ValorMoedaEstrangeira.ToString("n2");
            txtVlrTotalMn.Text = mercadoria.ValorReais.ToString("n2");
            txtVlrCofins.Text = mercadoria.Cofins.ToString("n2");
            txtVlrPis.Text = mercadoria.PIS.ToString("n2");
            txtVlrII.Text = mercadoria.II.ToString("n2");
            txtVlrIpi.Text = mercadoria.IPI.ToString("n2");
            txtVlrIcms.Text = mercadoria.ICMS.ToString("n2");
            txtVlrIcmsSt.Text = mercadoria.ICMSST.ToString("n2");
            vlUnitFob.Text = mercadoria.TotalUnitarioFob.ToString("n2");
            vlrTotalFob.Text = mercadoria.TotalFob.ToString("n2");

            return mercadoria;
        }

        private void buttonEditMercadoria_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //show mercadorias here
        }

        private void simpleButtonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void XFrmAddMercadoria_Shown(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext(false))
            {
                string[] dados = ctx.ItensCusteios.Select(i => i.Mercadoria).ToArray();

                AutoCompleteIts.AddAutoCompleteButtonEdit(buttonEditMercadoria, dados);
            }
        }

        private void textEditValorMercadoria_Leave(object sender, EventArgs e)
        {
            indexarDados(indexarDados());
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Mercadoria == null)
            {
                //save   
                this.Mercadoria = indexarDados();
            }
            else
            {
                //update

            }

            //suaviza o fechamento
            this.Close();
            this.Dispose();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtVlrUnitario_Leave(object sender, EventArgs e)
        {
            var quantidade = ParseUtil.ToDecimal(textEditQuantidade.Text);
            var vlrUnitario = ParseUtil.ToDecimal(txtVlrUnitario.Text);
            textEditValorMercadoriaME.Text = (quantidade * vlrUnitario).ToString("n2");
        }
    }
}