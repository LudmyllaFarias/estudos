using System.Collections.Generic;

namespace OOP;

public class List
{
    public static void MainList()
    {
        /*
         * A lista armazena um conjunto de dados de um tipo, ou seja, a lista pode armazenar vários nomes, idades e números mas,
         * os dados a serem armazenados precisam ser do mesmo tipo.
         */

        var listaNomes = new List<string>
        {
            "Maria Lima",
            "José Silva",
            "Murilo Bones",
            "Clarice Maia",
            "Pedro Gomes",
            "José Mario",
            "Frederico Martins",
            "Maria Alves"
        };

        foreach(var nome in listaNomes)
        {
            Console.WriteLine(nome);
        }

        // Remove todos elementos da lista
        // listaNomes.Clear();

        // Remove um elemento da lista
        listaNomes.Remove("José Mario");

        if (listaNomes.Contains("José Mario"))
        {
            Console.WriteLine("O nome existe na lista");
        }
        else
        {
            Console.WriteLine("\nO nome não existe na lista");
        }

        // Adiciona elementos especificados ao final da lista
        var listaNomesAprovados = new List<string> { "Carolina dos Santos " };
        listaNomesAprovados.AddRange(listaNomes);

        foreach (var nome in listaNomesAprovados)
        {
            Console.WriteLine($"Aprovado: {nome}");
        }

        // Retorna o índice do elemento
        Console.WriteLine($"\nÍndice: {listaNomes.IndexOf("Murilo Bones")}");

        // Remove o elemento de um índice da lista
        // listaNomes.RemoveAt(2); 

        /* 
         * Remove um intervalo de elementos, o primeiro parâmetro é o índice que 
         * deseja remove e o segundo é quantos a partir daquele índice deseja remover
        */
        // listaNomesAprovados.RemoveRange(2, 2);

        // Define a capacidade/tamanho de elementos de a lista deve ter
        // listaNomes.Capacity = 1;

        // Adiciona os elementos da coleção especificada ao final da lista
        var listaNotas = new List<double>()
        {
            7.5,
            4.0,
            7.4,
            5.6
        };
        var soma = listaNotas.Aggregate(seed: 1, func: (f, i) => (int)(f + i), 
                        resultSelector: f => (decimal)f / listaNotas.Count);
        Console.WriteLine($"Soma: {soma}");

        // Determina de todos os elementos da lista satisfazem uma condição
        Console.WriteLine(listaNomes.All(p => p.StartsWith("Maria")));

    }
}
