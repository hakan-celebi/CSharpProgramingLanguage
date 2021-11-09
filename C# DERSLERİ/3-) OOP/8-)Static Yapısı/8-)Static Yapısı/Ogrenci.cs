using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Static_Yapısı
{
    class Ogrenci
    {
        public Ogrenci() //---> Consturctor Metodu
        {
            //Burda her yeni bir instance yani ram'de yeni bir ogrenci class'ı oluşturulduğu zaman tanimlanma sayisini bir arttırarak kaç adet ogrenci instance olduğunu öğrenebiliyoruz.
            tanimlanmasayisi++;
        }

        /*Static - Durağan
         * Static bir yapının tek bir kez tanımlanmasını form.cs de yaptığımız gibi global olarak tanımlanmasını yada ram'de static bir yere sahip olması diyebiliriz. Ram'de ayrıca kendi için bir alan açılır ve kullanılmak istendiği zaman kendisi bulunup işlem yapılır. Örneğin MessageBox.Show(); show metodu MessageBox class'ının içinde olmasına rağmen yeni bir instance oluşturmadan kullanabiliyoruz. Peki bunu ne sağlıyor bunu show metodunun static olması sağlıyor. Biz de bunun gibi bir static eleman sağlıyalım. 1!'de görebilirsiniz.
         * Static eleman oluşturulduğu zaman static eleman static olmayan elemana static olmayan eleman ise static olan elemana ulaşamaz. Static eleman static elemana static olmayan eleman static olmayan elemana ulaşabilir.
         * Her şeyi static yapabiliriz bir sınıfı bir metodu veya bir field'i.
         * Bir sınıfı static yapar isek static olmayan elemanı olmaması gerekir eğer sınıf static olursa instance üretilemez ve static olmayan elemana ulaşılamaz.
         */

        public string adisoyadi { get; set; }

        public string sinifi { get; set; }

        //Artık bu yapının ram'de heap bölümünde kendine ait bir yapısı bulunur ve bu class üzerinden erişilmek istendiği zaman tüm instance'ler tarafından erişilebilir.
        public static int tanimlanmasayisi { get; set; } //---> *1!*
    }
}
