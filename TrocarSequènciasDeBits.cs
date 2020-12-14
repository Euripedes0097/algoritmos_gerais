
//Os r bits a partir do dígito p são trocados com os r bits começados no dígito q de um inteiro sem sinal.
// 56 _10 = 0011 1000 _2. Então depois do 56 ser processado, a saída será 7 _10 = 0000 0111 _2
using System;
namespace Projeto002Operadores02
{
    class TrocarSequènciasDeBits
    {
        static int bitDaPosição(uint num, int pos)
        {
            if((num & (1 << pos)) != 0)
            {
                return 1;
            }

            return 0;
        }

        static uint trocarBits(uint num, int pos, int bit)
        {
            return (uint)(bit * (num | (uint)(1 << pos)) + (1 - bit)*(num & (~(uint)(1 << pos))));
        }

        static void Main(string[] args)
        {
            uint n = 56u;
            int p = 0, q = 3, r = 3;

            for(int i = 0; i < r; i++)
            {
                int inf = bitDaPosição(n, p + i), sup = bitDaPosição(n, q + i);

                if (inf != sup)
                {
                    n = trocarBits(n, p + i, sup);
                    n = trocarBits(n, q + i, inf);
                }
            }
            Console.WriteLine(n);
        }
    }
}
