using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; /*DllImport metodunu kullanmak için eklememiz lazım.*/
using System.Windows.Forms;

#region Accessing Operating System's Sources - İşletim Sistemi Kaynaklarına Erişim

#region Tanım
/*
    İşletim sistemlerinin yönetmekte olduğu işlemler ve görevlere işletim istemi kaynakları denilebilir. C# içerisinde işletim sistemleri kaynaklarına
erişim için Windows API ve WMI sınıfından yararlanılabilir. Bu sayede işletim sistemi dahilinde kullanılan metodlar ve özelliklere erişilebilir ve
projelerimize dahil edilebilir.
*/
#endregion

#region Windows API(Application Programing Interface) - Windows API(Uygulama Programlama Arayüzü)

#region Tanım
/*
    Windows API, Windows işletim sisteminin parçası olan Dll kütüphaneleridir. .NET ile yapmak istediğimiz işlemlere ait API'leri kullanabiliriz.
Ayrıca https://www.pinvoke.net adresinden hemen hemen tüm API'leri ve kullanımlarını bulabiliriz.
*/
#endregion

#region Importing DLL - DLL'i İçe Aktarma
/*
    C# projemize API'leri dahil etmek için DllImport() metodundan yararlanırız. Bu metodu kullanmak için de System.Runtime.InteropService sınıfını
projemize dahil etmemiz gerekmektedir.
*/
#endregion

#region Getting Informations Of Disk - Disk Bilgilerini Alma
/*
    Disk sürücüleri hakkında bilgi alabilmek için kernel.dll dosyasını kullanabiliriz. Disk boyutunu ve disk üzerindeki boş alan miktarını bulmak için
dll dosyasının GetDiskFreeSpaceEx(string DirectoryName, out ulong FreeByteAvailable, out ulong TotalNumberOfBytes, out ulong TotalNumberOfFreeBytes);
metodunu kullanmalıyız. Bu metod geriye boolean değer döndermektedir.
NOT: Example Of Getting Informations Of Disk Informations region alanındaki örneği inceleyiniz.
*/
#endregion

#region Getting Informations Of Microprocessor - Mikroişlemci Bilgilerini Alma
/*
    Disk bilgilerini alırken olduğu gibi mikroişlemci bilgilerini almak için kernel32.dll dosyasını kullanabiliriz. Bu dll dosyasının içerisinde
olan void GetSystemInfo([MarshalAs(UnmanagedType.Struct)] ref SYSTEM_INFO SystemInfo);
NOT: Example Of Getting Informations Of Microprocessor region alanındaki örneği niceleyiniz.
*/

#region SYSTEM_INFO
/*
    Bu metod ile birlikte kullanılan SYSTEM_INFO yapısı aşağıdaki şekildedir.
    public struct SYSTEM_INFO
    {
        internal _PROCESSOR_INFO_UNION uProcessorInfo;
        public uint dwPageSize; //Cache bellek boyutunu belirtir.
        public IntPtr lpMinimumApplicationAddress;
        public IntPtr lpMaximumApplicationAddress;
        public IntPtr dwActiveProcessorMask;
        public uint dwNumberOfProccessors; //İşlemci sayısını belirtir.
        public uint dwProcessorType; //İşlemci tipini belirtir.
        public uint dwAllocationGranularity;
        public ushort dwProcessorLevel;
        public ushort dwProcessorRevision;
    }
*/
#endregion

#region _PROCESSOR_INFO_UNION
/*
    Yine bu Metod ile birlikte kullanılan yani SYSTEM_INFO yapısı içerisinde bulunan _PROCESSOR_INFO_UNION yapısı aşağıdaki gibidir.
    public struct _PROCESSOR_INFO_UNION
    {
        [FieldOffset(0)]
        internal uint dwOemId;
        [FieldOffset(0)]
        internal ushort wProcessorArchitecture; //İşlemci türünü belirtir.
        [FieldOffset(2)]
        internal ushort wReserved;
    }
*/
#endregion

#endregion

#endregion

#endregion

namespace Ders_10_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        #region Example Of Getting Informations Of Disk
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetDiskFreeSpaceEx(string DirectoryName, out ulong FreeBytesAvailable, out ulong TotalNumberOfBytes,
            out ulong TotalNumberOfFreeBytes);
        public void DiskInformations()
        {
            ulong FreeBytesAvailable; ulong TotalNumberOfBytes; ulong TotalNumberOfFreeBytes;
            bool result = GetDiskFreeSpaceEx("C:", out FreeBytesAvailable, out TotalNumberOfBytes, out TotalNumberOfFreeBytes);
            if (result)
            {
                FreeBytesAvailable /= (1024 * 1024);
                TotalNumberOfFreeBytes /= (1024 * 1024);
                TotalNumberOfBytes /= (1024 * 1024);
                MessageBox.Show(string.Format($"Ulaşılan boş alan: {FreeBytesAvailable} MB\nToplam alan: {TotalNumberOfBytes} MB\nBoş alan:" +
                    $" {TotalNumberOfFreeBytes} MB"), "Disk Information");
            }
            else
                throw new System.ComponentModel.Win32Exception();
        }
        private void btnGetDiskInformation_Click(object sender, EventArgs e)
        {
            DiskInformations();
        }
        #endregion

        #region Example Of Getting Information Of Microprocessor
        [DllImport("kernel32.dll")]
        public static extern void GetSystemInfo([MarshalAs(UnmanagedType.Struct)] ref SYSTEM_INFO SystemInfo);
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO
        {
            internal _PROCESSOR_INFO_UNION uProcessorInfo;
            public uint dwPageSize; //Cache bellek boyutunu belirtir.
            public IntPtr lpMinimumApplicationAddress;
            public IntPtr lpMaximumApplicationAddress;
            public IntPtr dwActiveProcessorMask;
            public uint dwNumberOfProccessors; //İşlemci sayısını belirtir.
            public uint dwProcessorType; //İşlemci tipini belirtir.
            public uint dwAllocationGranularity;
            public ushort dwProcessorLevel;
            public ushort dwProcessorRevision;
        }
        [StructLayout(LayoutKind.Explicit)]
        public struct _PROCESSOR_INFO_UNION
        {
            [FieldOffset(0)]
            internal uint dwOemId;
            [FieldOffset(0)]
            internal ushort wProcessorArchitecture; //İşlemci türünü belirtir.
            [FieldOffset(2)]
            internal ushort wReserved;
        }
        public void MicroprocessorInformations()
        {
            SYSTEM_INFO SystemInfo = new SYSTEM_INFO();
            GetSystemInfo(ref SystemInfo);
            switch (SystemInfo.uProcessorInfo.wProcessorArchitecture)
            {
                case 0:
                    MessageBox.Show("Microprocessor Type: AMDx64", "Microprocessor Architecture!");
                    break;
                case 6:
                    MessageBox.Show("Microprocessor Type: Itaniumx64", "Microprocessor Architecture!");
                    break;
                case 9:
                    MessageBox.Show("Microprocessor Type: Intelx86", "Microprocessor Architecture!");
                    break;
                default:
                    MessageBox.Show("Microprocessor Type is Unknown!", "Failed!");
                    break;
            }
            MessageBox.Show(string.Format($"Microprocessor Core Count: {SystemInfo.dwNumberOfProccessors}"), "Microprocessor Core Count!");
            MessageBox.Show(string.Format($"Microprocessor Cache Memory Size: {SystemInfo.dwPageSize}"), "Microprocessor Cache Memory!");
        }
        private void btnGetMicroprocessorInformation_Click(object sender, EventArgs e)
        {
            MicroprocessorInformations();
        }
        #endregion
    }
}