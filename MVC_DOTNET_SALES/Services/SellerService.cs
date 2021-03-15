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

        public List<Seller> FindAll()
        {
            // retornando do banco de dados, todos os vendedores
            return _context.Vendedor.ToList();
        }
    }
}
