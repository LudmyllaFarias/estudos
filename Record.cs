using System.Collections.Generic;

namespace OOP;

// Definir o tipo cliente como record significa que quero tratar os objetos desse tipo como valor de dados imutável
// Ao definir um tipo como record o compilador sintetiza vários outros métodos para mim
public record Cliente
{
    public string Nome { get; init; }
    public string Sobrenome { get; init; }
    public string Email { get; init; }

    public Cliente()
    {

    }

    public Cliente(string nome, string sobrenome, string email)
    {
        Nome = nome; 
        Sobrenome = sobrenome; 
        Email = email;
    }

    public void Desconstrutor(out string nome, out string sobrenome, out string email)
    {
        nome = Nome;
        sobrenome = Sobrenome;
        email = Email;
    }
}

public class Record
{
    public static void MainRecord()
    {


        var cliente = new Cliente
        {
            Nome = "Maria",
            Sobrenome = "Lima",
            Email = "maria@gmail.com"
        };

        // Ele não deixa alterar o valor da propriedade após a instância do objeto e definição do valor
        // cliente.Nome = "Mariana";

        // Para alterar, eu preciso criar um novo objeto
        var novoCliente = new Cliente
        {
            Nome = "Mariana",
            Sobrenome = cliente.Sobrenome,
            Email = cliente.Email   
        };

        // Realizando cópias com with
        var cliente2 = new Cliente
        {
            Nome = "Maria",
            Sobrenome = "Lima",
            Email = "maria@gmail.com"
        };

        // O with permite criar novo objeto com mais eficiência
        var novoCliente2 = cliente2 with { Email = "maria@yahoo.com" };
        Console.WriteLine(novoCliente2.Nome);

        var outroCliente = novoCliente2 with { Email = "maria@gmail.com" };

        Console.WriteLine(cliente == outroCliente);

        // Construtor
        var cli = new Cliente("José", "Morais", "jose@gmail.com");

        // Desconstrução
        // var (nome, sobrenome, email) = cli;

        /*
         * O record pode ser comparado a um dto também, se eu tenho a classe id, nome e email eu posso criar um dto com nome e email e ele pode ser um record.
         * Mas o principal é: 
         * 
         */

        var cli1 = new Cliente("José", "Morais", "jose@gmail.com");
        var cli2 = new Cliente("José", "Morais", "jose@gmail.com");

        if (cli1 == cli2) // Seria false se fossse uma classe, por mais que as informações são iguais a referência do objeto é diferente. Agora o record compara os valores
        {

        }

    }
}
