namespace OOP.Exercicio;

public class Pedido
{
    public string Cliente { get; set; }
    public double Total { get; set; }

}

public class Exercicio01
{
    public static void MainExercicio01()
    {
        var pedidos = new List<Pedido>
        {
            new() { Cliente = "Maria Lima", Total = 800.78 },
            new()  { Cliente = "Carol Martins", Total = 600.45 },
            new()  { Cliente = "José Souza", Total = 125.40 },
            new()  { Cliente = "Maria Lima", Total = 854.00 },
            new()  { Cliente = "José Souza", Total = 752.40 },
            new()  { Cliente = "Frederico Rocha", Total = 14.52 },
            new()  { Cliente = "Mário Pereira", Total = 964.44 },
            new()  { Cliente = "João Gomes", Total = 45.26 },
            new()  { Cliente = "Frederico Rocha", Total = 90.30 },
            new()  { Cliente = "Ana Alves", Total = 145.00 },
            new()  { Cliente = "João Gomes", Total = 89.45 },

        };
        // Encontre todos os pedidos acima de R$500
        var lista = pedidos.FindAll(p => p.Total >= 500);

        Console.WriteLine("Pedidos acima de 500\n");
        foreach (var item in lista)
        {
            // Console.WriteLine($"Cliente: {item.Cliente}, Total R$: {item.Total}");
        }

        var dicionarioGrupo = new Dictionary<string, double>();
        foreach (var item in lista)
        {
            if (!dicionarioGrupo.ContainsKey(item.Cliente))
            {
                dicionarioGrupo.Add(item.Cliente, item.Total);
            }
            else
            {
                dicionarioGrupo[item.Cliente] += item.Total;
            }
        }

        foreach(var dic in dicionarioGrupo)
        {
            Console.WriteLine($"Cliente: {dic.Key}, Total: {dic.Value} ");
        }

        var maiorValor = 0.0;
        var nomeCliente = string.Empty;
        foreach (var dic in dicionarioGrupo)
        {
            Console.WriteLine("dic.Value " + dic.Value);
            if (dic.Value > maiorValor)
            {
                maiorValor = dic.Value;
                nomeCliente = dic.Key;
            }
        }
        Console.WriteLine("Cliente que mais comprou: " + nomeCliente);
    }
}
