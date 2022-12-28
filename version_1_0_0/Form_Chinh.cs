namespace version_1_0_0
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        // khai báo biến toàn cục
        public static CongTy congty = new CongTy();
        NhanVien nv;
        public static bool check = false;

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
            string diachi = textBox_DiaChi.Text;
            DateTime ngaysinh = dateTimePicker_NgaySinh.Value;
            double hesoluong = double.Parse(textBox_HeSoLuong.Text);
            double luongcoban = double.Parse(textBox_LuongCoBan.Text);

            //Kiểm tra mã số trùng trong danh sách công ty -- true là có trùng, false là ko có trùng
            if (congty.kiemTraMaTrung(maso) == true)
            {
                MessageBox.Show("Mã nhân viên mới trùng với mã nhân viên trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //Chọn loại nhân viên
            if (radioButton_Programmer.Checked == true)
            {
                double tienOT = double.Parse(textBox_ThongTinRieng.Text);

                nv = new Programmer(maso, hoten, ngaysinh, diachi, hesoluong, luongcoban, tienOT);
            }
            else if (radioButton_Tester.Checked == true)
            {
                double soloi = double.Parse(textBox_ThongTinRieng.Text);

                nv = new Tester(maso, hoten, ngaysinh, diachi, hesoluong, luongcoban, soloi);
            }
            else if (radioButton_Designer.Checked == true)
            {
                double tienthuong = double.Parse(textBox_ThongTinRieng.Text);

                nv = new Designer(maso, hoten, ngaysinh, diachi, hesoluong, luongcoban, tienthuong);
            }
            else if (radioButton_Manager.Checked == true)
            {
                nv = new Manager(maso, hoten, ngaysinh, diachi, hesoluong, luongcoban);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn loại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            congty._DanhSach.Add(nv); //Thêm nhân viên vào danh sách công ty 

            List<string> arr = new List<string>(); //Tạo 1 mảng để nạp dữ liệu vào mảng đó

            arr = nv.xuatNhanVien(); //nạp dữ liệu vào mảng
            arr.Insert(0, (listView_DanhSachNhanVien.Items.Count + 1).ToString()); //Nạp STT cho mảng
            arr.Add(nv.TinhLuong().ToString()); //Nạp tiền lương nhân viên cho mảng
            ListViewItem item = new ListViewItem(arr.ToArray()); //Tạo 1 list item ứng với từng dữ liệu
            listView_DanhSachNhanVien.Items.Add(item); //Nạp list item vào listView

            MessageBox.Show("Thêm thành công nhân viên", "Thông báo", MessageBoxButtons.OK);
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if(listView_DanhSachNhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên muốn sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int STT = int.Parse(listView_DanhSachNhanVien.SelectedItems[0].SubItems[0].Text);
            string maso = listView_DanhSachNhanVien.SelectedItems[0].SubItems[1].Text;
            string hoten = listView_DanhSachNhanVien.SelectedItems[0].SubItems[2].Text;
            string diachi = listView_DanhSachNhanVien.SelectedItems[0].SubItems[3].Text;
            DateTime ngaysinh = DateTime.Parse(listView_DanhSachNhanVien.SelectedItems[0].SubItems[4].Text);
            double hesoluong = double.Parse(listView_DanhSachNhanVien.SelectedItems[0].SubItems[5].Text);
            double luongcoban = double.Parse(listView_DanhSachNhanVien.SelectedItems[0].SubItems[6].Text);
            string chucvu = listView_DanhSachNhanVien.SelectedItems[0].SubItems[7].Text;
            string thongtinrieng = listView_DanhSachNhanVien.SelectedItems[0].SubItems[8].Text;

            //Bước 1: Cập nhập dữ liệu từ form Chính sang form Chỉnh sửa
            Form_ChinhSua frm = new Form_ChinhSua();

            frm.STT = STT;
            frm.maso = maso;
            frm.hoten = hoten;
            frm.ngaysinh = ngaysinh;
            frm.diachi = diachi;
            frm.hesoluong = hesoluong;
            frm.luongcoban = luongcoban;
            frm.chucvu = chucvu;
            frm.thongtinrieng = thongtinrieng;

            frm.ShowDialog();

            //Bước 2: Nhận lại dữ liệu form Chỉnh sửa lại form Chính và cập nhập dữ liệu vào listView  
            if (check == true)
            {
                check = false;

                nv = frm.nv;

                List<string> arr = new List<string>(); //Tạo 1 mảng để nạp dữ liệu vào mảng đó

                arr = nv.xuatNhanVien(); //nạp dữ liệu vào mảng
                arr.Insert(0, STT.ToString()); //Nạp STT cho mảng
                arr.Add(nv.TinhLuong().ToString()); //Nạp tiền lương nhân viên cho mảng
                ListViewItem item = new ListViewItem(arr.ToArray()); //Tạo 1 list item ứng với từng dữ liệu
                listView_DanhSachNhanVien.Items.RemoveAt(STT - 1); //Xoá hàng nhân viên cũ
                listView_DanhSachNhanVien.Items.Insert(STT - 1, item); //Thay bằng hàng nhân viên mới
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (listView_DanhSachNhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên muốn xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn xoá nhân viên này chứ ???", "Thông báo", MessageBoxButtons.YesNo);

            if (dlr == DialogResult.Yes)
            {
                int STT = int.Parse(listView_DanhSachNhanVien.SelectedItems[0].SubItems[0].Text);

                congty._DanhSach.RemoveAt(STT - 1);

                listView_DanhSachNhanVien.Items.RemoveAt((STT - 1));
                int sohang = listView_DanhSachNhanVien.Items.Count;
                for(int i = STT - 1; i < sohang; i++)
                {
                    listView_DanhSachNhanVien.Items[i].SubItems[0].Text = (i + 1).ToString();
                }

                MessageBox.Show("Xoá thành công nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            else if (dlr == DialogResult.No)
            {
                MessageBox.Show("Sau nhớ nghĩ kĩ rồi hay chọn", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}