using ITE.Entidades.POCO.Sales;
using ITSolution.Framework.Windows.BaseForms;
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
    public partial class GrcTeste : ITSTransaction
    {
        public GrcTeste()
        {
            InitializeComponent();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Produto p = gridView1.GetFocusedRow() as Produto;
            ITSTools.ShowTransaction(new TraTesteView(p));
        }
    }
}
