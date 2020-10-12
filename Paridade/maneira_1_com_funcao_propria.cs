using System;

/*O algoritmo testa se um número digitado pelo teclado é par ou ímpar através da
 * função MóduloExterno e mostra o resultado no terminal
 * Uma divisão pode ser escrita como uma equação. Ao isolar o resto da divisão em um dos membros da
 * equação, teremos o módulo. É ele que se´r retornado pela função.
 * Se o resto da divisão for igual a 0, o número é par; caso o resto seja 1, o número é ímpar*/

public class ParidadeComFInterna
{
    // Dividendo/divisor = quociente + resto/divisor;
    public static int ModuloExterno(int dividendo, int divisor)
    {
        int quociente;
        quociente = dividendo / divisor;

        return dividendo - quociente * divisor; 
    }

    public static void Main()
    {
        Console.Write("\nDigite um número para que a paridade dele seja verificada: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        if (ModuloExterno(n1, 2) == 0)
        {
            Console.WriteLine("\nO número {0} é par.", n1);
        }
        else
        {
            Console.WriteLine("\nO número {0} é impar.", n1);
        }

        Console.WriteLine("\nProgrma finalizado. Aperte qualquer tecla.");
        Console.ReadKey();

    }
}
