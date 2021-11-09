using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3_Oparatorler
{
    class Program
    {
        /*Oparatörler
         * 1-Matematiksel Oparatörler:
         * Toplama(+),Çıkarma(-),Çarpma(*),Bölme(/)
         * ++:Değişkenin değerini 1 arttırır.
         * --:Değişkenin değerini 1 eksiltir.
         * %:Değişkenin modunu alır.
         * -=,+=,*=,/=
         * Not:++ veya -- Opratörleri değişkenin önünde (solunda) ise değişkeni önce işleme sokar daha sonra kullanırız.
         * Not:++ veya -- Oparatörleri değişkenin arkasında(sağında)ise önce değişkeni kullanır daha sonra işleme sokar.
         * -a = a +-/* 10; gibi işlemleri a +-/*= 10; kullanarak gerçekleştirebiliriz. 
         * 
         * 2-İlişkisel Oparatörler:
         * == --> Eşitmi sorusunu sorar.
         * < --> Küçükmü sorusunu sorar.
         * > --> Büyükmü sorusunu sorar.
         * <= --> Küçük eşitmi sorusunu sorar.
         * >= --> Büyük eşitmi sorusunu sorar.
         * !:Değil anlamına gelir.Örnek; != --> Eşit değilmi sorusunu sorar.
         * 
         * 3-Mantıksal Oparatörler:
         * & --> 'Ve' Anlamına gelir.
         * | --> 'Veya' Anlamına gelir.
         * ! --> 'Değil' Anlamına gelir.    
         */
        static void Main(string[] args)
        {
            int a = 2;
            Console.WriteLine(a);
            a += 10;
            Console.WriteLine(a);
            int b = 3;
            Console.WriteLine(b);
            b *= 2;
            Console.WriteLine(b);
            a = a / b;
            Console.WriteLine(a);
            int c = 5;
            Console.WriteLine(c);
            int d = 3;
            Console.WriteLine(d);
            c = ++c;
            Console.WriteLine(c);
            c = c++;
            Console.WriteLine(c);

            Console.ReadLine();

        }
    }
}
