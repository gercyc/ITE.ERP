using System;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO.RH.Folha;
using ITE.Entidades.POCO.RH;
using ITSolution.Framework.Util;
using ITE.RH.Enumeradores;

namespace ITE.RH.Forms.Folha
{
    public partial class XFrmAdicionarFichaFinanceira : DevExpress.XtraEditors.XtraForm
    {
        private CompetenciaFolha comp;
        private FuncionarioCompetencia func;

        public XFrmAdicionarFichaFinanceira()
        {
            InitializeComponent();
            cbTipo.Properties.Items.AddRange(Enum.GetValues(typeof(TypeReferenciaEvento)));
        }

        public XFrmAdicionarFichaFinanceira(CompetenciaFolha comp, FuncionarioCompetencia func) : this()
        {
            this.comp = comp;
            this.func = func;
        }

        private void XFrmAdicionarEvento_Shown(object sender, EventArgs e)
        {
            carregarEventos();
        }
        private void carregarEventos()
        {
            using (var ctx = new BalcaoContext())
            {
                var eventos = ctx.EventoDao.FindAll();
                lkEvento.Properties.DataSource = eventos;
            }
        }
        private FichaFinanceiraFuncionario IndexarMovFicha()
        {
            var evento = lkEvento.EditValue as Evento;
            var valor = ParseUtil.ToDecimal(txtValor.Text);
            var qtd = ParseUtil.ToDecimal(txtQuantidade.Text);
            var tipo = (TypeReferenciaEvento)cbTipo.SelectedIndex;

            FichaFinanceiraFuncionario ficha = new FichaFinanceiraFuncionario(func, evento, valor, tipo, comp.DataFinalCompetencia, qtd);
            ficha.Evento = evento;
            ficha.FuncionarioCompetencia = func;
            return ficha;            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            func.FichaFinanceiraFuncionario.Add(IndexarMovFicha());
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lkEvento_EditValueChanged(object sender, EventArgs e)
        {
            var evento = lkEvento.EditValue as Evento;

            cbTipo.SelectedItem = evento.TipoReferencia;
        }
    }
}