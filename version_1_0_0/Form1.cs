namespace version_1_0_0
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

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

        
    }
}