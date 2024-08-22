using PilhaNecessidades.Domain.Entities;

namespace PilhaNecessidades.Domain.Tests;

public class UnitTest1
{
    [Fact]
    public void DeveRetornarPilhaVazia()
    {
        Pilha pilha = new Pilha();

        Assert.True(pilha.EstaVazia());
    }

    [Fact]
    public void DeveAdicionarElementoAPilha()
    {
        Pilha pilha = new Pilha();

        string elemento = "teste";
        var result = pilha.AddElemento(elemento);

        Assert.True(result);
    }

    [Fact]
    public void DeveAdicionarVariosElementos()
    {
        Pilha pilha = new Pilha();

        List<string> elementos = new List<string>(){
            "a",
            "b",
            "c"
        };

        var result = pilha.AddRangeElementos(elementos);

        Assert.True(result);
    }

    [Fact]
    public void DeveRetornarPrimeiroElemento()
    {
        Pilha pilha = new Pilha();

        List<string> elementos = new List<string>(){
            "a",
            "b",
            "c"
        };

        pilha.AddRangeElementos(elementos);
        var result = pilha.PrimeiroElemento();

        Assert.Equal("a", result);
    }

    [Fact]
    public void DeveRetornarUltimoElemento()
    {
        Pilha pilha = new Pilha();

        List<string> elementos = new List<string>(){
            "a",
            "b",
            "c"
        };

        pilha.AddRangeElementos(elementos);
        var result = pilha.UltimoElemento();

        Assert.Equal("c", result);
    }

    [Fact]
    public void DeveRemoverElemento()
    {
        Pilha pilha = new Pilha();
        List<string> elementos = new List<string>() { "a", "b", "c" };
        pilha.AddRangeElementos(elementos);

        var result = pilha.RemoveElemento("a");

        Assert.True(result);
    }
}