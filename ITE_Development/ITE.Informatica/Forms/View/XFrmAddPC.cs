using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using System.Reflection;
using ITE.Entidades.POCO.TI;
using System.Collections.Generic;

namespace ITE.Informatica.Forms.Cadastro
{
    public partial class XFrmAddPC : DevExpress.XtraEditors.XtraForm
    {
        public Computador Computador { get; private set; }

        public XFrmAddPC()
        {
            InitializeComponent();

        }

        public XFrmAddPC(Computador computador) : this()
        {
            this.Computador = indexarDados(computador);
        }

        private Computador indexarDados(Computador pc)
        {
            if (pc != null)
            {
                txtPlacaMae.Text = pc.NomePlacaMae;
                txtProcessador.Text = pc.Processador;
                txtMemRam.Text = pc.MemoriaRam;
                txtHd.Text = pc.Hd;

                var pcs = new List<SistemaOperacional>();
                pcs.Add(pc.SistemaOperacional);

                var so = pc.SistemaOperacional;

                if (so != null)
                {
                    txtSO.Text = so.NomeSistema;
                    cbArq.AddItem<SistemaOperacional>(so);
                }


                txtNomePc.Text = pc.NomeComputador;
                txtGrupoTrabalho.Text = pc.GrupoTrabalho;
            }

            return pc;

        }

        private void XFrmAddPC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Dispose();

        }

      

        private Computador indexarDados()
        {
            var o = cbArq.SelectedItem;
            string arq = o != null ? o.ToString() : null;
            string soName = txtSO.Text;

            var so = new SistemaOperacional(arq, soName);

            return new Computador(txtPlacaMae.Text, txtProcessador.Text, txtHd.Text,
                                  txtMemRam.Text, txtNomePc.Text, txtGrupoTrabalho.Text, so);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var novo = indexarDados();

            if (this.Computador == null)
            {
                this.Computador = novo;
                this.Dispose();
            }
            else
            {
                using (var ctx = new BalcaoContext())
                {
                    var current = ctx.ComputadorDao.Find(this.Computador.IdComputador);
                    current.Update(novo);

                    this.Computador.Update(novo);

                    if (ctx.ComputadorDao.Update(current))
                        this.Dispose();
                }
            }
        }

    }
}