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

        public NhanVien nv;

        public int STT;
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
            textBox_MaSo.Text = maso; textBox_MaSo.Enabled = false;
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
                            radioButton_Tester.Checked = true;
                            label_ThongTinRieng.Text = "Số lỗi";

                            break;
                        }
                    case "Designer":
                        {
                            radioButton_Designer.Checked = true;
                            label_ThongTinRieng.Text = "Tiền thưởng";

                            break;
                        }
                }

                textBox_ThongTinRieng.Text = thongtinrieng;
            }
        }

        private void button_XacNhanSua_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn sửa thông tin nhân viên chứ ???", "Thông báo", MessageBoxButtons.YesNo);

            if (dlr == DialogResult.Yes)
            {
                string masoMoi = textBox_MaSo.Text;
                string hotenMoi = textBox_HoTen.Text;
                string diachiMoi = textBox_DiaChi.Text;
                DateTime ngaysinhMoi = dateTimePicker_NgaySinh.Value;
                double hesoluongMoi = double.Parse(textBox_HeSoLuong.Text);
                double luongcobanMoi = double.Parse(textBox_LuongCoBan.Text);

                //Kiểm tra mã số trùng trong danh sách công ty -- true là có trùng, false là ko có trùng
                if (FormChinh.congty.kiemTraMaTrung(masoMoi) == true)
                {
                    if (masoMoi == maso)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên mới trùng với mã nhân viên trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                }

                //Chọn loại nhân viên
                if (radioButton_Programmer.Checked == true)
                {
                    double tienOTMoi = double.Parse(textBox_ThongTinRieng.Text);

                    nv = new Programmer(masoMoi, hotenMoi, ngaysinhMoi, diachiMoi, hesoluongMoi, luongcobanMoi, tienOTMoi);
                }
                else if (radioButton_Tester.Checked == true)
                {
                    double soloiMoi = double.Parse(textBox_ThongTinRieng.Text);

                    nv = new Tester(masoMoi, hotenMoi, ngaysinhMoi, diachiMoi, hesoluongMoi, luongcobanMoi, soloiMoi);
                }
                else if (radioButton_Designer.Checked == true)
                {
                    double tienthuongMoi = double.Parse(textBox_ThongTinRieng.Text);

                    nv = new Designer(masoMoi, hotenMoi, ngaysinhMoi, diachiMoi, hesoluongMoi, luongcobanMoi, tienthuongMoi);
                }
                else if (radioButton_Manager.Checked == true)
                {
                    nv = new Manager(masoMoi, hotenMoi, ngaysinhMoi, diachiMoi, hesoluongMoi, luongcobanMoi);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn loại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                FormChinh.congty.rePlace(STT - 1, nv); //Thay thế nhân viên vào vị trí STT - 1 trong danh sách công ty

                MessageBox.Show("\nCập nhật thành công nhân viên");

                FormChinh.check = true;

                this.Close();
            }
            else if (dlr == DialogResult.No)
            {
                MessageBox.Show("Sau nhớ nghĩ kĩ rồi hay chọn", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
