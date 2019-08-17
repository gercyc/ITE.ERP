using System;
using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.DaoManager.FiscalDaoManager;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.Enumeradores;

namespace ITE.Fiscal.RegrasFiscais
{
    public partial class XFrmAddRegraFiscal : DevExpress.XtraEditors.XtraForm
    {
        private RegraFiscal tipoMovimento;
        private FormTypeAction acao;
        public List<ImpostosRegraFiscal> impostosRemovidos = new List<ImpostosRegraFiscal>();

        public XFrmAddRegraFiscal()
        {
            InitializeComponent();
            FormsUtil.AddShortcutEscapeOnDispose(this);
            cbTipoNatureza.AddEnumValues(typeof(TypeDirecao));
            cbTipoDevolucao.AddEnumValues(typeof(TypeTipoDevolucao));
        }
        public XFrmAddRegraFiscal(RegraFiscal tipoMov, FormTypeAction acao) : this()
        {
            this.tipoMovimento = tipoMov;
            this.acao = acao;
            IndexarFormulario(tipoMov);
        }

        //salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var ctx = new BalcaoContext();
                var manager = new RegraFiscalDaoManager();
                tipoMovimento.Update(IndexarTipoMovimento());


                if (acao == FormTypeAction.Visualizar) //visualizando/editando o tipo de movimento
                {
                    if (manager.UpdateRegraFiscal(tipoMovimento, impostosRemovidos))
                    {
                        XMessageIts.Mensagem("Tipo de movimento atualizado com sucesso!");
                        IndexarFormulario(tipoMovimento);
                    }
                }

                else
                {
                    manager.ZerarReferencias(tipoMovimento);

                    var ok = ctx.RegraFiscalDao.Save(tipoMovimento);
                    if (ok)
                    {
                        XMessageIts.Mensagem("Tipo de movimento cadastrado com sucesso!");
                        this.Dispose();
                    }

                }
            }

            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Erro: ");
            }
        }

        //Indexa o tipo de movimento.
        private RegraFiscal IndexarTipoMovimento()
        {
            var tipoMovimentoNew = new RegraFiscal();
            tipoMovimentoNew.BaseLegal = memDispLegal.Text;
            tipoMovimentoNew.CodigoRegraFiscal = txtCodigoTpMov.Text;
            tipoMovimentoNew.DescricaoRegraFiscal = txtDescricaoMov.Text;
            tipoMovimentoNew.MovimentaEstoque = chkMovEstoque.Checked;
            tipoMovimentoNew.TipoDevolucao = cbTipoDevolucao.GetSelectedItem<TypeTipoDevolucao>();
            tipoMovimentoNew.TipoNatureza = cbTipoNatureza.GetSelectedItem<TypeDirecao>();

            return tipoMovimentoNew;
        }

        //remove o imposto selecionado
        private void btnRemoverImposto_Click(object sender, EventArgs e)
        {
            var impSel = gridView1.GetFocusedRow() as ImpostosRegraFiscal;
            if (impSel != null)
            {
                this.tipoMovimento.ImpostosRegraFiscal.Remove(impSel);
                impostosRemovidos.Add(impSel);
            }
        }

        //form pra add imposto
        private void btnNewImposto_Click(object sender, EventArgs e)
        {
            //se o mov for nulo, crie um para ser usado.
            if (this.tipoMovimento == null)
            {
                this.tipoMovimento = IndexarTipoMovimento();
            }

            var addImposto = new XFrmAddImpostoRegraFiscal();
            addImposto.ShowDialog();
            if (!addImposto.IsDisposed)
            {
                this.tipoMovimento.ImpostosRegraFiscal.Add(addImposto.ImpostoTpMov);
                UpdateGrid();
            }
        }
        private void UpdateGrid()
        {
            gridControl1.DataSource = this.tipoMovimento.ImpostosRegraFiscal.ToList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void IndexarFormulario(RegraFiscal tipoMovimento)
        {
            memDispLegal.Text = tipoMovimento.BaseLegal;
            txtCodigoTpMov.Text = tipoMovimento.CodigoRegraFiscal;
            txtDescricaoMov.Text = tipoMovimento.DescricaoRegraFiscal;
            chkMovEstoque.Checked = tipoMovimento.MovimentaEstoque;
            cbTipoDevolucao.SetSelectItem<TypeTipoDevolucao>(tipoMovimento.TipoDevolucao);
            cbTipoNatureza.SetSelectItem<TypeDirecao>(tipoMovimento.TipoNatureza);
            gridControl1.DataSource = tipoMovimento.ImpostosRegraFiscal.ToList();
        }

        private void btnEditarRegistro_Click(object sender, EventArgs e)
        {
            var impSel = gridView1.GetFocusedRow() as ImpostosRegraFiscal;
            if (impSel != null)
            {
                var editImposto = new XFrmAddImpostoRegraFiscal(impSel, FormTypeAction.Visualizar);
                editImposto.ShowDialog();
                UpdateGrid();

            }
        }
    }
}