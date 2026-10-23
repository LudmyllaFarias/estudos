using System.Collections.Generic;

namespace OOP;

public class IEnumerable
{
    public static void MainIEnumerable()
    {
        /*
         * O tipo enumerable permite somente a leitura dos elementos
         */
        var nomes = new List<string> { "Maria", "José", "Paulo", "Pedro", "Lucas" };
        IEnumerable<string> nomesContenhamLetraO2 = nomes.Where(x => x.Contains("o"));
        List<string> nomesContenhamLetraO = nomes.Where(x => x.Contains("o")).ToList();
        nomes[0] = "Marcos";

        /* O nome Marcos foi listado sendo alterado depois da declaração do IEnumerable.
        * Isso acontece porque o IEnumerable é executado no foreach. O mesmo não acontece com tip List, porque
        * ele já estava criado e armazenado em memória. Devemos usar o IEnumerable quando precisamos apenas ler a coleção
        * ou quando lidamos com grande volume de dados. Já o List usamos quando precisamos modificar a coleção ou precisamos do resultado
        * imediatamente.
        */
        foreach (var nome in nomesContenhamLetraO)
        {
            Console.WriteLine(nome);
        }
    }
}
