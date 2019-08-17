using ITSolution.Framework.Beans.ProgressBar;
using System.Threading.Tasks;
using ITSolution.Framework.Forms;
using System;

namespace ITE.DataControl.Company.MAB
{
    public partial class XFrmFuncionarioImport : XFrmExcelManager
    {
        private const string BASE = @"D:\Desktop\FUNCIONARIOS.xlsx";

        public XFrmFuncionarioImport() : this(BASE)
        {
           
        }
        public XFrmFuncionarioImport(string file)
            :base(file)
        {
            //carrega o layout dentro do projeto
            //var layoutStream = XGridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
            //"ITE.ControlExportImport.Company.MAB.lancamentos.xml");

            //gridView2.RestoreLayoutFromStream(layoutStream, OptionsLayoutBase.FullLayout);

        }

        public override void Alterar()
        {
        }

        public override void Novo()
        {
        }

        public override async void Salvar()
        {
            var m = new ModelControlFuncionario(gridViewResult);
            this.Enabled = false;
            var r = await XFrmWait.StartTask<bool>(Task.Run(() => m.CreateFuncionarios()), "Cadastrando Funcionários" );
            if (r)
            {
                this.Enabled = true;
                base.ShowResult(m.Result);
                base.ShowErrors(m.Errors);
            }


        }

    }
}