using System;

/**/

public class ParidadeComMetProprio
{
    public static void Main()
    {
        Console.Write("\nDigite um número para que a paridade dele seja verificada: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        if ((n1 & 1) == 1)
        {
            Console.WriteLine("\nO número {0} é ímpar.", n1);
        }
        else
        {
            Console.WriteLine("\nO número {0} é par.", n1);
        }

        Console.WriteLine("\nProgrma finalizado. Aperte qualquer tecla.");
        Console.ReadKey();
    }
}
