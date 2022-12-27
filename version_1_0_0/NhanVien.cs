using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_1_0_0
{
    internal class NhanVien
    {
        protected string MaSo;
        protected string HoTen;
        protected string DiaChi;
        protected DateTime NgaySinh;
        protected double HeSoLuong;
        protected double LuongCoBan;

        public string _MaSo { get => MaSo; set => MaSo = value; }

        public NhanVien()
        {
            MaSo = "AAAA";
            HoTen = "BBBB";
            NgaySinh = DateTime.Now;
            DiaChi = "CCCC";
            HeSoLuong = 1.0;
            LuongCoBan = 1111.0;
        }

        public NhanVien(string maso, string hoTen, DateTime ngaySinh, string diaChi, double heSoLuong, double luongCoBan)
        {
            MaSo = maso;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            HeSoLuong = heSoLuong;
            LuongCoBan = luongCoBan;
        }

        public NhanVien(NhanVien other)
        {
            MaSo = other.MaSo;
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

        virtual public List<string> xuatNhanVien()
        {
            List<string> arr = new List<string>(); //Tạo 1 mảng để nạp dữ liệu vào mảng đó

            arr.Add(MaSo); //nạp maso vào mảng
            arr.Add(HoTen); //nạp hoten vào mảng
            arr.Add(DiaChi); //nạp diachi vào mảng
            arr.Add(NgaySinh.ToString()); //nạp ngaysinh vào mảng
            arr.Add(HeSoLuong.ToString()); //nạp hesoluong vào mảng
            arr.Add((LuongCoBan).ToString()); //nạp luongcoban vào mảng

            return arr;
        }
    }
}
