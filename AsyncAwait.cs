using System.Threading.Tasks;

namespace OOP;

public class AsyncAwait
{
    /*
     * O Task, async e await são usados quando queremos executar métodos/tarefas ao mesmo tempo, sem a necessidade
     * de esperar uma tarefa/método terminar para então executar o próximo método.
     * Task representa uma operação que está acontecendo ou vai terminar no futuro.
     * async diz que o método pode usar await e await diz espere essa operação terminar sem bloquear a thread
     */
    public async static Task MainAsyncAwait()
    {
        var asyncAwait = new AsyncAwait();

        // SEM USAR TASK, ASYNC E AWAIT
        // task.ExemploFazerPao();

        // USANDO TASK, ASYNC E AWAIT
        await asyncAwait.ExemploFazerPaoAsync();
    }

    public void ExemploFazerPao()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Mãe vai mandar a Maria coletar ovos.");
        var ovos = MandarAMariaColetarOvos();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Mãe vai mandar o João comprar farinha.");
        var farinha = MandarOJoaoComprarFarinha();

        FazerPao(ovos, farinha);
    }

    public async Task ExemploFazerPaoAsync()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Mãe vai mandar a Maria coletar ovos.");
        var tarefaMaria = MandarAMariaColetarOvosAsync();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Mãe vai mandar o João comprar farinha.");
        var tarefaJoao = MandarOJoaoComprarFarinhaAsync();

        await Task.Delay(9000);
        var primeira = await Task.WhenAny(tarefaMaria, tarefaJoao);
        if (primeira == tarefaMaria)
        {
            var ovos = await tarefaMaria;
            FazerOmelete(ovos);
        }
        else if (primeira == tarefaJoao)
        {
            var farinha = await tarefaJoao;
            var ovos = await tarefaMaria;
            FazerPao(ovos, farinha);
        }
      
    }

    public Farinha MandarOJoaoComprarFarinha()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("João sai de casa.");
        Thread.Sleep(3000);
        Console.WriteLine("João chega no mercado.");
        Thread.Sleep(4000);
        Console.WriteLine("João faz a compra.");
        Thread.Sleep(3000);
        Console.WriteLine("João chega em casa.");
        return new Farinha();
    }

    public Ovos MandarAMariaColetarOvos()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Maria vai ao galinheiro.");
        Thread.Sleep(1000);
        Console.WriteLine("Maria coleta ovos.");
        Thread.Sleep(3500);
        Console.WriteLine("Maria retorna à casa.");
        return new Ovos();
    }

    public void FazerPao(Ovos ovos, Farinha farinha)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Preparando pão.");
        Thread.Sleep(3500);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Pão pronto.");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void FazerOmelete(Ovos ovos)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Preparando omelete.");
        Thread.Sleep(3500);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Omelete pronto.");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static async Task<Ovos> MandarAMariaColetarOvosAsync()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Maria vai ao galinheiro.");
        await Task.Delay(1000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Maria coleta ovos.");
        await Task.Delay(3500);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Maria retorna à casa.");
        return new Ovos();
    }

    public static async Task<Farinha> MandarOJoaoComprarFarinhaAsync()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("João sai de casa.");
        await Task.Delay(3000);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("João chega no mercado.");
        await Task.Delay(4000);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("João faz a compra.");
        await Task.Delay(3000);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("João chega em casa.");
        return new Farinha();
    }

}

public class Farinha { }
public class Ovos { }
