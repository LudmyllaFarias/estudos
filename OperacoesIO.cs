using System.Text;

namespace OOP;
public class OperacoesIO
{
    // Revisar
    public async static Task MainOperacoesIO()
    {
        /*
         * Tanto o ReadAllLines e ReadAllText carregam todo arquivo em memória e isso é um problema quando o
         * arquivo é muito grande
         */

        var file = File.ReadAllLines("C:\\arquivo\\nomes.txt", Encoding.UTF8);
        
        foreach(var f in file)
        {
            // Console.WriteLine(f);
        }

        var data = File.ReadAllText("C:\\arquivo\\nomes.txt", Encoding.UTF8);
        // Console.WriteLine(data);

        // Leitura sob demanda sem carregar o arquivo inteiro
        foreach(var leituraSobDemanda in File.ReadLines("C:\\arquivo\\nomes.txt", Encoding.UTF8)) {
            // Console.WriteLine(leituraSobDemanda);
        }

        // O streamReader ler linha a linha do arquivo e é usado em arquivos grandes 
        using var filesd = new StreamReader("C:\\arquivo\\nomes.txt", Encoding.UTF8);
        string? line;

        while ((line = filesd.ReadLine()) != null)
        {
            // Console.WriteLine(line);
        }

        // Opcional: o using já fecha o arquivo ao final do escopo
        // filesd.Close();


        // Lê o arquivo inteiro sem bloquear a thread atual
        var content = await File.ReadAllTextAsync("C:\\arquivo\\nomes.txt");
        Console.WriteLine(content);
    }
}
