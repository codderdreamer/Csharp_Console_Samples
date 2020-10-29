using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehir_Atama_Programi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int gelenSehirIndex;
            string[] sehirler = { "Adana", "Antalya", "Bursa", "Eskişehir", "Bilecik", "İstanbul", "Trabzon", "Hakkari", "Şanlıurfa", "Gaziantep" };

            Console.WriteLine("**** Sehir Atama Programı ****");

            gelenSehirIndex = random.Next(0, sehirler.Length);

            Console.WriteLine(gelenSehirIndex);
            Console.WriteLine(sehirler[gelenSehirIndex]);

            Console.ReadLine();
        
        }
    }
}
