using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO.Fiscal;
using DevExpress.XtraEditors;

namespace ITE.Components
{
    public partial class LookUpMunicipio : XtraUserControl
    {
        public string Municipio { get; set; }
        public string UF { get; set; }
        public Form MdiForm { get; set; }

        public ComboBoxEdit ComboEditMunicipio {
            get { return cbCidade; }
        }
        public ComboBoxEdit ComboEditUF {
            get { return cbUf; }
        }

        public bool ReadyOnly
        {

            get { return cbCidade.ReadOnly && cbUf.ReadOnly; }
            set
            {
                cbCidade.ReadOnly = value;
                cbUf.ReadOnly = value;
            }
        }

        public LookUpMunicipio()
        {
            InitializeComponent();

        }

        //seta a UF
        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var o = cbCidade.SelectedItem as Municipios;

            if (o != null)
            {
                try
                {
                    var cidade = cbCidade.SelectedItem as Municipios;
                    this.Municipio = cidade.NomeMunicipio;
                    this.UF = cidade.UnidadeFederacao.CodigoUF;

                    this.cbUf.Properties.Items.Clear();
                    this.cbUf.Text = this.UF;
                    //this.cbUf.Properties.Items.Add(this.UF);

                }
                catch (NullReferenceException ex)
                {
                    //nao importar se foi localizado pelo cep
                    Console.WriteLine(ex);
                }
            }

        }

        private void cbCidade_Click(object sender, EventArgs e)
        {
            //garante a indexacao
            if (cbCidade.Properties.Items.Count == 0)
            {
                RefreshMunicipioUF();
            }
        }

        public void RefreshMunicipioUF()
        {
            using (var ctx = new BalcaoContext())
            {
                this.cbCidade.Properties.Items.Clear();
                this.cbUf.Properties.Items.Clear();
                try
                {
                    var mun = ctx.MunicipiosDao.FindAll().OrderBy(m => m.NomeMunicipio).ToList();
                    this.cbCidade.Properties.Items.AddRange(mun);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Cidade/UF nao encontrado " + ex.Message);
                }

            }

        }

        public void SetMunicipioUF(string cidade, string uf)
        {
            this.Municipio = cidade;
            this.UF = uf;

            this.cbCidade.Properties.Items.Clear();
            this.cbUf.Properties.Items.Clear();
            if (cidade != null)
                this.cbCidade.Properties.Items.Add(cidade);

            if (uf != null)
                this.cbUf.Properties.Items.Add(uf);

            this.cbCidade.SelectedIndex = 0;
            this.cbUf.SelectedIndex = 0;

        }

        private void cbCidade_DoubleClick(object sender, EventArgs e)
        {
            RefreshMunicipioUF();
        }

        private void cbCidade_EditValueChanged(object sender, EventArgs e)
        {
            this.Municipio = this.cbCidade.Text;
        }

        private void cbUf_EditValueChanged(object sender, EventArgs e)
        {
            this.UF = cbUf.Text;
        }
    }
}
