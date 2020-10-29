using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            Console.WriteLine("*** Diziyi Sondan Başa Doğru Sıralama ***");

            for(int i=0;i<5;i++)
            {
                Console.Write("Sayıyı Giriniz: ");
                sayilar[i] = Convert.ToInt16(Console.ReadLine());
            }

            Array.Reverse(sayilar);

            foreach(int i in sayilar)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
