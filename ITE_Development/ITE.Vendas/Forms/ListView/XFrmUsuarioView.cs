using System;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Eventos.GridViewEvents;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;

namespace ITE.Vendas.Forms.ListView
{
    public partial class XFrmUsuarioView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Usuario userLogado;
        private FocusRowChangedEvent gridFocusUtil;

        public XFrmUsuarioView()
        {
            InitializeComponent();
            this.gridFocusUtil = new FocusRowChangedEvent(gridViewUsuarios);
        }

        public XFrmUsuarioView(Usuario userLogado) : this()
        {
            this.userLogado = userLogado;
        }

        private void XFrmGerenciarUsuario_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void barBtnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new View.XFrmUsuarioView(userLogado).ShowDialog();
        }

        private void barBtnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewUsuarios.IsSelectOneRowWarning() )
            {
                
                var user = gridViewUsuarios.GetFocusedRow() as Usuario;

                //se o admin ta na ativa
                if (userLogado.NomeUtilizador == "admin")
                {
                    var frm = new View.XFrmUsuarioView(userLogado, user);
                    frm.ShowDialog();

                    if (frm.IsSave)
                        barBtnAtualizar_ItemClick(null, null);
                }
                else
                {
                    //eu nao sou o admin e estou e estou tentando editar o admin      
                    if (userLogado.NomeUtilizador != "admin" && user.NomeUtilizador == "admin")
                    {
                        XMessageIts.Advertencia("Você não tem permissão para alterar os dados do administrador!",
                                                    "Acesso Negado");
                    }
                    else
                    {
                        var frm = new View.XFrmUsuarioView(userLogado, user);
                        frm.ShowDialog();

                        if(frm.IsSave)
                            barBtnAtualizar_ItemClick(null, null);
                    }

                }
                
            }
        }
        //Teste
        private async void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var source = await XFrmWait.StartTask(new BalcaoContext()
                .UsuarioDao.FindAllAsync(), "Carregando usuários", this);

            if (source != null)
                gridControlUsuario.DataSource = source;

            this.gridFocusUtil.KeepFocusedRowChanged();
        }

        private void barBtnGrupo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmGrupoUsuarioView().ShowDialog();
        }

        private void gridViewUsuarios_DoubleClick(object sender, EventArgs e)
        {
            barBtnAlterar_ItemClick(null, null);
        }
    }
}