using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamav2
{
    public class CamasirMakinasi: Urun
    {
        public int YikamaKapasitesi;
        public bool Kurutma;

        public CamasirMakinasi(string marka, string model, double fiyat,int yikamaKapasitesi, bool kurutma)
           :base(marka, model, fiyat)
        {
            YikamaKapasitesi = yikamaKapasitesi;
            Kurutma = kurutma;
        }

        public override string Yazdir()
        {
            return $"{base.Yazdir()} Yikama Kapasitesi = {YikamaKapasitesi}, Kurutma = {Kurutma}";
        }
    }
}
