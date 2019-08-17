using ITE.Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Teste.EagerLoading
{
    class Eager
    {
        //necessario using System.Data.Entity;
        async void teste()
        {
            var context = new BalcaoContext();
            var clientes = await Task.Run(() => context.CliFors.Include("Enderecos").ToList());


            // Load all blogs and related posts 
            var blogs1 = context.CliFors
                                  .Include(b => b.Enderecos)
                                  .ToList();

            // Load one blogs and its related posts 
            var blog1 = context.CliFors
                                .Where(b => b.RazaoSocial.Contains("Mineracao"))
                                .Include(b => b.NotasFiscaisCapa)
                                .FirstOrDefault();

            // Load all blogs and related posts  
            // using a string to specify the relationship 
            var blogs2 = context.CliFors
                                  .Include("Enderecos")
                                  .ToList();

            // Load one blog and its related posts  
            // using a string to specify the relationship 
            var blog2 = context.CliFors
                                .Where(b => b.CpfCnpj == "000.000")
                                .Include("NotasFiscaisCapa")
                                .FirstOrDefault();
        }
    }
}
