using ITE.Entidades.POCO;
using ITE.Entidades.POCO.TI;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Validador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ITE.Entidades.DaoManager.InformaticaDaoManager;
using ITE.Entidades.UnitControl;

namespace ITE.Informatica.Forms.Cadastro
{
    public partial class XFrmAddManutencao : DevExpress.XtraEditors.XtraForm
    {
        private List<Computador> computadoresManutencao = new List<Computador>();
        private List<ItemManutencao> itensManutencao = new List<ItemManutencao>();
        private Manutencao manutencao;
        private Atendimento atendimento;

        public XFrmAddManutencao()
        {
            init();

        }

        private void init()
        {
            InitializeComponent();
            this.ActiveControl = memoEditReport;
            this.gridControlProduto.DataSource = this.itensManutencao;
            this.gridControlPc.DataSource = this.computadoresManutencao;
        }

        public XFrmAddManutencao(Atendimento a)
        {
            init();
            this.atendimento = indexarDadosAt(a);

            this.Text = "Ordem de serviço:";

            try
            {
                var ctx = new BalcaoContext();
                ctx.LazyLoading(false);
                var first = ctx.CentroCustoDao.Find(2);
                this.lookUpCentroCusto1.FindSetCentroCusto(first.CodigoCentroCusto);
            }
            catch (Exception)
            {
                //azar se nao deu certo
            }
        }
        /// <summary>
        /// Altera uma manutencao
        /// </summary>
        /// <param name="m"></param>
        public XFrmAddManutencao(Manutencao m)
        {
            init();
            this.manutencao = indexarDados(m);

            //somente leitura
            if (this.manutencao.StatusManutencao == TypeStatusManutencao.Encerrado)
            {
                this.btnSalvar.Text = "OK";
                this.btnCancelar.Visible = false;

                ComponenteUtil.ReadyOnly(true,
                    this.cbStatus,timeEditDuracao,
                    this.timeEditDuracao,
                    this.memoEditReport,
                    this.cbStatus);

                this.lookUpCentroCusto1.ReadOnlyMode();
                this.searchLookUpCliente.ReadOnly = true;
                this.btnLoadReport.Enabled = false;

                this.dtEntrega.Enabled = false;
                this.dtInicial.Enabled = false;
                this.dtTermino.Enabled = false;

                this.txtValor.ReadOnly = true;

                this.gridViewItens.OptionsBehavior.Editable = false;
                this.gridViewPCs.OptionsBehavior.Editable = false;

                //bar 1
                this.barBtnAddPC.Enabled = false;
                this.barBtnEditarPc.Enabled = false;
                this.barBtnRemovePc.Enabled = false;

                //bar 1
                this.barBtnAddItem.Enabled = false;
                this.barBtnRemoveItem.Enabled = false;
            }
        }

        private Manutencao indexarDados(Manutencao m)
        {
            if (m.Atendimento != null)
                this.atendimento = indexarDadosAt(m.Atendimento);
            else
            {
                indexarCliente(m.Cliente);
                this.xtraTabPageAtendimento.PageVisible = false;
            }

            this.itensManutencao = m.ItensManutencao != null ? m.ItensManutencao.ToList() : null;
            this.computadoresManutencao = m.Computadores != null ? m.Computadores.ToList() : null;

            this.cbStatus.SelectedIndex = (int)m.StatusManutencao;

            this.dtInicial.Value = m.DataInicial;
            this.dtTermino.Value = m.DataTermino;
            this.dtEntrega.Value = m.DataEntrega;


            this.timeEditDuracao.Time = ParseUtil.ToDate(m.Duracao);
            this.memoEditReport.Text = m.RelatorioManutencao;

            this.gridControlProduto.DataSource = itensManutencao;
            this.gridControlPc.DataSource = computadoresManutencao;

            this.gridViewItens.RefreshData();
            this.gridViewPCs.RefreshData();

            this.refreshTotal();

            this.lookUpCentroCusto1.FindSetCentroCusto(m.CentroCusto.CodigoCentroCusto);

            return m;
        }
        private void indexarCliente(CliFor cliente)
        {
            if (cliente != null)
            {
                var clientes = new List<CliFor>();
                clientes.Add(cliente);
                searchLookUpCliente.Properties.DataSource = clientes;
                searchLookUpCliente.EditValue = cliente;
                searchLookUpCliente.Text = cliente.RazaoSocial;
                gridViewCliente.SelectRow(0);

                searchLookUpCliente.ReadOnly = true;
            }
        }
        private Atendimento indexarDadosAt(Atendimento at)
        {
            if (at != null)
            {
                indexarCliente(at.Cliente);
                memoEditProblemas.Text = at.RelatorioAtendimento;
                dtDataColeta.Value = at.DataColeta;

                cbTipoColeta.SelectedIndex = (int)at.TipoColeta;

                if (at.Endereco != null)
                    //endereco
                    txtEndereco.Text = at.Endereco.ToString();

                txtResponsavel.Text = at.Responsavel;
                txtTelefone.Text = at.Telefone;
                txtCelular.Text = at.Celular;

            }
            return at;
        }

