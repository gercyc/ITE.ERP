using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using ITE.Entidades.Repositorio;
using ITE.Forms.VersionController.Entidades;

namespace ITE.Forms.VersionController
{
    public partial class XFrmVersionValidator : DevExpress.XtraEditors.XtraForm
    {
        public XFrmVersionValidator()
        {
            InitializeComponent();
        }

        #region Regras e métodos

        

        #endregion

        #region Eventos
        private void btnValidar_Click(object sender, EventArgs e)
        {
            var domain = typeof(XFrmVersionValidator);
            var assembliesCarregados = new VersionValidatorUtil().AssembliesCarregados(domain);
            gridControl1.DataSource = assembliesCarregados;
            var ctx = ITEGenericContext<ItsVersionControl>.Instance;
            new VersionValidatorUtil().Sincbd(assembliesCarregados);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = new VersionValidatorUtil().GetInstalledAssemblies();
        }
        
        #endregion


    }
}