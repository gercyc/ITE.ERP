using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITSolution.Framework.Mensagem;

namespace ITE.Fiscal.Movimentacoes.NotaFiscal
{
    public partial class XFrmListaValidacaoNF : DevExpress.XtraEditors.XtraForm
    {
        private List<string> listErros;
        public bool Return { get; set; }

        public XFrmListaValidacaoNF()
        {
            InitializeComponent();
        }

        public XFrmListaValidacaoNF(List<string> listErros) : this()
        {
            this.listErros = listErros;
            gridControlValidList.DataSource = listErros;
            gridViewValidList.BestFitColumns();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var msg = "Certeza que deseja prosseguir com a criaçao da nota?";

            var result = XMessageIts.Confirmacao(msg);
            if(result == DialogResult.Yes)
            {
                this.Dispose();
            }

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            gridViewValidList.ShowPrintPreview();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Return = true;
            this.Dispose();
        }
    }
}