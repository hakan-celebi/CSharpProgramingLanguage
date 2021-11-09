using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__Constructor__Yapıcı_Metod_
{
    class Personel
    {
        /*Constructor - Yapıcı Metod
         * Nesnenin ram'de üretilmesini sağlayan metoddur. Tanımlanmaz ise default olarak metod belirlidir.
         * Constructor Metodlarının Overload'u vardır. Yani bir tane metod var gözükür isimleri aynıdır fakat parametre değerleri değiştiği için imzası değişmiş oluyor bu şekilde overload yani tekrar aynı metodu oluşturma yapabiliriz. Yani biz constructor'u overload yapabiliriz.
         * Constructor geriye değer döndermez bu yüzden voide gerek yoktur. Bu yüzden tek geriye dönüştipi olmayan metoddur. Eğer biz kendimiz yeni bir constructor oluşturursak default constructor iptal olur.
         * Bir sınıf için new kullandığımız zaman klonlamış veya örnek üretmiş oluyoruz bunun ismi "INSTANCE"'dır.
         * Kısacası Constructor ram'de alan inşa etmemizi ve kod'lar çalışmadan önce bir değer atamamız gerekiyorsa constructor metodu ile yapılır. Constructor metodları sınıf ismi (class) ile aynı olmak zorundadır.
         *Object Initializer
         * Constructor'ün bitmesini sağlamıştır new Personel(); yerine new Personel {} şeklinde tanımlanır ve süslü parantezler içerisinde direk istediğimiz değerleri gönderebiliyoruz. Object Initializer tanımlarken örneğin new Personel
         * {
         *      adi = ad,
         *      soyadi = soyad;
         * }
         * Şeklinde kullanılır.
         */

        //Ram bizim arka plandaki verilerimizi tuttan cihazdır. Bir uygulama her zaman ram'de belli bir yer kaplar. Ram'de 2 türlü bir yapı vardır. Bunlar 'Stack' ve 'Heap' dir.
        //Biz örneğin personel metodunu çağırıyoruz: Personel p; şeklinde tanımladığımız zaman stack tarafına p = null; değeri atılır ve heap de bir yer oluşmaz. Eğer biz: Personel p = new Personel(); şeklinde tanımlanan bir metod yazarsak bu sefer heap kısmına gider p = new Personel(); yazar ve bir geriye seri numarası dönderir örneğin 1a45x7 bu seri numarası stack kısmına gider ve p = 1a45x7; şeklinde tanımlanır. Yani bu şekilde ram'de istediğimiz şekilde yer inşa ettirmiş oluruz. Her new Personel(); metodu kullandığımız zaman tekrar bir seri numarası üretir ve birbirinden farklı birden fazla personel sınıfı çağrılmış olunur. Yani personel sınıfını çağırırken klonlayıp ram'de inşasını tamamlayıp içerisine değer atıyoruz.

        Personel()
        {

        }

        internal string isim;
        internal string soyisim;
        internal DateTime dogumtarihi;
        internal string tckn;
    }
}
