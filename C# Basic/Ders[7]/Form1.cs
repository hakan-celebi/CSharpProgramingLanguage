using System;
using System.Windows.Forms;
using System.ComponentModel;

#region Classes - Sınıflar

#region Tanım
/*
    C# Programlama Dili, Object Oriented Programing(Nesneye Dayalı Programlama) dilidir. Yani Class'lar kullanılarak bir nesne modeli
kurularak, daha düzenli daha anlaşılır ve verimli programlar yazılabilmektedir. Class'lar oluşturulması aşağıdaki şekildedir;
<access_modifiers><Class><class_name>
{

}
*/
#endregion

#region Whats We Will Learn Object Oriented Programing? - Nesneye Dayalı Programlamada Neler Öğreneceğiz?

#region Data Abstraction - Veri Soyutlama
/*
    Nesneyi gereksiz detaylardan soyutlamak olarak özetlenebilir. Örneğin detaylı bir program yazdığımızı ve bunun için tüm canlılardan
yararlandığımızı düşünelim. Canlı sınıfı ve bundan bazı özellikleri miras alan İnsan sınıfı ve hayvan sınıfı oluşturalım. İşimizi bu şekilde
modelledikten sonra bir iş yeri için de personel sınıfı oluşturalım. Bu personel sınıfı da İnsan sınıfından miras alarak oluşturulmalıdır.
Peki ya işimize yaramayan özellikler ne olacak? Abstraction da tam olarak bu işimize lazım olmayan verileri soyutlamak için kullanılacaktır.
*/
#endregion

#region Inheritance - Kalıtım
/*
    Abstraction kısmında da anlattığımız gibi, alt kavram üzerinde çalıştığımız zaman üst kavramlar vardır. Yani araç satan bir firmaya otomasyon
sistemi veya web sitesi gibi projeler yazdığımızı düşünelim. Yat, motor, araba vb. olarak değişiklik gösterecektir. Nesneye Dayalı Programlamanın
kurallarına göre önce Vehicle isminde bir sınıf oluşturmamız ve artından Yacth, Motorcycle, Car vb. olarak Vehicle sınıfından miras alan yani
araçların ortak özelliklerinin tanımlandığı ve extra olarak tanımlamaya gerek kalmadan diğer sınıflar arasında kalıtım yaparız. Anne-Baba => Evlat
örneği de açıklayabilir.
*/
#endregion

#region Polymorphism - Çok Biçimlilik
/*
    Inheritance yapılan birden fazla Class var olduğunu düşünelim. Hatta inheritance region alanındaki Vehicle main class'dan extend edilen diğer
Car, Yacth ve Motorcycle olmak üzere 3 class'ımız var olsun. Şimdi biz başka bir alana veya method'a bu araçları göndererek boyama işlemi yapmak
isteyelim. Her biri farklı class olduğundan ötürü farklı 3 adet method mu yazmamız gerekiyor? Eğer Polymorphism kullanıyorsak hayır. Şöyle ki; main
class olarak tanımlanan bir parametreye yani Vehicle vehicle; şeklinde tanımlanan parametreye biz Car veya Yacth vb. Inheritance alan class'ları
gönderebiliriz. Artık tek bir method ile çok biçimli işlem yapabiliriz.
*/
#endregion

#region Encapsulation - Kapsulleme
/*
    Bir personle sınıfı yazdığımızı ve verileri okuyan user sınıfı yazdığımızı düşünelim. Bazı kullanıcıların personellerin TC'leri gibi önemli
bilgilerini görmemesi veya değiştirmemesi gerekir. Bu durumlarda Encapsulation devreye girer. Property kullanarak fieldlara erişimi denetleyerek
private alanlara kontrollü erişim sağlamak olarak özetlenebilir.
*/
#endregion

#region Class Components - Sınıf Bileşenleri

#region Methods - Metotlar
/*
    Geçen derste anlatılan method'lar class'lar içerisinde tanımlanırlar. 
*/
#endregion

#region Fields - Alanlar
/*
    Class'lar içerisinde değer tipinde veya referans tipinde değer tutan yapılardır. Değişkenler olarak düşünülebilir. 
*/
#endregion

#region Properties - Özellikler
/*
    Field'lara erişimi kısıtlamak veya denetlemek için kullanılan yapılardır. Kendilerine ait iki adet get ve set olmak üzere method'ları vardır.
Bu method'lar isteğe bağlı kullanılabilir.
*/
#endregion

