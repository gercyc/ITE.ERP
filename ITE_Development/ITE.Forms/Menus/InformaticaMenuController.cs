using ITE.Informatica.Forms.View;
using ITSolution.Framework.GuiUtil;

namespace ITE.Forms.Menus
{
    public class InformaticaMenuController
    {
        private XFrmViewAtendimento xFrmGerenciarAtendimento;
        private XFrmViewManutencao xFrmGerenciarManutencao;
        private XFrmMenu menu;

        public InformaticaMenuController(XFrmMenu menu)
        {
            this.menu = menu;
        }


        internal void ManagerAtendimentos()
        {
            if (FormsUtil.isFormDisposedOrNull(this.xFrmGerenciarAtendimento))
            {
                this.xFrmGerenciarAtendimento = new XFrmViewAtendimento();
            }
            FormsUtil.Show(this.xFrmGerenciarAtendimento, this.menu);
        }

        internal void ManagerManutencoes()
        {
            if (FormsUtil.isFormDisposedOrNull(this.xFrmGerenciarManutencao))
                this.xFrmGerenciarManutencao = new XFrmViewManutencao();

            FormsUtil.Show(this.xFrmGerenciarManutencao, this.menu);
        }

    }
}
