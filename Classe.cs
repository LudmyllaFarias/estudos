/*
 * A classe representa algo no mundo real que 
 * possui atributos e comportamentos.
 * Por exemplo: Um carro, ele possui cor, marca, ano e também possui
 * comportamentos como: ligar, acelerar, desligar.
 *
 */

class Classe
{
    public static void MainClasse()
    {
        // Aqui estou criando um objeto(new Carro()), ou seja o objeto é a instância da classe
        var carro1 = new Carro();

        // A variável carro1 não é um objeto e sim uma referência ao objeto
        carro1.Marca = "Ford";
        Console.WriteLine($"Carro1: {carro1.Marca}");

        // Com a instância da classe eu posso usar os comportamentos da classe que eu criei
        // entre outros comportamentos do objeto são definidos por padrão.
        carro1.Ligar();

        // Um exemplo de comportamentos que podemos usar ao instânciar a classe é sabe o tipo dessa classe, que nesse caso é Carro
        Console.WriteLine(carro1.GetType());


        // Uma classe é como se fosse um molde. Eu posso fazer vários com informações diferentes
        var carro2 = new Carro();

        // Nesse caso eu apenas estou copiando o valor da marca do carro um, mas ele referenciam objetos diferentes
        // Se eu mudar a marca do carro1 não vai refletir no carro dois
        carro2.Marca = carro1.Marca;
        carro2.Ano = 1998;
        Console.WriteLine($"Carro2: {carro2.Marca}");
        Console.WriteLine($"Carro2: {carro2.Ano}");

        // Referência compartilhada
        // Carro3 e carro4 referenciam o mesmo objeto
        var carro3 = new Carro();
        carro3.Marca = "Fiat";

        var carro4 = new Carro();
        carro4 = carro3;

        Console.WriteLine($"Carro3: {carro3.Marca}");
        Console.WriteLine($"Carro4: {carro4.Marca}");

        // Então se eu altero a marca do carro4, isso reflete no carro3
        carro4.Marca = "Siena";
        Console.WriteLine($"Carro3: {carro3.Marca}");
        Console.WriteLine($"Carro4: {carro4.Marca}");

        // PESSOA

        // instânciar a classe
        var pessoa1 = new Pessoa{ Idade = 8 };
        pessoa1.Idade = 8;
        Console.WriteLine(pessoa1.Idade);

        // Quando a classe possui um construtor com algum campo, é obrigatório fornecer
        // uma valor para esse campo ao instânciar a classe
        var pessoa2 = new Pessoa2("Ana");
        Console.WriteLine(pessoa2.Nome);

        // Quando uma comportamento/método é estático, eu não preciso instânciar a classe para usar
        // É bastante usado em método/classes utilitárias.
        Util.Saudacao("Ana");

        // Se alterar uma classe para estática ela não pode ser instânciada
       // var util = new Util();


    }
}

public class Carro
{
    // Quais são os atributos do carro
    public string Marca { get; set; } = string.Empty;
    public int Ano { get; set; }
    public string Cor { get; set; } = string.Empty;

    // Quais são os comportamentos desse carro
    public void Ligar()
    {
        Console.WriteLine("Carro ligado!");
    }

    public void Desligar()
    {
        Console.WriteLine("Carro desligado!");
    }
}

public class Pessoa
{
    // Inicializadores de campo, definem um valor padrão na declaração do campo
    // se deseja que os campos sejam inicializados essa é uma forma
    private bool Ativo = true;
    public string Nome { get; set; }

    // Uma forma de obrigar a preencher o campo é usar a palavra required na declaração do atributio
    public required int Idade { get; set; }
}

public class Pessoa2
{
    public string Nome { get; set; }

    //Outra forma é utilizando construtor, que obriga a informar os campos do construtor ao instânciar a classe
    public Pessoa2(string nome)
    {
        Nome = nome;
    }
}

public class Pessoa3(int idade)
{
    // Outra forma é utilizar parâmentros na declaração da classe
    private int Idade = idade;

}

public static class Util
{
    public static void Saudacao(string nome)
    {
        Console.WriteLine($"Olá, {nome}! Bem vindo");
    }
}