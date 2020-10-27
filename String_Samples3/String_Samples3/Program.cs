using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Samples3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string isim;
            Console.Write("İsminizi Giriniz: ");
            isim = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz: " + isim);
            Console.Read();*/

            string ad, soyad, yas;

            Console.Write("Adınızı giriniz: ");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı giriniz: ");
            soyad = Console.ReadLine();
            Console.Write("Yaşınızı giriniz: ");
            yas = Console.ReadLine();

            Console.WriteLine("Ad: {0} Soyad: {1} Yaş: {2}", ad, soyad, yas);
            Console.ReadLine();
        }
    }
}
