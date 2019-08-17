using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITSolution.Framework.GuiUtil;
//using ITSolution.Util.Reflection;
using ITSolution.Framework.ConnectionFactory;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Dao.Contexto;
using System.Data.SqlClient;
using ITSolution.Framework.Util;

namespace ITE.DataControl.Forms
{
    public partial class XFrmMapping : XtraForm
    {
        public DataSet Mapeamento = new DataSet("Mapeamento");
        DataTable dtColsOrigem = new DataTable("ColsOrigem");
        DataTable dtTabSelected = new DataTable("TabDestino");
        DataTable dtMapeamento = new DataTable("TableMapeamento");

        public XFrmMapping()
        {
            InitializeComponent();

        }

        #region Origem dos dados

        private void barBtnAddColOrg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewColsOrigem.AddNewRow();
        }

        private void barBtnDelColOrg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewColsOrigem.DeleteRow();
        }

        private void gridControlColsOrigem_Load(object sender, EventArgs e)
        {
            boundXGridOrigem();
        }
        //indexar o DataSource do grid, ele nao eh editavel no modo "Unbound"
        private void boundXGridOrigem()
        {
            dtColsOrigem.Columns.Add("NomeColOrigem", typeof(string));
            dtColsOrigem.Columns.Add("TipoColOrigem", typeof(string));
            dtColsOrigem.Columns.Add("Tamanho", typeof(string));
            dtColsOrigem.Columns.Add("Precisao", typeof(string));

            //adiciona a coluna ao dt da tabela selecionada
            dtTabSelected.Columns.Add("Tabela", typeof(string));

            gridControlColsOrigem.DataSource = dtColsOrigem;
        }

        //Validacao: so deixa seguir se houver ao menos 1 coluna na origem
        private void wizardPageOrigem_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            if (dtColsOrigem.Rows.Count < 1)
                XMessageIts.Advertencia("Informe pelo menos uma coluna para prosseguir!");
            else
                return;
        }
        private void wizardPageOrigem_PageCommit(object sender, EventArgs e)
        {
            //adicione ao dataset somente se nao existir
            if (!Mapeamento.Tables.Contains("ColsOrigem"))
            {
                //armazenar as cols de origem no dataset
                Mapeamento.Tables.Add(dtColsOrigem);
            }
            //preenche o proximo grid.
            boundXGridTabDestino();
        }
        internal class ColunaOrigem : IConvertible
        {
            public ColunaOrigem(string nome, string tipo, string tamanho, string precisao)
            {
                this.Nome = nome;
                this.Tipo = tipo;
                this.Tamanho = tamanho;
                this.PrecisaoDecimal = precisao;
            }
            public string Nome { get; set; }
            public string Tipo { get; set; }
            public string Tamanho { get; set; }
            public string PrecisaoDecimal { get; set; }
            public string EscalaDecimal { get; set; }

            public override string ToString()
            {
                return Nome;
            }

            public TypeCode GetTypeCode()
            {
                throw new NotImplementedException();
            }

            public bool ToBoolean(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public char ToChar(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public sbyte ToSByte(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public byte ToByte(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public short ToInt16(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public ushort ToUInt16(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public int ToInt32(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public uint ToUInt32(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public long ToInt64(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public ulong ToUInt64(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public float ToSingle(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public double ToDouble(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public decimal ToDecimal(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public DateTime ToDateTime(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public string ToString(IFormatProvider provider)
            {
                return Nome;
            }

            public object ToType(Type conversionType, IFormatProvider provider)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Destino dos dados
        private void boundXGridTabDestino()
        {
            try
            {
                ConnectionFactoryIts conn = new ConnectionFactoryIts(AppConfigManager.Configuration.AppConfig.ConnectionString);
                DataTable dtTabelas = new DataTable("Tabelas");
                dtTabelas = conn.ExecuteQueryDataTable("SELECT TABLE_SCHEMA, TABLE_NAME FROM INFORMATION_SCHEMA.TABLES");

                gridControlTabDestino.DataSource = dtTabelas;
            }
            catch (SqlException ex)
            {
                LoggerUtilIts.ShowExceptionLogs(ex);
            }
        }

        internal class ColunaDestino : IConvertible
        {
            public ColunaDestino(string nome, string tipo, string tamanho, string precisao, string escala)
            {
                this.Nome = nome;
                this.Tipo = tipo;
                this.Tamanho = tamanho;
                this.PrecisaoDecimal = precisao;
                this.EscalaDecimal = escala;
            }
            public string Nome { get; set; }
            public string Tipo { get; set; }
            public string Tamanho { get; set; }
            public string PrecisaoDecimal { get; set; }
            public string EscalaDecimal { get; set; }

            public override string ToString()
            {
                return Nome;
            }

            public TypeCode GetTypeCode()
            {
                throw new NotImplementedException();
            }

            public bool ToBoolean(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public char ToChar(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public sbyte ToSByte(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public byte ToByte(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public short ToInt16(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public ushort ToUInt16(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public int ToInt32(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public uint ToUInt32(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public long ToInt64(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public ulong ToUInt64(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public float ToSingle(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public double ToDouble(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public decimal ToDecimal(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public DateTime ToDateTime(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public string ToString(IFormatProvider provider)
            {
                return Nome;
            }

            public object ToType(Type conversionType, IFormatProvider provider)
            {
                throw new NotImplementedException();
            }
        }

        private void wizardPageTabDestino_PageCommit(object sender, EventArgs e)
        {
            var rowSel = gridViewTabDestino.GetFocusedDataRow();
            dtTabSelected.Columns.Add("TABLE_SCHEMA", typeof(string));
            dtTabSelected.Columns.Add("TABLE_NAME", typeof(string));

            dtTabSelected.Rows.Add(rowSel.ItemArray);

            //prosseguir somente se houver 1 tabela selecionada
            if (dtTabSelected.Rows.Count >= 1)
            {
                //adicione ao dataset somente se nao existir
                if (!Mapeamento.Tables.Contains("TabDestino"))
                {
                    //armazena a tabela de destino
                    Mapeamento.Tables.Add(dtTabSelected);

                    indexColumnsCbColDestino(dtTabSelected.Rows[0][1].ToString());
                    indexColumnsCbColOrigem();

                    //preenche o grid de mapeamento
                    boundXGridMapeamento();
                }
            }
            else
                XMessageIts.Advertencia("Selecione uma tabela!!");
        }
        #endregion

        #region Mapeamento DExPARA

        private void boundXGridMapeamento()
        {
            dtMapeamento.Columns.Add("Destino", typeof(string));
            dtMapeamento.Columns.Add("TipoDestino", typeof(string));
            dtMapeamento.Columns.Add("Origem", typeof(string));
            dtMapeamento.Columns.Add("TipoOrigem", typeof(string));

            gridControlMapeamento.DataSource = dtMapeamento;
        }


        private void indexColumnsCbColDestino(string tableName)
        {
            try
            {
                var dtColumns = new DataTable("ColumnsDestino");
                ConnectionFactoryIts cnn = new ConnectionFactoryIts(AppConfigManager.Configuration.AppConfig.ConnectionString);
                dtColumns = cnn.ExecuteQueryDataTable(String.Format("SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, NUMERIC_SCALE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = {0}", "\'" + tableName + "\'"));

                foreach (var col in dtColumns.AsEnumerable())
                {
                    var colDest = new ColunaDestino(col[0].ToString(), col[1].ToString(), col[2].ToString(), col[3].ToString(), col[4].ToString());

                    repComboDestino.Items.Add(colDest);
                }
            }
            catch (SqlException ex)
            {
                LoggerUtilIts.ShowExceptionLogs(ex);
            }
        }

        private void indexColumnsCbColOrigem()
        {
            foreach (var col in dtColsOrigem.AsEnumerable())
            {
                var colOrg = new ColunaOrigem(col[0].ToString(), col[1].ToString(), col[2].ToString(), col[3].ToString());
                repComboOrigem.Items.Add(colOrg);
            }
        }
        private void repComboDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            var row = gridViewMapeamento.GetFocusedDataRow();
            BaseEdit sel = sender as BaseEdit;

            var col = sel.EditValue as ColunaDestino;
            row[1] = col.Tipo.ToString();
            gridControlMapeamento.Refresh();
            gridControlMapeamento.Update();
        }
        private void wizardPageMapeamento_PageCommit(object sender, EventArgs e)
        {
            //adicione ao dataset somente se nao existir
            if (!Mapeamento.Tables.Contains("TableMapeamento"))
            {
                //armazenar o mapeamento no dataSet
                Mapeamento.Tables.Add(dtMapeamento);
            }

            SaveFileDialog sv = new SaveFileDialog();
            sv.FileName = "Mapeamento.xml";
            sv.ShowDialog();

            Mapeamento.WriteXml(sv.FileName);
            Mapeamento.WriteXmlSchema(sv.FileName + "xsd");
        }

        #endregion

        private void repComboOrigem_SelectedValueChanged(object sender, EventArgs e)
        {
            var row = gridViewMapeamento.GetFocusedDataRow();
            BaseEdit sel = sender as BaseEdit;

            var col = sel.EditValue as ColunaOrigem;
            row[3] = col.Tipo.ToString();
            gridControlMapeamento.Refresh();
            gridControlMapeamento.Update();
        }
    }
}