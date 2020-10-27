using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Samples2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sırası ile ad, soyad, yas, meslek, sehir bilgilerinizi giriniz!");

            string ad, soyad, yas, meslek, sehir;
            ad = Console.ReadLine();
            soyad = Console.ReadLine();
            yas = Console.ReadLine();
            meslek = Console.ReadLine();
            sehir = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Yas: " + yas);
            Console.WriteLine("Meslek: " + meslek);
            Console.WriteLine("Şehir: " + sehir);
            Console.ReadLine();
        }
    }
}
