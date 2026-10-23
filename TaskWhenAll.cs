namespace OOP;

public class TaskWhenAll
{
    public class Farinha { }
    public class Ovos { }
    public class Azeite { }


    public async static Task MainTaskWhenAll()
    {
        // Task.WhenAll - Cria uma tarefa que será concluída quando todas tarefas fornecidas estivem concluídas
        var taskWhenAll = new TaskWhenAll();
        await taskWhenAll.ExemploFazerPao();
    }

    public async Task ExemploFazerPao()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Esperando a entrega do pedido de farinha.");
        var pedidoFarinha = PedidoDeFarinha();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Esperando a entrega do pedido de ovos.");
        var pedidoOvos = PedidoDeOvos();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Esperando a entrega do pedido de azeite.");
        var pedidoAzeite = PedidoDeAzeite();

        await Task.WhenAll(pedidoFarinha, pedidoOvos, pedidoAzeite);

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Pedido de farinha = {pedidoFarinha.Result}");
        Console.WriteLine($"Pedido de ovos = {pedidoOvos.Result}");
        Console.WriteLine($"Pedido de azeite = {pedidoAzeite.Result}");

        FazerPao(pedidoFarinha.Result, pedidoOvos.Result, pedidoAzeite.Result);
    }

    public async Task<Farinha> PedidoDeFarinha()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Envia pedido de farinha.");
        await Task.Delay(2000);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("A entrega de farinha chegou.");
        return new Farinha();
    }

    public async Task<Ovos> PedidoDeOvos()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Envia pedido de ovos.");
        await Task.Delay(2000);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("A entrega de ovos chegou.");
        return new Ovos();
    }

    public async Task<Azeite> PedidoDeAzeite()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Envia pedido de azeite.");
        await Task.Delay(2000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("A entrega de azeite chegou.");
        return new Azeite();
    }

    public void FazerPao(Farinha farinha, Ovos ovos, Azeite azeite)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Preparando pão.");
        Thread.Sleep(3500);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Pão pronto.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
