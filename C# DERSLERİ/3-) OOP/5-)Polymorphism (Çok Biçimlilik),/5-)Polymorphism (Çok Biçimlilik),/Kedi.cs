using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Polymorphism__Çok_Biçimlilik__
{
    class Kedi
    {
        /*Polymorphism - Çok Biçimlilik
         * Polymorphism Sınıflar içerisinde miras yolu ile çalışan sınıflar'da bir metodun ana sınıf içerisinde yer alması ve bizim bu ana metod içerisindeki metodu kendimize göre şekillendirmemiz gerektiği için Polymorphism ortaya çıkmıştır. Biz şu anda zorunsuz Polymorphism göreceğiz.
         * Polymorphism ikiye ayrılır. 1.Zorunlu Polymorphism 2.Zorunsuz Polymorphism.
         * Zorunlu Polymorphism'de işaretleme yapılırken iki terim vardır.
         * a-)Virtual: Bu komut ile işaretlenmiş metod değiştirilebilir anlamına gelir. Yani bu metod ezilebilir denmiş olur. İsteğe bağlı yani Zorunsuz Polymorphism'dir
         * b-)Override: Bu komut 'Virtual' ile işaretlenmiş metodlar üzerinde istediğimiz şekilde değişim geri dönderilen yazıyı kodu veya işlemleri değiştirebilmemizi sağlar. Ezmek anlamına gelir.
         */

        public int kilo { get; set; }

        public int yas { get; set; }

        public string ismi { get; set; }

        public virtual string Gozrengi()
        {
            return "Kedinizin Gözrengi Mavidir.";
        }
    }
}
