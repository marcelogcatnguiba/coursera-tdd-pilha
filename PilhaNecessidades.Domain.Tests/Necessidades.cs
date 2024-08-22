using PilhaNecessidades.Domain.Entities;

namespace PilhaNecessidades.Domain.Tests
{
    public class Necessidades
    {
        [Fact]
        public void Test1()
        {
            List<Pedido> pedidos = new()
            {
                new Pedido("001", new Produto("tecido"), 200),
                new Pedido("001", new Produto("fio"), 300),
                new Pedido("001", new Produto("urdume"), 400)
            };

            var listaNecessidades = Gerar.Necessidades(pedidos);

            Assert.Equal(3, listaNecessidades.Count);
        }
    }
}