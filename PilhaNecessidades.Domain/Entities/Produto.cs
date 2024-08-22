using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilhaNecessidades.Domain.Entities
{
    public class Produto
    {
        public string Nome { get; set; } = "";
        public Produto(string nome)
        {
            Nome = nome;
        }
    }
}