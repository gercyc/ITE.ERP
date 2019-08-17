using System;
using System.Collections.Generic;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Util;

namespace ITE.DataControl.Company.NCM
{
    public class ModelNcm
    {

        public const string Codigo = "CodigoNcm";
        public const string Descricao = "DescricaoNcm";
        public const string UnidadeMed = "UnidadeMedida";
        private GridView gridView1;

        public HashSet<Ncms> Result { get; private set; }
        public HashSet<Ncms> Errors { get; private set; }


        public ModelNcm(GridView gridView1)
        {
            this.gridView1 = gridView1;
            this.Result = new HashSet<Ncms>();
            this.Errors = new HashSet<Ncms>();

        }

        public bool CreateNcms()
        {
            var x = gridView1.RowCount;
            var ctx = new BalcaoContext();
            var dao = ctx.NcmsDao;


            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                var codigo = row[Codigo].ToString();
                var desc = row[Descricao].ToString().Trim();
                var un = row[UnidadeMed].ToString();

                Ncms l = new Ncms
                {
                    CodigoNcm = codigo,
                    DataCadastro = DateTime.Now,
                    DescricaoNcm = desc,
                    UnidadeMedida = un
                };

                try
                {
                    dao.Save(l);
                    this.Result.Add(l);
                }
                catch (Exception ex)
                {
                    this.Errors.Add(l);
                    LoggerUtilIts.ShowExceptionLogs(ex);
                }


            }
            return true;
        }
    }
}
