using System;

//A troca aritmética de números dispensa o uso de uma terceira variável auxiliar. Ao final da execução, mostra os dois valores no console.

class TrocaAritmeticaDeNumerosDecimais
{
    public static void Main()
    {
        Console.Write("Digite o valor do primeiro número: ");
        decimal n1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("\nDigite o valor do segundo número: ");
        decimal n2 = Convert.ToDecimal(Console.ReadLine());

        n1 = n1 + n2;
        n2 = n1 - n2;
        n1 = n1 - n2;

        Console.WriteLine("\nOs valores agora são: n1 = {0} e n2 = {1} ", n1, n2);

        Console.WriteLine("Programa finalizado. Pressione qualquer tecla.");
        Console.ReadKey();
    }
}