#region Constructor & Destructor Methods - Yapıcı & Yıkıcı Metotlar
/*
    Class'dan object üretildiği anda tetiklenen method'a Constructor, object'in memory'den silindiği anda yani object'in işlevini yitirdiği anda
son olarak işlem yapılmak isteniyorsa tanımlanan Destructor method'lar dır.
*/
#endregion

#region Events - Olaylar
/*
    Olaylar anlamına gelir. Bir olay karşısında tetiklenen method'lar sayesinde dynamic programing yapılabilmektedir. 
*/
#endregion

#region Delegates - Temsilciler
/*
    Method adreslerini tutan yapılardır. Geçen derste gördüğümüz yapılardır. 
*/
#endregion

#endregion

#endregion

#region Constructor Method - Yapıcı Metot
/*
    Class üzerinden bir nesne türetildiği anda tetiklenerek çalışan başlangıç metotlarıdır. Bu metodlar sınıf içerisinde oluşturulurlar ve
return value veya access modifiers belirtilmeden yazılırlar. İsteğe bağlı olarak birden fazla farklı parametre adetleri veya türleri alabilecek
Constructor tanımlanabilmektedir. Eğer sınıfı oluşturur ve Constructor method tanımlamaz isek default olarak parametresiz ve hiç bir işlem
yapmayan bir Consturctor tanımlanmaktadır. Örnek için Example Of Constructor and Destructor region alanına bakınız.
*/
#endregion

#region Destructor Method - Yıkıcı Metot
/*
    Parametresiz olarak nesne memory üzerinden silineceği zaman tetiklenerek çalışan method'dur. Sadece bir adet tanımlanabilir ve asla
parametre alamaz. ~class_name biçiminde isimlendirilmelidir.
*/
#endregion

#region Primary Constructors - Birincil Yapıcılar
/*
    Manuel olarak Class içerisindeki bir değişkene değer atmak için Constructor tanımlaması yapmamıza gerek yoktur. Class new anahtar kelimesi
ile türetilirken sınıf direkt olarak parametre alabilir ve bu parametreyi Class içerisindeki fields veya propertys için kullanılabilir.
public class PrimaryConsturctor(type parameter)
{
    type field = parameter;
}
    Yukarıdaki biçimde kullanılırlar.
*/
#endregion

#region Properties - Özellikler

#region Tanım
/*
    Sınıflar içerisinde properties değer almak veya okumak için kullanılırlar. Properties için get ve set olmak üzere değer almak ve okumak için
özel methodları vardır. Bu sayede property'ler güvenlik bakımından daha doğrudur. Genel olarak bir adet field tanımlanır ve bu field'a direkt
olarak ulaşmamak ve belirli şartlar için properties kullanılır.
*/
#endregion

#region Read Only Property - Salt Okunur Özellik
/*
    Property içindeki set method'u kaldırılarak property Read Only olarak tanımlanabilir. Bunun yanı sıra readonly anahtar kelimesi ile de
readonly property tanımlanabilirken, readonly olarak tanımlanan property değerlerini class içerisinden dahi değiştiremeyiz. Yani bir property
için class dışarısından değiştirilemez ama class içerisinden değiştirilebilir olmasını istiyorsak set method'u kaldırılır.
*/
#endregion

#region Write Only Property - Sadece Yazılabilir Özellik
/*
    Read Only Property tam tersi olarak get method'unu kaldırarak yapılır. Class dışarısından veri yazılabilir ama okunamaz. Fakat yine class
içerisinden veri okunabilmektedir.
*/
#endregion

#region Auto Property Initializers - Otomatik Özellik Tanımlama
/*
    Property'lere de field'lara olduğu gibi = ile tanımlama anında başlangıç değeri verilebilmektedir. Ayrıca sadece get; default method'u veya
set; default method'u tanımlayarak da default değer verilebilmektedir.
*/
#endregion

#region Details Of Get & Set methods - Get & Set Metodların Detayları
/*
    Eğer get ve set method'ları default halleriyle yani gövdesiz halleriyle kullanılıyorsa aynı zamanda field gibi davranırlar. Yani extra olarak
bir field'a gerek duymazlar. Değerler property içerisinde tutular veya okunur. Fakat get veya set methodlarından biri için bir gövde yazacak
olursak, diğer get veya set method'u için de gövde yazmamız gerekmektedir. Önceleri gövdeler {} parantezlerden oluşurken artık => operatörü
ile de gövde yazılabilmektedir.
    # Eğer Auto Property Initializers kullanılmak isteniyorsa property default get; set; method'larnna sahip olmalı.
    # Eğer set method'u için gövde kullanılması gerekiyorsa, property değer tutamaz field kullanımı zorunludur.
    # Eğer property{get; } = value; biçiminde Auto Property Initializer kullanmak istiyorsak bunun yerine property => value; property kullanabiliriz.
    # property => value; biçiminde tanımlanan property'lere class içerisinden de değer atanamaz. readonly olmaktadırlar.
*/
#endregion

