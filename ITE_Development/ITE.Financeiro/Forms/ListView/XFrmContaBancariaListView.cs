using System.Threading.Tasks;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITE.Financeiro.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Forms;
using ITSolution.Framework.GuiUtil;

namespace ITE.Financeiro.Forms.ListView
{
    public partial class XFrmContaBancariaListView : XFrmCrudListView
    {
        public XFrmContaBancariaListView()
        {
            InitializeComponent();
        }


        private async Task carregarContas()
        {
            using (var ctx = new BalcaoContext())
            {
                var lista = await ctx.ContaBancariaDao.FindAllAsync();
                gridControlContaBancaria.DataSource = lista;
            }
        }
       
      

        #region Métodos sobrescritos
        public override void SaveItemClick()
        {
            new XFrmAddContaBancaria().ShowDialog();
        }
        public override void RefreshItemClick()
        {
            XFrmWait.StartTask(carregarContas(), "Carregando lançamentos...");
        }

        public override void UpdateItemClick()
        {
            if (gridViewContaBancaria.IsSelectOneRowWarning())
            {
                ContaBancaria conta = gridViewContaBancaria.GetFocusedRow() as ContaBancaria;
                new XFrmAddContaBancaria(conta).ShowDialog();
            }
        }
        public override void PrintItemClick()
        {
            gridViewContaBancaria.ShowPrintPreview();
        }
        public override void DeleteItemClick()
        {
            base.DeleteItemClick();
        }


        #endregion

        private void gridViewContaBancaria_DoubleClick(object sender, System.EventArgs e)
        {
            UpdateItemClick();
        }

        private void XFrmViewContaBancaria_Shown(object sender, System.EventArgs e)
        {
            RefreshItemClick();
        }
    }
}