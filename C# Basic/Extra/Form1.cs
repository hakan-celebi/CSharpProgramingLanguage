#define DefinedVariable1
/*Conditional için define bir değer tanımladık.*/
using System;
using static System.Math; /*Artık pow vb. metodları Math.Pow gibi kullanmamıza gerek yok. Direkt olarak Pow diyerek kullanılabilir.*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics; /*Conditional etiketi için*/

#region Subjects - Konular

#region Events - Olaylar
/*
    Event'ler ile ilgili bazı detaylar için notlar.
*/
#region EventArgs
/*
    Event metodlarında parametre olarak kullanılırlar. Eğer sadece 'Eventargs' parametresi varsa geri object bir değer döndürürken, bu parametrenin
yanında 'MouseEventArgs' örneğinde olduğu gibi kontrolün veya event'in ismi varsa o kontrol veya event ile ilgili özellikler geriye döner.
*/
#endregion

#region Sender
/*
    Event metodlarında object Sender tanımlaması ile görülen Sender parametresi o olayın hangi kontrol nesnesine ait olduğunu tutmaktadır. 
*/
#endregion

#endregion

#region Namespace Keywords - İsim Uzayı Anahtar Kelimeleri

#region Warning - Uyarı
/*
    Namespace içerisinde direkt scope içerisinde field, property vb. kullanılamaz. Class, struct, enum vb. yapılar kullanılmak zorundadır. Ayrıca
bu yapılar public olmak zorundadır. Eğer namespace dışarısından erişilmemesini istediğimiz işlemler varsa bunları namespace içerisindeki yapıların
içerisine yeni bir yapı oluşturup access modifiers ile sağlayabiliriz.
*/
#endregion

#region Namespace - İsim Uzayı
/*
    Namespace, isim uzayı anlamına gelmektedir. İçerisinde; Other Namespace, Class, Interface, Struct, Enum ve Delegate barındırabilmektedir.
İçerisindeki kodları organize etmek, kodları hiyerarşik bir düzende saklamamıza yardımcı olur. Benzer amaçlarla kurulan yapıları bir arada tutmamızı
sağlar. Namespace içerisindeki yapılara access modifiers sınırları dahilinde erişebilmemiz mümkündür.
*/
#endregion

#region Using Keyword - Using Anahtar Kelimesi

#region Description - Açıklama
/*
    Bir kütüphanenin/sınıfın kullanım direktifini ifade eden anahtar kelimedir. Ardına kütüphane/sınıf ismi yazılarak ; karakteri ile bildirim
yapılır.
*/
#endregion

#region Alias - Takma İsim
/*
    Using ifadesi ile kullandığımız nesnelere(Kütüphaneler/Sınıflar) takma isim vererek daha kısa olarak çağırıp kullanmamızı sağlar. Kullanımı;
Using ifadesinden sonra alias gelir ve = karakterinden sonra kullanacağımız nesne gelir. [using aliasName = Library;] Ayrıca eğer .NET kütüphaneleri
veya kendi kütüphanelerimiz herhangi bir alias almamış ise 'global' alias alırlar.
NOT: Example Of Alias region alanındaki örneği inceleyiniz.
*/
#endregion

#region Using IDisposable Interface

#region Warning - Uyarı
/*
    ASP.NET Core Version 3.X versiyonları şu anda sadece C# 8 Version desteklemektedir. ASP.NET Framework 6.X ile C# 10 Version, ASP.NET Framework 5.X
ile C# 9 Version kullanılabilmektedir. Bu özellik C# 9 ve üzeri versiyonlarda desteklenmektedir. 
*/
#endregion

#region IDisposable Interface
/*
    Bu interface, bu interface'i implement(uygulayan) eden nesnelerin kullandıkları kaynakları kullanımları tamamlandıktan sonra ram içerisinden
kaldırılması yani dispose edilmesine yarayan bir yapıdır.
*/
#endregion