#region INotifyPropertyChanged Interface
/*
    Property değiştiği anda PropertyChanged olayı tetiklenerek olay hakkında bilgi elde edilmek için kullanılır. Example Of INotifyPropertyChanged Interface
region alananıdaki örneği inceleyiniz.
*/
#endregion

#region Nameof
/*
    typeof vb. bir ifade olarak verilen parametrenin ismini(değişken, property, field, method vb.) dönderir. 
*/
#endregion

#endregion

#region Inheritence - Miras, Kalıtım
/*
    OOP(Object Oriented Programing)'nin temel unsurlarından biri olan Inheritence ':' operatörü ile miras alacak sınıfa miras verilecek sınıf ismi yazılarak
Inheritence yapılır(Extend Edilir).
*/
#endregion

#region Access Modifiers - Erişim Belirteçleri

#region Tanım
/*
    Oluşturduğumuz değişken, method, sturct, enum vb. elemanlar için bulunduğu bölge dışarısından erişimin olup olmayacağı veya özel erişimler olacağı
gibi seçenekleri belirlememizi sağlarlar.
*/
#endregion

#region Nelerdir?
/*
    #1. Public: İçeriden ve dışarıdan her alandan erişilebileceğini belirtir. Umimi/Genel olarak Türkçe'ye çevirilebilir.
    #2. Internal: Sadece bulunulan proje içerisinden yani derlenen dll veya exe içerisinden erişilebileceğini belirtir.
    #3. Protected: Sadece bulunulan sınıf ve bu sınıftan türetilmiş sınıflardan erişilebilir.
    #4. Static: Sınıf içerisindeki elemanlara direkt sınıf ismi kullanarak erişebilmemizi ayrıca static sınıflar için değişken olarak kullanabilmemizi
        sağlayan erişim belirtecidir.
    #5. Protected Internal: Türetilmiş tüm sınıflardan veya sadece bulunduğu proje içerisinden erişilebileceğini belirtir.
    #6. Private: Sadece bulunduğu sınıf veya block üzerinden erişilebileceğini belirtir.
    #7. Private Protected: Türetilmiş sınıf olsa dahi aynı namespace üzerinde değil ise erişilemeyeceğini belirtir.
*/
#endregion

#endregion

#region Encapsulation - Kapsülleme
/*
    Class içerisindeki field'a doğrudan erişimi engelleyerek, denetimsiz, yanlış veya istenmeyen değer atamalaraını önlemek için bir property tanımlayarak
belirtilen field'a bu property üzerinden erişilmesine Encapsulation denir. 
*/
#endregion

#region Method Overriding - Metot Ezme
/*
    Temel sınıf içerisindeki metodun türetilmiş sınıf için yetersiz kalması sonucu türetilmiş sınıf içerisinde bu metodu değiştirerek kullanılmasına Method
Overriding işlemi denir. Method Overriding işlemi temel sınıftaki metodu sanki yeni bir metod oluşturuyormuş gibi aynı parametre, ay
*/
#endregion

#region Polymorphism - Çok Biçimlilik
/*
    Temel sınıftan tanımladığımız bir nesneye türetilmiş sınıftan oluşturduğumuz nesneyi attığımız zaman sadece temel sınıftaki methodlar
kullanılabilmektedir. Dolayısıyla eğer türetilmiş sınıfta overriding işlemi yaparsak yine de temel sınıftaki metod çalışacaktır. Bunu önlemek/değiştirmek
için temel sınfıtaki metoda virtual anahtar kelimesi eklenerek "Eğer override edilirse bu metodu geçersiz kıl" seçeneğini seçeriz ve türetilmiş sınıfta da
override anahtar kelimesi ile temel sınıftaki virtual metodu ezerek bu durumlarda türetilmiş sınıftaki metodun kullanılmasını sağlarız.
*/
#endregion

#region Abstraction - Soyutlama                                                     
/*
    Miras vermek için oluşturulmuş sınflar olarak özetlenebilmektedir. Metodlar ve elemanlar da abstact olarak tanımlanabilmektedir. Fakat eğer class
abstract değil ise tanımlamak mümkün değildir. Ayrıca abstract sınıflar içerisinde de normal elemanlar barınabilmektedir.
*/
#endregion

