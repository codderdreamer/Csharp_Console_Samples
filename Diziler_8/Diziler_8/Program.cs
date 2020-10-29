using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10;
            string stop = "stop";
            string girilenSayi ="";
            int sonindex = 0;
            int[] sayilar = new int[max];

            while(girilenSayi != stop)
            {
                for(int i=0; i< max; i++)
                {
                    Console.Write(i + 1 + ". Sayıyı giriniz: ");
                    girilenSayi = Console.ReadLine();
    
                    if (girilenSayi == stop)
                    { 
                        break; 
                    }
                    else
                    {
                        sayilar[i] = Convert.ToInt32(girilenSayi);
                    }

                    
                    
                    sonindex = i;
                    
                }
            }

            Console.WriteLine();
            for(int i= 0; i<sonindex+1; i++)
            {
                Console.WriteLine(sayilar[i]);
            }


            Console.ReadLine();

        }
    }
}
