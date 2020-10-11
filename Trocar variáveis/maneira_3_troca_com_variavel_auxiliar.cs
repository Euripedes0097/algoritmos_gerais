using System;
using System.Collections.Generic;

//A função chamada de "Troca" realiza uma troca de duas variáveis da mesma classe. Ela altera os valores por referência para que possam ser usados em outros escopos. É feito um teste na função Main com variáveis da classe String.

public class TrocaComVariavelAuxiliar
{
    public static void Troca<T>(ref T var1, ref T var2)
    {
        T aux = var1;
        var1 = var2;
        var2 = aux;
    }

    public static void Main()
    {
        string nome1 = "Delta", nome2 = "Epsilon";
        System.Console.WriteLine("\nAs variáveis nome1 e nome2 valem, antes de serem trocadas pela função, respectivamente {0} e {1}.",nome1,nome2);

        Troca<string>(ref nome1, ref nome2);

        Console.WriteLine("\nApós o processo da função, nome1 é igual a {0} e nome2 é {1}.",nome1,nome2);

        Console.WriteLine("\nPrograma finalizado. Pressione qualquer tecla.");
        Console.ReadKey();
    }
}