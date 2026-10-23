
public class Encapsulamento
{
    public static void MainEncapsulamento(string[] args)
    {
        /* Modificador de acesso */

        /*
         * O encapsulamento protege propriedades e comportamentos de serem alterados ou acessados fora da classe. Se eu tenho a classe conta
         * e a propriedade saldo privada, somente a classe conta pode acessar saldo. Ele cria dois métodos publicos que o saldo seja modificado de forma concisa,
         * como o deposito e saque que são realizados pelo títular. Se essa propriedade fosse públic, em alguma parte do código do saldo poderia ser modificado
         * de forma livre, sem o título, sem validações de saldo e criando inconsistência.
         *
         */

        // - public: As propriedades e comportamentos da classe que são publicas podem ser acessados fora da classe
        var conta1 = new Conta();
        conta1.Titular = "Ana Lima";

        /* - private: As propriedades e comportamentos privados de uma classe só podem ser acessados pela própria classe. 
         * Porém a propriedade pode ser visualizada e editada por métodos publicos dentro da classe */
        conta1.ConsultarSaldo();

        /*
         * protected: As propriedades e comportamentos protected de classe, só podems ser acessados pela própria classe ou
         * classes derivadas
         */
        //conta1.ChequeEspecial = true;

        var derivada = new Derivada();
        derivada.ConsultaChequeEspecial();

    }
}

public class Conta // classe base
{
    public string Titular { get; set; } = string.Empty;

    // Modificador de acesso private. Somente a própria classe pode acessar esse atributo
    private double Saldo { get; set; }

    protected bool ChequeEspecial { get; set; }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo: {Saldo}");
    }
}

public class Derivada : Conta
{
    public void ConsultaChequeEspecial()
    {
        Console.WriteLine($"Possui cheque especial: {ChequeEspecial}");
    }
}


