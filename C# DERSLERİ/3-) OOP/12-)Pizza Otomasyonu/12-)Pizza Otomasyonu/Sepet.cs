using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__Pizza_Otomasyonu
{
    class Sepet
    {
        public Sepet()
        {
            pizza = new List<Pizzalar>();
        }

        public override string ToString()
        {
            sepettoplam += piza.topfiyati;
            return string.Format("{0}-{1} {2} {3}x{4}: {5} TL", piza.ebati, piza.adi, piza.kenari, piza.adeti, piza.fiyati, piza.topfiyati);
        }

        public Pizzalar piza { get; set; }

        public decimal sepettoplam { get; set; }

        public List<Pizzalar> pizza { get; set; }


    }
}
