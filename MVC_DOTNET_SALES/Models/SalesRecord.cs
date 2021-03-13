using MVC_DOTNET_SALES.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DOTNET_SALES.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public SaleStatus Status { get; set; }

        // Associação do controle de vendas com o vendedor
        public Seller Vendedor{ get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime data, double valor, SaleStatus status, Seller vendedor ) 
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
