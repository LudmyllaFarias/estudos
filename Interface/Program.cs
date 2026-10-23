namespace OOP.Interface;

public class Program
{
    public static void MainProgram()
    {
        // Mesmo método porém com implementações diferentes

        var contaPF = new ContaPF();
        contaPF.Depositar(115);
        contaPF.ConsultarSaldo();
        contaPF.Sacar(100);
        contaPF.ConsultarSaldo();

        var contaPJ = new ContaPJ();
        contaPJ.Depositar(200);
        contaPJ.ConsultarSaldo();
        contaPJ.Sacar(150);
        contaPJ.ConsultarSaldo();

    }
}
