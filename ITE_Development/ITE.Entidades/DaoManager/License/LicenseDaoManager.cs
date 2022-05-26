﻿using ITE.Entidades.POCO.Base;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.DaoManager.License
{
    public class LicenseDaoManager
    {
        public bool SaveOrUpdateLicense(ItsLicense license)
        {
            var ctx = new BalcaoContext();

            var licenseBd = ctx.LicenseDao.Find(license.IdLicense);

            //se nao for nulo, achou a licenca.. segue 
            if (license != null && license.IdLicense > 0)
            {
                licenseBd.Update(license);
                return ctx.LicenseDao.Update(licenseBd);
            }
            //senao cria..
            else
            {
                return ctx.LicenseDao.Save(license);
            }
        }
        public ItsLicense GetValidLicense()
        {
            try
            {
                var ctx = new BalcaoContext();

                //busca licencas ativas e com datafim nula, se nao encontrou nenhuma dispara advertencia.
                var licActive = ctx.LicenseDao.Where(
                    l => l.LicenseStatus
                    || l.LicenseDataUnSerialized.DataFimLic == null).First();

                //se encontrou alguma...
                if (licActive != null)
                {
                    //verifica a validade, se invalida lanca advertencia e retorna null 
                    if (licActive.LicenseDataUnSerialized.DataInicioLic.Date <= DateTime.Now.Date
                    && licActive.LicenseDataUnSerialized.DataFimLic.Date <= DateTime.Now.Date)
                    {
                        XMessageIts.Advertencia("A licença para " + licActive.CustomerName
                            + " expirou em " + licActive.LicenseDataUnSerialized.DataFimLic.Date + ". Por favor entre em contato com a IT Solution.");
                        return null;
                    }

                    //senao retorna a licenca como valida...
                    return licActive;
                }

                return null;
            }
            catch (Exception)
            {
                XMessageIts.Advertencia("Não foi encontrada uma licença válida no seu banco de dados, " +
                        "por favor entre em contato com a IT Solution");
                return null;
            }

        }
    }
}