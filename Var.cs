using System.Collections.Generic;

namespace OOP;

public class Var
{
    public static void MainVar()
    {
        /*
         * A palavra-chave var instrui o compulador deduzir o tipo da variável 
         */

        // Ambas as variáveis são do mesmo tipo int
        // Compilado como int
        var x = 0;
        int y = 0;

        // tipo anônimo
        // Quando tempos um tipo anônimo somos obrigados a usar var
        var aluno = new { Nome = "Ana Maria", Idade = 16 };
    }
}
