using System;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;
using ITE.Entidades.Enumeradores.TipoMovimentoEnum;
using ITE.Entidades.POCO.Contabil;
using ITE.Fiscal.RegrasFiscais.Managers;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;

namespace ITE.Fiscal.TpMovimento
{
    public partial class XFrmParametrizarMovimentoView : DevExpress.XtraEditors.XtraForm
    {
        private FormTypeAction formTypeAction;
        private TipoMovimento current_tipoMovimento;

        public XFrmParametrizarMovimentoView()
        {
            InitializeComponent();
            FormsUtil.AddShortcutEscapeOnDispose(this);

        }
        public XFrmParametrizarMovimentoView(TipoMovimento tipoMovimento, FormTypeAction acao) : this()
        {
            this.current_tipoMovimento = tipoMovimento;
            this.formTypeAction = acao;
            indexarCampos();
        }
        private TipoMovimento indexarParametrizacao()
        {
            var param = new TipoMovimento();

            param.CodigoTipoMovimento = txtCodTpMovimento.Text;
            param.DescricaoTipoMovimento = txtDescTpMov.Text;
            param.CategoriaTipoMovimento = (TypeCategoriaTipoMovimento)cbCategoriaTpMov.SelectedIndex + 1; //indexado a partir do 1
            param.Direcao = (TypeDirecao)rdDirecao.SelectedIndex;
            param.Numeracao = (TypeConfigNumeracao)rdNumeracao.SelectedIndex + 1; //indexado a partir do 1
            param.MovimentarEstoque = chkMovimentaEstoque.Checked;
            param.InformarCentro = chkInfoCentroCusto.Checked;
            param.GeraMovimentoFiscal = chkGeraDadosFiscais.Checked;
            param.GerarFaturamento = chkGerarFaturamento.Checked;
            param.EmiteNFe = chkEmiteNFe.Checked;
            if (lookUpLocalEstoque1.LocalEstoque != null)
            {
                param.LocalEstoque = lookUpLocalEstoque1.LocalEstoque;
                param.IdLocalEstoque = lookUpLocalEstoque1.LocalEstoque.IdLocalEstoque;
            }
            if (lookUpFormaPagamento1.FormaPagto != null)
            {
                param.FormaPagamento = lookUpFormaPagamento1.FormaPagto;
                param.IdFormaPagamentoDefault = lookUpFormaPagamento1.FormaPagto.IdFormaPagamento;
            }
            if (lookUpCentroCusto1.CentroCusto != null)
            {
                param.CentroCusto = lookUpCentroCusto1.CentroCusto;
                param.IdCentroCustoDefault = lookUpCentroCusto1.CentroCusto.IdCentroCusto;
            }
            //se esta editando e nao mudou o combo da categoria..
            if (param.CategoriaTipoMovimento == 0 && current_tipoMovimento != null)
                param.CategoriaTipoMovimento = current_tipoMovimento.CategoriaTipoMovimento;

            return param;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var manager = new TipoMovimentoDaoManager();

            if (formTypeAction == FormTypeAction.Alterar)
            {
                manager.UpdateTipoMovimento(indexarParametrizacao(), current_tipoMovimento);
            }
            else
            {
                if (manager.SaveTipoMovimento(indexarParametrizacao()))
                {
                    this.Dispose();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void indexarCampos()
        {
            this.Text = current_tipoMovimento.CodigoTipoMovimento + " - " + current_tipoMovimento.DescricaoTipoMovimento;
            txtCodTpMovimento.Text = current_tipoMovimento.CodigoTipoMovimento;
            txtDescTpMov.Text = current_tipoMovimento.DescricaoTipoMovimento;
            cbCategoriaTpMov.SelectedIndex = (int)current_tipoMovimento.CategoriaTipoMovimento + 1;
            cbCategoriaTpMov.Text = current_tipoMovimento.CategoriaTipoMovimento.ToString();
            rdDirecao.SelectedIndex = (int)current_tipoMovimento.Direcao;
            rdNumeracao.SelectedIndex = (int)current_tipoMovimento.Numeracao - 1;

            chkMovimentaEstoque.Checked = current_tipoMovimento.MovimentarEstoque;
            chkGeraDadosFiscais.Checked = current_tipoMovimento.GeraMovimentoFiscal;
            chkEmiteNFe.Checked = current_tipoMovimento.EmiteNFe;
            chkInfoCentroCusto.Checked = current_tipoMovimento.InformarCentro;
            chkGerarFaturamento.Checked = current_tipoMovimento.GerarFaturamento;

            if (current_tipoMovimento.IdFormaPagamentoDefault != null)
                lookUpFormaPagamento1.FindSetFormaPagto(current_tipoMovimento.IdFormaPagamentoDefault.ToString());
            if (current_tipoMovimento.IdCentroCustoDefault != null)
                lookUpCentroCusto1.FindSetCentroCusto(current_tipoMovimento.CentroCusto.CodigoCentroCusto);
            if (current_tipoMovimento.IdLocalEstoque != null)
                lookUpLocalEstoque1.FindSetLocalEstoque(current_tipoMovimento.LocalEstoque.CodigoLocalEstoque);

        }

        private void cbCategoriaTpMov_EditValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cbCategoriaTpMov.SelectedItem);
        }
    }
}