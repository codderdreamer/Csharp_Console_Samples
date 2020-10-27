using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Samples1
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            Console.Write("İsminizi Giriniz: ");
            isim = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz: " + isim);
            Console.Read();
        }
    }
}