#region Disposable - Tek Kullanımlık
/*
    Using ifadesi ile tanımladığımız/kullandığımız nesnelerin, Visual Studio tarafından kullanımı bittikten sonra otomatik olarak hafızadan silinmesine
yarayan bir sistemdir. Aksi halde program kapatılana kadar ram meşgul olacaktır.
*/
#endregion

#region Using IDisposable Interface
/*
    Kullanımı bittikten sonra dispose etmek istediğimiz nesneleri using ile kullanımı;
    using (ClassName ObjectName = new ClassName(Parameters))
    {
        Bu noktada bu ObjectName nesnesini kullanımını yapacağız.
    }
NOT: Example Of Using IDisposable Interface region alanındaki örneği inceleyiniz.
*/
#endregion

#endregion


#endregion

#region Extern Alias (::)
/*
    Alias verilmeyen .NET kütüphanelerine veya şahsi kütüphanelere global alias verilir demiştik. Bu global alias kullanımı şu şekilde kullanılır;
using global::alias libraryName
NOT: Example Of Extern Alias region alanındaki örneği inceleyin.
*/
#endregion

#endregion

#region Assembly
/*
    Programı oluşturan derlenmiş exe veya dll uzantılı dosyalara Assembly denir. 
*/
#endregion

#region Class Types - Sınıf Çeşitleri

#region Instance - Numune
/*
    Bir class, struct veya enum gibi yapılardan yeni bir nesne üretilmesine Instance almak denir. Örneğin Button btn = new Button(); tanımlamasında
var olan Button sınıfından ki bu sınıf form kontrolünü belirtir, yeni bir nesne üretilmesi instance örneğidir.
*/
#endregion

#region Partial Class - Parçalı Sınıf

#region Warning - Uyarı
/*
    Partial sınıflar aynı namespace içerisinde olmalıdırlar. Fakat namespace olmadan da sınıf oluşturabilir ve bunları partial yapabilmekteyiz.
Fakat bu sınıflara tüm assembly üzerinden erişilebilmektedir.
*/
#endregion

/*
    Bir sınıfı partial olarak işaretledikten sonra farklı yerlerde aynı sınıfı tekrar yazıp yeni özellikler veya metodlar tanımlayabiliriz. Örneğin
InstanceClass isimli bir sınıf oluşturalım. Bu sınıf içerisinde Form1 için bazı yöntemler yazalım. Daha sonra Form2 için yeni yöntemler yazacak
olursak farklı bir sınıf oluşturmamıza gerek yoktur. Tüm sınıf parçalarını partial olarak işaretleyerek istediğimiz alanda bu sınıfı yazabiliriz.
NOT: Example Of Partial Class region alanındaki örneği inceleyin.
*/
#endregion

#region Sealed Class - Mühürlü Sınıf
/*
    Sealed olarak ifade edilmiş sınıflar miras alınamaz sınıflardır. Sadece instance alınabilir. 
*/
#endregion

#region Static Class - Sabit Sınıf

#region Warning - Uyarı
/*
    Class içerisinde instance alınabilir yani struct, enum, class tanımlamaları static olmak zorunda değilidir.
*/
#endregion

/*
    Instance alınamayan ve direkt olarak sınıf ismi ile sınıf üyelerine erişebildiğimiz sınıf türüdür. Mantıken direkt olarak sınıf üyelerine
erişebildiğimiz için sınıf üyelerininde yani property, field, method vb. üyelerinin de static olması gerekmektedir. Buna karşın normal bir sınıf
içerisinde static üye yazılabilmektedir.
*/
#endregion

#endregion

#region Type Converting With As Keyword - As Anahtar Kelimesi ile Tip Çevirimi
/*
    Genellikle object türündeki verileri asıl tipine dönüştürmek için kullanılır. Sadece reference type için kullanılabilir.
NOT: Example Of Type Converting With As Keyword region alanında kullanımı ve örneği vardır.
*/
#endregion

#region Is Keyword - Is Anahtar Kelimesi
/*
    a is b gibi bir örnekte a, b mi anlamına gelir. Eğer a, b ise true, değil ise false döner. Example Of Is Keyword örneğinde daha iyi anlaşılır. 
*/
#endregion

