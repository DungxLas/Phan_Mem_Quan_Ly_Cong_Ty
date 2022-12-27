using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_1_0_0
{
    internal class Designer : NhanVien
    {
        private double TienThuong;

        public Designer() : base()
        {
            TienThuong = 0.0;
        }

        public Designer(string ma, string hoTen, DateTime ngaySinh, string diaChi, double heSoLuong, double luongCoBan, double tienThuong) 
            : base(ma, hoTen, ngaySinh, diaChi, heSoLuong, luongCoBan) 
        { 
            TienThuong = tienThuong; 
        }

        public Designer(Designer other)
            : base((NhanVien)other)
        {
            TienThuong = other.TienThuong;
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + TienThuong;
        }
    }
}