        private Manutencao indexarDados()
        {
            Manutencao m = new Manutencao()
            {
                RelatorioManutencao = memoEditReport.Text,
                DataInicial = dtInicial.Value,
                DataTermino = dtTermino.Value,
                DataEntrega = dtEntrega.Value,
                IdFilial = UnitWork.Filial.IdFilial,
            };

            var cliente = gridViewCliente.GetFocusedRow< CliFor>();

            if (cliente != null)
            {
                m.IdCliente = cliente.IdCliFor;
            }


            if (this.atendimento != null)
            {
                m.IdAtendimento = atendimento.IdAtendimento;
                m.Atendimento = this.atendimento;
            }
            m.Duracao = ParseUtil.ToTimeSpan(timeEditDuracao.Time);

            m.StatusManutencao = (TypeStatusManutencao)cbStatus.SelectedIndex;

            if (lookUpCentroCusto1.CentroCusto != null)
                m.IdCentroCusto = lookUpCentroCusto1.CentroCusto.IdCentroCusto;


            m.ItensManutencao = itensManutencao;
            m.ValorManutencao = ParseUtil.ToDecimal(txtValor.Text)+ calculaTotal();

            foreach (var pc in computadoresManutencao)
            {
                m.Computadores.Add(pc);
            }

            if (this.manutencao != null)
                m.IdManutencao = this.manutencao.IdManutencao;

            return m;
        }

        private decimal calculaTotal()
        {
            decimal total = 0;

            foreach (var item in itensManutencao)
            {
                total += item.TotalItem;
            }
            return total;

        }

        private void refreshTotal()
        {
            //permite a edição
            this.txtValor.ReadOnly = false;
            this.txtValor.Text = calculaTotal().ToString("N2");
            this.gridControlProduto.DataSource = this.itensManutencao;
            this.gridControlProduto.Refresh();
            this.gridControlProduto.RefreshDataSource();
            this.txtValor.ReadOnly = true;
        }

        #region Eventos


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text.Equals("Salvar"))
            {
                Manutencao novo = indexarDados();

                if (ValidadorDTO.ValidateWarningAll(novo))
                {
                    var dao = new ManutencaoDaoManager();

                    if (this.manutencao == null)
                    {
                        if (dao.SaveManutencao(novo))
                        {
                            XMessageIts.Mensagem("Manutenção arquivada.");
                            this.Dispose();

                        }
                    }
                    else
                    {
                        if (dao.UpdateManutencao(novo))
                        {
                            XMessageIts.Mensagem("Manutenção atualizada.");
                            this.manutencao.Update(novo);

                        }
                    }
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
        private void barBtnVoltar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormat.SelectedIndex == 0)
            {
                memoEditReport.Text = memoEditReport.Text.ToUpper();
            }
            else
            {
                memoEditReport.Text = memoEditReport.Text.ToLower();
                memoEditReport.Text = memoEditReport.Text.FirstCharToUpper();
            }
            memoEditReport.Refresh();
        }

