using System;

//A troca aritmética de números dispensa o uso de uma terceira variável auxiliar. Os valores dessas variávais estão restritos ao conjunto dos números inteiros.

class TrocaAritmeticaDeNumerosBinarios
{
    public static void Main()
    {
        Console.Write("Digite o valor do primeiro número inteiro: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nDigite o valor do segundo número inteiro: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        n1 = n1 ^ n2;
        n2 = n1 ^ n2;
        n1 = n1 ^ n2;

        Console.WriteLine("\nOs valores agora são: n1 = {0} e n2 = {1} ", n1, n2);

        Console.WriteLine("Programa finalizado. Pressione qualquer tecla.");
        Console.ReadKey();
    }
}
