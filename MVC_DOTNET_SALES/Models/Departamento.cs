using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DOTNET_SALES.Models
{
    public class Departamento
    {
        public int id { get; set; }
        public string nome { get; set; }

        // Associação do departamento com o vendedor, seguindo o diagrama do pdf disponivel do curso.
        public ICollection<Seller> Vendedores { get; set; } = new List<Seller>();

        public Departamento() { }

        public Departamento(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public void AddVendedor(Seller vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {
            // Aplicando a soma para cada vendedor da lista da classe Seller, chamando o método TotalVendas da Classe "Seller" e fazendo uma soma do resultado para 
            // todos os vendedores do departamento
            return Vendedores.Sum(vendedor => vendedor.TotalVendas(inicio, final));
        }
    }
}
