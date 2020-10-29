using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel_Hesapla
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int faktoriyel = 1;
            Console.Write("Faktoriyel hesaplanacak sayıyı giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());

            while(sayi > 1)
            {
                faktoriyel = faktoriyel * sayi;
                sayi--;
            }
            Console.WriteLine("Faktoriyel: " + faktoriyel);
            Console.ReadLine();
        }
    }
}
