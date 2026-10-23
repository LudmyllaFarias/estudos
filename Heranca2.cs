public class Heranca2
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public DateOnly DataDeNascimento { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

    }

    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; } = string.Empty;
    }

    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; } = string.Empty;
    }

    public static void MainHeranca2(string[] args)
    {
        /*
         * A herança é utlizada quando temos duplicidades de propriedades e comportamentos. Se tivermos a classe pessoa fisica e juridica,
         * as duas precisam de nome, sobrenome, data de nascimento, e-mail, telefone. E com herança ao invéz de criar as duas classes com essas propriedades
         * duplicadas podemos usar a herança para resolver.
         */
        var pf = new PessoaFisica();
        pf.Nome = "Ana Lima";
        pf.Cpf = "69854723645";

        var pj = new PessoaJuridica();
        pj.Nome = "Maria Martins";
        pj.Cnpj = "36745852000125";

        var casa1 = new Casa();
        casa1.NumeroQuartos = 3;
        casa1.Consultar();
    }
}

public class Imovel // classe base
{
    public string Tipo { get; set; } = string.Empty;
    public double Preco { get; set; }

    // se a propriedade é privada ela só pode ser acessada na própria classe
    private bool Vendido { get; set; }
    public string NumeroCrea { get; set; } = string.Empty;

    public void ComprarCasa()
    {
        Vendido = true;
    }

    public void Consultar()
    {
        Console.WriteLine($"Tipo: {Tipo}, Preco R$: {Preco}, Vendido: {Vendido}, Crea: {NumeroCrea}");
    }
}

public class Casa : Imovel // classe derivada
{
    public int NumeroQuartos { get; set; }

    public Casa()
    {
        Tipo = "Casa";
        Preco = 250000.00;
        NumeroCrea = "SP4587";
        // Vendido = true; A classe derivada não consegue acessar esse atributo da classe base porque ele é privado.
    }

}