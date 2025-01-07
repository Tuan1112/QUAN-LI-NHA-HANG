namespace QL_Nha_Hang
{
    partial class ThanhToanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMonan = new System.Windows.Forms.DataGridView();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.cboNhanvien = new System.Windows.Forms.ComboBox();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.dtpNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayThanhToan = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblBan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonan
            // 
            this.dgvMonan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonan.Location = new System.Drawing.Point(30, 30);
            this.dgvMonan.Name = "dgvMonan";
            this.dgvMonan.RowHeadersWidth = 51;
            this.dgvMonan.RowTemplate.Height = 24;
            this.dgvMonan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonan.Size = new System.Drawing.Size(500, 300);
            this.dgvMonan.TabIndex = 0;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(30, 350);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(150, 22);
            this.txtTongtien.TabIndex = 1;
            // 
            // cboNhanvien
            // 
            this.cboNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanvien.Location = new System.Drawing.Point(210, 350);
            this.cboNhanvien.Name = "cboNhanvien";
            this.cboNhanvien.Size = new System.Drawing.Size(150, 24);
            this.cboNhanvien.TabIndex = 2;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Location = new System.Drawing.Point(600, 180);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(150, 50);
            this.btnThanhtoan.TabIndex = 3;
            this.btnThanhtoan.Text = "Thanh Toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(600, 250);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(150, 50);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cboBan
            // 
            this.cboBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBan.Location = new System.Drawing.Point(390, 350);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(140, 24);
            this.cboBan.TabIndex = 5;
            this.cboBan.SelectedIndexChanged += new System.EventHandler(this.cboBan_SelectedIndexChanged);
            // 
            // dtpNgayThanhToan
            // 
            this.dtpNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThanhToan.Location = new System.Drawing.Point(600, 100);
            this.dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            this.dtpNgayThanhToan.Size = new System.Drawing.Size(150, 22);
            this.dtpNgayThanhToan.TabIndex = 6;
            // 
            // lblNgayThanhToan
            // 
            this.lblNgayThanhToan.AutoSize = true;
            this.lblNgayThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThanhToan.Location = new System.Drawing.Point(597, 79);
            this.lblNgayThanhToan.Name = "lblNgayThanhToan";
            this.lblNgayThanhToan.Size = new System.Drawing.Size(145, 18);
            this.lblNgayThanhToan.TabIndex = 7;
            this.lblNgayThanhToan.Text = "Ngày Thanh Toán:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(30, 330);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(88, 18);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(210, 330);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(89, 18);
            this.lblNhanVien.TabIndex = 9;
            this.lblNhanVien.Text = "Nhân Viên:";
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBan.Location = new System.Drawing.Point(390, 330);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(42, 18);
            this.lblBan.TabIndex = 10;
            this.lblBan.Text = "Bàn:";
            // 
            // ThanhToanForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBan);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblNgayThanhToan);
            this.Controls.Add(this.dtpNgayThanhToan);
            this.Controls.Add(this.cboBan);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.cboNhanvien);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.dgvMonan);
            this.Name = "ThanhToanForm";
            this.Text = "Thanh Toán";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonan;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.ComboBox cboNhanvien;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhToan;
        private System.Windows.Forms.Label lblNgayThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblBan;
    }
}
