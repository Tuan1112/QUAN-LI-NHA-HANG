namespace QL_Nha_Hang
{
    partial class QuanLyBanForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.btnThemban = new System.Windows.Forms.Button();
            this.btnXoaban = new System.Windows.Forms.Button();
            this.btnCapnhattrangthai = new System.Windows.Forms.Button();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblDanhSachBan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBan
            // 
            this.dgvBan.AllowUserToAddRows = false;
            this.dgvBan.AllowUserToDeleteRows = false;
            this.dgvBan.AllowUserToOrderColumns = true;
            this.dgvBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Location = new System.Drawing.Point(56, 75);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.ReadOnly = true;
            this.dgvBan.RowHeadersWidth = 51;
            this.dgvBan.RowTemplate.Height = 24;
            this.dgvBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBan.Size = new System.Drawing.Size(721, 475);
            this.dgvBan.TabIndex = 0;
            this.dgvBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_CellClick);
            // 
            // txtTenban
            // 
            this.txtTenban.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenban.Location = new System.Drawing.Point(802, 149);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(180, 30);
            this.txtTenban.TabIndex = 1;
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangthai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Items.AddRange(new object[] {
            "Trống",
            "Đang phục vụ",
            "Đã đặt"});
            this.cboTrangthai.Location = new System.Drawing.Point(802, 249);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(180, 31);
            this.cboTrangthai.TabIndex = 2;
            // 
            // btnThemban
            // 
            this.btnThemban.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemban.Location = new System.Drawing.Point(802, 331);
            this.btnThemban.Name = "btnThemban";
            this.btnThemban.Size = new System.Drawing.Size(180, 40);
            this.btnThemban.TabIndex = 3;
            this.btnThemban.Text = "Thêm Bàn";
            this.btnThemban.UseVisualStyleBackColor = true;
            this.btnThemban.Click += new System.EventHandler(this.btnThemban_Click);
            // 
            // btnXoaban
            // 
            this.btnXoaban.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaban.Location = new System.Drawing.Point(802, 396);
            this.btnXoaban.Name = "btnXoaban";
            this.btnXoaban.Size = new System.Drawing.Size(180, 40);
            this.btnXoaban.TabIndex = 4;
            this.btnXoaban.Text = "Xóa Bàn";
            this.btnXoaban.UseVisualStyleBackColor = true;
            this.btnXoaban.Click += new System.EventHandler(this.btnXoaban_Click);
            // 
            // btnCapnhattrangthai
            // 
            this.btnCapnhattrangthai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCapnhattrangthai.Location = new System.Drawing.Point(802, 463);
            this.btnCapnhattrangthai.Name = "btnCapnhattrangthai";
            this.btnCapnhattrangthai.Size = new System.Drawing.Size(188, 40);
            this.btnCapnhattrangthai.TabIndex = 5;
            this.btnCapnhattrangthai.Text = "Cập Nhật Trạng Thái";
            this.btnCapnhattrangthai.UseVisualStyleBackColor = true;
            this.btnCapnhattrangthai.Click += new System.EventHandler(this.btnCapnhattrangthai_Click);
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenBan.Location = new System.Drawing.Point(798, 112);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(77, 23);
            this.lblTenBan.TabIndex = 6;
            this.lblTenBan.Text = "Tên Bàn:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.Location = new System.Drawing.Point(798, 213);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(100, 23);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // lblDanhSachBan
            // 
            this.lblDanhSachBan.AutoSize = true;
            this.lblDanhSachBan.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachBan.Location = new System.Drawing.Point(438, 9);
            this.lblDanhSachBan.Name = "lblDanhSachBan";
            this.lblDanhSachBan.Size = new System.Drawing.Size(256, 46);
            this.lblDanhSachBan.TabIndex = 8;
            this.lblDanhSachBan.Text = "Danh Sách Bàn";
            // 
            // QuanLyBanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 586);
            this.Controls.Add(this.lblDanhSachBan);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblTenBan);
            this.Controls.Add(this.btnCapnhattrangthai);
            this.Controls.Add(this.btnXoaban);
            this.Controls.Add(this.btnThemban);
            this.Controls.Add(this.cboTrangthai);
            this.Controls.Add(this.txtTenban);
            this.Controls.Add(this.dgvBan);
            this.Name = "QuanLyBanForm";
            this.Text = "Quản Lý Bàn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.ComboBox cboTrangthai;
        private System.Windows.Forms.Button btnThemban;
        private System.Windows.Forms.Button btnXoaban;
        private System.Windows.Forms.Button btnCapnhattrangthai;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblDanhSachBan;
    }
}
