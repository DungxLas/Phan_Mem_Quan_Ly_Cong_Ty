using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace version_1_0_0
{
    internal class CongTy
    {
        private List<NhanVien> DanhSach = new List<NhanVien>();

        internal List<NhanVien> _DanhSach 
        { get => DanhSach; set => DanhSach = value; }

        public void SapXepTheoLuong(char PhanLoai)
        {

        }

        public void SapXepTheoTuoi(char PhanLoai)
        {

        }

        public bool kiemTraMaTrung(string ma)
        {
            int soLuongNhanVien = DanhSach.Count;

            for(int i = 0; i < soLuongNhanVien; i++)
            {
                if (DanhSach[i]._MaSo == ma)
                    return true;
            }

            return false;
        }
    }
}
