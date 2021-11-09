using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__Interface_Yapısı
{
    class Oyuncu
    {
        public string adi { get; set; }

        public int yasi { get; set; }

        public int yasamdegeri { get; set; }

        public void nisanal()
        {
            //Nişan Alma İşlemi Yapılacak.
            if (oyuncusilahi is IYakinlastir)
            {
                //oyuncununsilahi eğer IYakinlastir interface'ini özellik olarak kazanmış ise Buradaki işlemler yapılacak.
                IYakinlastir ykn = (IYakinlastir)oyuncusilahi;
                ykn.yakinlastir();
            }
        }

        public void saldir()
        {
            //Saldırma İşlemi Yapılacak
        }

        public Silah oyuncusilahi { get; set; }

    }
}
