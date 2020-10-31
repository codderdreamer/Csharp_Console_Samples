using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematiksel_Fonksiyonlar_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayıyı girin: "); 
            sayi = Convert.ToInt16(Console.ReadLine());
            Console.Write("Mutlak Değerli Hali: " + Math.Abs(sayi));
            Console.ReadLine();
        }
    }
}
