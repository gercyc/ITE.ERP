using System;
using ITE.Entidades.DaoManager.SlateManager;
using ITE.Entidades.Enumeradores.SlateEnums;
using ITE.Entidades.POCO.Ardosia.ProductionSlate;

namespace ITE.Slate.Forms.ControleCarga.View
{
    public partial class XFrmAddSerra : DevExpress.XtraEditors.XtraForm
    {
        private Serra _serraAnt;

        public XFrmAddSerra()
        {
            InitializeComponent();
        }

        public XFrmAddSerra(Serra unidadeMedida)
           : this()
        {

            this._serraAnt = indexarCampos(unidadeMedida);
        }

        private Serra indexarCampos(Serra s)
        {
            cbStatus.SelectedIndex = (int)s.StatusSerra;
            txtDescricao.Text = s.NomeSerra;

            return s;
        }

        private Serra indexarDados()
        {
            TypeStatusSerra status = (TypeStatusSerra)cbStatus.SelectedIndex;
            var nome = txtDescricao.Text;

            var novo = new Serra(status, nome);

            if (_serraAnt != null)
                novo.IdSerra = _serraAnt.IdSerra;
            return novo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novo = indexarDados();
            if (new SerraDaoManager().SaveUpdate(novo))
            {
                if (_serraAnt != null)
                    _serraAnt.Update(novo);
                //libera a memoria do objeto
                this.Dispose();

            }
        }
    }
}