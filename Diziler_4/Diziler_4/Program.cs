using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Mersin", "İzmir", "Kocaeli", "Şanlıurfa", "Bilecik", "Sakarya" };
            
            foreach(string i in sehirler)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