#region Other Variable Types - Diğer Veri Tipleri

#region Description - Açıklama
/*
    Daha önceki derslerde de anlattığımız üzere değişkenler; Value Type ve Reference Type olmak üzere ikiye ayrılırlar. Value Type değişkenler normal
şartlarda null değer alamazken, tanımlarken sonlarına ? karakteri eklenmesi sayesinde null değer alabilmektedirler. Sonuç olarak bu değişkenlere de
nullable değişken denilir. Ayrıca Nullable olarak tanımlanan değişkenler yeni bir metoda ve iki özelliğe sahip olur.
*/
#endregion

#region Nullable Variable's Properties - Null Değer Alabilen Değişkenlerin Özellikleri
/*
    Nullable olarak tanımlanan değişklenler extra olarak iki property'e sahip olduklarını söylemiştik. Bu propertyies;
    # Value
        Nullable olarak tanımlanan değişkenin değerini dönderir. Eğer null ise hata fırlatır.
    # HasValue
        Nullable olarak tanımlanan değişkenin bir değer içerip içermediğini bildirir. Değer varsa geriye true, yoksa geriye false dönderir.
NOT: Example Of Nullable Variable's Properties region alanındaki örneği inceleyiniz.
*/
#endregion

#region Nullable Variable's Method - Null Değer Alabilen Değişkenlerin Metodu
/*
    Description alanında da söylediğimiz üzere, nullable değişkenlerin bir adet extra metodu bulunur. Bu metod;
    # returning [Nullable Variable's Type] GetValueOrDefault([Overloading Option]Type defaultValue)
        Nullable değişken içerisinde değer varsa o değeri, değer yoksa o değişken tipinin varsayılan değerini dönderir. (boolean default value is
    false, int default value is 0) Parametre değişkenin tipinde olmak zorunda bir parametre verilerek çağrılırsa içerisinde bir değer yoksa
    parametre olarak verilen değer dönderilir.
*/
#endregion

#region Why Using Nullable Variables? - Null Değer Alabilen Değişkenler Neden Kullanılır?
/*
    Nullable değişkenler genellikle database ile çalışırken kullanılmaktadır. Eğer sorgudan elde edilen sonuç null gelirse hatayı önlemek ve
tespit etmek amacı ile kullanılır.
*/
#endregion

#region Null Conditional Operator - Null Koşulu Operatörü
/*
    Eğer nullable değişkenin değeri varsa özelliklerine ulaş demek için kullanılır. C# 6 Version öncesinde bu değişkenin özelliklerine ulaştığımız
zaman eğer değişkenin değeri yoksa NullReferenceException hatası fırlatılıyordu. Bu operatör ile beraber artık hata fırlatımı yapılmadan default
değerler dönderilerek özelliklere erişilebilmektedir.
*/
#endregion

#endregion

#region Generating Unique Identity with GUID - GUID ile Benzersiz Kimlik Üretmek
/*
    Değişken için benzersiz bir kimlik numarası üretmek için kullanılan bir sınıftır. Açılımı Globally Unique Identifier olmak üzere Türkçesi
Global Benzersiz Kimlik Tanımlayıcı olarak söylenebilir. Bu sınıf rakamsal ve metinsel veri tiplerinin bir araya gelmesi ile oluşur. Hafızada
16 byte yer kullanır. Bir çok yerde kullanılabilir. Örn; internet üzerinden kaydedilecek bir resimi isimlendirirken resmin orjinal adının
yanında bir de guid ekleriz.
NOT: Kullanımını ve örneğini Example Of Generating Unique Identity With GUID region alanından görebilirsin.
*/
#endregion

