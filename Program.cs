using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test010
{
    class Program
    {
        static void Main(string[] args)
        {
            ThuVien tv = new ThuVien();
            Sach s = new Sach();
            tv.ThemSach();
            Console.WriteLine("=======> Danh sach sau khi them<======");
            Console.WriteLine("   MaSach    |    TenSach   |   TacGia  ");
            tv.DisplayListSach();
            Console.WriteLine("==============================================");

            Console.Write("Nhap ma sach muon xoa : ");String ms = Console.ReadLine();
            tv.XoaSach(ms);
            Console.WriteLine("=======> Danh sach sau khi xoa<======");
            Console.WriteLine("   MaSach    |    TenSach   |   TacGia  ");
            tv.DisplayListSach();

            Console.WriteLine("==============================================");
            Console.WriteLine("   MaSach    |    TenSach   |   TacGia  ");
            tv.DisplayListSach();
            Console.ReadKey();
        }
    }
}
