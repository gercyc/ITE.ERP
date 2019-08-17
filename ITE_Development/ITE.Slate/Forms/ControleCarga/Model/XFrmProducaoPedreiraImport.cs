using System;
using System.Threading.Tasks;
using ITE.Entidades.Enumeradores.SlateEnums;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Ardosia.ModelSlateImport;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Forms;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Slate.Forms.ControleCarga.Model
{
    public partial class XFrmProducaoPedreiraImport : XFrmExcelManager
    {
        private const string BASE = @"D:\Documents\Controle Produção\TABELA PRECOS ARDOCOLOR.xlsx";
        private readonly TypeImport _type;
        private readonly Usuario _user;

        public XFrmProducaoPedreiraImport() : base(BASE)
        {
            InitializeComponent();
            barIndex.EditValue = 1;

            this.ModoCompacto();

        }

        public XFrmProducaoPedreiraImport(Usuario user, TypeImport type) : base("")
        {
            this._type = type;
            this._user = user;
            this.ModoCompacto();
        }


        public override async void PreVisualizarValidar()
        {
            if (!string.IsNullOrEmpty(txtExcelFile.Text))
            {
                try
                {

                    var m = new ModelProducaoSerra(gridViewBase, _user);
                    XFrmWait.ShowSplashScreen("Preparando Dados");

                    var r = await Task.Run(() => m.LoadProducaoNew());

                    if (r)
                    {
                        base.ShowResult(m.Result);
                        this.IsValido = true;
                        this.barBtnSalvar.Enabled = true;
                    }
                    else
                    {
                        XMessageIts.Advertencia("Validação com erros.");
                        base.ShowErrors(m.Errors);
                        this.barBtnSalvar.Enabled = false;
                    }
                    Console.WriteLine(r);
                    XFrmWait.CloseSplashScreen();

                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionLogs(ex);
                }
            }
        }

        public override async void Salvar()
        {
            if (this._type == TypeImport.Material)
            {
                var m = new ModelMaterialSerra(gridViewBase);
                var r = await XFrmWait.StartTask<bool>(Task.Run(() => m.CreateBaseProduto()), "Gerando base");
                if (r)
                    base.ShowResult(m.Result, m.Errors);
            }
            else
            {
                if (this.barBtnSalvar.Enabled)
                {
                    var m = new ModelProducaoSerra(gridViewResult, _user);

                    XFrmWait.ShowSplashScreen("Importando Produção");
                    var r = await Task.Factory.StartNew(() => m.SalvaProducao());
                    //var r = await XFrmWait.StartTask<bool>(Task.Run(() => m.SalvaProducao()), "Salvando Produção");

                    if (r)
                        XMessageIts.Mensagem("Produção importada com sucesso.");
                    else
                        XMessageIts.Erro("Ocorreram erros durante a importação!");

                    base.ShowResult(m.Result, m.Errors);

                    XFrmWait.CloseSplashScreen();
                    this.barBtnSalvar.Enabled = false;
                }
                else
                {
                    XMessageIts.Mensagem("Realize a validação antes de salvar!");
                }
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
