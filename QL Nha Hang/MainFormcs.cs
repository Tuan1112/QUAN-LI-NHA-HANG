using System;
using System.Drawing;
using System.Windows.Forms;

namespace QL_Nha_Hang
{
    public partial class MainFormcs : Form
    {
        private Form currentChildForm;

        public MainFormcs()
        {
            InitializeComponent();
        }

        // Phương thức mở Form con
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(childForm);
            this.pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Reset giao diện về mặc định với hình ảnh chào mừng
        private void ResetToMainContent()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // Đóng form con hiện tại
                currentChildForm = null;  // Reset form con
            }

            // Xóa toàn bộ nội dung trong panel (nếu có)
            pnlContent.Controls.Clear();

            // Hiển thị hình ảnh chào mừng
            PictureBox pbWelcomeImage = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = Properties.Resources.t5n95jeb, // Thay "welcome_image" bằng tên hình ảnh trong Resources
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            pnlContent.Controls.Add(pbWelcomeImage); // Thêm PictureBox vào panel
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            ResetToMainContent(); // Quay về giao diện mặc định với hình ảnh
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1()); // Hiển thị Form1
        }

        private void btnQuanLiBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyBanForm()); // Hiển thị Quản Lý Bàn
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maBan = 1; // Lấy mã bàn từ dữ liệu của bạn (ví dụ: ComboBox hoặc DataGridView)
            OpenChildForm(new ThanhToanForm(maBan)); // Hiển thị Form Thanh Toán với mã bàn
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeForm()); // Hiển thị Form Thống Kê
        }
    }
}