#region Base Keyword - Base Anahtar Kelimesi
/*
    Inheritance(Miras/Kalıtım) konusunda gördüğümüz üzere bir adet base class ve bu base class dan miras alan bir adet derived class'ımız olsun. Derived
classdan instance aldığımız zaman ilk başta base class constructor daha sonra ise derived class consturoctor oluşturulduğunu görmüştük. Peki biz eğer
derived ve base class için int value parametresi alan constructor oluşturarak derived classdan bir instance alınca ne olacak? Şöyle ki; derived class'ın
parametre alan constructoru çalıştırılacaktır fakat base classın parametresiz constructoru çalıştırılacaktır.(Eğer mevcutsa) Peki ya aynı parametreyi
base class'a göndererek parametreli consturctor'u çalıştırmamız mümkün mü? Evet base anahtar kelimesi ile bunu yapmamız mümkündür. Ayrıca base anahtar
kelimesi ile derived class içerisinde ovverride edilen metod yerine derived class içerisinden base class'ın metodunu çağırmamız da mümkündür.
NOT: Konu Example Of Base Keyword region alanındaki örnekte daha iyi anlaşılacaktır.
*/
#endregion

#region Iteration Yield - İterasyon Verme
/*
    Örneğin; 2 4 6 8 olarak verilen sayının sonuna 10 eklenmesi bir iterasyondur. Peki ya C# da iterasyon nedir? C# da iterasyon; bir metodun
return değerlerini foreach döngüsü ile gezinmek bir iterasyondur. Peki ya bunun için ne türlü bir şart vardır? İterasyon yapılmak istenen veri tipi
yani metodun geri dönüş tipi IEnumerable interface'ini implement etmek zorundadır. Ayrıca meotodun geri dönüş değeri IEnumerable da olabilmektedir.
NOT: Example Of Iteration Yield region alanındaki örnekte daha düzgün konu anlaşılacaktır.
*/
#endregion

#region Attributes - Öznitelikler
/*
    Runtime içerisinde bilgi veren nitelikler diyebiliriz. Bunu en iyi Example Of Attributes region alanında açıklarız. Yalnız atribute'ler
reflection ile daha karmaşık hale gelerek daha iyi işler çıkarmamızı sağlar.
*/
#endregion

#region Reflection - Yansıma

#endregion

#endregion

#region Homework - Ödev
/*
    1-)Environment Class için konu anlatımı hazırlayın.
    2-)StringBuilder Class için konu anlatımı hazırlayın.
    3-)XML oluşturma, yazma, okuma için konu anlatımı hazırlayın. Merkez Bankasından Döviz Kurlarını 1 sn de bir çeken örnek program yazın.
    4-)JSON oluşturma, yazma, okuma için konu anlatımı hazırlayın.
    5-)BigInteger yapısını için konu anlatımı hazırlayın.
*/
#endregion

namespace Extra
{
    public partial class Form1 : Form
    {
        #region Example Of Base Keyword
        public class BaseKeywordBaseClass
        {
            public BaseKeywordBaseClass()
            {
                MessageBox.Show("Base Class Constructor Not With Parameter!", "Consturctor");
            }
            public BaseKeywordBaseClass(int value)
            {
                MessageBox.Show($"Base Class Constructor With {value} int Parameter!", "Consturctor");
            }
            public BaseKeywordBaseClass(string text)
            {
                MessageBox.Show($"Base Class Constructor With {text} string Parameter!", "Consturctor");
            }
            public void GetClassName()
            {
                MessageBox.Show($"Base Class Name: {nameof(BaseKeywordBaseClass)}", "GetClassName() Method");
            }
        }

        public class BaseKeywordDerivedClass : BaseKeywordBaseClass
        {
            public BaseKeywordDerivedClass()
            {
                MessageBox.Show("Derived Class Constructor Not With Parameter!", "Consturctor");
            }
            public BaseKeywordDerivedClass(int value) : base(value)
            {
                MessageBox.Show($"Derived Class Constructor With {value} int Parameter!", "Consturctor");
            }
            public BaseKeywordDerivedClass(string text)
            {
                MessageBox.Show($"Derived Class Constructor With {text} string Parameter!", "Consturctor");
            }
            public new void GetClassName()
            {
                MessageBox.Show($"Derived Class Name: {nameof(BaseKeywordDerivedClass)}\n", "GetClassName() Method");
                base.GetClassName();
            }
        }
        #endregion

