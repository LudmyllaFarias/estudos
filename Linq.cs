using System.Collections.Generic;

namespace OOP;

public class Despesa
{
    public string Descricao { get; set; }
    public double Valor { get; set; }
}

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public DateOnly DataDeValidade { get; set; }
}

public class Produto2
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string Categoria { get; set; }
}

public class Aluno
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
}
public class Pedidos
{
    public string Cliente { get; set; }
    public double Total { get; set; }
    public int Quantidade { get; set; }
}

public class Linq
{
    public static void MainLinq()
    {
        var despesas = new List<Despesa>
        {
            new() { Descricao = "Alimentação", Valor = 400.80 },
            new() { Descricao = "Água", Valor = 85.25 },
            new() { Descricao = "Luz", Valor = 258.45 },
            new() { Descricao = "Aluguel", Valor = 600.00 },
            new() { Descricao = "Internet", Valor = 99.99 },
            new() { Descricao = "Lazer", Valor = 157.45 }
        };

        /*
         * O where é utilizado quando precisamos filtrar os elementos de uma coleção
         * com base em uma ou mais condições
         */
        var pedidos = new List<Pedidos>
        {
            new() { Cliente = "Ana", Total = 400.80, Quantidade = 1 },
            new() { Cliente = "Maria", Total = 85.25, Quantidade = 1  },
            new() { Cliente = "José", Total = 258.45, Quantidade = 2  },
            new() { Cliente = "Cleide", Total = 600.00, Quantidade = 3  },
            new() { Cliente = "José", Total = 99.99, Quantidade = 2  },
            new() { Cliente = "Frederico", Total = 157.45 },
            new() { Cliente = "Lucas", Total = 548.45, Quantidade = 4 }
        };

        // O where utilizamos quando precisamos filtrar os elementos da coleção
        var clientesComMaiorPedido = pedidos.Where(x => x.Total > 300 && x.Quantidade == 1);
        foreach(var item in clientesComMaiorPedido)
        {
            Console.WriteLine($"{item.Cliente}");
        }

        /*
         * O select é usado para remodelar/mapear a listagem. Por exemplo: Se eu tiver uma lista de nomes com id
         * eu posso usar o select para listar somente o nome, pois o id é algo que o usuário final não precisa saber
         * além de ser uma forma de proteger os dados ou ataques.
         */

        // O select utilizamos quando queremos exibir apenas algumas propriedades
        var despesasMaiorQue300 = despesas.Select(p => p.Descricao).ToList();
        foreach (var item in despesasMaiorQue300)
        {
            // Console.WriteLine(item);
        }

        var produtos = new List<Produto>
        {
            new() { Nome = "Biscoito", Preco = 15.89, DataDeValidade  = new DateOnly(2026, 10, 7)},
            new() { Nome = "Iogurte", Preco = 20.45, DataDeValidade  = new DateOnly(2027, 04, 14)},
            new() { Nome = "Leite", Preco = 6.60, DataDeValidade  = new DateOnly(2026, 10, 1)},
            new() { Nome = "Feijão", Preco = 16.85, DataDeValidade  = new DateOnly(2029, 01, 3)},
            new() { Nome = "Arroz", Preco = 31.00, DataDeValidade  = new DateOnly(2028, 08, 23)},
            new() { Nome = "Café", Preco = 50.78, DataDeValidade  = new DateOnly(2028, 05, 9)},
        };

        var produtosValidos = produtos.Select(p => new
        {
            p.Nome,
            p.Preco,
            p.DataDeValidade
        }).Where(x => x.DataDeValidade > DateOnly.FromDateTime(DateTime.Now)).ToList();

        foreach (var item in produtosValidos)
        {
            // Console.WriteLine(item);
        }

        /*
         * firstOrDefault não lança exceção caso a coleção seja vazia. E a melhor opção caso o elemento ou comdição não existe ou não retorne nada. Já o first
         * é usado quando você tem certeza que o elemento existe.
         */
        var listaVazia = new List<Produto>();
        // O First resolve quando queremos retornar apenas o primeiro elemento ou o primeiro que satisfaz a condição
        var primeiroProdutoPrecoMaior50 = produtos.First(x => x.Preco > 50);
        var primeiroProdutoPrecoMaior100 = produtos.FirstOrDefault(x => x.Preco > 100);
        var firstOrDefaultVazio = listaVazia.FirstOrDefault();

        // Console.WriteLine($"Retorna o primeiro elemento da lista que o preço é maior que R$ 50 reais: {primeiroProdutoPrecoMaior50.Nome}");
        // Console.WriteLine($"Retorna o primeiro elemento da lista que o preço é maior que R$ 100 reais: {primeiroProdutoPrecoMaior100?.Nome}");
        // Console.WriteLine($"Retorna o primeiro elemento da lista vazia: {firstOrDefaultVazio}");

        /*
         * O single é usado quando você tem um único elemento ou uma condição que deve retornar um único elemento. 
         * Se a lista for vazia, ou possui mais de um elemento, ou condição retornar mais um elemento será lançado um exceção.
         * Pode ser usado quando você precisa verificar se o elemento é único na coleção. Já o SingleOrDefault lançará uma exceção apenas se
         * a lista possui mais elemento ou a condição retornar mais de um elemento.
         */

        var frutas = new List<string> { "Maça" };
        // Console.WriteLine($"Single: {frutas.Single()}");

        var nomes = new List<string> { "Ana", "José", "Bruno" };
        // Console.WriteLine($"Single com condição: {nomes.Single(x => x.StartsWith("B"))}");

        var notas = new List<double> { };
        // Console.WriteLine($"SingleOrDefault: {notas.SingleOrDefault()}");

        /*
         * Ao usar any com lambda e pelo menos um elemento satifazer a condição retornará true.
         * Se nenhum elemento satisfazer a condição retornará false. Ao usar any sem nenhum condição e houver algum elemento na lista,
         * o retorno será true.
         */

        var numeros = new List<int> { 1, 2, 3, 4, 5 };
        var numerosPares = new List<int> { };
        var numerosImpares = new List<int> { 1, 3, 5, 7 };

        // O any resolve quando precisamos saber se a coleção tem valor ou se pelo menos um elemento satisfaz a condição
        var numerosMaioresQue3 = numeros.Any(p => p > 3);
        // Console.WriteLine($"Números maiores que 3: {numerosMaioresQue3}");

        var numerosMaioresQue10 = numeros.Any(p => p > 10);
        // Console.WriteLine($"Números maiores que 10: {numerosMaioresQue10}");

        var existemElementos = numerosPares.Any();
        // Console.WriteLine($"Existe algum elemento: {existemElementos}");

        /*
         * Retorna verdadeiro se todos elementos satisfazerem a condição e retorna
         * falso para lista vazia
         */

        // O all utilizamos quando precisamos saber se todos elementos satisfazem ou não uma condição
        var todosSaoNumerosImpares = numerosImpares.All(x => x % 2 != 0);
        // Console.WriteLine($"Todos são números ímpares: {todosSaoNumerosImpares}");

        var listaNumerosParesVazia = numerosImpares.All(x => x % 2 == 0);
        // Console.WriteLine($"Lista vazia: {listaNumerosParesVazia}");

        /*
       * O orderBy vai ordenar a lista de forma crescente por padrão, sem a necessidade de condições. Para
       * ordernar de forma descrecente usamos
       */

        // O order by utilizamos quando precisamos ordernar a coleção
        var numerosDesodernados = new List<int> { 5, 4, 8, 1, 6 };
        var alunos = new List<Aluno>
        {
            new() { Nome = "Maria", Sobrenome = "Lima"},
            new() { Nome = "José", Sobrenome = "Gomes"},
            new() { Nome = "José", Sobrenome = "Alves"},
            new() { Nome = "Ana", Sobrenome = "Dutra"},
            new() { Nome = "Julia", Sobrenome = "Peres"},
            new() { Nome = "João", Sobrenome = "Batista"},
            new() { Nome = "Mariana", Sobrenome = "Santos"},
            new() { Nome = "Maria", Sobrenome = "Clara"},
        };

        var ordenaLista = numerosDesodernados.OrderBy(x => x);
        foreach(var item in ordenaLista)
        {
            // Console.WriteLine($"Lista ordenada: {item}");
        }

        var ordenaNomes = alunos.OrderBy(x => x.Nome).ThenBy(i => i.Sobrenome);
        foreach (var item in ordenaNomes)
        {
            // Console.WriteLine($"Lista de alunos: {item.Nome} {item.Sobrenome}");
        }

        var ordenaListaDescrecente = numerosDesodernados.OrderByDescending(x => x);
        foreach (var item in ordenaListaDescrecente)
        {
            // Console.WriteLine($"Lista ordenada descrecente: {item}");
        }

        /*
        * O group by serve para agrupar os elementos de uma lista.
        */

        var produtos2 = new List<Produto2>
        {
            new() { Nome = "Caixa de som", Preco = 352.45, Categoria = "Eletrônicos"},
            new() { Nome = "Mouse Gamer", Preco = 125.00,  Categoria = "Informática"},
            new() { Nome = "Liquidificador", Preco = 256.23,  Categoria = "Eletrodomésticos"},
            new() { Nome = "Fone de ouvido", Preco = 69.99,  Categoria = "Eletrônicos"},
            new() { Nome = "Teclado", Preco = 56.00,  Categoria = "Informática"},
            new() { Nome = "Forno", Preco = 452.00,  Categoria = "Eletrodomésticos"},
        };

        // O group by utilizamos quando precisamos agrupar a coleção por alguma propriedade
        var listaAgrupada = produtos2
            .GroupBy(p => new { p.Categoria }) // Agrupa os produtos por categoria
            .Select(g => new { AgrupamentoProdutos = g.Key, MediaDoPreco = g.Average(i => i.Preco) }); // objeto anônimo para cada grupo contendo as propriedades do produto agrupado

        foreach (var item in listaAgrupada)
        {
            // Console.WriteLine($"{item}");
        }

        /*
        * ToList é usando quando queremos transformar uma sequência em uma list. O inteiros é uma IEnumerable que
        * não permite modificações. Se precisamos adicionar ou remover algum elementro, precisamos transformar essa 
        * sequência em um list
        */

        // Usamos o tolist quando precisamos utilizar os métodos para modificar a coleção
        var inteiros = new[] { 1, 5, 4, 6 };
        var inteirosMaiorQue2 = inteiros.Where(x => x > 2);
        // inteirosMaiorQue2.Add(8);

        var inteirosList = inteiros.Where(x => x > 2).ToList();
        inteirosList.Add(10);

        foreach (var item in inteirosMaiorQue2)
        {
            // Console.WriteLine($"{item}");
        }
    }
}
