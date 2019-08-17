#define DESIGN
//using Common.Math;
using DevExpress.XtraBars.Ribbon;
using ITSolution.Framework.BaseForms;
using ITSolution.Framework.BaseInterfaces;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Scheduler.Forms;
//using ITSolution.ServiceFramework.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEDesktop
{
    public partial class ITEDesktop : ITSAncestorDesktop
    {
        public ITEDesktop()
        {
            InitializeComponent();
        }

        private void ITEDesktop_Load(object sender, EventArgs e)
        {
            //ShowLoginForm();
            ITSTools.Login("gercy", "a123");
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ITSTools.ShowTransaction(new XFrmTaskCentral());
            //FormsUtil.Show(new XFrmTaskCentral());
        }

        private void btnTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //TraTesteView tra = new TraTesteView();
            //tra.Show();
            ITSTools.ShowTransaction(new GrcTeste());
        }

        private void btnMath_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //ITSTools.OpenConnection<IMath>("Servers.Math.MathController").TestConnection();
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }
            
        }
    }
}
