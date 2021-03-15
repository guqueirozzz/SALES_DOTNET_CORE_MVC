using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_DOTNET_SALES.Services;
using MVC_DOTNET_SALES.Models;

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
            var list = _sellerservice.BuscarTodosVendedores();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        // O nome desse método tem que bater com o <form asp-action="Cadastrar"> do arquivo Views -> Vendedores -> Create.cshtml
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(Seller vend)
        {
            _sellerservice.Inserir(vend);
            //return RedirectToAction("Index");
            // ou 4
             return RedirectToAction(nameof(Index));
        }
    }
}
