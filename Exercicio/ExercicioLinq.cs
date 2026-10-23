
namespace OOP.Exercicio;

public class Produto
{
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
}
public class ExercicioLinq
{
    public static void MainExercicioLinq()
    {
        var numeros = new List<int> { 5, 12, 8, 20, 3, 15, 10, 7, 25, 2 };

        var produtos = new List<Produto>
        {
            new() { Nome = "Caixa de som", Preco = 352.45, Categoria = "Eletrônicos", Estoque = 8},
            new() { Nome = "Mouse Gamer", Preco = 125.00,  Categoria = "Informática", Estoque = 10},
            new() { Nome = "Liquidificador", Preco = 256.23,  Categoria = "Eletrodomésticos", Estoque = 0},
            new() { Nome = "Fone de ouvido", Preco = 69.99,  Categoria = "Eletrônicos", Estoque = 6},
            new() { Nome = "Teclado", Preco = 56.00,  Categoria = "Informática", Estoque = 20},
            new() { Nome = "Forno", Preco = 452.00,  Categoria = "Eletrodomésticos", Estoque = 0},
        };

        var apenasNumerosMaioresQue10 = produtos.Where(x => x.Estoque > 10);
        foreach (var item in apenasNumerosMaioresQue10)
        {
            // Console.WriteLine(item.Nome);
        }

        var dobroDeCadaNumero = numeros.Select(x => x * 2);
        foreach (var item in dobroDeCadaNumero)
        {
             // Console.WriteLine(item);
        }

        var numeroDoMenorParaOMarior = numeros.OrderBy(x => x);
        foreach (var item in numeroDoMenorParaOMarior)
        {
            // Console.WriteLine(item);
        }

        var encontrandoElemento = produtos.Single(x => x.Nome.Equals("Teclado"));
        // Console.WriteLine(encontrandoElemento.Nome);

        var produtosComPrecoMenorQue200 = produtos.Where(x => x.Preco < 200).OrderBy(i => i.Preco);
        foreach (var item in produtosComPrecoMenorQue200)
        {
           // Console.WriteLine($"{item.Nome} - {item.Preco}");
        }

        var produtosComEstoqueMaior100 = produtos.Where(x => x.Estoque > 0 && x.Preco > 100);
        foreach (var item in produtosComEstoqueMaior100)
        {
            // Console.WriteLine($"Nome: {item.Nome} - Preço: {item.Preco} - Estoque: {item.Estoque}");
        }

        var nomesProdutos = produtos.Select(x => x.Nome).ToList();
        foreach (var item in nomesProdutos)
        {
            Console.WriteLine($"{item}");
        }
    }
}
