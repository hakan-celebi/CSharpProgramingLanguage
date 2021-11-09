using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11__Generic_Mimari
{
    class Ogrenci <Temsili> where Temsili:class //---> Bu şekilde temsili elemanını sadece class tipinde vermen gerekir.
    {
        /*Generic
         * Dışardan bir tip alarak çalışmayı sağlayan yapıdır. <> bu semboller ile belirtilir.
         */
        public string isimsoyisim { get; set; }

        public int okulno { get; set; }

        public int sinifi { get; set; }

        public char subesi { get; set; }

        public alan alani { get; set; }

        public Temsili tmsl { get; set; }
    }

    enum alan
    {
        Say,
        Soz,
        EA,
        Dil
    }
}
