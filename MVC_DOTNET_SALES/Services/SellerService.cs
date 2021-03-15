using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_DOTNET_SALES.Data;
using MVC_DOTNET_SALES.Models;

namespace MVC_DOTNET_SALES.Services
{
    public class SellerService
    {
        private readonly MVC_DOTNET_SALESContext _context;

        public SellerService(MVC_DOTNET_SALESContext context)
        {
            _context = context;
        }

        public List<Seller> BuscarTodosVendedores()
        {
            // retornando do banco de dados para a tela, todos os vendedores
            return _context.Vendedor.ToList();
        }

        // Notas: a classe MVC_DOTNET_SALESContext herda de Dbset, que por sua vez, tem o método "Add()"
        public void Inserir(Seller vend)
        {
            // Adicionando novos vendedores no banco de dados
            _context.Add(vend);
            _context.SaveChanges();
        }


    }
}
