using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilhaNecessidades.Domain.Entities
{
    public class Pedido
    {
        public string Codigo { get; set; } = "";
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public Pedido(string codigo, Produto produto, int quantidade)
        {
            Codigo = codigo;
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}