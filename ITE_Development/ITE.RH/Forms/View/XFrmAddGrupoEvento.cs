using ITE.Entidades.POCO.RH;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITE.RH.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO.RH.Folha;
using System.Linq;
using ITSolution.Framework.Forms;
using ITSolution.Framework.Beans.Forms;
using System;
using System.Collections.Generic;

namespace ITE.RH.Forms.View
{
    public partial class XFrmAddGrupoEvento : DevExpress.XtraEditors.XtraForm
    {
        private GrupoEvento grpEventoAnt;
        private List<EventosGrupo> eventosGrupo;

        public XFrmAddGrupoEvento()
        {
            InitializeComponent();
            this.eventosGrupo = new List<EventosGrupo>();
        }

        public XFrmAddGrupoEvento(GrupoEvento grupoEvento) : this()
        {
            this.grpEventoAnt = indexarFormulario(grupoEvento);

        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var novo = indexarDados();

            if (grpEventoAnt == null)
            {
                var ctx = new BalcaoContext();
                foreach (var ev in novo.EventosGrupo)
                {
                    ev.Evento = null;
                }
                if (ctx.GrupoEventoDao.Save(novo))
                {
                    XMessageIts.Mensagem("Grupo de eventos adicionado com sucesso!");
                    this.Dispose();
                }
            }
            else
            {
                var ctx = new BalcaoContext();
                var current = ctx.GrupoEventoDao.Find(grpEventoAnt.IdGrupoEvento);
                //atualiza com os dados dos campos
                current.Update(novo);
                //anular os eventos, senao vai duplicar no cadastro
                novo.EventosGrupo.ToList().ForEach(ev => ev.Evento = null);
                //atualiza no banco
                if (ctx.GrupoEventoDao.Update(current))
                {
                    RemoveEventos(novo);
                    this.grpEventoAnt.Update(current);//manda a atualizacao pro objeto do grid
                    XMessageIts.Mensagem("Evento atualizado com sucesso!");
                    this.Dispose();
                }
            }
        }

        private GrupoEvento indexarDados()
        {
            var codigo = txtCodGrpEvento.Text;
            var descricao = txtDescricaoGrpEvento.Text;
            var obs = txtObservacoes.Text;


            var grpEvento = new GrupoEvento()
            {
                CodigoGrupo = codigo,
                DescricaoGrupo = descricao,
                Observacoes = obs
            };

            foreach (var ev in this.eventosGrupo)
            {
                grpEvento.EventosGrupo.Add(ev);
            }

            return grpEvento;
        }

        private GrupoEvento indexarFormulario(GrupoEvento Grpevt)
        {
            if (Grpevt != null)
            {
                txtCodGrpEvento.Text = Grpevt.CodigoGrupo;
                txtDescricaoGrpEvento.Text = Grpevt.DescricaoGrupo;
                txtObservacoes.Text = Grpevt.Observacoes;

                var q = from e in Grpevt.EventosGrupo
                        select new EventosGrupo() { Evento = e.Evento, IdEvento = e.IdEvento, ImprimirHolerite = e.ImprimirHolerite, IdEvtGrupo = e.IdEvtGrupo, IdGrupoEvento = e.IdGrupoEvento };
                this.eventosGrupo = q.ToList();

                gridControlEventosGrp.DataSource = this.eventosGrupo;
            }
            return Grpevt;
        }

        private void btnAddEvento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Title = "Localizar evento:",
                    Columns = new string[] { "CodigoEvento", "DescricaoEvento", "TipoEvento", "CodigoCalculo" },
                    Order = "CodigoEvento",
                    DynamicObject = null
                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<Evento>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var codEvento = selected.GetType().GetProperty("CodigoEvento").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("DescricaoEvento").GetValue(selected, null);

                    selected = ctx.EventoDao.Where(ev => ev.CodigoEvento == codEvento).FirstOrDefault() as Evento;

                    if (selected != null)
                    {
                        //procura o evento selecionado na lista dos eventos do grupo, se nao encontrar nada, adicione
                        if (this.eventosGrupo.Where(fe => fe.IdEvento == selected.IdEvento).Count() == 0)
                        {
                            //se esta editando ja existe o grupo
                            if (grpEventoAnt != null)
                                this.eventosGrupo.Add(new EventosGrupo() { Evento = selected, IdEvento = selected.IdEvento, IdGrupoEvento = grpEventoAnt.IdGrupoEvento });
                            else //senao so add o evento no grupo que esta sendo criado
                                this.eventosGrupo.Add(new EventosGrupo() { Evento = selected, IdEvento = selected.IdEvento });
                        }
                        else
                            //senao o evento ja existe para o funcionario, então ignore.
                            XMessageIts.Advertencia("Evento já existente para o grupo.");
                    }
                    //atualize o grid.
                    setDataGridEventos();
                }
            }
        }

        private void setDataGridEventos()
        {
            gridControlEventosGrp.DataSource = this.eventosGrupo.Where(e => e.Removed != true);
            gridControlEventosGrp.RefreshDataSource();
        }

        private void btnRemoveEvento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = gridViewEventosGrp.GetFocusedRow<EventosGrupo>();
            try
            {
                //procura o evento removido na lista do funcionario e marca como removido
                var evtF = grpEventoAnt.EventosGrupo.Where(ev => ev.IdEvento == selected.IdEvento).First();
                //marca como removido.
                evtF.Removed = true;

                //remova da lista;
                eventosGrupo.Where(ev => ev.IdEvento == selected.IdEvento).First().Removed = true;
            }
            catch (Exception)
            {
                //fodase
            }
            finally
            {
                setDataGridEventos();
            }
        }
        private void RemoveEventos(GrupoEvento grpEvento)
        {
            using (var ctx = new BalcaoContext())
            {
                foreach (var evt in grpEvento.EventosGrupo.Where(e => e.Removed == true))
                {
                    var r = ctx.EventosGrupoDao.Find(evt.IdEvtGrupo);
                    ctx.EventosGrupoDao.Delete(r);

                }
            }
        }
    }
}