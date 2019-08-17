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
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.POCO;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;

namespace ITE.Contabil.Desenvolvimento.Lancamentos
{
    public partial class XFrmLancamentosContabeisView : DevExpress.XtraEditors.XtraForm
    {
        private Usuario _currentUser;
        private LoteContabil _lote;

        public XFrmLancamentosContabeisView()
        {
            InitializeComponent();
            FormsUtil.AddShortcutCtrlWOnDispose(this);
        }

        public XFrmLancamentosContabeisView(Usuario currentUser) : this()
        {
            this._currentUser = currentUser;
            
        }
        public XFrmLancamentosContabeisView(Usuario currentUser, LoteContabil lote) : this()
        {
            this._currentUser = currentUser;
            this._lote = lote;
            this.Text = "Lançamentos contábeis: " +  "- Lote: " + lote.NumeroLote + " - " + lote.DescricaoLote;

        }

        private async Task carregarLancamentos()
        {
            var ctx = new BalcaoContext();
            var lancamentos = await ctx.LancamentoContabilDao.FindAllAsync();

            if (_lote != null)
                lancamentos = await ctx.LancamentoContabilDao.WhereAsync(l => l.IdLoteOrigem == _lote.IdLote);

            gridControlLancamentos.DataSource = lancamentos;
        }

        private void btnNovoLancamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormsUtil.Show(new XFrmAddLancamentoContabil(_currentUser, _lote));
            //starTask();
        }

        private void btnEditarLancamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var currentLancamento = gridViewLancamentos.GetFocusedRow<LancamentoContabil>();
            if (currentLancamento != null)
                FormsUtil.Show(new XFrmAddLancamentoContabil(_currentUser, currentLancamento));

            //starTask();
        }

        private void btnDelLancamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            starTask();
        }

        private void gridViewLancamentos_DoubleClick(object sender, EventArgs e)
        {
            btnEditarLancamento_ItemClick(null, null);
            
        }

        private void XFrmLancamentosContabeisView_Shown(object sender, EventArgs e)
        {
            starTask();
        }
        private void starTask()
        {
            XFrmWait.StartTask(carregarLancamentos(), "Carregando lançamentos contábeis...");
        }

    }
}