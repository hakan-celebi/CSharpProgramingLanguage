using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _6__Struct_Yapısı
{
    /*1!*/class Ogrenci
    {
        /*
         * Struct ekle yeni item struct şeklinde eklenmez ilk başta class oluşturulur 1! koyduğum yerdeki class silinerek yerine struct yazılır biz bu tarafta struct tanımlamayacağız çünkü Ogrenci class'ında daha sonradan miras kalmasını isteyebiliriz veya override Polymorphism gibi yapılar kullanabiliriz. Normal kodlarda kullandığımız int decimal sbyte gibi değişkenlerde struct'dır.
         */
        public string isim { get; set; }

        public string soyisim { get; set; }

        public long tckn { get; set; }

        public int yas { get; set; }

        public string sinif { get; set; }

        public Ders ders { get; set; } //---> Struct bu şekilde tanımlanır değişken ismi gibi yazilir.
    }
}