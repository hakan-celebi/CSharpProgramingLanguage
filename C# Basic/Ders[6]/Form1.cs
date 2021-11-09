using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#region Methods

#region Tanım
/*
    C# içerisinde methodlar, C/C++ dillerindeki fonksiyonlara benzetilebilir. C# içerisinde fonksiyonlara method ismi verilmesinin sebebi
methodlar sınıflar içerisnide tanımlanabildiği içindir. C# da methodlar, geriye değer döndüren methodlar ve geriye değer döndermeyen methodlar
olmak üzere iki ayrı grubda incelenebilir.
*/
#endregion

#region Geriye Değer Dönderen Methodlar ve Basic Method Tanımlaması
/*
    Methodlar aşağıdaki gibi tanımlanırlar;
<access_type><type><method_name>(parameters)
{
-
}
    Geriye değer döndermeyen methodlarda type kısmına void gelir ve return anahtar kelimesi ile değer döndermemiz mümkün değildir.
access_type ile belirtilen kısıma ise erişim belirteci yani public, private veya protected anahtar kelimeleri gelmektedir.
*/
#endregion

#region Parameter Definition, Optional Parameters & Params
/*
    C# içerisinde methodlar içerisinde parametre tanımlamak için method parantezleri arasına değişken tanımlama yapmamız gerekmektedir. Eğer
normal bir biçimde değişken tanımlanmış ve bu method çağrılmak isteniyorsa, tanımlanan parametreler için çağrılma yerinde parametre değerleri
de verilmesi gerekmektedir. Eğer çağrılma anında değer verilmesinin mecburi olmasını istemiyorsak bunun için Optional Parameters yöntemi
kullanılır. Beyin cimlastiği yapalım. Neden parametrelere çağrılma anında değer vermemiz gerekiyor? Çünkü method çağrılma anında parametrelere
değer vermezsek parametreler değer almamış olacaktır. Bu da hataya yol açmaktadır. Buradan da zaten Optional Parameters'ın ne olduğu ortaya
çıkmaktadır. Optional Parameters method parametrelerine tanımlama anında ilk değeri attığımız parametrelere denir. Fakat dikkat edilmesi
gereken şudur. Optional Parameter'dan sonra yine bir Optional Parameter gelmesi gerekmektedir. Yani birden fazla Optional Parameter tanımlaması
yapılabilir fakat bu parametrelerin normal parametrelerden sonra olması gerekmektedir.
    Çağrılma anında parametrelere değer atarken parametrelerin tanımlanma sırasına göre soldan sağa değer ataması yapılabilirken, parametre
isimlerini belirterek yani parameter_name:value biçiminde de değer ataması mümkündür. Ayrıca Optional Parameters için method çağrılırken
değer ataması yapmamıza gerek yoktur.
    Parametre sayısının belli olmadığı durumlarda params dizileri kullanılmaktadır. Kullanırken normal parametre tanımlamasının önüne yani
params parameter_type parameter_name biçiminde tanımlanır. Peki ya neden normal bir dizi olarak parametre almıyoruz? Çünkü eğer normal bir
dizi olarak alacak olursak, method çağırma anında da parametre olarak tek bir dizi göndermemiz gerekmektedir. Dolayısıyla dizi işlemleri
ile extra olarak uğraş gerekecektir. Bu yöntem ile çağırma sırasında parametreleri, karakteri ile ayırarak gönderiyor ve params parametresi
ile de bu verilere bir dizi halinde ulaşabiliyoruz.
*/
#endregion

#region Geriye Değer Döndüren Methodlar
/*
    Geriye değer dönderen methodları tanımlarken geriye döndürülecek değerin tipini belirtiriz ve return anahtar kelimesi ile birlikte
istediğimiz değeri geriye döndeririz. Değer dönderilmesi demek methodun bir değişken veya değer gibi başka bir değişkene aktarılabilmesi, 
özetle methodu bir değişken olarak kullanılabilmesi anlamına gelmektedir.
*/
#endregion

