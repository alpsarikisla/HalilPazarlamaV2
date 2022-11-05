using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamav2
{
    public class Urun
    {
        public string Marka;
        public string Model;
        public double Fiyat;

        //Default Constructor
        public Urun(){ }

        //Overload Constructor
        public Urun(string marka, string model, double fiyat)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
        }

        public virtual string Yazdir()
        {
            return $"Marka={Marka} Model={Model} Fiyat = {Fiyat}";
        }

    }
}
