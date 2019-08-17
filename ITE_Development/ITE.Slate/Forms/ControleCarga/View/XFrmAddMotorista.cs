using System;
using ITE.Entidades.DaoManager.SlateManager;
using ITE.Entidades.POCO.Ardosia.Minning;

namespace ITE.Slate.Forms.ControleCarga.View
{
    public partial class XFrmAddMotorista : DevExpress.XtraEditors.XtraForm
    {
        public XFrmAddMotorista()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Motorista motorista = new Motorista(txtNome.Text);

            if (new MotoristaDaoManager().SaveUpdate(motorista))
            {
                this.Dispose();
            }
        }
    }
}