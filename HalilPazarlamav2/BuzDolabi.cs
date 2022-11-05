using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamav2
{
    public class BuzDolabi:Urun
    {
        public int IcHacim;
        public int KapiSayisi;
        public bool BuzMakinasi;

        public BuzDolabi(string marka, string model, double fiyat,int icHacim, int kapiSayisi, bool buzMakinasi)
            :base(marka, model, fiyat)
        {
            IcHacim = icHacim;
            KapiSayisi = kapiSayisi;
            BuzMakinasi = buzMakinasi;
        }

        public override string Yazdir()
        {
            return $"{base.Yazdir()} iç Hacim = {IcHacim}, Kapı Sayısı = {KapiSayisi} Buz Makinası = {BuzMakinasi}";
        }
    }
}
