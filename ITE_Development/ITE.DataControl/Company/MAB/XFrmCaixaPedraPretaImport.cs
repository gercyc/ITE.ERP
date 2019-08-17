using DevExpress.Utils;
using ITE.Entidades.POCO.Financeiro;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using System.Reflection;
using System.Threading.Tasks;
using ITSolution.Framework.Forms;
using System;

namespace ITE.DataControl.Company.MAB
{
    public partial class XFrmCaixaPedraPretaImport : XFrmExcelManager
    {
        private const string BASE = @"D:\Documents\Contas\Base-Caixa-Pedra-Preta-2016.xls";

        public XFrmCaixaPedraPretaImport() : this(BASE)
        {

        }
        public XFrmCaixaPedraPretaImport(string file)
            : base(file)
        {
            //carrega o layout dentro do projeto
            var layoutStream = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
            "ITE.ControlExportImport.Company.MAB.lancamentos.xml");

            gridViewBase.RestoreLayoutFromStream(layoutStream, OptionsLayoutBase.FullLayout);

        }

        public override async void Salvar()
        {
            ModelControlLancamento m = new ModelControlLancamento(gridViewBase);
            this.Enabled = false;
            var r = await XFrmWait.StartTask<bool>(Task.Run(() => m.CreateLancamentos()), "Gerando lançamentos");
            if (r)
            {
                this.Enabled = true;
                base.ShowResult<LancamentoFinanceiro>(m.Result);
                base.ShowErrors<LancamentoFinanceiro>(m.Errors);
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