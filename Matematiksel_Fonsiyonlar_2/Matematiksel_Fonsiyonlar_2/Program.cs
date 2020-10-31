using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematiksel_Fonsiyonlar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi;
            Console.Write("Sayıyı girin: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayının üste yuvarlanmış hali: " + Math.Ceiling(sayi));
            Console.WriteLine("Sayının alta yuvarlanmış hali: " + Math.Floor(sayi));
            Console.ReadLine();
        }
    }
}
