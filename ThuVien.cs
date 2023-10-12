using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test010
{
    class ThuVien
    {
        //khai bao

        private List<Sach> danhsachSach;

        // khoi tao
        public ThuVien()
        {
            danhsachSach = new List<Sach>();
        }

        //them sach
        public void ThemSach()
        {

            Console.WriteLine("==========> Them sach <============");
            Console.Write("Nhap so luong muon them : ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Sach sach = new Sach();
                sach.Nhap();
                danhsachSach.Add(sach);
            }
            Console.WriteLine("");
            Console.WriteLine("==========> Them sach thanh cong <============");
        }

       public void XoaSach(String maSach)
        {

            Sach Xoa = danhsachSach.Find(s=>s.MaSach == maSach);
            if ( Xoa != null )
            {
                danhsachSach.Remove(Xoa);
                Console.WriteLine("==========> Xoa sach thanh cong <============");
            } else
            {
                Console.WriteLine("==========> Sach khong ton tai <============");
            }
        }


        //hien thi danh sach sach

        public void DisplayListSach()
        {
            foreach(Sach sach in danhsachSach)
            {
                sach.Xuat();
            }
            Console.WriteLine("==================================================");
        }

    }
}
