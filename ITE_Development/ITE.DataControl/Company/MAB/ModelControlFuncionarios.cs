using ITE.Entidades.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using ITSolution.Framework.Util;
using System.Data;
using ITE.Entidades.POCO.RH;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITE.RH.Enumeradores;

namespace ITE.DataControl.Company.MAB
{
    public class ModelControlFuncionario
    {

        private const string NomeFuncionario = "NomeFuncionario";
        private const string CPF = "CPF";
        private const string DataNascimento = "DataNascimento";
        private const string Idade = "Idade";
        private const string DataAdmissao = "DataAdmissao";
        private const string Situacao = "Situacao";
        private const string Salario = "Salario";
        private const string EstadoCivil = "EstadoCivil";
        private const string TipoRecebimento = "TipoRecebimento";
        private const string IdDepartamento = "IdDepartamento";
        private const string IdFuncao = "IdFuncao";
        private const string IdFilial = "IdFilial";

        public TypeMoeda Moeda { get; set; }
        private GridView gridView1;

        public HashSet<Funcionario> Result { get; private set; }
        public HashSet<Funcionario> Errors { get; private set; }

        public ModelControlFuncionario()
        {

        }

        public ModelControlFuncionario(GridView gridView1)
        {
            this.gridView1 = gridView1;
            this.Result = new HashSet<Funcionario>();
            this.Errors = new HashSet<Funcionario>();

        }

        public bool CreateFuncionarios()
        {
            using (var ctx = new BalcaoContext())
            {
                var dao = ctx.FuncionarioDao;


                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);

                    var f = new Funcionario();
                    try
                    {
                        f.NomeFuncionario = row[NomeFuncionario].ToString();

                        f.CPF = row[CPF].ToString();
                        f.DataNascimento = DataUtil.ToDate(row[DataNascimento].ToString());
                        f.Idade = ParseUtil.ToInt(row[Idade].ToString());
                        f.DataAdmissao = DataUtil.ToDate(row[DataAdmissao].ToString());
                        f.Situacao = (TypeSituacaoFuncionario) ParseUtil.ToInt(row[Situacao].ToString());
                        f.Salario = ParseUtil.ToDecimal(row[Salario].ToString());
                        f.EstadoCivil = (TypeEstadoCivil) ParseUtil.ToDecimal(row[EstadoCivil].ToString());
                        f.TipoRecebimento = (TypeRecebimento) ParseUtil.ToDecimal(row[TipoRecebimento].ToString());
                        f.IdDepartamento = ParseUtil.ToInt(row[IdDepartamento].ToString());
                        f.IdFuncao = ParseUtil.ToInt(row[IdFuncao].ToString());
                        f.IdFilial = ParseUtil.ToInt(row[IdFilial].ToString());
                        //efetiva no banco
                        dao.Save(f);
                        this.Result.Add(f);
                    }
                    catch (Exception ex)
                    {
                        this.Errors.Add(f);
                        LoggerUtilIts.ShowExceptionLogs(ex);
                    }


                }
                return true;
            }
        }
    }
}
