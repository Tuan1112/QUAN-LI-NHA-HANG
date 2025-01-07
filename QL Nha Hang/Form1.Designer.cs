namespace QL_Nha_Hang
{
    partial class Form1
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
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.btnDatmon = new System.Windows.Forms.Button();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.lvSelectedItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTongGia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboBan
            // 
            this.cboBan.FormattingEnabled = true;
            this.cboBan.Location = new System.Drawing.Point(926, 443);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(121, 24);
            this.cboBan.TabIndex = 10;
            // 
            // btnDatmon
            // 
            this.btnDatmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatmon.Location = new System.Drawing.Point(452, 443);
            this.btnDatmon.Name = "btnDatmon";
            this.btnDatmon.Size = new System.Drawing.Size(128, 53);
            this.btnDatmon.TabIndex = 8;
            this.btnDatmon.Text = "Đặt món";
            this.btnDatmon.Click += new System.EventHandler(this.btnDatmon_Click);
            // 
            // flpMenu
            // 
            this.flpMenu.AutoScroll = true;
            this.flpMenu.Location = new System.Drawing.Point(107, 16);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(483, 421);
            this.flpMenu.TabIndex = 11;
            // 
            // lvSelectedItems
            // 
            this.lvSelectedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSelectedItems.FullRowSelect = true;
            this.lvSelectedItems.GridLines = true;
            this.lvSelectedItems.HideSelection = false;
            this.lvSelectedItems.Location = new System.Drawing.Point(596, 0);
            this.lvSelectedItems.Name = "lvSelectedItems";
            this.lvSelectedItems.Size = new System.Drawing.Size(457, 437);
            this.lvSelectedItems.TabIndex = 12;
            this.lvSelectedItems.UseCompatibleStateImageBehavior = false;
            this.lvSelectedItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 100;
            // 
            // lblTongGia
            // 
            this.lblTongGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGia.Location = new System.Drawing.Point(586, 446);
            this.lblTongGia.Name = "lblTongGia";
            this.lblTongGia.Size = new System.Drawing.Size(334, 30);
            this.lblTongGia.TabIndex = 13;
            this.lblTongGia.Text = "Tổng giá: 0 VND";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 609);
            this.Controls.Add(this.lvSelectedItems);
            this.Controls.Add(this.lblTongGia);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.cboBan);
            this.Controls.Add(this.btnDatmon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.Button btnDatmon;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.ListView lvSelectedItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblTongGia; // Biến cho Label tổng giá
    }
}
