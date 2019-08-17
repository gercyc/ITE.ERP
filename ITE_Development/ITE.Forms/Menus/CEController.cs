using ITE.CE.Forms;
using ITE.CE.Forms.View;
using ITE.Entidades.POCO;
using ITSolution.Framework.GuiUtil;

namespace ITE.Forms.Menus
{
    public class CEController
    {

        private readonly XFrmMenu _menu;
        private XFrmAddDespesa _xFrmAddDespesa;
        private XFrmAddMercadoria _xFrmAddMercadoria;
        private XFrmCusteio _xFrmCusteio;
        private XFrmCusteioListView _xFrmCusteioListView;

        public CEController(XFrmMenu menu)
        {
            this._menu = menu;
        }

        public void AddDespesa(Usuario user)
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmAddDespesa))
            {
                this._xFrmAddDespesa = new XFrmAddDespesa();
            }
            FormsUtil.Show(_xFrmAddDespesa, this._menu);
        }

        public void AddMaterial(Usuario user)
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmAddMercadoria))
            {
                this._xFrmAddMercadoria = new XFrmAddMercadoria();
            }
            FormsUtil.Show(_xFrmAddMercadoria, this._menu);
        }
        public void CalcularCusteio(Usuario user)
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmCusteio))
            {
                this._xFrmCusteio = new XFrmCusteio(user);
            }
            FormsUtil.Show(new XFrmCusteio(user), this._menu);
        }
        public void GerenciarCusteios(Usuario user)
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmCusteioListView))
            {
                this._xFrmCusteioListView = new XFrmCusteioListView();
            }
            FormsUtil.Show(_xFrmCusteioListView, this._menu);
        }

    }
}
