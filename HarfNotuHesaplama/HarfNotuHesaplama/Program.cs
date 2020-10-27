using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfNotuHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            int not;
            string harfNotu;

            Console.Write("İsminizi giriniz: ");
            isim = Console.ReadLine();

            Console.Write("Notunuzu giriniz: ");
            not = Convert.ToInt32(Console.ReadLine());

            if(not < 30)
            {
                harfNotu = "FF";
            }
            else if(not < 40)
            {
                harfNotu = "DD";
            }
            else if(not < 50)
            {
                harfNotu = "DC";
            }
            else if(not < 60)
            {
                harfNotu = "CC";
            }
            else if(not < 70)
            {
                harfNotu = "CB";
            }
            else if(not < 80)
            {
                harfNotu = "BB";
            }
            else if(not < 90)
            {
                harfNotu = "BA";
            }
            else
            {
                harfNotu = "AA";
            }

            Console.WriteLine(isim + " aldığınız harf notu: " + harfNotu);

            
            Console.WriteLine();
            Console.WriteLine("Not Çizelgesi");
            Console.WriteLine("0 - 29   : FF\n" +
                              "30 - 39  : DD\n" +
                              "40 - 49  : DC\n" +
                              "50 - 59  : CC\n" +
                              "60 - 69  : CB\n" +
                              "70 - 79  : BB\n" +
                              "80 - 89  : BA\n" +
                              "90 - 100 : AA");
            Console.ReadLine();

        }


    }
}
