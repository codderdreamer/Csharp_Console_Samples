using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];

            for(int i = 0; i<5;i++)
            {
                Console.Write("Sayıyı Giriniz: ");
                sayilar[i] = Convert.ToInt16(Console.ReadLine());
            }

            Array.Sort(sayilar);

            foreach(int i in sayilar)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
