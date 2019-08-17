using System;
using System.Windows.Forms;
using ITE.Entidades.DaoManager.SlateManager;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Ardosia.ProductionSlate;
using ITSolution.Framework.Util;

namespace ITE.Slate.Forms.ControleCarga.View
{
    public partial class XFrmAddMaterialSerra : DevExpress.XtraEditors.XtraForm
    {
        private readonly MaterialSerra _materialAnt;

        private XFrmAddMaterialSerra()
        {
            InitializeComponent();
        }

        public XFrmAddMaterialSerra(Usuario user):this()
        {
            if (!user.IsAdmin)
            {
                txtValorMetro.Visible = false;
                labelControl8.Visible = false;
            }
        }

        public XFrmAddMaterialSerra(MaterialSerra materialAnt) : this()
        {
            this._materialAnt = materialAnt;

            txtComprimento.Text = materialAnt.Comprimento.ToString();
            txtLargura.Text = materialAnt.Largura.ToString();
            txtEspessura1.Text = materialAnt.Espessura1.ToString();
            txtEspessura2.Text = materialAnt.Espessura2.ToString();

            txtComprimento.ReadOnly = true;
            txtLargura.ReadOnly = true;
            txtEspessura1.ReadOnly = true;
            txtEspessura2.ReadOnly = true;

            txtValorMetro.Text = materialAnt.ValorMetroQuadrado.ToString();
        }


        private MaterialSerra indexarDados()
        {
            MaterialSerra m = new MaterialSerra(ParseUtil.ToDecimal(txtComprimento.Text),
                ParseUtil.ToDecimal(txtLargura.Text),
                ParseUtil.ToDecimal(txtEspessura1.Text),
                ParseUtil.ToDecimal(txtEspessura2.Text),
                ParseUtil.ToDecimal(txtValorMetro.Text));

            if (_materialAnt != null)
            {
                m.IdMaterial = _materialAnt.IdMaterial;

                m.CodigoMaterial = m.IdMaterial;
            }
            return m;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (new MaterialSerraDaoManager().SaveUpdate(indexarDados()))
                this.Dispose();
        }


        private void XFrmAddMaterialSerra_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                btnSalvar_Click(null, null);
        }
    }
}