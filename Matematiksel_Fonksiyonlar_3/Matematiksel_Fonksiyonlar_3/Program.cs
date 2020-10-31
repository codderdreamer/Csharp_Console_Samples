using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematiksel_Fonksiyonlar_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi;
            Console.Write("Sayıyı girin: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sonuç: " + Math.Pow(sayi, 5));
            Console.ReadLine();
        }
    }
}
