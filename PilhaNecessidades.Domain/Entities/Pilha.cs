using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilhaNecessidades.Domain.Entities
{
    public class Pilha
    {
        public ICollection<string> Necessidades { get; set; } = new List<string>();

        public bool AddElemento(string elemento)
        {
            Necessidades.Add(elemento);
            if (Necessidades.Contains(elemento))
                return true;
            else
                return false;
        }

        public bool AddRangeElementos(List<string> elementos)
        {
            foreach (var e in elementos)
                Necessidades.Add(e);

            var result = true;
            foreach (var e in elementos)
                result = Necessidades.Contains(e);

            return result;
        }

        public bool EstaVazia()
        {
            if (Necessidades.Any() is false)
                return true;
            else
                return false;
        }

        public string PrimeiroElemento()
        {
            return Necessidades.ElementAt(0);
        }

        public bool RemoveElemento(string v)
        {
            return Necessidades.Remove(v);
        }

        public string UltimoElemento()
        {
            return Necessidades.ElementAt(Necessidades.Count - 1);
        }
    }
}