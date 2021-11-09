using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__Interface_Yapısı
{
    public interface IYakinlastir
    {
        /*Interface - Arabirim
         * Biz bir sınıftan miras alabiliyoruz fakat birden fazla miras alamıyoruz. Fakat almamız gerekiyor ise intarface ara birim ekliyoruz arabirimi şu şekilde düşüne biliriz. Sınıf bizim babamızken sadece birtane babamız olur ve ondan miras alırız Ara birim ise bizim amcamızdır biz onlardan da miras alabiliriz özelliklerini alabiliriz. Interface de budur bir yetenek kazanabilme işidir.
         * Interface içerisinde property,metod,indexleyici ve event haricinde birşey bulunmaz.
         * Interface içerisindeki elemanların abstract metodunda olduğu gibi gövdesi bulunmaz.
         * Interface'in Abstract'tan Farkları;
         * 1-Interface içerisinde sadece Abstract elemanlar bulunur. Gövdesiz elemanlar.
         * 2-Interface içerisindeki elemanların Acces Modifires'ları bulunmaz ve varsayılan A-Modifiers'ları publictir.
         * 3-Interface'den instance üretilemez.
         */
        void yakinlastir();
    }
}
