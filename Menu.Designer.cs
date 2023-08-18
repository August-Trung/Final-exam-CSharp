namespace Nhom_1_BaiThiCuoiKy
{
    partial class FormMenu
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
            this.cbofoodanddrinkFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSpecialities = new System.Windows.Forms.ListBox();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnDatMon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.cbofoodanddrink = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbofoodanddrinkFilter
            // 
            this.cbofoodanddrinkFilter.FormattingEnabled = true;
            this.cbofoodanddrinkFilter.Location = new System.Drawing.Point(87, 9);
            this.cbofoodanddrinkFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbofoodanddrinkFilter.Name = "cbofoodanddrinkFilter";
            this.cbofoodanddrinkFilter.Size = new System.Drawing.Size(133, 23);
            this.cbofoodanddrinkFilter.TabIndex = 0;
            this.cbofoodanddrinkFilter.SelectedIndexChanged += new System.EventHandler(this.cbofoodanddrinkFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn loại";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstSpecialities
            // 
            this.lstSpecialities.FormattingEnabled = true;
            this.lstSpecialities.ItemHeight = 15;
            this.lstSpecialities.Location = new System.Drawing.Point(10, 34);
            this.lstSpecialities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstSpecialities.Name = "lstSpecialities";
            this.lstSpecialities.Size = new System.Drawing.Size(263, 304);
            this.lstSpecialities.TabIndex = 2;
            this.lstSpecialities.SelectedIndexChanged += new System.EventHandler(this.lstSpecialities_SelectedIndexChanged);
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(297, 35);
            this.picFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(337, 168);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFood.TabIndex = 3;
            this.picFood.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.btnDatMon);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.cbofoodanddrink);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(297, 207);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(407, 271);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Enabled = false;
            this.txtGiaTien.Location = new System.Drawing.Point(89, 119);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(122, 23);
            this.txtGiaTien.TabIndex = 7;
            // 
            // btnDatMon
            // 
            this.btnDatMon.Location = new System.Drawing.Point(89, 199);
            this.btnDatMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(82, 22);
            this.btnDatMon.TabIndex = 6;
            this.btnDatMon.Text = "Đặt món";
            this.btnDatMon.UseVisualStyleBackColor = true;
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(224, 199);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 22);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(89, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtKey
            // 
            this.txtKey.Enabled = false;
            this.txtKey.Location = new System.Drawing.Point(89, 25);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(87, 23);
            this.txtKey.TabIndex = 1;
            // 
            // cbofoodanddrink
            // 
            this.cbofoodanddrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbofoodanddrink.Enabled = false;
            this.cbofoodanddrink.FormattingEnabled = true;
            this.cbofoodanddrink.Location = new System.Drawing.Point(89, 160);
            this.cbofoodanddrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbofoodanddrink.Name = "cbofoodanddrink";
            this.cbofoodanddrink.Size = new System.Drawing.Size(122, 23);
            this.cbofoodanddrink.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thuộc loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã:";
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(87, 366);
            this.btnCapNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(88, 22);
            this.btnCapNhap.TabIndex = 2;
            this.btnCapNhap.Text = "Cập nhật";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(465, 480);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 22);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 513);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.lstSpecialities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbofoodanddrinkFilter);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbofoodanddrinkFilter;
        private Label label1;
        private ListBox lstSpecialities;
        private PictureBox picFood;
        private GroupBox groupBox1;
        private TextBox txtName;
        private TextBox txtKey;
        private ComboBox cbofoodanddrink;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnXoa;
        private Button btnCapNhap;
        private Button btnThoat;
        private Button btnDatMon;
        private TextBox txtGiaTien;
        private Label label5;
    }
}