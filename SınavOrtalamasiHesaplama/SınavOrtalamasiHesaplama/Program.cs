using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOrtalamasiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, numara;
            int vize1, vize2, final, ortalama;
            ad = "Sevda";
            soyad = "Yücedağ";
            numara = "123456";

            Console.WriteLine("******** Öğrenci Bilgileri ********");
            Console.WriteLine();
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Numara: " + numara);
            Console.WriteLine();
            Console.WriteLine("***** Not Bilgilerini Giriniz *****");
            Console.WriteLine();
            Console.Write("Vize1: ");
            vize1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vize2: ");
            vize2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final: ");
            final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("************ Ortalama *************");
            ortalama = (vize1 + vize2 + final) / 3;
            Console.Write(ortalama);
            Console.Read();

            

        }
    }
}
