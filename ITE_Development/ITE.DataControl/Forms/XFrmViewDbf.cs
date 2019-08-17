using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITSolution.Framework.Util;
using ITSolution.Framework.Beans.ProgressBar;
using System.IO;
using ITSolution.Framework.Mensagem;
using System.Collections.Generic;
using ITE.Entidades.POCO;
using System.Linq;
using ITE.DataControl.Company.LSC;

namespace ITE.DataControl.Forms
{
    public partial class XFrmViewDbf : DevExpress.XtraEditors.XtraForm
    {
        private String fileDbf;


        public XFrmViewDbf()
        {
            InitializeComponent();
            this.ActiveControl = btnSelectFileDbf;
            this.btnSelectFileDbf.Focus();
        }

        private DataTable carregarDbf()
        {
            var dt = new ConnectionDbf(fileDbf).GetDataTable();

            return dt;
        }


        private async Task carregarDbfAsync()
        {
            var result = await Task.Run(() => carregarDbf());
            gridViewImport.Columns.Clear();
            gridControlimport.DataSource = result;

            //ETL
            //List<String> columns = new List<string>();
            //foreach (var col in result.Columns)
            //{
            //    columns.Add(col.ToString());
            //}

            //XFrmMapping map = new XFrmMapping(columns);
            //map.Show();

        }
        private void btnSelectFileDbf_Click(object sender, EventArgs e)
        {
            var op = openFileDbf.ShowDialog();
            if (op == DialogResult.OK)
            {

                this.fileDbf = openFileDbf.FileName;
                var fileName = Path.GetFileName(fileDbf);

                if (fileName.Contains(" "))
                {
                    this.fileDbf = null;
                    XMessageIts.Advertencia("O nome do arquivo não pode conter espaços");
                }
                else
                {

                    txtFileDbf.Text = fileDbf;
                }

            }
        }

        private void barBtnImportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.fileDbf != null)
            {
                var name = Path.GetFileName(this.fileDbf);

                if (name.Equals("ESS1PRO.DBF"))
                    new ProdutoImport().ImportToDatabase(carregarDbf());

                else if (name.Equals("CLS1CLI.DBF"))
                    new CliForImport().ImportToDatabase(carregarDbf());
                else
                    XMessageIts.Advertencia("Arquivo DBF não aceito pelo contexto.");
            }
            else
                XMessageIts.Advertencia("Informe o arquivo DBF");

        }


        private void barBtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ProdutoImport().ExportExcel(gridControlimport);
            this.barBtnExportarExcel.Enabled = false;
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnIndexar_ItemClick(null, null);
        }

        private void barBtnIndexar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.barBtnExportarExcel.Enabled = true;

            if (this.fileDbf != null)
                XFrmWait.StartTask(carregarDbfAsync(), "Preparando dados");
            else
                XMessageIts.Advertencia("Informe o arquivo DBF");
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos XML | *.xml";
            openFile.ShowDialog();
            DataSet mapeamento = new DataSet("mapeamento");
            DataTable dados = carregarDbf();
            List<CliFor> cliforAdd = new List<CliFor>();
            List<DataColumn> columns = new List<DataColumn>();
            mapeamento.ReadXml(openFile.FileName);

            foreach (DataColumn col in dados.Columns)
            {
                columns.Add(col);
            }

            var cols = columns.Where(c => c.ColumnName.Contains(mapeamento.Tables[0].Rows[0][0].ToString()));

            //for (int i = 0; i < dados.Columns.Count; i++)
            //{
            //    var field = from DataColumn f in 
            //                where f[i].Equals(mapeamento.Tables[0].Columns[i].ColumnName)
            //}



            foreach (var item in dados.AsEnumerable())
            {
                CliFor c = new CliFor();



                c.RazaoSocial = item[1].ToString();
                cliforAdd.Add(c);

            }

            Console.WriteLine("stop");

        }
    }
}