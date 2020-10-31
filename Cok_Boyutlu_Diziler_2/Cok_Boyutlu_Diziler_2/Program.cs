using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cok_Boyutlu_Diziler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrislerde Toplama");
            int[,] matris1 = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] matris2 = { { 3, 4, 5 }, { 3, 4, 5 }, { 3, 4, 5 } };
            int[,] toplam = new int[3, 3];

            for(int i=0; i<3;i++)
            {
                for(int j=0; j<3;j++)
                {
                    toplam[i, j] = matris1[i, j] + matris2[i, j];
                    Console.Write(" {0} ", toplam[i, j]);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
