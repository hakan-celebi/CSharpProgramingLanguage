using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Registry Procceses - Kayıt Defteri İşlemleri

#region Tanım
/*
    Registery, işletim sistemi ve bu işletim sistemi içerisinde yüklü olan programlar, kullanıcı bilgileri gibi bilgilerin tutulduğu
kayıt defteridir. Biz de geliştirdiğimiz programımız ile ilgili veya kullanıcılar ile ilgili kısa bilgileri saklamak istediğimizde
registery kullanacağız.
*/
#endregion

#region Registry Root/Main Keys - Kayıt Defteri Kök/Ana Anahtarlar
/*
    Registry içerisinde varsayılan olarak var olan HKEY_CLASSES_ROOT, HKEY_CURRENT_USER, HKEY_LOCAL_MACHINE, HKEY_USERS ve
HKEY_CURRENT_CONFIG olmak üzere 5 adet anahtar bulunur.
    # HKEY_CLASSES_ROOT: Windows işletim sistemi ve çalışan procces'ler ile ilgili bilgileri tutar.
    # HKEY_CURRENT_USER: Geçerli kullanıcı hakkındaki bilgileri ve geçerli ayarları saklar.
    # HKEY_LOCAL_MACHINE: Bilgisayarın konfigürasyon bilgileri saklanır.
    # HKEY_USERS: İşletim sisteminde var olan tüm kullanıcılar hakkında bilgileri ve geçerli ayarları saklar.
    # HKEY_CURRENT_CONGIG: Donanım bilgilerini saklar.
    Registry üzerinde işlem yapabilmek için "Microsoft.Win32" sınıfını projemize dahil etmemiz gerekmektedir. Ayrıca registery
işlemlerinde kullanacağımız keyleri "RegistryKey" sınıfından türetilmiş nesneler ile tanımlayacağız.
*/
#endregion

#region Accessing Registry Key & Registry Value - Registry Anahtarlarına & Registry Değerlerine Erişim
/*
    # Registry'deki anahtarlara erişebilmek için OpenSubKey() metodu kullanılır.
    # Registry'deki değerlere erişebilmek için GetValue() metodu kullanılır.
Not: Example Of Accessing Registery Key & Value region alanındaki örneği inceleyiniz. 
*/
#endregion

#region Adding Key & Value to Registry - Kayıt Defterine Anahtar ve Değer Ekleme
/*
    # Registry'e yeni bir anahtar oluşturmak için CreateSubKey metodu kullanılır.
    # Registry'e yeni bir değer eklemek için SetValue metodu kullanılır.
    Registry'e yeni bir değer eklerken değer türü yani "RegistryValueKind parametresi aşağıdaki değerleri alabilir. Bu değerler
registry'e ekleyebileceğimiz her türlü veri tipidir.
    #1. String: Katar/Dize Değeri.
    #2. Binary: İkilik Değer.
    #3. DWord: 32 bit Binary Değer.
    #4. MultiString: Çok Katar/Dizeli Değer.
    #4. QWord: 64 bit Binary Değer.
    #5. Unknow: Genişletilebilir Katar/Dize Değeri.
    Registry'e değer eklerken varsayılan keyler için iznimiz olmayabilir. Örneğin KHEY_LOCAL_MACHINE yönetici iznine ihtiyaç 
duyarken HKEY_CURRENT_USER hiç bir izne ihtiyaç duymaz.
NOT: Example Of Adding Key & Value to Registry region alanındaki örneği inceleyiniz.
*/
#endregion

#endregion

#region Homework - Ödev
/*
    1-)Registry Anahtar ve Değer sayısını bulma, Anahtar ve Değer listesini alma, Anahtar ve Değer silme ve RegistryKeyPermissionCheck
OpenSubKey metodundaki parametresinin alabileceği değerleri araştır.
*/
#endregion

namespace Ders_9_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region Example Of Accessing Registery Key & Value Apply
            /*RegisteryKeyAndValue();*/
            #endregion

            #region Example Of Adding Key & Value to Registry Apply
            /*AddingKeyAndValueToRegistry();*/
            #endregion
        }

        #region Example Of Accessing Registery Key & Value
        /*
            Internet Explorer versiyonunu kayıt defterinden çeken kodu yazıyoruz. Internet Explorer versiyonu kayıt defteri üzerinde
        HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer yolunda bulunur.
         */
        public void RegisteryKeyAndValue()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer", false);
                string value = key.GetValue("Version").ToString();
                MessageBox.Show(value, "Internet Explorer Version!");
            }
            catch
            {
                MessageBox.Show("Internet Explorer not Installed in this Computer!", "Warning!");
            }
        }
        #endregion

        #region Example Of Adding Key & Value to Registry
        /*
            HKEY_CURRENT_USER\Software key altına ExampleOfRegistry isminde yeni bir key oluşturarak, bu key içerisinde SomeValue
        isimli bir değer oluşturacağız.
        */
        public void AddingKeyAndValueToRegistry()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
                RegistryKey newKey = key.CreateSubKey("ExampleOfRegistry");
                newKey.SetValue("SomeValue", "978");
                MessageBox.Show("Registry Key & Value Successfully Created!", "Successful!");
            }
            catch
            {
                MessageBox.Show("Registry Key & Value Cant Created!", "Unsuccessful!");
            }
        }
        #endregion

    }
}
