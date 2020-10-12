using System;

/*O algoritmo testa se um número digitado pelo teclado é par ou impar e mostra o resultado
no terminal*/

public class ParidadeComMetNativo
{
    public static void Main()
    {
        Console.Write("\nDigite um número para que a paridade dele seja verificada: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        if(n1 % 2 == 0)
        {
            Console.WriteLine("\nO número {0} é par.",n1);
        }
        else
        {
            Console.WriteLine("\nO número {0} é ímpar.",n1);
        }

        Console.WriteLine("\nProgrma finalizado. Aperte qualquer tecla.");
        Console.ReadKey();

    }
}
