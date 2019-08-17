using System;
using System.Linq;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Beans.ProgressBar;
using System.Threading.Tasks;
using ITE.Entidades.POCO.TI;
using ITSolution.Framework.Mensagem;
using ITE.Informatica.Forms.Cadastro;

namespace ITE.Informatica.Forms.View
{
    public partial class XFrmViewAtendimento : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public XFrmViewAtendimento()
        {
            InitializeComponent();
        }

        private void XFrmGerenciarAtendimento_Shown(object sender, EventArgs e)
        {
            barBtnRefresh_ItemClick(null, null);
        }
        private void barBtnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddAtendimento().ShowDialog();
        }

        private void barBtnIniciar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {
                var at = gridView1.GetFocusedRow() as Atendimento;

                try
                {
                    //verifica se atendimento ja foi iniciado
                    //joga a excecao se nao exisitir
                    var r = new BalcaoContext().Manutencoes.
                    Where(a => a.IdAtendimento == at.IdAtendimento)
                    .First();

                    if (r.StatusManutencao == Entidades.Enumeradores.TypeStatusManutencao.Encerrado)
                        XMessageIts.Mensagem("Atendimento selecionado já foi iniciado e finalizado!\n\n" +
                                "Nº: Manutenção: \"" + r.IdManutencao + "\"", "Atenção");
                    else
                        //se nao chegar aqui vai pro catch para abertura
                        XMessageIts.Advertencia("Atendimento selecionado já foi iniciado !\n\n" +
                            "Nº: Manutenção: \"" + r.IdManutencao + "\"", "Atenção");

                }
                catch
                {
                    new XFrmAddManutencao(at).ShowDialog();
                }
            }
        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void barBtnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {
                var row = gridView1.GetFocusedRow<Atendimento>();
                new XFrmAddAtendimento(row).ShowDialog();

                if (row.StatusAtendimento != Entidades.Enumeradores.TypeStatusAtendimento.Encerrado)
                    gridView1.RefreshData();

            }
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarAtendimentos());
        }

        private async Task carregarAtendimentos()
        {
            gridControl1.DataSource = await new BalcaoContext().
                AtendimentoDao.FindAllAsync();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = gridView1.GetFocusedRow<Atendimento>();
            if (row != null)
            {
                var ctx = new BalcaoContext();
                var current = ctx.AtendimentoDao.Find(row.IdAtendimento);
                current.Update(row);
                row.Update(current);
                ctx.AtendimentoDao.Update(current);
                gridView1.RefreshRow(e.RowHandle);

            }
        }

        private void gridViewAt_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.IsSelectRow())
            {
                var at = gridView1.GetFocusedRow() as Atendimento;
                new XFrmAddAtendimento(at).ShowDialog();
            }

        }
    }
}
