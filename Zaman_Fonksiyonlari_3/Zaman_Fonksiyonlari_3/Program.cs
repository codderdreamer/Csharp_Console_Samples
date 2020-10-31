using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaman_Fonksiyonlari_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime;
            dateTime = DateTime.Now;
            Console.WriteLine("***** C# Dersleri Tarih Saat Fonksiyonları *****");
            Console.WriteLine("Tarih d: {0:d}", dateTime);
            Console.WriteLine("Tarih D: {0:D}", dateTime);
            Console.WriteLine("Tarih f: {0:f}", dateTime);
            Console.WriteLine("Tarih F: {0:F}", dateTime);
            Console.WriteLine("Tarih g: {0:g}", dateTime);
            Console.WriteLine("Tarih G: {0:G}", dateTime);
            Console.WriteLine("Tarih m: {0:m}", dateTime);
            Console.WriteLine("Tarih r: {0:r}", dateTime);
            Console.WriteLine("Tarih s: {0:s}", dateTime);
            Console.WriteLine("Tarih t: {0:t}", dateTime);
            Console.WriteLine("Tarih y: {0:y}", dateTime);
            Console.ReadLine();
        }
    }
}
