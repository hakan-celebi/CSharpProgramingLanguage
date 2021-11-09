using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__Pizza_Otomasyonu
{
    struct Kenar
    {
        public string kenar { get; set; }

        public double carpani { get; set; }

        public override string ToString()
        {
            return kenar;
        }
    }
}
