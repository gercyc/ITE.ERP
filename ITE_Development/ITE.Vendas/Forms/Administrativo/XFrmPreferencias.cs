using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Dao.Contexto;
using ITSolution.Framework.Entities;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Vendas.Forms.Administrativo
{
    public partial class XFrmPreferencias : DevExpress.XtraEditors.XtraForm
    {

        public XFrmPreferencias()
        {
            InitializeComponent();

        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.AddRange(paramVenda());
            parametros.AddRange(paramLocais());
            parametros.AddRange(paramReport());
            parametros.AddRange(paramRH());

            var manager = new ParametroDaoManager();

            manager.UpdateParamFromCodigo(parametros);

        }

        private List<Parametro> paramVenda()
        {
            List<Parametro> parametros = new List<Parametro>();
            var centro = lookUpCentroCustoDefault.CentroCusto;

            parametros.Add(new Parametro(TypeParametro.centro_custo_venda,
                                        centro.IdCentroCusto.ToString(),
                                         true));

            parametros.Add(new Parametro(TypeParametro.exigir_login_venda,
                null,
                chkLoginVenda.Checked));

            parametros.Add(new Parametro(TypeParametro.venda_quitada_avista,
                null,
                chkVendaQuitadaVista.Checked));


            return parametros;
        }
        private List<Parametro> paramRH()
        {
            List<Parametro> parametros = new List<Parametro>();
            var centro = lookUpCentroCustoRH.CentroCusto;
            var cliFor = lookUpCliForRH.CliFor;

            parametros.Add(new Parametro(TypeParametro.centro_custo_folha,
                                        centro.IdCentroCusto.ToString(),
                                         true));

            parametros.Add(new Parametro(TypeParametro.clifor_folha,
                                        cliFor.IdCliFor.ToString(),
                                         true));
            return parametros;
        }

        private List<Parametro> paramLocais()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro(TypeParametro.dir_digitalizacoes,
                    txtDirDigitalizacao.Text,
                    true),
                new Parametro(TypeParametro.venda_quitada_avista,
                    txtDirBackup.Text,
                    true)
            };


            return parametros;
        }

        private List<Parametro> paramReport()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro(TypeParametro.report_engine,
                                        (cbEngReport.SelectedIndex+1).ToString(),
                                        true)
            };
            return parametros;
        }
        private void XFrmConfigParam_Shown(object sender, EventArgs e)
        {
            barBtRefresh_ItemClick(null, null);
        }

        private void loadPreferences()
        {
            //nao use o using aqui
            var ctx = new BalcaoContext();

            this.Invoke(new MethodInvoker(delegate
            {
                try
                {
                    //centro de custo
                    int idCentroCusto = ParseUtil.ToInt(ParametroManager
                                                .FindParamByTypeParametro(TypeParametro.centro_custo_venda)
                                                            .ValorParametro);
                    var centro = ctx.CentroCustoDao.Find(idCentroCusto);
                    lookUpCentroCustoDefault.FindSetCentroCusto(centro.CodigoCentroCusto);

                    //conta bancaria
                    int idContaBancaria = ParseUtil.ToInt(ParametroManager
                                        .FindParamByTypeParametro(TypeParametro.conta_bancaria)
                                        .ValorParametro);
                    var conta = ctx.ContaBancariaDao.Find(idContaBancaria);
                    lookUpContaBancariaDefault.FindSetContaBancaria(conta.CodigoContaBancaria);

                    bool statusLoginVParam = ParametroManager.FindParamByTypeParametro(TypeParametro.exigir_login_venda)
                                                    .StatusParametro;

                    //venda
                    chkLoginVenda.Checked = statusLoginVParam;
                    var statusVendaQuitada = ParametroManager.FindParamByTypeParametro(TypeParametro.venda_quitada_avista)
                                            .StatusParametro;
                    chkVendaQuitadaVista.Checked = statusVendaQuitada;


                    //report
                    int reportEngine = ParseUtil.ToInt(ParametroManager.FindParamByTypeParametro(TypeParametro.report_engine)
                        .ValorParametro)-1;
                    cbEngReport.SelectedIndex = reportEngine;

                    //locais
                    string dirDigitalizacao = ParametroManager.FindParamByTypeParametro(TypeParametro.dir_digitalizacoes)
                                        .ValorParametro;

                    string dirBackup = ParametroManager.FindParamByTypeParametro(TypeParametro.dir_backup)
                                        .ValorParametro;

                    txtDirDigitalizacao.Text = dirDigitalizacao;
                    txtDirBackup.Text = dirBackup;

                    //rh
                    int idCentroCustoRH = ParseUtil.ToInt(ParametroManager
                                                .FindParamByTypeParametro(TypeParametro.centro_custo_folha)
                                                            .ValorParametro);
                    var centroRH = ctx.CentroCustoDao.Find(idCentroCustoRH);
                    lookUpCentroCustoRH.FindSetCentroCusto(centroRH.CodigoCentroCusto);

                    int idCliForRH = ParseUtil.ToInt(ParametroManager
                                                .FindParamByTypeParametro(TypeParametro.clifor_folha)
                                                            .ValorParametro);
                    var cliForRH = ctx.CliForDao.Find(idCliForRH);
                    lookUpCliForRH.FindSetCliFor(cliForRH.IdCliFor.ToString());

                    ctx.Dispose();
                }
                catch (Exception ex)
                {
                    XMessageIts.Mensagem("Existem argumentos não parametrizados.");
                    LoggerUtilIts.GenerateLogs(ex);
                }

            }));

        }

        private void barBtRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(Task.Run(() => loadPreferences()), "Carregando Preferências");
        }


        private void btnSetDirDigitacao_Click(object sender, EventArgs e)
        {
            var op = fbDialogDirectory.ShowDialog();

            if (op == DialogResult.OK)
                txtDirDigitalizacao.Text = fbDialogDirectory.SelectedPath;
        }

        private void btnSetDirBackup_Click(object sender, EventArgs e)
        {
            var op = fbDialogDirectory.ShowDialog();

            if (op == DialogResult.OK)
                txtDirBackup.Text = fbDialogDirectory.SelectedPath;
        }
    }
}