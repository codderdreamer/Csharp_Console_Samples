using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Tahmin_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int tahmin;
            Random random = new Random();
            a = random.Next(1, 5);

            Console.WriteLine("0 ile 5 arasında olan bir sayı tahmin et!");
            tahmin = Convert.ToInt32(Console.ReadLine());
            while ( tahmin != a)
            {
                Console.WriteLine("Yanlış sayı! Tekrar deneyiniz.");
                tahmin = Convert.ToInt32(Console.ReadLine());
            }
            if(tahmin == a)
            {
                Console.WriteLine("Tebrikler! Tahmin ettiğiniz sayı doğru.");
            }

            Console.ReadLine();

        }
    }
}
