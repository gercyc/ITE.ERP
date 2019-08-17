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
using ITE.Entidades.Repositorio;
using ITE.Entidades.Enumeradores.CEEnums;

namespace ITE.CE.Forms.View
{
    public partial class XFrmAddDespesa : DevExpress.XtraEditors.XtraForm
    {
        public DespesaCusteio Despesa { get; private set; }

        public XFrmAddDespesa()
        {
            InitializeComponent();
            //ReflectionIts.ShowComponentsFromGroupControl(this,true);
        }

        public XFrmAddDespesa(DespesaCusteio despesa)
        {
            indexarDados(despesa);
        }

        private DespesaCusteio indexarDados()
        {
            var tipo = (TypeDespesaCusteio)radioGroupTipoDespesa.SelectedIndex;
            decimal aliquota = ParseUtil.ToDecimal(textEditAliquota.Text);
            decimal valorDespesa = ParseUtil.ToDecimal(textEditValorDespesa.Text);
            var discriminacaoDespesa = buttonEditDiscriminacaoDespesa.Text;

            var d = new DespesaCusteio()
            {
                DiscriminacaoDespesa = discriminacaoDespesa,
                ValorAliquota = aliquota,
                ValorDespesa = valorDespesa,
                Tipo = tipo
            };

            return d;
        }

        private DespesaCusteio indexarDados(DespesaCusteio despesa)
        {
            radioGroupTipoDespesa.SelectedIndex = (int)despesa.Tipo;
            textEditAliquota.Text = despesa.ValorAliquota.ToString("n2");
            textEditValorDespesa.Text = despesa.ValorDespesa.ToString("n2");
            buttonEditDiscriminacaoDespesa.Text = despesa.DiscriminacaoDespesa;

            //indexar os campos aqui
            return despesa;
        }

        //Add um auto complete no campo
       

        private void buttonEditDespesa_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            //show despesas existente

        }

        /// <summary>
        /// Exibe os campos aliquota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkEditAliquota_CheckedChanged(object sender, EventArgs e)
        {
            labelControl4.Visible = checkEditAliquota.Checked;
            textEditAliquota.Visible = checkEditAliquota.Checked;
        }

        private void XFrmAddDespesa_Shown(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext(false))
            {
                string[] dados = ctx.DespesasCusteio.Select(i => i.DiscriminacaoDespesa).ToArray();

                AutoCompleteIts.AddAutoCompleteButtonEdit(buttonEditDiscriminacaoDespesa, dados);

            }
        }

        private void simpleButtonSalvar_Click(object sender, EventArgs e)
        {
            if (this.Despesa == null)
            {
                //save   
                this.Despesa = indexarDados();
            }
            else
            {
                //update

            }

            //suaviza o fechamento
            this.Close();
            this.Dispose();
        }
    }
}