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
using ITSolution.Framework.Beans.ProgressBar;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Contabil;
using ITE.Contabil.Desenvolvimento.Lancamentos;
using DevExpress.XtraBars.Ribbon;

namespace ITE.Contabil.Desenvolvimento.Lotes
{
    public partial class XFrmLoteContabilView : DevExpress.XtraEditors.XtraForm
    {
        private Usuario _currentUser;
        private RibbonForm _form;

        public XFrmLoteContabilView()
        {
            InitializeComponent();
            FormsUtil.AddShortcutCtrlWOnDispose(this);
        }
        public XFrmLoteContabilView(Usuario user, RibbonForm form) :this()
        {
            this._currentUser = user;
            this._form = form;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarLotes(), "Carregando lotes contábeis...");
        }

        private async Task carregarLotes()
        {
            var ctx = new BalcaoContext();
            var lotes = await ctx.LoteContabilDao.FindAllAsync();
            gridControlLoteCont.DataSource = lotes;
        }

        private void btnNovoLote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormsUtil.ShowDialog(new XFrmAddLoteContabil(_currentUser));
            btnRefresh_ItemClick(null, null);
        }

        private void XFrmLoteContabilView_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var loteSel = gridViewLoteCont.GetFocusedRow<LoteContabil>();
            if (loteSel != null)
            {
                FormsUtil.ShowDialog(new XFrmAddLoteContabil(loteSel, _currentUser));
            }
        }

        private void gridViewLoteCont_DoubleClick(object sender, EventArgs e)
        {
            var loteSel = gridViewLoteCont.GetFocusedRow<LoteContabil>();
            if (loteSel != null)
            {
                FormsUtil.Show(new XFrmLancamentosContabeisView(_currentUser, loteSel), _form);
            }
            
        }
    }
}