#region Interface - Arayüz
/*
    C# içerisinde türetilmiş bir sınıf birden fazla sınftan miras alamaz. Bunun yerine interface kullanılarak türetilmiş sınıfa birden fazla özellik
ekleyebilmekteyiz. Interface kendisi abstract olmakla beraber içerisinde yazılan bütün her şey abstract olmaktadır. Metodların gövdeleri yazılmaz ve
abstract anahtar kelimesi eklenmesine gerek yoktur. Ayrıca abstract sınıflarda olduğu gibi interface içerisindeki metodlar da override edilmek zorundadır.
Override edilirken override veya new anahtar kelimelerinin kullanımına gerek yoktur.
*/
#endregion

#region Homework
/*
    1. XML Yorum Satırı eklemek ile ilgili araştırıp anlatınız. 
*/
#endregion

#endregion

namespace Ders_7_
{
    #region Example Of INotifyPropertyChanged Interface
    public class Info : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string name = string.Empty;
        private string surname = string.Empty;
        public string Name 
        {
            get => name; 
            set 
            { 
                if (name != value) 
                { 
                    name = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                } 
            } 
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (surname != value)
                {
                    surname = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Surname"));
                }
            }
        }

        public void PropertySet(string propertyName, string value)
        {
            switch (propertyName)
            {
                case nameof(Name):
                    if(name != value)
                    {
                        name = value;
                        if (PropertyChanged != null)
                            PropertyChanged(this, new PropertyChangedEventArgs(nameof(Name)));
                    }
                    break;
                case nameof(Surname):
                    if (surname != value)
                    {
                        surname = value;
                        if (PropertyChanged != null)
                            PropertyChanged(this, new PropertyChangedEventArgs(nameof(Surname)));
                    }
                    break;
                default:
                    break;
            }
        }
    }
    #endregion

    #region Example Of Inheritence
    public class Animals
    {
        public enum DirectionEnum
        {
            Left,
            Top,
            Right,
            Bottom
        }
        public struct LocationStructer
        {
            public float x;
            public float y;
        }
        private  bool canMove;
        private float velocity = 0;
        public float Velocity { get => velocity; set { if (value <= 35) { velocity = value; canMove = true; } else canMove = false; } }
        private DirectionEnum direction;
        public DirectionEnum Direction { get => direction; set { if (canMove) direction = value; } }
        private LocationStructer location = new LocationStructer();
        public LocationStructer Location { get => location; }
        public void Move(float v, DirectionEnum direction)
        {
            Velocity = v;
            Direction = direction;
            ChangeLocation();
        }
        private void ChangeLocation()
        {
            if (canMove)
            {
                switch (Direction)
                {
                    case DirectionEnum.Left:
                        location.x -= Velocity;
                        break;
                    case DirectionEnum.Top:
                        location.y += Velocity;
                        break;
                    case DirectionEnum.Right:
                        location.x += Velocity;
                        break;
                    case DirectionEnum.Bottom:
                        location.y -= Velocity;
                        break;
                    default:
                        break;
                }
            }
        }
        public void GetLocationInformation()
        {
            MessageBox.Show(string.Format($"Abdullah x: {this.Location.x}, y: {this.Location.y} konumundadır."), "Abdullah konum.exe");
        }
    }

    public class Human : Animals
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    #endregion

    #region Example Of Encapsulation
    public class Encapsulation
    {
        private string text;
        public string Text { get => text; set => text = value; }
    }
    #endregion

    #region Example Of Overriding
    public class OverridingBasicClass
    {
        public void SaySomething(string text, string number)
        {
            MessageBox.Show(text, number);
        }
    }
    public class OverridingExtendClass : OverridingBasicClass
    {
        public new void SaySomething(string text, string number)
        {
            
        }
    }
    #endregion

    #region Example Of Polymorphism
    public class PolymorphismBaseClass
    {
        public PolymorphismBaseClass()
        {
            MessageBox.Show("This is PolymorphismBaseClass!");
        }
        public virtual void Message(string text, string title)
        {
            MessageBox.Show(text, title);
        }
    }
    public class PolymorphismDerivedClass : PolymorphismBaseClass
    {
        public PolymorphismDerivedClass()
        {
            MessageBox.Show("This is PolymorphismDerivedClass!");
        }
        public override void Message(string text, string title)
        {
            MessageBox.Show(text.ToUpper(), title);
        }
    }
    public class PolymorphismDerivedClass2 : PolymorphismDerivedClass
    {
        public PolymorphismDerivedClass2()
        {
            MessageBox.Show("This is PolymorphismDerivedClass2!");
        }
        public override void Message(string text, string title)
        {
            MessageBox.Show(text.ToUpper(), title.ToUpper());
        }
    }
    #endregion

    #region Example Of Abstraction
    public abstract class AbstractBaseClass
    {
        public AbstractBaseClass()
        {
            MessageBox.Show("This is AbstractBaseClass's Constructor!");
        }
        public abstract void SaySomething();
    }
    public class AbstractDerivedClass1 : AbstractBaseClass
    {
        public AbstractDerivedClass1()
        {
            MessageBox.Show("This is AbstractDerivedClass1's Constructor!");
        }
        
        public override void SaySomething()
        {
            MessageBox.Show("Abdullah!", "Hello!");
        }
    }
    public class AbstractDerivedClass2 : AbstractDerivedClass1
    {
        public AbstractDerivedClass2()
        {
            MessageBox.Show("This is AbstractDerivedClass2's Constructor!");
        }
    }
    #endregion

    #region Example Of Interface
    public interface IKdv
    {
        public double Earning { get; set; }
        public double Expense { get; set; }
        public double BeforeTax { get; set; }
        public double NetMoney { get; set; }
        public void CalculateNetMoneyWithKdv();

    }
    public interface INonKdv
    {
        public double Earning { get; set; }
        public double Expense { get; set; }
        public double NetMoney { get; set; }
        public void CalculateNetMoneyNonWithKdv();
    }

    public class InterfaceDerivedClass : IKdv, INonKdv
    {
        public double Earning { get; set; }
        public double Expense { get; set; }
        public double BeforeTax { get; set; }
        public double NetMoney { get; set; }
        public void CalculateNetMoneyWithKdv()
        {
            BeforeTax = Earning - Expense;
            NetMoney = BeforeTax - (BeforeTax * 0.18);
        }
        public void CalculateNetMoneyNonWithKdv()
        {
            NetMoney = BeforeTax = Earning - Expense;
        }
    }
    #endregion

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Example Of Constructor & Destructor Methods Apply
            /*Car porche = new Car();
            porche.Number = 8;
            this.Text = porche.Number.ToString();*/
            #endregion

            #region Example Of INotifyPropertyChanged Interface Apply
            /*Info info = new Info() { Name = "Abdullah", Surname = "ALTUNKAYNAK" };
            info.PropertyChanged += (sender, arg) => MessageBox.Show(string.Format($"{arg.PropertyName}"), "Information");
            info.Name = "Zeynep";
            info.PropertySet(nameof(Name), "Abdullah");*/
            #endregion

            #region Example Of Inheritence Apply
            /*Human abdullah = new Human() { Name = "Abdullah", Surname = "ALTUNKAYNAK"};
            abdullah.Move(30.8f, Animals.DirectionEnum.Top);
            abdullah.GetLocationInformation();
            abdullah.Move(40f, Animals.DirectionEnum.Left);
            abdullah.GetLocationInformation();*/
            #endregion

            #region Example Of Polymorphism Apply
            /*PolymorphismBaseClass derived = new PolymorphismDerivedClass2();
            derived.Message("Abdullah niyaban!", "MessageBox");*/
            #endregion

            #region Example Of Abstraction Apply
            /*AbstractDerivedClass2 ob = new AbstractDerivedClass2();
            ob.SaySomething();*/
            #endregion

            #region Example Of Interface Apply
            InterfaceDerivedClass person = new InterfaceDerivedClass();
            person.Earning = 22345.98;
            person.Expense = 8350.50;
            person.CalculateNetMoneyWithKdv();
            MessageBox.Show(string.Format($"{person.NetMoney} TL"), "Net Money With KDV");
            person.CalculateNetMoneyNonWithKdv();
            MessageBox.Show(string.Format($"{person.NetMoney} TL"), "Net Money Non With KDV");
            #endregion
        }
    }

    #region Example Of Constructor & Destructor Methods
    public class Car
    {
        public int Number { get => 4; set => text = value.ToString(); }/*Property*/
        public string text; /*Field*/
        public Car()/*Default Constructor Method*/
        {
            MessageBox.Show("Object Generated!");
        }

        public Car(int number)
        {
            this.Number = number;
        }

        public Car(string text)
        {
            this.text = text;
        }

        public Car(int number, string text)
        {
            this.Number = number; this.text = text;
        }
        public Car(Form frm, string text)
        {
            frm.Text = text;
        }

        ~Car() /*Destructor Method*/
        {
            MessageBox.Show("Object Destroyed!");
        }

    }
    #endregion
}

