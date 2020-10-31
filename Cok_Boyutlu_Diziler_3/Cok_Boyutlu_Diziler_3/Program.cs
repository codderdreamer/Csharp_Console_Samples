using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cok_Boyutlu_Diziler_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;
            int i, j;
            Console.Write("Satır Sayısımı Girin: ");
            satir = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sutun Sayısını Girin: ");
            sutun = Convert.ToInt16(Console.ReadLine());

            int[,] matris = new int[satir, sutun];

            for ( i = 0; i < satir; i++)
            {
                for(j=0; j<sutun; j++)
                {
                    Console.Write("Matrisin {0} x {1} Değeri: ", i + 1, j + 1);
                    matris[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for(i=0;i<satir;i++)
            {
                for(j=0;j<sutun; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();

        }
    }
}
