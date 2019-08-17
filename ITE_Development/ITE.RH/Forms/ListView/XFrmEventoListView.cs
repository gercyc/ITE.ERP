﻿using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO.RH;
using ITE.Entidades.Repositorio;
using ITE.RH.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;

namespace ITE.RH.Forms.ListView
{
    public partial class XFrmEventoListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmEventoListView()
        {
            InitializeComponent();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarEventos(), "Carregando eventos...");
        }

        private async Task carregarEventos()
        {
            var ctx = new BalcaoContext();
            var lista = await ctx.EventoDao.FindAllAsync();
            gridControlEventos.DataSource = lista;
        }


        private void btnNovaFuncao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddFuncao().ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctx = new BalcaoContext();
            var eventoSelect = GridViewUtil.GetFocusedRow<Evento>(gridViewEventos);
            if (eventoSelect != null)
            {
                var dResult = XMessageIts.Confirmacao(@"Certeza que deseja excluir o evento 
                    selecionado? Ele será excluída somente se não houver nenhum 
                    lançamento vinculado a ele.");
                if (dResult == DialogResult.Yes)
                {
                    var eventoRemove = ctx.EventoDao.Find(eventoSelect.IdEvento);
                    if (ctx.EventoDao.Delete(eventoRemove))
                    {
                        XMessageIts.Mensagem("Evento removido com sucesso!", "Sucesso");
                        btnRefresh_ItemClick(null, null);
                    }
                    else
                    {
                        XMessageIts.Erro("Evento não removido! Está vinculado a ficha financeira!", "Erro");
                    }
                }
            }
        }

        private void btnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddEvento().ShowDialog();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewEventos.IsSelectOneRowWarning())
            {
                var evt = gridViewEventos.GetFocusedRow<Evento>();
                new XFrmAddEvento(evt).ShowDialog();
            }
        }

        private void XFrmGerenciarEvento_Shown(object sender, System.EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void gridViewEventos_DoubleClick(object sender, System.EventArgs e)
        {
            btnEditar_ItemClick(null, null);
        }
    }
}