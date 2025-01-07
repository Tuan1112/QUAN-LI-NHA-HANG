namespace QL_Nha_Hang
{
    partial class ThongKeForm
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(50, 100);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(900, 350);
            this.dgvThongKe.TabIndex = 0;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKe.Location = new System.Drawing.Point(400, 20);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(261, 29);
            this.lblThongKe.TabIndex = 1;
            this.lblThongKe.Text = "Thống Kê Doanh Thu";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(185, 60);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(250, 22);
            this.dtpNgayBatDau.TabIndex = 2;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(600, 60);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(250, 22);
            this.dtpNgayKetThuc.TabIndex = 3;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(900, 60);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 30);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(50, 470);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(240, 25);
            this.lblTongDoanhThu.TabIndex = 5;
            this.lblTongDoanhThu.Text = "Tổng doanh thu: 0 VND";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(63, 63);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(116, 18);
            this.lblNgayBatDau.TabIndex = 6;
            this.lblNgayBatDau.Text = "Ngày Bắt Đầu:";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(471, 63);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(123, 18);
            this.lblNgayKetThuc.TabIndex = 7;
            this.lblNgayKetThuc.Text = "Ngày Kết Thúc:";
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 520);
            this.Controls.Add(this.lblNgayKetThuc);
            this.Controls.Add(this.lblNgayBatDau);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.lblThongKe);
            this.Controls.Add(this.dgvThongKe);
            this.Name = "ThongKeForm";
            this.Text = "Thống Kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
    }
}
