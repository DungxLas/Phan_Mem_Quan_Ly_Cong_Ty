using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_1_0_0
{
    internal class Programmer : NhanVien
    {
        private double TienOT;

        public Programmer() : base() 
        {
            TienOT= 0.0;
        }

        public Programmer(string ma, string hoTen, DateTime ngaySinh, string diaChi, double heSoLuong, double luongCoBan, double tienOT) 
            : base(ma, hoTen, ngaySinh, diaChi, heSoLuong, luongCoBan)
        {
            TienOT = tienOT;
        }

        public Programmer(Programmer other) 
            : base((NhanVien)other)
        {
            TienOT = other.TienOT;
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + TienOT;
        }
    }
}
