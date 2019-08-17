using System;
using System.Threading.Tasks;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Forms;

namespace ITE.DataControl.Company.NCM
{
    public partial class XFrmNCM : XFrmExcelManager
    {
        public XFrmNCM():base(@"D:\Downloads\TabeladeNCMs.xlsx")
        {
            InitializeComponent();
        }

        public override async void Salvar()
        {
            var m = new ModelNcm(gridViewBase);
            this.Enabled = false;
            var r = await XFrmWait.StartTask<bool>(Task.Run(() => m.CreateNcms()), "Gerando NCM's");
            if (r)
            {
                this.Enabled = true;
                base.ShowResult(m.Result);
                base.ShowErrors(m.Errors);
            }
        }
        public override void Novo()
        {
        }
        public override void Alterar()
        {
        }
    }
}