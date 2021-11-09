using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__INTRODUCTION_OPARATORLER
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Oparatörler
             * 1-) Matematiksel Operatörler:
             * Toplama(+),Çıkarma(-),Çarpma(*),Bölme(/)
             * ++ Bir arttırmayı sağlar.
             * -- Bir azaltmayı sağlar.
             * % Mod almayı sağlar.
             * +=
             * -=
             * *=
             * /=
             * Bu tür işlemlerde değişkeni kendisi ile toplama çıkarma çarpma ve bölme işlemleri yapılır.
             * Örnek:int a = 5; a'nın değeri şu anda 5 ve siz a'yı 20 yapmak istiyorsunuz bu işlem için 3 seçenek var;
             * 1-a = 20;
             * 2-a = a + 15;
             * 3-a += 15;
             * yapabilrsiniz 2 ve 3. seçenekler aynı işlemi yapar 3. seçenek 2. seçeneğin kısa halidir.
             * Bu işlemi sadece += için değil hepsi için geçerlidir.
             * 
             * Not:++ Veya -- operatörleri eğer sayının önüne gelirse ilk başta arttırma işlemini yapar.
             * Örnek:int a = 1; int b = 0; b = ++a; olur sa b nin değeri 2 eğer b = a++; olursa b nin değeri 1 kalır.
             * 
             * Pekiştirme:int a = 3; ve a = a++ - --a; işleminin sonucu;
             * a şu an 3 değerinde ve a yı 3 olarak aldık a(3) = 3(++) /bu durumda a 4 oldu ama işlemde a nın ilk değerini kullanıyoruz
             * a(3) = a(3)++ - --a(4) = 0; olur çünkü a nın sağa aktarım değeri 4 olmuştur 1 eksilttiğimiz zaman işleme -- sol tarafta
             * olduğu için 3 olarak alınır a = 3 - 3; olur ve sonuç 0 dır.
             * 
             * 2-)İlişkisel Operatörler:
             * == --> Bu işlem denklik kontrolü için kullanılır.
             * < --> Bu işlem küçük mü kontrolü için kullanılır.
             * > --> Bu işlem büyük mü kontrolü için kullanılır.
             * <= --> Bu işlem küçük veya eşit mi kontrolü için kullanılır.
             * >= --> Bu işlem büyük veya eşit mi kontrolü için kullanılır.
             * != --> Bu işlem denk değil mi kontrolü için kullanılır.
             * Örneğin: int a = 5;
             * if (a == 5 işleminde a 5'e eşit ise if'in içine girer - a < 6 işleminde a 6'dan küçük veya büyük ise if'in içine girer)
             * {                                                        = >        gibi işlemlerde aynı görevi görür.
             * 
             * }
             * if (a != 4 işleminde a 4 değil ise if'in içine girer.)
             * {
             * 
             * }
             * Not: !< - !> gibi işlemlerde küçük değil , büyük değil , küçük eşit değil , büyük eşit değil gibide kullanılabilir.
             * 
             * 3-)Mantıksal Operatörler:
             * & --> 'Ve' anlamına gelir.
             * | --> 'Veya' anlamına gelir.
             * ! --> 'Değil' anlamına gelir.
             * 
             */
        }
    }
}
