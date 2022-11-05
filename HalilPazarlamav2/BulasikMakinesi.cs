using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamav2
{
    public class BulasikMakinesi:Urun
    {
        public int ProgramSayisi;
        public string EnerjiSinifi;

        public BulasikMakinesi(string marka, string model, double fiyat,int programSayisi, string enerjiSinifi)
            :base(marka, model, fiyat)
        {
            ProgramSayisi = programSayisi;
            EnerjiSinifi = enerjiSinifi;
        }
        public override string Yazdir()
        {
            return $"{base.Yazdir()} Program Sayısı = {ProgramSayisi}, Enerji Sınıfı = {EnerjiSinifi}";
        }
    }
}
