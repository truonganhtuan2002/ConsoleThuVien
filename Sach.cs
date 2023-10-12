using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test010
{
    public class Sach
    {

        private String MaSach { get; set; } 
        private String TenSach { get; set; }
        private String TacGia { get; set; }

        public Sach()
        {

        }

        public Sach(String maSach,String tenSach,String tacGia)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
        }
        
        public void Nhap()
        {
            Console.Write("Nhap ma Sach : ");MaSach = Console.ReadLine();
            Console.Write("Nhap ten Sach : ");TenSach = Console.ReadLine();
            Console.Write("Nhap ten Tac Gia : "); TacGia = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("    " + MaSach + "        " + TenSach + "          " + TacGia + "      ");
        }


    }
}
