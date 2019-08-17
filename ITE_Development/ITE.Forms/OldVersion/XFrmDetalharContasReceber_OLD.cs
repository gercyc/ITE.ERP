using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ITE.Entidades.POCO;
using ITE.Entidades.Enumeradores;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.Sales;

namespace ITE.Vendas.Forms.Administrativo
{
    public partial class XFrmDetalharContasReceber_OLD : DevExpress.XtraEditors.XtraForm
    {
        public Usuario User { get; set; }

        public XFrmDetalharContasReceber_OLD()
        {
            InitializeComponent();


        }

        public XFrmDetalharContasReceber_OLD(Usuario user)
            : this()
        {
            this.User = user;
        }

        #region Metodos

        private void showDemonstrativoParcelas(List<Venda> vendas)
        {
            var valorEmAberto = 0m;
            var valorJuros = 0m;
            var valorRecebido = 0m;

            foreach (var v in vendas)
            {
                var parcelas = v.Parcelas;

                foreach (var item in parcelas)
                {
                    if (item.StatusLancamento == TypeStatusLancamentoFinanceiro.Aberto)
                    {
                        valorEmAberto += item.ValorLancamento;
                        valorJuros += item.ValorJuros;
                    }
                    else if (item.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago )
                        valorRecebido += item.ValorLancamento;
                }
            }

            gridControlReceber.DataSource = vendas;
            gridViewReceber.SelectRange(0, 0);
        }

     
        #endregion

        #region Eventos

        private void XFrmContasReceber_Shown(object sender, EventArgs e)
        {
            btnAtualizar_ItemClick(null, null);
        }

        private void btnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //XFrmWait.StartTask(action(), "Carregando Informações");
        }

        private void btnBaixarTitulo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewReceber.IsSelectOneRowWarning())
            {
                var venda = gridViewReceber.GetFocusedRow<Venda>();

                if (venda.StatusVenda == TypeStatusVenda.Cancelada)
                    XMessageIts.Advertencia("Você não pode quitar uma venda cancelada!", "Atenção");
                else
                {
                    //var quitacao = new XFrmQuitarParcela(venda.Parcelas.ToList());

                    //if (quitacao.IsParcelas())
                    //{
                    //    quitacao.ShowDialog();
                    //    //se foi quitada
                    //    if (quitacao.IsQuitado)
                    //        //atualiza a tela atual denovo
                    //        this.Dispose();
                    //}
                }
            }
        }


        #endregion 

        #region Master Row Parcelas

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            Venda c = gridViewReceber.GetRow(e.RowHandle) as Venda;
            e.IsEmpty = c.Parcelas.Count == 0;
        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Parcelas";

        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            Venda v = gridViewReceber.GetRow(e.RowHandle) as Venda;

            var bs = new BindingSource(v, "Parcelas");
            var ds = bs.DataSource as Venda;
            List<LancamentoFinanceiro> items = ds.Parcelas.ToList();
            var query = from p in items
                        select new
                        {
                            p.SequencialParcela,
                            p.Venda.NumeroParcelas,
                            p.DiasPrazo,
                            p.DataVencimento,
                            p.DataPagamento,
                            p.ValorLancamento,
                            
                        };
            bs.DataSource = query.ToList();
            e.ChildList = bs;

        }
        
        #endregion
    }
}