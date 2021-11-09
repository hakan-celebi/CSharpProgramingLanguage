using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__Pizza_Otomasyonu
{
    class Pizzalar
    {
        public string adi { get; set; }

        public decimal fiyati { get; set; }

        public Ebatlar ebati { get; set; }

        public Kenar kenari { get; set; }

        public int adeti { get; set; }

        public List<string> malzemeler { get; set; }

        private decimal _topfiyati;

        public decimal topfiyati
        {
            get
            {
                _topfiyati = fiyati * (decimal)ebati.carpani;
                _topfiyati += (decimal)ebati.carpani * (decimal)kenari.carpani;
                _topfiyati *= adeti;
                return _topfiyati;
            }
        }

        public override string ToString()
        {
            return adi;
        }
    }
}
