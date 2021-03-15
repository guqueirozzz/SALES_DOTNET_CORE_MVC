using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_DOTNET_SALES.Models;
using MVC_DOTNET_SALES.Models.Enums;

namespace MVC_DOTNET_SALES.Data
{
    public class SeedingService
    {
        // Classe que popula as tabelas do MySQL
        private MVC_DOTNET_SALESContext _context;

        public SeedingService(MVC_DOTNET_SALESContext context)
        {
            _context = context;
        }

        public void Alimentar()
        {
            // Testando para ver se tem alguma coisa na base de dados
            if (//_context.Departamento.Any() || 
                _context.Vendedor.Any() ||
                _context.ControleVendas.Any())
            {
                return; // O banco de Dados ja foi populado
            }

            Departamento d1 = new Departamento(4, "Computadores");
            Departamento d2 = new Departamento(5, "Eletrônicos");
            Departamento d3 = new Departamento(6, "Moda");
            // outro moodo
            Departamento d4 = new Departamento { id = 7, nome = "Livros" };

            Seller s1 = new Seller(1, "Alessandro Araujo", "alearaujo@hotmail.com", 1000.00, new DateTime(1998, 4, 21), d1);
            Seller s2 = new Seller(2, "Julio Araujo", "juliolaurindo@hotmail.com", 1000.00, new DateTime(1999, 5, 17), d1);
            Seller s3 = new Seller(3, "Janaina Ribeiro", "janlindona@hotmail.com", 1000.00, new DateTime(1998, 7, 19), d2);
            Seller s4 = new Seller(4, "Maria Ribeiro", "marimarilinda@hotmail.com", 1000.00, new DateTime(1976, 10, 13), d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 03, 15), 1100.00, SaleStatus.Faturado, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 03, 14), 1100.00, SaleStatus.Faturado, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 03, 13), 15000.00, SaleStatus.Faturado, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 03, 12), 1900.00, SaleStatus.Faturado, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 03, 11), 5000.00, SaleStatus.Faturado, s4);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 03, 10), 71000.00, SaleStatus.Faturado, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 02, 15), 7000.00, SaleStatus.Faturado, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 01, 15), 81000.00, SaleStatus.Faturado, s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 01, 15), 8000.00, SaleStatus.Faturado, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 01, 15), 112.00, SaleStatus.Faturado, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 01, 15), 14300.00, SaleStatus.Faturado, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 01, 15), 12900.00, SaleStatus.Faturado, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 02, 15), 11900.00, SaleStatus.Faturado, s4);

            // Permite adicionar varios objetos de uma só vez
            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(s1, s2, s3, s4);
            _context.ControleVendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13);


            // Salva e confirma as alterações na base de dados
            _context.SaveChanges();

        }

    }
}
