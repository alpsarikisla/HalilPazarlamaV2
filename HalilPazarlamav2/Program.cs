using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamav2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Depo d = new Depo();
            #region Doldur

            d.Ekle(new CamasirMakinasi("Regal", "RG123", 5000, 7, false));
            d.Ekle(new BulasikMakinesi("Ariston", "Abc111", 7000, 15, "A+++"));
            d.Ekle(new CamasirMakinasi("Arçelik", "Ar12", 5500, 7, false));
            d.Ekle(new BuzDolabi("SIEMENS", "IQ500", 23000, 50, 3, true));

            #endregion

            Console.WriteLine("1 - Camasir Makinaları");
            Console.WriteLine("2 - Bulasik Makinaları");
            Console.WriteLine("3 - Buz Dolapları");
            Console.WriteLine("4 - Tümü");
            Console.WriteLine("Seçim Yapnız");
            string secim = Console.ReadLine();
            d.Listele(secim);

        }
    }
}
