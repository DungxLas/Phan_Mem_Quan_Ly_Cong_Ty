using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace version_1_0_0
{
    public partial class Form_ChinhSua : Form
    {
        public Form_ChinhSua()
        {
            InitializeComponent();
        }

        public string maso;
        public string hoten;
        public DateTime ngaysinh;
        public string diachi;
        public double hesoluong;
        public double luongcoban;
        public string chucvu;
        public string thongtinrieng;

        private void Form_ChinhSua_Load(object sender, EventArgs e)
        {
            textBox_MaSo.Text = maso;
            textBox_HoTen.Text = hoten;
            dateTimePicker_NgaySinh.Value = ngaysinh;
            textBox_DiaChi.Text = diachi;
            textBox_HeSoLuong.Text = hesoluong.ToString();
            textBox_LuongCoBan.Text = luongcoban.ToString();

            if (chucvu == "Manager")
            {
                radioButton_Manager.Checked = true;
            }
            else
            {
                groupBox_ThongTinRieng.Visible = true;

                switch (chucvu)
                {
                    case "Programmer":
                        {
                            radioButton_Programmer.Checked = true;
                            label_ThongTinRieng.Text = "Tiền ngoài giờ";

                            break;
                        }
                    case "Tester":
                        {
                            radioButton_Tester.Checked = true; break;
                            label_ThongTinRieng.Text = "Số lỗi";

                            break;
                        }
                    case "Designer":
                        {
                            radioButton_Designer.Checked = true; break;
                            label_ThongTinRieng.Text = "Tiền thưởng";

                            break;
                        }
                }

                textBox_ThongTinRieng.Text = thongtinrieng;
            }
        }
    }
}
