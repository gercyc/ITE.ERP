using ITE.Entidades.POCO.RH;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITE.RH.Enumeradores;
using ITSolution.Framework.GuiUtil;

namespace ITE.RH.Forms.View
{
    public partial class XFrmAddEvento : DevExpress.XtraEditors.XtraForm
    {
        private Evento eventoAnt;

        public XFrmAddEvento()
        {
            InitializeComponent();
            //Susbtitui isso
            //Coloca manualmente
            cbTipoEvento.AddEnumValues(typeof(TypeEvento));
            cbTipoRef.AddEnumValues(typeof(TypeReferenciaEvento));
            cbCodCalculo.AddEnumValues(typeof(TypeCodigoCalculo));

            
        }

        public XFrmAddEvento(Evento evento) : this()
        {
            this.eventoAnt = indexarFormulario(evento);
        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           var novo = indexarDados();

            if (eventoAnt == null)
            {
                var ctx = new BalcaoContext();

                if (ctx.EventoDao.Save(novo))
                {
                    XMessageIts.Mensagem("Evento adicionado com sucesso!");
                    this.Dispose();
                }
            }
            else
            {
                var ctx = new BalcaoContext();
                var current = ctx.EventoDao.Find(eventoAnt.IdEvento);
                //atualiza com os dados dos campos
                current.Update(novo);
                //atualiza no banco
                if (ctx.EventoDao.Update(current))
                {
                    this.eventoAnt.Update(current);//manda a atualizacao pro objeto do grid
                    XMessageIts.Mensagem("Evento atualizado com sucesso!");
                    this.Dispose();
                }
            }
        }

        private Evento indexarDados()
        {
            var e = new Evento();
            var codigo = txtCodEvento.Text;
            var descricao = txtDescricaoEvento.Text;
            var baseSoma = new bool[checkedListBoxSomaBase.ItemCount];

            //nunca ira falhar pois o valor sera sempre true or false
            for (int i = 0; i < baseSoma.Length; i++)
            {
                baseSoma[i] = checkedListBoxSomaBase.GetItemChecked(i);
            }

            e = new Evento(codigo, descricao, baseSoma[0], baseSoma[1], baseSoma[2]);

            if (cbTipoEvento.SelectedIndex >= 0)
                //indexado a partir do 0
                e.TipoEvento = (TypeEvento)cbTipoEvento.SelectedItem;

            if (cbTipoRef.SelectedIndex >= 0)
                //indexa a partir do 1
                e.TipoReferencia = (TypeReferenciaEvento)cbTipoRef.SelectedItem;

            if (cbCodCalculo.SelectedIndex >= 0)
                //indexado a partir do 0
                e.CodigoCalculo = (TypeCodigoCalculo)cbCodCalculo.SelectedItem;

            return e;
        }

        private Evento indexarFormulario(Evento evt)
        {
            if (evt != null)
            {
                txtCodEvento.Text = evt.CodigoEvento;
                txtDescricaoEvento.Text = evt.DescricaoEvento;

                cbTipoRef.SetSelectItem(evt.TipoReferencia);
                cbTipoEvento.SetSelectItem(evt.TipoEvento);
                cbCodCalculo.SetSelectItem(evt.CodigoCalculo);

                checkedListBoxSomaBase.SetItemChecked(0, evt.SomaBaseIRRF);
                checkedListBoxSomaBase.SetItemChecked(1, evt.SomaBaseFGTS);
                checkedListBoxSomaBase.SetItemChecked(2, evt.SomaBaseINSS);
            }
            return evt;
        }

        private void barBtnVoltar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}