        private void gridViewItens_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colQuantidade || e.Column == colValorUnitario)
            {
                //esse value eh disparado automaticamente na data do gridControl
                //var x = e.Value;

                //linha que houve a ocorrencia
                var item = gridViewItens.GetFocusedRow<ItemManutencao>();

                //se for informado 0, sera considerado preco de proposta do produto
                if (item.ValorUnitario == 0)
                {
                    //atribua o preco de proposta
                    item.ValorUnitario = item.Produto.PrecoVenda;
                    gridViewItens.SetFocusedRowCellValue(colValorUnitario, item.ValorUnitario);
                }

                if (item.Produto.TipoItemProduto == TypeItemProduto.Produto)
                {
                    item.TotalItem = item.Quantidade * item.ValorUnitario;

                    //atualize a quantidade do produto
                    item.Produto.QuantidadeProduto = item.Quantidade;
                }
                else
                {
                    item.Quantidade = 0;//padrão do serviço
                }

                item.Produto.PrecoVenda = item.ValorUnitario;

                gridViewItens.SetFocusedRowCellValue(colTotalItem, item.TotalItem);
            }
        }

        #endregion Eventos

        #region Eventos Barmanager Standalone

        private void barBtnAddPC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmPc = new XFrmAddPC();
            frmPc.ShowDialog();
            var result = frmPc.Computador;

            if (result != null)
            {
                this.computadoresManutencao.Add(result);

                this.gridControlPc.DataSource = this.computadoresManutencao;
                this.gridViewPCs.RefreshData();
            }
        }

        private void barBtnEditPC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewPCs.IsSelectOneRowWarning())
                new XFrmAddPC(gridViewPCs.GetFocusedRow<Computador>()).ShowDialog();
        }

        private void barBtnRemovePC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewPCs.DeleteSelectedRows();
        }

        private void barBtnAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //criar forms para chamar os produtos
            xtabControl.SelectedTabPage = xtabItens;
            try
            {
                using (var ctx = new BalcaoContext())
                {

                    var layoutStream = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
                        "ITE.Informatica.GridLayout.produto_basico.xml");

                    var produtosTyped = XFrmFindEntity.ShowDialogFindListEntity<Produto>(ctx, layoutStream);

                    if (produtosTyped != null)
                    {

                        var itensFind = new List<Produto>();

                        //procure e add
                        foreach (var pro in produtosTyped)
                        {
                            Produto p = ctx.ProdutoDao.Find(pro.IdProduto);

                            var o = this.itensManutencao.Find(x => x.Produto.DescricaoProduto.Equals(p.DescricaoProduto));
                            if (o == null)
                                //se for null eh pq nao esta na lista
                                //add o item
                                this.itensManutencao.Add(new ItemManutencao(p));
                            else
                                itensFind.Add(p);//nao entra
                        }


                        if (itensFind.Count > 0)
                        {
                            XFrmOptionPane.ShowListTextArea<Produto>(itensFind, "Atenção os produtos abaixo não serão adicionados poiss já existem !");
                        }
                        refreshTotal();
                    }
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }
        }

        private void barBtnRemoveItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewItens.DeleteSelectedRows();
            refreshTotal();
        }


        #endregion

        private void memoEditReport_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(memoEditReport.Text))
                cbFormat_SelectedIndexChanged(null, null);
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            //criar um campo para guardar o relatorio no banco
            var op = openFileReport.ShowDialog();

            if (op == DialogResult.OK)
            {
                var file = openFileReport.FileName;
                webBrowser1.Navigate(file);
            }
        }

        private async void XFrmAddManutencao_Shown(object sender, EventArgs e)
        {
            if (manutencao == null && atendimento == null)
            {
                var ctx = new BalcaoContext();
                ctx.LazyLoading(false);

                var clientes = await ctx.CliForDao.FindAllAsync();
                this.searchLookUpCliente.Properties.DataSource = clientes;
                this.searchLookUpCliente.Refresh();
            } 
        }
    }
}
