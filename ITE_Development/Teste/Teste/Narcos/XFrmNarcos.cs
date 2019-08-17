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
using ITSolution.Framework.ConnectionFactory.Access;

namespace Teste.Teste.Narcos
{
    public partial class XFrmNarcos : DevExpress.XtraEditors.XtraForm
    {
        public XFrmNarcos()
        {
            InitializeComponent();

            new ConnectionFactoryAccess().Fill(this.gridControl1);
        }

    }
}