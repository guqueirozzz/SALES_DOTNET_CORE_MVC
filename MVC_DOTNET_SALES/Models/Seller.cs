using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DOTNET_SALES.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double SalarioBase { get; set; }
        public DateTime Dt_aniversario { get; set; }

        // Associação de associação dos vendedores com o departamento
        public Departamento Departamento{ get; set; }

        // Associação dos vendedores com o controle de vendas
        public ICollection<SalesRecord> Vendas { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string nome, string email, double salario_base, DateTime dt_aniversario, Departamento departamento )
        {
            Id = id;
            Nome = nome;
            Email = email;
            SalarioBase = salario_base;
            Dt_aniversario = dt_aniversario;
            Departamento = departamento;

        }

        public void AddVendas(SalesRecord sr)
        {
            Vendas.Add(sr);
        }

        public void RemoveVendas(SalesRecord sr)
        {
            Vendas.Remove(sr);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {                                                           // a soma vai ser baseada no atributo "Valor" da Classe SalesRecord
            return Vendas.Where(sr => sr.Data >= inicio && sr.Data <= final).Sum(sr => sr.Valor);
        }

    }
}
