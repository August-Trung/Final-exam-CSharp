namespace Nhom_1_BaiThiCuoiKy
{
    partial class FormTTKH
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
            this.cbGioiTinhKH = new System.Windows.Forms.ComboBox();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colSDTKH = new System.Windows.Forms.ColumnHeader();
            this.colDiaChiKH = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinhKH = new System.Windows.Forms.ColumnHeader();
            this.colHoTenKH = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lvTTKH = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGioiTinhKH
            // 
            this.cbGioiTinhKH.DisplayMember = "Nam";
            this.cbGioiTinhKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinhKH.FormattingEnabled = true;
            this.cbGioiTinhKH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbGioiTinhKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinhKH.Location = new System.Drawing.Point(174, 116);
            this.cbGioiTinhKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGioiTinhKH.Name = "cbGioiTinhKH";
            this.cbGioiTinhKH.Size = new System.Drawing.Size(95, 28);
            this.cbGioiTinhKH.TabIndex = 2;
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(176, 417);
            this.btnXoaAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(86, 31);
            this.btnXoaAll.TabIndex = 8;
            this.btnXoaAll.Text = "Xóa hết";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(110, 484);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(222, 57);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(176, 347);
            this.btnSuaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(86, 31);
            this.btnSuaKH.TabIndex = 6;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(334, 347);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 31);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 347);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 31);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(174, 261);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(245, 27);
            this.txtSDTKH.TabIndex = 4;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(174, 35);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(245, 27);
            this.txtTenKH.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // colSDTKH
            // 
            this.colSDTKH.Text = "Số điện thoại";
            // 
            // colDiaChiKH
            // 
            this.colDiaChiKH.Text = "Địa chỉ";
            // 
            // colGioiTinhKH
            // 
            this.colGioiTinhKH.Text = "Giới tính";
            // 
            // colHoTenKH
            // 
            this.colHoTenKH.Text = "Họ và tên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGioiTinhKH);
            this.groupBox1.Controls.Add(this.btnXoaAll);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSuaKH);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtSDTKH);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(489, 599);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(174, 185);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(245, 27);
            this.txtDiaChi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ:";
            // 
            // lvTTKH
            // 
            this.lvTTKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoTenKH,
            this.colGioiTinhKH,
            this.colDiaChiKH,
            this.colSDTKH});
            this.lvTTKH.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvTTKH.Location = new System.Drawing.Point(489, 0);
            this.lvTTKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvTTKH.Name = "lvTTKH";
            this.lvTTKH.Size = new System.Drawing.Size(578, 648);
            this.lvTTKH.TabIndex = 3;
            this.lvTTKH.UseCompatibleStateImageBehavior = false;
            this.lvTTKH.View = System.Windows.Forms.View.Details;
            this.lvTTKH.SelectedIndexChanged += new System.EventHandler(this.lvTTKH_SelectedIndexChanged);
            // 
            // FormTTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvTTKH);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTTKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTTKH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTTKH_FormClosing);
            this.Load += new System.EventHandler(this.FormTTKH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbGioiTinhKH;
        private Button btnXoaAll;
        private Button btnThoat;
        private Button btnSuaKH;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtSDTKH;
        private TextBox txtTenKH;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label1;
        private ColumnHeader colSDTKH;
        private ColumnHeader colDiaChiKH;
        private ColumnHeader colGioiTinhKH;
        private ColumnHeader colHoTenKH;
        private GroupBox groupBox1;
        private TextBox txtDiaChi;
        private Label label3;
        private ListView lvTTKH;
    }
}