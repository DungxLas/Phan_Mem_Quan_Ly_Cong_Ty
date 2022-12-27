using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_1_0_0
{
    internal class Manager : NhanVien
    {
        public Manager() : base() { }

        public Manager(string ma, string hoTen, DateTime ngaySinh, string diaChi, double heSoLuong, double luongCoBan)
            : base(ma, hoTen, ngaySinh, diaChi, heSoLuong, luongCoBan) { }

        public Manager(Manager other)
            : base((NhanVien)other) { }

        public override double TinhLuong()
        {
            return base.TinhLuong();
        }

        public override List<string> xuatNhanVien()
        {
            List<string> arr = base.xuatNhanVien();
            arr.Add("Manager");
            arr.Add("Không có");

            return arr;
        }
    }
}
