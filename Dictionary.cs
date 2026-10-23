using System.Collections.Generic;

namespace OOP;

public class Dictionary
{
    public static void MainDictionary()
    {
        /*
         * O dicionário armazena uma conjunto de dados de pares chave: valor
         */

        var listaNomes = new Dictionary<int, string>
        {
            { 1, "José Lima" },
            { 2, "Maria Alves" },
            { 3, "Carlos Martins" },
            { 4, "Ana Ribelo" },
            { 5, "João Souza" },
        };

        foreach (var item in listaNomes) 
        {
           // Console.WriteLine(item); // Retorna chave: valor [1, José Lima]
           // Console.WriteLine(item.Key); // Retorna chave
           // Console.WriteLine(item.Value); // Retorna os valores
        }

        // Remove as chaves e valores do dicionário
        // listaNomes.Clear();

        // Remove o valor da chave específicada
        listaNomes.Remove(4);

        /* 
         * Ao tentar adicionar um valor a uma chave existente nada acontece,
         * mas ao adicionar um valor ao uma chave que ainda não existe ele insere no dicionário
         */
        listaNomes.TryAdd(6, "Alice Sader");

        /*
         * Diferente do TryAdd, ao adicionar um valor ao uma chave existente é lançada uma exceção
         */
        // listaNomes.Add(6, "Frederico Gomes");

        // Busca valor associado à chave
        var value = string.Empty;
        Console.WriteLine(listaNomes.TryGetValue(8, out value));

        // Verifica se todos os elementos satisfazem a condição
        Console.WriteLine($"All: {listaNomes.All(x => x.Value.StartsWith("Maria"))}");

        // Determina se algum elemento da sequência satisfaz a condição
        Console.WriteLine($"Any: {listaNomes.Any(x => x.Value == "Maria Alves")}");

        foreach (var item in listaNomes)
        {
            Console.WriteLine(item.Value);
        }
    }
}
