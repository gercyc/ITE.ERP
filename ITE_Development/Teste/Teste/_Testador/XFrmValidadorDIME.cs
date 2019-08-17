using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.Teste._Testador
{
    public partial class XFrmValidadorDIME : DevExpress.XtraEditors.XtraForm
    {
        public XFrmValidadorDIME()
        {
            InitializeComponent();
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                buttonEdit1.Text = openFileDialog.FileName;
                var path = openFileDialog.FileName;
                var text = ITSolution.Framework.Arquivos.FileManagerIts.GetDataStringFile(path);
                var r = new ValidadorDIME.ValidadorDimeSoapClient();
                var result = r.ValidarDime(text, "");

                foreach (var erro in result.Erros)
                {
                    memoEdit1.Text += "Linha: " + erro.Linha + " - Mensagem:" + erro.Mensagem + "\n";
                }

            }
            
        }
    }
}
