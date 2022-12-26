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
            Ma = string.Empty;
        }
    }
}
