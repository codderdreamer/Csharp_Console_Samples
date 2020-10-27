using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tam_Bolenleri_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 120;
            for( int i = 1; i<=sayi; i++)
            {
                if(sayi%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