#region params IEnumerable<type>
/*
    C# 6 sürümünden sonra gelen bu özellik ile parametre sayısı bilinmeyen bir parametre tanımlayarak parametrelere sırayla erişim
sağlayabiliyoruz. Örneği Example Of Params IEnumerable region alanından görebiliriz.
*/
#endregion

#region Ref Return
/*
    C# içerisinde ref anahtar kelimesi ile tanımlanan Reference Variable tanımlayabiliyorduk. Bu tanımladığımız değişkenler değer tutmak
yerine o verinin adresini tutmaktadır. Dolayısıyla ref değişken üzerinden yapılan bir değişiklik direkt olarak hafızada yapılacağından
dolayı değer kopyalamayıp değişkeni kopyalamış oluyoruz. Methodlar için de aynı şey geçerlidir. Ref anahtar kelimesi ile type belirtilen
bir method ref anahtar kelimesi ile geriye değer dönderir. Dolayısıyla dönderilen değer kopyalanmaz değişken kopyalanır.
*/
#endregion

#region In Parameter
/*
    In anahtar kelimesi readonly parameter tanımlamak için kullanılır. In anahtar kelimesi ile tanımlanmış bir parameter değeri kesinlikle
değiştirilemez. Dikkat edilmesi gereken şey; In parameter, asyncrone method'larda kullanılamaz.
*/
#endregion

#region Ref Readonly Return
/*
    In Parameter region alanında değer tipi readonly parametrelerin tanımlanabilmesini göstermiştik. In Parameter ile tanımlanmış bir parameter
değeri kopyalanarak kullanılabilmektedir. Değişken de değer tipinde olduğu için değeri kullanırken değişkenin içeriği kopyalanır ve memory
içerisinde alan kaybı olmaktadır. Aynı zamanda sürekli olarak bu kopyalanan değerler Garbage Collector tarafından temizleneceğinden ötürü, 
yine bir performans kaybı oluşacaktır. Bunun yerine readonly olarak bir değişken tanımlayarak ve ref readonly return yöntemini kullanarak
değer üzerinde değişiklik yapabiliriz. Example Of RefReadonly Return region alanındaki örneği inceleyiniz.
*/
#endregion

#region Event Handler
/*
    C# da Event Handler yardımıyla Controls'e method atayabilmektediyiz. Method atamak için += operatörü kullanılırken, method
çıkarmak için -= operatörü kullanılmaktadır.
*/
#endregion

#region Generic Methods
/*
    Return değeri Generic Collections olan bu methodları kullanmak için, System.Collections.Generic sınıfını projemize dahil etmemiz
gerekmektedir. Bu methodlar ile birlikte sıralama gibi işlemler yapabiliriz. Ayrıca farklı Generic Collections için Method Overloading
yapmamıza da gerek yoktur. Type tipi ile belirleyerek her türden Generic Collection için ortak Generic Method yazabiliriz.
*/
#endregion

#region Method Overloading - Metod Aşırı Yükleme
/*
    C# içerisinade farklı parametreler veya farklı dönüş tipleri ile aynı isimli birden fazla method tanımlanmasına Method Overloading
adı verilir. Method Overloading yapmak için ya parametre sayısı farklı olacak, ya parametre tipleri farklı olacak ya da geri dönüş
tipi farklı olacaktır.
*/
#endregion

#region Delegates - Temsilciler
/*
    Delegates methodların adreslerini tutar. Bu sayede delegates yardımı ile methodları çağırabilir aynı zamanda birden fazla metodu
çağırabiliriz. Example Of Delegates region alanını inceleyin.
*/
#endregion

#region Anonymous Methods - Anonimm Metodlar
/*
    Delegates kullanmak için delegate'in gösterdiği methodu da tanımlamamız gerekiyordu. Bunun yerine delegate method tanımlayarak delegate
kullanılabilmektedir. Bu methodlara Anonymous Methods adı verilir. Anonymous Method'un sadece bulunduğu kod bloğu için tanımlanması gerekir.
*/
#endregion

