using System;

/*O algoritmo testa se um n�mero digitado pelo teclado � par ou impar e mostra o resultado
no terminal*/

public class ParidadeComFInterna
{
    public static void Main()
    {
        Console.Write("\nDigite um n�mero para que a paridade dele seja verificada: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        if(n1 % 2 == 0)
        {
            Console.WriteLine("\nO n�mero {0} � par.",n1);
        }
        else
        {
            Console.WriteLine("\nO n�mero {0} � impar.",n1);
        }

        Console.WriteLine("\nProgrma finalizado. Aperte qualquer tecla.");
        Console.ReadKey();

    }
}