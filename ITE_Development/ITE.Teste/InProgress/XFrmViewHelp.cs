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

namespace ITE.Teste._Testador
{
    public partial class XFrmViewHelp : DevExpress.XtraEditors.XtraForm
    {
        public XFrmViewHelp()
        {
            InitializeComponent();
            var doc = @"D:\help.rtf";
            richEditControl1.LoadDocument(doc);
        }
    }
}