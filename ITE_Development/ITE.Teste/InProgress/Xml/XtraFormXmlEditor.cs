using System;
using System.Windows.Forms;
using System.Reflection;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Arquivos;
using System.IO;

namespace ITE.Teste
{
    public partial class XtraFormXmlEditor : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormXmlEditor()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Assembly _assembly = Assembly.GetExecutingAssembly(); ;
            
            var resource = XFrmOptionPane.ShowInputDialog("Path.xml name");

            if (resource != null)
            {
                var stream = GridViewUtil.GetLayoutStreamFromResource(_assembly, resource);

                this.gridControl1.ViewCollection.Clear();

                this.gridView1.Columns.Clear();

                this.gridView1.LayoutChanged();

                this.gridView1.RestoreLayoutFromStream(stream);

            }

        }
  

    }
}