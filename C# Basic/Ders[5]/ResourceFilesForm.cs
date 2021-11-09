using System.Windows.Forms;

#region Resource Files - Kaynak Dosyaları

#region Tanım
/*
    .Net içerisinde resim, müzik, video gibi medya dosyalarını haricen projemize eklemek için "Resource Files" kullanılır. Resource Files
içerisine iki yöntem ile dosya ekleyebiliriz.
*/

#region First Definition Way - Local Resource
/*
     Birinci yöntem, "Local Resource" olarak eklemektir. Form veya form üzerindeki PictureBox gibi ir resim kontrolüne resim yüklemek
istediğimizde karşımıza çıkan Select Resource penceresi üzerinden Local Resource seçeneğini işaretleyerek medya import edilebilmektedir.
Fakat Local Resource yapılan medyaları kullanabilmek için programın çalıştırılacağı bilgisayara da bu medyaları taşımamız gerekmektedir.
*/
#endregion

#region Second Definition Way - Using .resx File
/*
    İkinci yöntem, .resx uzantılı dosya ile yapılabilmektedir. Bu yöntemde kullandığımız .resx uzantılı dosya proje klasörümüze kayıt olduğu
için taşımaya gerek kalmadan her halukarda medya kullanılabilmektedir. .resx file Project/Add New Item seçeneği ile eklenebilmektedir.
    Açılan .resx file üzerinden hangi medyanın (string, image, audio vb..) gösterilmesi/işlenmesini istiyorsak o seçilebilmektedir. Ayrıca
Visual Studio IDE ile birlikte basit olarak boyama ve çizim yapılabilmektedir.
*/
#endregion

#endregion

#region Resource File Processes - Kaynak Dosyası İşlemleri
/*
    System.Resource sınıfını kullanarak Resource Files üzerinde işlem yapabilmekteyiz. Ayrıca Assembly nesnesine erişebilmek için
System.Reflection sınıfın projemize dahil etmemiz gerekmektedir. Bu işlemler ile birlikte aynı veritabanında olduğu gibi; veri okuma, yazma, 
silme vb. işlemler gerçekleştirilebilmektedir.
*/
#endregion

#endregion

namespace Ders_5_
{
    public partial class ResourceFilesForm : Form
    {
        public ResourceFilesForm()
        {
            InitializeComponent();
        }
    }
}
