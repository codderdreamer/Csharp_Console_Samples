using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaman_Fonksiyonlari_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman;
            zaman = DateTime.Now;
            int ay = zaman.Month;
            int gun = zaman.Day;
            int yil = zaman.Year;
            DayOfWeek dayOfWeek = zaman.DayOfWeek;
            Console.WriteLine("Gün:{0} ", gun);
            Console.WriteLine("Ay:{0} ", ay);
            Console.WriteLine("Yıl:{0} ", yil);
            Console.WriteLine("Haftanın günü:{0} ", dayOfWeek);
            Console.ReadLine();
        }
    }
}
