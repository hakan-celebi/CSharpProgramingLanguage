using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Enumeration_Yapısı
{
    class Ogrenci
    {
        /*Enum - Enumaration
         * Enum struct gibi bir yapıdır fakat struct bir değişken tipi'ne benzerken enum bir liste yapısına benzer biz bir butonun rengini değiştirirken buton.BackColor = Color.White; gibi tanımlarız buradaki Color bir enum'dur Enum iki şekilde tanımlanır struct tanımlar gibi veya !1 işaretlediğim yer gibi.
         * Enum yapısının elemanlarının index numaraları vardır. İlk eklenen eleman 0 ikinci 1 gibi index numaraları devam eder ve bir enum tanımlarken index numaralarını da kullanabiliriz. Eğer biz index numaraları ile kullanmak istemiyorsak içerideki değerlere kendimiz bir sayı verebiliriz fakat index numaraları kaybolmaz ama burdaki alana cast ederek ulaşıladabilir !2 de gösterildiği gibi.
         * Enumlarda GetName ve GetNames olarak iki adet metod vardır.
         * GetName: GetName kullanıcının verdiği tipte ve hangi class üzerindeki enum değerini göstermek istiyorsak onun ismi gereklidir geriye string değer dönderir kullanımı şu şekildedir;
         * GetName(typeof(Alan),alan.alani);
         * GetNames: Adından'da anlaşılabileceği gibi belirtilen tip deki tüm içeriği gösterir ve geriye string dizisi olarak dönderir kullanımı şu şekildedir;
         * GetNames(typeof(Alan));
         */

        public string isimsoyisim { get; set; }

        public string sinif { get; set; }

        public Alan alani { get; set; }
    }

    //*1!*
    public enum Alan
    {
        Sayisal = 10, // ---> *2!*
        Sozel,
        Esitagirlik,
        Dil
    }
}