#region Lambda Operator
/*
    Anonymous Methods'un delegate kullanımını kolaylaştırdığını görmüştük. Lambda (=>) operatörü ise Anonymous Methods'un kullanımını
kolaylaştırır. Example Of Delegates örneğini baza alarak yazılmış, Example Of Anonymous Methods & Lambda Operator örneğini inceleyiniz.
*/
#endregion

#region Action Delegates
/*
    Lamba operatörü gibi bu delegate türü de delegate kullanımını kolaylaştırmaktadır. Yeni bir delegate'den türetilmek istenen
delegate için kullanılır. Delagetes, Lambda Operator ve Anonymous Methods örneklerini bu örnekte toparlayalım.
*/
#endregion

#region Func Delegates
/*
    Action Delegates gibi tanımlanır ve değer olarak yine bir method alır. Action Delegates'den farkı geriye değer döndermesidir.
Parametre alabilir veya almayabilir geriye bir değer dönderir.
*/
#endregion

#region Predicate Delegates
/*
    Func Delegates'den tek farkı geriye sadece boolean değerler döndermesidir. 
*/
#endregion

#region Local Function
/*
    Method içerisinde method tanımlamak olarak özetlenebilir. Harici bir sınıf veya alan üzerinden kesinlikle ulaşılamaz. Sadece
tanımlandığı method içerisinde kullanılabilir. Ayrıca C# 9 versiyonundan itibaren Local Funtion static olarak tanımlanabilmektedir.
Böylelikle Local Function içerisinden üst sınıf değişkenlerine ulaşım engellenmektedir.
*/
#endregion

#region Caller Info Attrıbutes - Çağıran Bilgi Nitelikleri
/*
    CallerMemberName, CallerFilePath ve CallerLineNumber olmak üzere 3 attribute'den oluşmaktadır. Bu sayade sırasıyla Çağıran üye
adı, çağrılan dosya uzantısı ve çağrılan satır numarası bilgileri alınabilmektedir.
*/
#endregion

#endregion

#region Extension Methods - Genişletme Metotları

#region Tanım
/*
    Extension Methods kullanmakta olduğumuz method'lara yeni özellikler eklemek amacıyla kullanılırlar. Extension Methods kullanırken;
Extension Method static bir class içerisinde yazılmalıdır ve ilk parametresi this olmak zorundadır. Ayrıca Extension Method'un ilk
ilk parameter'ının tipi methodun bağladığı değişken tipi ile aynı olmalıdır.
*/
#endregion

#region XML Yorum Satırı
/*
     Extension Method gibi açıklamak istediğimiz methodlar için yazılır. Her bir satır için /// karakterleri eklenmeli ve yazılacak yorum
<summary>açıklama...</summary> tag'leri arasında yapılmalıdır.
*/
#endregion

#endregion

namespace Ders_6_
{
    public partial class Form1 : Form
    {
        #region Example Of Params IEnumerable
        private float ExampleOfParamsIEnumerable(params IEnumerable<float>[] notes)
        {
            float result = 0;
            byte count = (byte)((float[])notes.GetValue(0)).Length;
            for (int i = 0; i < count; i++)
                result += ((float[])notes.GetValue(0))[i];
            result /= count;
            result = (result * 4) / 100;
            return result;
        }
        #endregion

        #region Example Of Ref Readonly Return
        private static int counter = 0;
        private static void Increase(in int increaseNumber = 1)
        {
            counter += increaseNumber;
        }
        private static ref readonly int GetCounterValue()
        {
            return ref counter;
        }
        #endregion

        #region Example Of Delegates
        private void Message(string title, string text)
        {
            MessageBox.Show(text, title);
        }
        private void Sum(int num1, int num2, MessageMethodInstance Message)
        {
            Message("Sum Result", (num1 + num2).ToString());
        }
        private void Sub(int num1, int num2, MessageMethodInstance Message)
        {
            Message("Sub Result", (num1 - num2).ToString());
        }
        private delegate void MessageMethodInstance(string title, string text);
        private delegate void Operation(int num1, int num2, MessageMethodInstance Message);
        #endregion

