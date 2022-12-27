using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_1_0_0
{
    internal class Tester : NhanVien
    {
        private double SoLoi;

        public Tester() : base()
        {
            SoLoi = 0.0;
        }

        public Tester(string ma, string hoTen, DateTime ngaySinh, string diaChi, double heSoLuong, double luongCoBan, double soLoi) 
            : base(ma, hoTen, ngaySinh, diaChi, heSoLuong, luongCoBan)
        {
            SoLoi = soLoi;
        }

        public Tester(Tester other)
            : base((NhanVien)other)
        {
            SoLoi =other.SoLoi;
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + SoLoi * 100000;
        }

        public override List<string> xuatNhanVien()
        {
            List<string> arr = base.xuatNhanVien();
            arr.Add("Tester");
            arr.Add(SoLoi.ToString());

            return arr;
        }
    }
}
