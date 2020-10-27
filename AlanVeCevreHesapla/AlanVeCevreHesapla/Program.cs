using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanVeCevreHesapla
{
    class Program
    {
        static void Main(string[] args)
        {
            int kareKenar, kareCevre, kareAlan;
            int dikdortgenKısaKenar, dikdortgenUzunKenar, dikdortgenCevre, dikdortgenAlan;

            Console.WriteLine("********* Kare Çevre ve Alan Hesaplaması *********");
            Console.WriteLine();
            Console.Write("Karenin bir kenarı = ");
            kareKenar = Convert.ToInt32(Console.ReadLine());
            kareCevre = kareKenar * 4;
            kareAlan = kareKenar * kareKenar;
            Console.WriteLine("Karenin çevresi = " + kareCevre);
            Console.WriteLine("Karenin alanı = " + kareAlan);
            Console.WriteLine();
            Console.WriteLine("********* Dikdörtgen Çevre ve Alan Hesaplaması *********");
            Console.WriteLine();
            Console.Write("Dikdörtgenin kısa kenarı = ");
            dikdortgenKısaKenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörtgenin uzun kenarı = ");
            dikdortgenUzunKenar = Convert.ToInt32(Console.ReadLine());
            dikdortgenCevre = 2 * dikdortgenKısaKenar + 2 * dikdortgenUzunKenar;
            dikdortgenAlan = dikdortgenKısaKenar * dikdortgenUzunKenar;
            Console.WriteLine("Dikdörtgenin çevresi = " + dikdortgenCevre);
            Console.WriteLine("Dikdörtgenin alanı = " + dikdortgenAlan);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