        #region Example Of Anonymous Methods & Lambda Operator
        private delegate void ShowMessage(string title, string text);
        private ShowMessage m = delegate (string title, string text)
        {
            MessageBox.Show(text, title);
        };
        private delegate void MathOperation(int num1, int num2, ShowMessage m);
        #endregion

        #region Example Of Caller Info Attributes
        static void info([CallerMemberName] string methodName = "", [CallerFilePath] string filePath = "", [CallerLineNumber]
               int lineNumber = 0)
        {
            MessageBox.Show(String.Format($"Method Name = {methodName}\nLine Number = {lineNumber}\nFile Path = {filePath}"),
                "Information");
        }
        #endregion

        #region Example Of Extension Methods
       
        #endregion
        public Form1()
        {
            InitializeComponent();
            #region Example Of Params IEnumerable Method Call
            /*MessageBox.Show(ExampleOfParamsIEnumerable(new float[] { 100, 100, 100, 0}).ToString());*/
            #endregion

            #region Example Of Ref Readonly Return Method Call
            /*ref readonly int value = ref GetCounterValue();
            MessageBox.Show(value.ToString());
            Increase(5);
            MessageBox.Show(value.ToString());*/
            #endregion

            #region Example Of Delegates Method Call
            /*
            MessageMethodInstance m = new MessageMethodInstance(Message);
            Operation o = new Operation(Sum);
            o += Sub;
            o.Invoke(12, 10, m);
            */
            #endregion

            #region Example Of Anonymous Methods & Lambda Operator
            /*
            MathOperation result = (num1, num2, m) => m("Result", (num1 + num2).ToString());
            result += (num1, num2, m) => m("Result", (num1 - num2).ToString());
            result += (num1, num2, m) => m("Result", (num1 * num2).ToString());
            result += (num1, num2, m) => m("Result", (num1 / num2).ToString());
            result.Invoke(10, 2, m);
            */
            #endregion

            #region Example Of Action Delegates
            /*Example Of Delegates region içerisindeki Message methodu kullanılmıştır!*//*
            Action<string, string> actionDelegate = delegate (string title, string text){Message("Action Delegate", "Hello!"); };
            actionDelegate += delegate (string title, string text) { Message("Second Action Delegate", "Hello Again!"); };
            actionDelegate.Invoke("Not Important", "Not Important");
            actionDelegate.Invoke("Not Important", "Not Important");
            */
            /*İkinci Örnek Example Of Anonymous Methods & Lamda Operator region içerisindeki bazı methodlar kullanılmıştır!*/
            /*
            Action<int, int, ShowMessage> result = (num1, num2, m) => m("Result", (num1 + num2).ToString());
            result += (num1, num2, m) => m("Result", (num1 - num2).ToString());
            result += (num1, num2, m) => m("Result", (num1 * num2).ToString());
            result += (num1, num2, m) => m("Result", (num1 / num2).ToString());
            result.Invoke(12, 2, m);
            */
            #endregion

            #region Example Of Caller Info Attributes Method Call
            /*info();*/
            #endregion
        }
    }

    #region ExtensionClass
    public static class ExtensionClass
    {
        /// <summary>
        /// ToInt16 metodu string bir değeri short int çevirmek için kullanır.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt16(this string value)
        {
            return Convert.ToInt16(value);
        }
        /// <summary>
        /// ToInt32 metodu string bir değeri int çevirmek için kullanır.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt32(this string value)
        {
            return Convert.ToInt16(value);
        }
        /// <summary>
        /// ToInt64 metodu string bir değeri long int çevirmek için kullanır.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt64(this string value)
        {
            return Convert.ToInt16(value);
        }
    }
    #endregion
}