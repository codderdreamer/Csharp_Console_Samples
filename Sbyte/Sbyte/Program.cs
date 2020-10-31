using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbyte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Doğu Anadolu Bölgesi Hava Durumu *****");
            Console.WriteLine("1-Ocak Hava Tahminleri");

            // sbyte -128 ile 127 arasındaki değerleri alabilir.
            // byte 0 ile 256 arasındaki değerleri alabilir.
            sbyte Erzurum, Malatya, Elazig;
            Erzurum = -35;
            Malatya = 3;
            Elazig = -7;
           
            Console.WriteLine("Erzurum Karlı: " + Erzurum + " Derecedir.");
            Console.WriteLine("Malatya Çok Bulutlu: " + Malatya + " Derecedir.");
            Console.WriteLine("Elazığ Karla Karışık Yağmurlu: " + Elazig + " Derecedir.");
            Console.ReadLine();

        }
    }
}
