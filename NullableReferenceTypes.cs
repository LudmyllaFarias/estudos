using System.Collections.Generic;

namespace OOP;

public class NullableReferenceTypes
{
    public static void MainNullableReferenceTypes()
    {
        /*
         * A palavra-chave var instrui o compulador deduzir o tipo da variável 
         */

        // O ? antes do tipo que dizer que idade pode conter um valor int ou null
        int? idade = null;
        // Sem o interrogação depois do tipo causa erro
        // int idade2 = null;

        /*
         * Int normalmente não aceita null, então interrogação transforma isso em um nullable<int>. Dessa
         * forma int? e Nullable<int> são equivalentes
         */
        int? ano = null;
        Nullable<int> anoFabricacao = null;

        // Para strings é diferente, o interrogação diz essa referência pode ser null
        // Então int? - Nullable<int> e string? - referência que pode ser null
        string? nome = null;

    }
}
