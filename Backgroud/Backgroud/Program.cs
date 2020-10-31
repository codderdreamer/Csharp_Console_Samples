using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgroud
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor kirmizi = ConsoleColor.Red;
            Console.BackgroundColor = kirmizi;
            Console.Write(" Ana Sayfa ");

            ConsoleColor yesil = ConsoleColor.Green;
            Console.BackgroundColor = yesil;
            Console.Write(" Hakkında ");

            ConsoleColor beyaz = ConsoleColor.White;
            Console.BackgroundColor = beyaz;
            Console.Write(" iletişim ");

            Console.ReadLine();
                
                
        }
    }
}
