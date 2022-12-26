namespace version_1_0_0
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
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