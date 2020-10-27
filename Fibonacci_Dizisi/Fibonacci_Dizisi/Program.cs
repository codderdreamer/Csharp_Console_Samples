using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Dizisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for(int i = 1; i<=8; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
}
