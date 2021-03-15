using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_DOTNET_SALES.Services;

namespace MVC_DOTNET_SALES.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly SellerService _sellerservice;

        // Injeção de depêndencia
        public VendedoresController(SellerService sellerservice)
        {
            _sellerservice = sellerservice;
        }

        public IActionResult Index()
        {
            // Retornando uma lista de sellerservice. 
            var list = _sellerservice.FindAll();
            return View(list);
        }
    }
}
