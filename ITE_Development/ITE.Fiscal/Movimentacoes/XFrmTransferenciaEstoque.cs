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
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.POCO.Sales;
using ITSolution.Framework.Forms;
using ITSolution.Framework.GuiUtil;
using System.Reflection;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITE.Entidades.UnitControl;
using ITE.Entidades.DaoManager.FiscalDaoManager;
using ITSolution.Framework.Beans.ProgressBar;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;

namespace ITE.Fiscal.Movimentacoes
{
    public partial class XFrmTransferenciaEstoque : DevExpress.XtraEditors.XtraForm
    {
        private LocalEstoque origem;
        private LocalEstoque destino;
        private List<dynamic> produtos;
        private bool IsSuccess = false;


        public XFrmTransferenciaEstoque()
        {
            InitializeComponent();
            this.produtos = new List<dynamic>();
        }

        private void wizardPageOrgDest_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            origem = lookUpLocalEstoqueOrigem.LocalEstoque;
            destino = lookUpLocalEstoqueDestino.LocalEstoque;

            if (origem != null && destino != null)
                e.Valid = true;
            else
            {
                e.Valid = false;
                e.ErrorText = "Informe os locais de estoque para transferir os produtos";
                //XMessageIts.Advertencia("Informe os locais de estoque para transferir os produtos");
            }
        }

        private void wizardPageOrgDest_PageCommit(object sender, EventArgs e)
        {

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                using (var ctx = new BalcaoContext())
                {
                    var paramsEntity = new ParamsFindEntity()
                    {
                        Columns = new string[] { "IdProduto", "DescricaoProduto", "PrecoVenda",
                "QuantidadeProduto", "StatusProduto", "TipoItemProduto", "CategoriaProduto" },
                        Layout = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
                    "ITE.Components.Resources.produto_basico.xml"),
                        Context = ctx,
                        Title = "Localizar produto:",
                        Order = "IdProduto"
                    };

                    var selected = XFrmFindEntity.ShowDialogFindEntity<Produto>(paramsEntity);

                    if (selected != null)
                    {
                        var id = selected.GetType().GetProperty("IdProduto").GetValue(selected, null);
                        var quant = Convert.ToDecimal(selected.GetType().GetProperty("QuantidadeProduto").GetValue(selected, null));
                        selected.GetType().GetProperty("QuantidadeProduto").SetValue(selected, 0M, null);
                        produtos.Add(selected);

                        gridControlItens.DataSource = produtos;
                    }
                    gridControlItens.RefreshDataSource();
                }

            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, ex.Message);
            }

        }

        private bool transfere()
        {
            var i = 1;
            var movs = new List<Movimento>();
            var manager = new MovimentoDaoManager();


            var movSaida = new Movimento()
            {
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpMovimento.Value,
                DirecaoMovimento = TypeDirecao.Saída,
                IdFilial = UnitWork.Filial.IdFilial,
                IdLocalEstoque = origem.IdLocalEstoque,
                IdSituacao = 1,
                IdTipoMovimento = lookUpTipoMovimento1.TipoMovimento.IdTipoMovimento,
                Observacoes = txtObsSaida.Text,
                IdUsuario = UnitWork.Usuario.IdUsuario,
                NumeroMovimento = manager.GetNewMovimentoNumber(),
                ValorBaseICMS = 0M,
                ValorBaseICMSST = 0M,
                ValorDesconto = 0M,
                ValorDespesasAcessorias = 0M,
                ValorFrete = 0M,
                ValorICMS = 0M,
                ValorICMSST = 0M,
                ValorSeguro = 0M

            };

            var movEntrada = new Movimento()
            {
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpMovimento.Value,
                DirecaoMovimento = TypeDirecao.Entrada,
                IdFilial = UnitWork.Filial.IdFilial,
                IdLocalEstoque = destino.IdLocalEstoque,
                IdSituacao = 1,
                IdTipoMovimento = lookUpTipoMovimento1.TipoMovimento.IdTipoMovimento,
                Observacoes = txtObsEntrada.Text,
                IdUsuario = UnitWork.Usuario.IdUsuario,
                NumeroMovimento = manager.GetNewMovimentoNumber(),
                ValorBaseICMS = 0M,
                ValorBaseICMSST = 0M,
                ValorDesconto = 0M,
                ValorDespesasAcessorias = 0M,
                ValorFrete = 0M,
                ValorICMS = 0M,
                ValorICMSST = 0M,
                ValorSeguro = 0M
            };

            foreach (var item in produtos)
            {
                var imEntrada = new ItemMovimento()
                {
                    IdProduto = item.IdProduto,
                    Quantidade = item.QuantidadeProduto,
                    IndicadorMovFisica = 1,
                    TotalItem = 0M,
                    ValorUnitario = 0M,
                    SequencialItem = i++
                };
                var imSaida = new ItemMovimento()
                {
                    IdProduto = item.IdProduto,
                    Quantidade = item.QuantidadeProduto,
                    IndicadorMovFisica = 1,
                    TotalItem = 0M,
                    ValorUnitario = 0M,
                    SequencialItem = i++
                };

                movSaida.ItensMovimento.Add(imSaida);
                movEntrada.ItensMovimento.Add(imEntrada);
            }

            movs.Add(movEntrada);
            movs.Add(movSaida);

            if (manager.TransferirEstoque(movs))
                return true;

            return false;
            
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var selected = gridViewItens.GetFocusedRow<dynamic>();
                if (selected != null)
                    produtos.Remove(selected);

                gridControlItens.RefreshDataSource();
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, ex.Message);
            }
        }

        private void wizardPageProdutos_PageCommit(object sender, EventArgs e)
        {
            this.completionWizardPage1.AllowFinish = false;
            XFrmWait.ShowSplashScreen("Criando transferência");

            //tenta baixar
            this.IsSuccess = transfere();

            //se deu errado
            if (!IsSuccess)
                //cancele o evento
                completionWizardPage1.FinishText = "Falha ao realizar a transferência de estoque.";
            else
                this.completionWizardPage1.AllowFinish = true;

            //fecha a barra
            XFrmWait.CloseSplashScreen();
        }

        private void wizardPageProdutos_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            if (produtos.Count > 0)
            {
                var msg = "Tem certeza que deseja transferir os produtos escolhidos?";
                var r = XMessageIts.Confirmacao(msg);

                if (r == DialogResult.Yes)
                    e.Valid = true;
                else e.Valid = false;
            }
            else
            {
                e.Valid = false;
                e.ErrorText = "Nenhum produto informado!";
            }
        }
    }
}