using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_1_0_0
{
    internal class NhanVien
    {
        protected string Ma;
        protected string HoTen;
        protected DateTime NgaySinh;
        protected string DiaChi;
        protected double HeSoLuong;
        protected double LuongCoBan;

        public NhanVien()
        {
            Ma = "AAAA";
            HoTen = "BBBB";
            NgaySinh = DateTime.Now;
            DiaChi = "CCCC";
            HeSoLuong = 1.0;
            LuongCoBan = 1111.0;
        }

        public NhanVien(string ma, string hoTen, DateTime ngaySinh, string diaChi, double heSoLuong, double luongCoBan)
        {
            Ma = ma;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            HeSoLuong = heSoLuong;
            LuongCoBan = luongCoBan;
        }

        public NhanVien(NhanVien other)
        {
            Ma = other.Ma;
            HoTen = other.HoTen;
            NgaySinh = other.NgaySinh;
            DiaChi = other.DiaChi;
            HeSoLuong = other.HeSoLuong;
            LuongCoBan = other.LuongCoBan;
        }

        public virtual double TinhLuong()
        {
            return LuongCoBan * HeSoLuong;
        }
    }
}
