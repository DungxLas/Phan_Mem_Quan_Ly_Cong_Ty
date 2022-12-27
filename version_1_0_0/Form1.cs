namespace version_1_0_0
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        // khai báo biến toàn cục
        CongTy congty = new CongTy();
        NhanVien nv;

        private void FormChinh_Load(object sender, EventArgs e)
        {
            listView_DanhSachNhanVien.Columns.Add("STT", 50);
            listView_DanhSachNhanVien.Columns.Add("Mã số", 140);
            listView_DanhSachNhanVien.Columns.Add("Họ tên", 140);
            listView_DanhSachNhanVien.Columns.Add("Địa chỉ", 140);
            listView_DanhSachNhanVien.Columns.Add("Ngày sinh", 140);
            listView_DanhSachNhanVien.Columns.Add("HSL", 50);
            listView_DanhSachNhanVien.Columns.Add("Lương cơ bản", 140);
            listView_DanhSachNhanVien.Columns.Add("Chức vụ", 140);
            listView_DanhSachNhanVien.Columns.Add("Thông tin riêng", 140);
            listView_DanhSachNhanVien.Columns.Add("Tiền lương", 140);
        }

        private void radioButton_Programmer_Click(object sender, EventArgs e)
        {
            groupBox_ThongTinRieng.Visible = true;

            label_ThongTinRieng.Text = "Tiền ngoài giờ";
        }

        private void radioButton_Tester_Click(object sender, EventArgs e)
        {
            groupBox_ThongTinRieng.Visible = true;

            label_ThongTinRieng.Text = "Số lỗi";
        }

        private void radioButton_Designer_Click(object sender, EventArgs e)
        {
            groupBox_ThongTinRieng.Visible = true;

            label_ThongTinRieng.Text = "Tiền thưởng";
        }

        private void radioButton_Manager_Click(object sender, EventArgs e)
        {
            groupBox_ThongTinRieng.Visible = false;
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string maso = textBox_MaSo.Text;
            string hoten = textBox_HoTen.Text;
            DateTime ngaysinh = dateTimePicker_NgaySinh.Value;
            string diachi = textBox_DiaChi.Text;
            double hesoluong = double.Parse(textBox_HeSoLuong.Text);
            double luongcoban = double.Parse(textBox_LuongCoBan.Text);

            if (radioButton_Programmer.Checked == true)
            {
                double tienOT = double.Parse(textBox_ThongTinRieng.Text);

                nv = new Programmer(maso, hoten, ngaysinh, diachi, hesoluong, luongcoban, tienOT);

                congty._DanhSach.Add(nv);
            }
            else if (radioButton_Tester.Checked == true)
            {
                double soloi = double.Parse(textBox_ThongTinRieng.Text);

                nv = new Tester(maso, hoten, ngaysinh, diachi, hesoluong, luongcoban, soloi);

                congty._DanhSach.Add(nv);
            }
            else if (radioButton_Designer.Checked == true)
            {
                double tienthuong = double.Parse(textBox_ThongTinRieng.Text);

                nv = new Designer(maso, hoten, ngaysinh, diachi, hesoluong, luongcoban, tienthuong);

                congty._DanhSach.Add(nv);
            }
            else if (radioButton_Manager.Checked == true)
            {
                nv = new Manager(maso, hoten, ngaysinh, diachi, hesoluong, luongcoban);

                congty._DanhSach.Add(nv);
            }

            List<string> arr = new List<string>(); //Tạo 1 mảng để nạp dữ liệu vào mảng đó

            arr = nv.xuatNhanVien(); //nạp dữ liệu vào mảng
            arr.Insert(0, (listView_DanhSachNhanVien.Items.Count + 1).ToString()); //Nạp STT cho mảng
            arr.Add(nv.TinhLuong().ToString()); //Nạp tiền lương nhân viên cho mảng
            ListViewItem item = new ListViewItem(arr.ToArray()); //Tạo 1 list item ứng với từng dữ liệu
            listView_DanhSachNhanVien.Items.Add(item); //Nạp list item vào listView
        }
    }
}