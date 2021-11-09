using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__Encapsulation___Kapsülleme
{
    class Urun
    {
        //Bir sınıf içerisinde tanımlanan değişkenlere field yani alan denir.

        /*Encapsulation - Kapsulleme
         * Mesela admin paneli oluşturduğumuz zaman veya kayıt ol yaptığımız zaman field'ın içerisine değer atamadan önce yapmamız gereken bu kullanıcı adından varmı yada admin ismine uyuyormu gibi kontrol işlemi yapmak ve veri tabanı güvenliğini sağlamak için veri tipinin güvenliğini sağlamak gerekiyor bunun için encapsulation yöntemi kullanılıyor.
         * Encapsulation yönteminin Auto property olarak bir yöntemi daha vardır.
         * Auto Property;
         * Field tanımlanmaz arka plandaki field'ını kendi tutar.
         * get ve set metodları değiştirilemez. değiştirilmek istenirse auto property bozulur ve arka plandaki field'ı elimiz ile tanımlamamız gerekir.
         */

        //Encapsulation Yöntemidir. Field'lar oluşturulurken _ ile veya küçük harflerle tanımlamak tercih edilir. Field gizli tutulur dışarıdan erişebilmek için aracı olarak property kullanılır.
        private string _kladi; //---> Bu bir field'dir. Ana değişkendir dışardan erişime kapalıdır.

        internal string kladi //---> Bu bir property'dir. İngiliz anahtarı simgesi ile form.cs den ulaşılır.
        {
            get
            {
                return _kladi; //---> Geriye _kladi'yı dönderir.
            }
            set //---> Eğer set metodunu kullanmaz isek sadece get ile oluşturur isek property readonly olur ve değer ataması yapılamaz.
            {
                if (value == "Admin") //---> Kullanıcıda dışardan girilen değer 'Value' olarak tutulur.
                {
                    _kladi = value; //---> Value sadece set içerisinde barınır.
                }
            }
        }

        internal string AutoProperty { get; set; } //---> Bu bir Auto Property'dir.

        /*Eğer Encapsulation yöntemi olmasaydı bu işlemi şu şekilde yapacaktık.

        private string kladi;

        internal void Kayitekle (string gelenkladi)
        {
            if (gelenkladi == "Admin")
            {
                kladi = "Admin";
            }
        }

        internal string Kayitdonder ()
        {
            if (kladi != null)
            {
                return kladi;
            }
        }*/
    }
}
