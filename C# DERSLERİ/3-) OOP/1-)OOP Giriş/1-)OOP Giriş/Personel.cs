using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__OOP_Giriş
{
    class Personel
    {
        /*Access Modifiers - Erişim Belirleyici
         * Bir değişkenin veya genelleme olarak içerisinde bir veri tutan bir kodun geriye değer dönderen herhangibir şeyin Acces Modifiers'i vardır. Bu acces modifiers erişimi belirler kişiselmi bütün projede erişilebilirmi diğer taraflardan müdahale edilebilirmi gibi birçok yapıyı belirler biz kodları yazarken hiç bir zaman yazmadık çünkü default olarak Acces Modifiers 'Private' olarak belirlidir.
         * Acces Modifiers Yapıları;
         * 1-)Private - Varsayılandır kişisel anlamına gelir sadece bulunduğu yapı içerisinden erişilebilir.
         * 2-)Internal - Bulunduğu proje içerisinde her yerden erişilebilirdir farklı projeden erişilemez.
         * 3-)Protected - Korunmuş anlamına gelir miras alınan sınıflar içerisinde erişilebilir.
         * 4-)Protected Internal - Hem miras alınan sınıflar içerisinden erişilebilir hemde proje içerisinden erişilebilir.
         * 5-)Public - Heryere açık anlamına gelir her yerden herşekilde erişilebilirdir.
         */

        internal string isim;
        internal string soyisim;
        internal DateTime dogumtarihi;

        internal void personelekle()
        {
            //VERİ TABANINA PERSONEL EKLEME İŞLEMİ YAPILIR
        }
    }
}
