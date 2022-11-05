using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamav2
{
    public class Depo
    {
        Urun[] urunler;

        public Depo()
        {
            urunler = new Urun[0];
        }

        public void Ekle(Urun u)
        {
            Urun[] gecici = new Urun[urunler.Length + 1];
            Array.Copy(urunler, gecici, urunler.Length);
            gecici[gecici.Length-1] = u;
            urunler = gecici;
        }

        public void Listele()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {urunler[i].Yazdir()}");
            }
        }

        public void Listele(string tur)
        {
            if (tur == "1")
            {
                for (int i = 0; i < urunler.Length; i++)
                {
                    if (urunler[i].GetType() == typeof(CamasirMakinasi))
                    {
                        Console.WriteLine($"{i + 1}) {urunler[i].Yazdir()}");
                    }
                }
            }
            if (tur == "2")
            {
                for (int i = 0; i < urunler.Length; i++)
                {
                    if (urunler[i].GetType() == typeof(BulasikMakinesi))
                    {
                        Console.WriteLine($"{i + 1}) {urunler[i].Yazdir()}");
                    }
                }
            }
            if (tur == "3")
            {
                for (int i = 0; i < urunler.Length; i++)
                {
                    if (urunler[i].GetType() == typeof(BuzDolabi))
                    {
                        Console.WriteLine($"{i + 1}) {urunler[i].Yazdir()}");
                    }
                }
            }
            if (tur == "4")
            {
                for (int i = 0; i < urunler.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) {urunler[i].Yazdir()}");
                }
            }
        }
    }
}
