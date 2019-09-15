using ITE.Entidades.POCO;
using ITE.Entidades.UnitControl;
using ITE.Entidades.Repositorio;
using ITE.Vendas.Forms.Administrativo;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using System;
using ITE.Entidades.DaoManager;
using ITE.Vendas.Forms.ListView;
using ITSolution.Framework.Forms;
using ITSolution.Framework.Util;
using ITSolution.Framework.Web.Bacen;
using System.Linq;
using ITSolution.Framework.Dao.Contexto;
using ITE.Entidades.Enumeradores.RHEnum;

namespace ITE.Forms.Menus
{
    public class SistemaMenuController
    {
        private XFrmUsuarioView _xFrmGerenciarUsuario;
        //private XFrmConfigParam xFrmConfigParam;
        private XFrmPreferencias _xFrmConfigParamDev;
        private XFrmScanning _xFrmDigitalizacaoAvancada;
        //Recurso Compartilhado
        private readonly XFrmMenu _menu;

        public SistemaMenuController(XFrmMenu menu)
        {
            this._menu = menu;
        }

        internal void InfoParam()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmConfigParamDev))
            {
                this._xFrmConfigParamDev = new XFrmPreferencias();
            }
            FormsUtil.ShowDialog(_xFrmConfigParamDev);
        }

        internal void UserControl(Usuario currentUser)
        {
            if (_menu.Controller.UserControl.AcessOrLogin(currentUser))
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmGerenciarUsuario))
                {
                    this._xFrmGerenciarUsuario = new XFrmUsuarioView(currentUser);
                }
                FormsUtil.Show(_xFrmGerenciarUsuario, this._menu);
            }
        }

        internal void PdfToText()
        {
            new XFrmPdfConvertToText().ShowDialog();

        }

        internal void Digitalizacao()
        {
            if (FormsUtil.isFormDisposedOrNull(this._xFrmDigitalizacaoAvancada))
            {
                this._xFrmDigitalizacaoAvancada = new XFrmScanning();
            }
            this._xFrmDigitalizacaoAvancada.Show();
        }

        internal void ChangeUnitWork(Usuario currentUser)
        {
            if (this._menu.Controller.UserControl.AcessOrLogin(currentUser, "Área restrita"))
            {
                var frm = new XFrmSetMatrizFilial(UnitWork.Filial, FormTypeAction.Alterar);

                frm.SetPreferences();

                frm.ShowDialog();

                if (frm.Filial != null)
                    this._menu.ChangeCaptionContext();
                else
                    XMessageIts.Mensagem("Alteração de contexto cancelada");
            }
        }

        internal void Backup()
        {
            new XFrmBackupSql(AppConfigManager.Configuration.AppConfig).ShowDialog();
        }

        internal void RestauracaoBackup(Usuario user)
        {
            var frm = new XFrmRestoreBackupSql(new BalcaoContext().DatabaseName);

            if (user.IsAdmin)
                frm.SelectDatabase();

            frm.ShowDialog();

        }

        public int GetCompetenciasEmEdicao()
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    var listComp = ctx.CompetenciaFolhaDao.Where(c => c.Status == TypeStatusCompetencia.EmEdicao);
                    return listComp.Count();
                }
                catch (Exception)
                {
                    //lista vazia
                    return 0;
                }

            }
        }

        public int CheckVendasLancamentos()
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);
                try
                {
                    string database = ctx.Database.Connection.Database;
                    //efetiva o status do venda no banco
                    string procedure1 = "[" + database + "].[dbo].[P_ATUALIZAR_VENDAS]";
                    //efetiva o status do lançamento no banco
                    string procedure2 = "[" + database + "].[dbo].[P_ATUALIZAR_LANCAMENTOS]";

                    //SqlParameter parametro = new SqlParameter("@Nome", ano);
                    //new SqlParameter[] { parametro }
                    ctx.ConnectionSql.ExecuteProcedure(procedure1);
                    ctx.ConnectionSql.ExecuteProcedure(procedure2);

                    //obtem e atualiza as cotações do sistema
                    new WSBacenCambio().GetCurrencyExchange();

                    return new VendaFilterManager().FindVendasEmAberto();
                }
                catch (Exception ex)
                {
                    LoggerUtilIts.GenerateLogs(ex);
                    throw ex;
                }

            }
        }

        public void AlterConnection(Usuario _currentUser)
        {
           // new XFrmAppConfig(_currentUser, AppConfigManager.Configuration.AppConfig, true).ShowDialog();

        }
    }
}
