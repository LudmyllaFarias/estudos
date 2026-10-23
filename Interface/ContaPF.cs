namespace OOP.Interface;

public class ContaPF: IConta
{
    private double Saldo { get; set; }
    double IConta.Saldo { get => Saldo; set => Saldo = value; }
    private double Tax { get; set; } = 0.10;
    double IConta.Tax { get => Tax; set => Tax = value; }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo RS: {Saldo}");
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
           Saldo += valor;
        }
    }

    public void Sacar(double valor)
    {
        if (Saldo > valor)
        {
            var valorComDesconto = valor + (Tax * 100);
            Saldo -= valorComDesconto;
        }
    }
}