        #region Example Of Iteration Yield
        public string IterationMethod1()
        {
            return "Hello";
        }
        public IEnumerable IterationMethod2()
        {
            return "Hello";
        }
        /* IEnumerable interface implement edilse de geri dönüş değeri IEnumerable olmadıkça Iteration yapılamamaktadır.
        public string IterationMethod3()
        {
            yield return "Hello";
            yield return "Hola";
        }*/
        public IEnumerable IterationMethod4()
        {
            yield return "Hello";
            yield return "Hola";
            yield return "Merhaba";
        }
        public void IterationMainMethod()
        {
            foreach (var item in IterationMethod1())
                MessageBox.Show(item.ToString(), "IterationMethod1()");
            foreach (var item in IterationMethod2())
                MessageBox.Show(item.ToString(), "IterationMethod2()");
            foreach (var item in IterationMethod4())
                MessageBox.Show(item.ToString(), "IterationMethod4()");
        }
        #endregion

        #region Example Of Attributes
        /*Creating Attribute*/
        [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
        /*Burada attribute'ü sadece class'lar için kullanılabilir ve birden fazla aynı class için attribute atanabilir olarak ayarladık*/
        public class SampleAttribute : Attribute
        {
            public string Name { get; set; } /*Attribute özellikleri*/
            public string Version { get; set; }
            public string Url { get; set; }
        }
        [Sample]
        [Sample(Name = "Abdullah", Version = "1.0", Url = "https://www.pamblycompany.com")]
        /*Attribute class ismimiz SampleAttribute isminde olduğu gibi sonunda Attribute olduğu için tanımlarken sadece ekten önceki
        isim ile tanımlanabilmektedir.*/
        class AttributeClass1
        {
            [Obsolete("You can't use this method!", true)]
            /*Sadece metodlar için kullanılabilir olan bu etiket bu metodun kullanımını engellemek için yazılır. Eğer bu metod kullanılmaya
             çalışılır ise Visual Studio bir uyarı vererek Obsolete için verdiğimiz ilk string parametresinde yazan değeri yazar. Ayrıca
            ikinci parametre olarak true verirsek kullanımda hata verir false verirsek sadece uyarı verir.*/
            public static void Method1()
            {
                MessageBox.Show("This is Method1()", "Method1()");
            }

            [Obsolete("You can't use this method!", false)]
            public static void Method2()
            {
                MessageBox.Show("This is Method2()", "Method2()");
            }
            [Conditional("DefinedVariable1")]
            /*Eğer DefinedVariable1 define edilmiş ise methodun scope'ları arasındaki işlem çalışır. Aksi halde çalışmaz.*/
            public static void Method3()
            {
                MessageBox.Show("This is Method3()", "Method3()");
            }
            [Conditional("DefinedVariable2")]
            public static void Method4()
            {
                MessageBox.Show("This is Method4()", "Method4()");
            }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();

            #region Example Of Is Keyword Apply
            /*
            int variable = 5;
            NewNamespace.MainClass.WhatTypeIsThis(variable);
            */
            #endregion

            #region Example Of Nullable Variable's Properties Apply
            /*NewNamespace.MainClass.NullableVariableProperty(null);*/
            #endregion

            #region Example Of Nullable Variable's Method Apply
            /*NewNamespace.MainClass.NullableVariableMethod(null);*/
            #endregion

            #region Example Of Generating Unique Identity With GUID Apply
            /*NewNamespace.MainClass.GenerateUniqueId();*/
            #endregion

            #region Example Of Base Keyword Apply
            /*
            BaseKeywordDerivedClass instanceOfSample1 = new BaseKeywordDerivedClass(31);
            BaseKeywordDerivedClass instanceOfSample2 = new BaseKeywordDerivedClass("Lorem Ipsum");
            instanceOfSample1.GetClassName();
            */
            #endregion

            #region Example Of Iteration Yield Apply
            /*IterationMainMethod();*/
            #endregion

            #region Example Of Attributes Apply
            //AttributeClass1.Method1(); Derlenmiyor hata alıyoruz.
            /*AttributeClass1.Method2(); //Uyarı veriyor.
            AttributeClass1.Method3();
            AttributeClass1.Method4();*/ //Conditional parametresi define edilmediğinden scope'larına girilmiyor.
            #endregion

            #region Example Of Assembly
            /*
            Assembly assembly = Assembly.GetExecutingAssembly();
            assembly.GetTypes().ToList().ForEach(
                item =>
                {
                    listBox1.Items.Add(string.Format($"Name: {item.Name}"));
                    item.GetProperties().ToList().ForEach(
                        pItem =>
                        {
                            listBox2.Items.Add(string.Format($"Property Name: {item.Name}.{pItem.Name}"));
                        });
                    item.GetMethods().ToList().ForEach(
                        mItem =>
                        {
                            listBox3.Items.Add(string.Format($"Method Name: {item.Name}.{mItem.Name}"));
                        });
                });*/
            Assembly assembly = Assembly.GetExecutingAssembly();
            //GetTypes ile type[] dizisi elde ederken GetType ile belirli bir assembly için type elde edebilmekteyiz.
            assembly.GetType("NewNamespace.MainClass").GetMethods().ToList().ForEach(
                item => MessageBox.Show(item.Name, "NewNamespace.MainClass Methods")
                );
            //Ya da bu aldığımız metodları işletelim.
            var mainClassInstance = (NewNamespace.MainClass)Activator.CreateInstance(typeof(NewNamespace.MainClass));
            object[] value = { 5 }; //İki adet parametre alsaydı ikinci parameteyi de ikinci eleman olarak verecektik.
            typeof(NewNamespace.MainClass).GetMethod("WhatTypeIsThis").Invoke(mainClassInstance, value);
            //Ayrıca property veya field için de yapılabilir.
            var ins = (SettingPrivateField)Activator.CreateInstance(typeof(Extra.Form1.SettingPrivateField));
            MessageBox.Show(ins.GetField().ToString(), "Field's First Value");
            typeof(Extra.Form1.SettingPrivateField).GetField("field", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(ins, 45);
            MessageBox.Show(ins.GetField().ToString(), "Field's Setted With Reflection Value");
            #endregion

        }

        class SettingPrivateField
        {
            private int field = 5;
            public int GetField()
            {
                return field;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1920, 1080);
            this.WindowState = FormWindowState.Maximized;
            listBox1.Size = new Size((this.Width / 3) - 50, 1000);
            listBox2.Size = new Size((this.Width / 3) - 50, 1000);
            listBox2.Location = new Point((this.Width / 3), 20);
            listBox3.Size = new Size((this.Width / 3) - 50, 1000);
            listBox3.Location = new Point((this.Width / 3) * 2, 20);
            label1.Location = new Point(listBox1.Location.X + (listBox1.Size.Width / 2) - (label1.Size.Width / 2), 0);
            label2.Location = new Point(listBox2.Location.X + (listBox2.Size.Width / 2) - (label2.Size.Width / 2), 0);
            label3.Location = new Point(listBox3.Location.X + (listBox3.Size.Width / 2) - (label3.Size.Width / 2), 0);
        }
    }
}

#region Example Of Using IDisposable Interface
/*
using (Font myFont = new Font("Arial", 10.0f)
{

}
*/
#endregion

#region Example Of Alias
//using S = System; /*Artık System Library yerine S kullanarak kütüphane içerisideki nesnelere ulaşabiliriz. Örn; S.Console.WriteLine();*/
#endregion

#region Example Of Extern Alias
/*Tabiki burada VB kontrolleri kullanılamaz çünkü reference eklemesi yapmadık. Solition Explorer içerisinden Dependenicies yani bağımlılıklar kısmına
sağ tıklayarak Add Project Refernces veya Project menüsünden Add Project Refernces seçilerek VB dahil edilir ise kullanım mümkündür.*/
//using global::Microsoft.VisualBasic;
#endregion

#region Example Of Partial Class
/*Herhangi bir namespace olmadan da tanımlanabilirdi. Eğer o şekilde tanımlansaydı sınıfa tüm assembly üzerinden erişilebilirdi.*/
namespace NewNamespace
{
    public partial class InstanceClass
    {
        public int Prop { get; set; }
        public void Meth()
        {
            MessageBox.Show("First Meth Method!");
        }
    }
}

namespace NewNamespace
{
    public partial class InstanceClass
    {

    }
}
#endregion

#region Example Of Type Converting With As Keyword
namespace NewNamespace
{
    public partial class MainClass
    {
        public object testVariable;
        public void TestMethod()
        {
            InstanceClass instance = testVariable as InstanceClass;
            /*Görüldüğü üzere kendi sınıflarımız için de kullanılabilir. Buradaki InstanceClass sınıfı Partial örneğinden gelmektedir.*/
        }
    }
}
#endregion

#region Example Of Is Keyword
/*Object ile gönderilen bir parametrenin değişken tipini öğrenelim.*/
namespace NewNamespace
{
    public partial class MainClass
    {
        public static void WhatTypeIsThis(object variable)
        {
            if (variable is null)
                return; /*Void olduğu için hiçbir şey döndürmüyor sadece metodu sonlandırmak için return kullanıyoruz.*/
            else if (variable is int)
                MessageBox.Show("This Variable's Type Is Integer!", "Succesfully");
            else if (variable is double)
                MessageBox.Show("This Variable's Type Is Double!", "Succesfully");
            else if (variable is string)
                MessageBox.Show("This Variable's Type Is String!", "Succesfully");
        }
    }
}
#endregion

#region Example Of Nullable Variable's Properties
namespace NewNamespace
{
    public partial class MainClass
    {
        public static void NullableVariableProperty(int? nullableParameter)
        {
            MessageBox.Show($"Nullable Parameter's HasValue Property Value = {nullableParameter.HasValue}", "nullableParameter.HasValue");
            /* Hata fırlatacaktır. Çünkü metod çağrılırken null değeri verildi.
            MessageBox.Show($"Nullable Parameter's Value Property Value = {nullableParameter.Value}", "nullableParameter.Value");*/
            int? nullableVariable = 5;
            MessageBox.Show($"Nullable Variable's HasValue Property Value = {nullableVariable.HasValue}", "nullableParameter.HasValue");
            MessageBox.Show($"Nullable Variable's Value Property Value = {nullableVariable.Value}", "nullableParameter.Value");
            nullableVariable = null;
            MessageBox.Show($"Nullable Variable's HasValue Property Value = {nullableVariable.HasValue}", "nullableParameter.HasValue");
            string? nullableText = null;
            /*Aşağıdaki MessageBox.Show metodu için Bkz. (Null Conditional Operator)*/
            MessageBox.Show($"Nullable Variable's Lenght = {nullableText?.Length}", "Nullable Variable's Properties!");
            /* Hata fırlatacaktır. Çünkü nullableVariable değeri yoktur(null).
            MessageBox.Show($"Nullable Variable's Value Property Value = {nullableVariable.Value}", "nullableParameter.Value");*/
        }
    }
}
#endregion

#region Example Of Nullable Variable's Method
namespace NewNamespace
{
    public partial class MainClass
    {
        public static void NullableVariableMethod(int? nullableParameter)
        {
            MessageBox.Show($"GetValueOrDefault Method's Result = {nullableParameter.GetValueOrDefault(-1)}", "Succesfully!");
        }
    }
}
#endregion

#region Example Of Generating Unique Identity With GUID
namespace NewNamespace
{
    public partial class MainClass
    {
        public static void GenerateUniqueId()
        {
            string id = Guid.NewGuid().ToString();
            MessageBox.Show(id, "Unique Identity");
            /*Sonuç - karakterleri ile birlikte üretilir. Bunu string parametre vererek format bildirerek düzenleyebiliriz. */
        }
    }
}
#endregion