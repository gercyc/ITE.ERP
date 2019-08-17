using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Validador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ITE.DataControl.Company.LSC
{
    public class CliForImport
    {
        public bool ImportToDatabase(DataTable dadosOrigem)
        {
            /*  Colunas
            NOMECLI	 | CIDADE  | UF     | NOMEFANT	
            ENDER	 | INSCEST | BAIRRO	| CGC	    
            CEP      | CONTATO | TELEF1	| TELEF2	
            TIPO_CLI | RG	   | LIMITE	| DT_CLI            
            */
            if (dadosOrigem != null)
            {
                var ctx = new BalcaoContext();
                List<CliFor> cliForSave = new List<CliFor>();
                int i = 0;
                try
                {
                    foreach (var cliForItg in dadosOrigem.AsEnumerable())
                    {
                        CliFor c = new CliFor();
                        EnderecoCliFor cEnd = new EnderecoCliFor();

                        c.RazaoSocial = cliForItg["NOMECLI"].ToString();
                        c.CpfCnpj = cliForItg["CGC"].ToString();

                        c.Telefone = cliForItg["TELEF1"].ToString();
                        c.RG = cliForItg["RG"].ToString();
                        c.DataNascimento = ParseUtil.ToDate(cliForItg["DT_CLI"]);
                        c.Celular = cliForItg["TELEF2"].ToString();

                        cEnd.TipoEndereco = "Comercial";
                        cEnd.Complemento = "N/A";
                        cEnd.Bairro = cliForItg["BAIRRO"].ToString();
                        cEnd.Cep = cliForItg["CEP"].ToString();
                        cEnd.Cidade = cliForItg["CIDADE"].ToString();
                        cEnd.NomeEndereco = cliForItg["ENDER"].ToString();

                        cEnd.Uf = cliForItg["UF"].ToString();
                        ValidadorDTO.ValidateWarningAll(cEnd);

                        c.Enderecos.Add(cEnd);
                        cliForSave.Add(c);
                        ValidadorDTO.ValidateWarningAll(c);
                        bool s = ctx.CliForDao.Save(c);
                        if(s) i++;
                    }
                    if (cliForSave.Count == i)
                    {
                        XMessageIts.Mensagem("Clientes importados com sucesso!");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return true;
        }
    }
}
