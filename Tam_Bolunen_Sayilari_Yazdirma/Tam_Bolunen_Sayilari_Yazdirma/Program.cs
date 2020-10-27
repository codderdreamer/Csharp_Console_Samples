using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tam_Bolunen_Sayilari_Yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1;i<=100;i++)
            {
                if(i % 9 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
