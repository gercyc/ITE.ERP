using System;
using System.Linq;
using ITE.Entidades.POCO.RH.Folha;
using ITSolution.Framework.Mensagem;
using ITE.RH.Enumeradores;
using System.Collections.Generic;
using System.Windows.Forms;
using ITSolution.Framework.Util;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITE.Entidades.Enumeradores.RHEnum;

namespace ITE.RH.Forms.Folha
{
    public partial class XFrmMovimentoCompetencia : DevExpress.XtraEditors.XtraForm
    {
        private CompetenciaFolha comp;
        private List<FichaFinanceiraFuncionario> movsRemovidos;
        public XFrmMovimentoCompetencia()
        {
            InitializeComponent();
            movsRemovidos = new List<FichaFinanceiraFuncionario>();
        }

        public XFrmMovimentoCompetencia(CompetenciaFolha comp) : this()
        {
            this.comp = comp;

            try
            {

                var mes = ParseUtil.ToInt(comp.Periodo.Split('/')[0]);
                string lblComp = DataUtil.GetDataInicialDoMes(mes).ToLongDateString();
                var split = lblComp.Split(',')[1].Replace(" 1 de ", "").FirstCharToUpper();

                lbCompSelect.Text = "Mês " + mes + " - " + split;

                var compf = comp.FuncionariosCompetencia;
                var totalSalario = compf.ToList().Sum(f => f.ValorLiquido);
                //var totalEventos = compf.ToList().Sum(f => f.FichaFinanceiraFuncionario. );

                lblTotalFolha.Text = totalSalario.ToString("N2");
            }
            catch
            {
                lbCompSelect.Text = comp.Periodo;

            }
            IndexarFormulario();
        }
        private void IndexarFormulario()
        {
            lstFuncionarios.DataSource = comp.FuncionariosCompetencia.ToList();
            //desative os botoes se a comp. estiver encerrada
            if (comp.Status == TypeStatusCompetencia.Encerrada || comp.Status == TypeStatusCompetencia.EncerradaFinanceiro)
            {
                barBtnLancarEvento.Enabled = false;
                btnSalvar.Enabled = false;
                barBtnRecalculoFolha.Enabled = false;
                barBtnRemoveEvento.Enabled = false;
            }
        }

        private void lstFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEventosFuncionario();
        }

        private void barBtnLancarEvento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var func = lstFuncionarios.SelectedItem as FuncionarioCompetencia;
            if (func != null)
            {
                new XFrmAdicionarFichaFinanceira(comp, func).ShowDialog();
                LoadEventosFuncionario();
            }
        }

        private void LoadEventosFuncionario()
        {
            try
            {
                var funcSelect = lstFuncionarios.SelectedItem as FuncionarioCompetencia;
                if (funcSelect != null)
                {
                    gridControlFichaFinanceira.DataSource = funcSelect.FichaFinanceiraFuncionario.ToList();

                    //calcula os valores
                    var totalBruto = 0M;
                    var descontos = 0M;
                    var liquido = 0M;

                    foreach (var fichaFinanceira in funcSelect.FichaFinanceiraFuncionario)
                    {
                        if (fichaFinanceira.Evento.TipoEvento == TypeEvento.Provento)
                        {
                            totalBruto += fichaFinanceira.ValorMovimento;
                        }
                        if (fichaFinanceira.Evento.TipoEvento == TypeEvento.Desconto)
                        {
                            descontos += fichaFinanceira.ValorMovimento;
                        }
                    }
                    liquido = totalBruto - descontos;
                    lbTotalBruto.Text = totalBruto.ToString("n2");
                    lbTotalDescontos.Text = descontos.ToString("n2");
                    lbTotalLiquido.Text = liquido.ToString("n2");
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionJustMessage(ex);
            }
            
        }

        private void btnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (new FolhaDaoManager().SalvarMovimentoEditado(comp, movsRemovidos))
                {
                    XMessageIts.Mensagem("Movimento alterado com sucesso!");
                    this.Dispose();
                }
                //else
                //    throw new Exception();

            }
            catch (Exception ex)
            {
                XMessageIts.Advertencia("Erro! Consulte administrador\n" + ex.Message);
            }
        }

        private void barBtnRemoveEvento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var func = lstFuncionarios.SelectedItem as FuncionarioCompetencia;
            var evtSelected = gridViewFichaFinanceira.GetFocusedRow() as FichaFinanceiraFuncionario;
            if (evtSelected != null && func != null)
            {
                movsRemovidos.Add(evtSelected);
                func.FichaFinanceiraFuncionario.Remove(evtSelected);
                LoadEventosFuncionario();
            }
        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void gridViewFichaFinanceira_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                gridViewFichaFinanceira.DeleteSelectedRows();
        }
    }
}