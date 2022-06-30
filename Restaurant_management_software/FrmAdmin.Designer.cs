
namespace Restaurant_management_software
{
    partial class FrmAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.bt_nvTimKiem = new System.Windows.Forms.Button();
            this.bt_nvXoa = new System.Windows.Forms.Button();
            this.bt_nvSua = new System.Windows.Forms.Button();
            this.bt_nvThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabThucDon = new System.Windows.Forms.TabPage();
            this.txtMaThucDon = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.bt_tdTimkiem = new System.Windows.Forms.Button();
            this.bt_tdXoa = new System.Windows.Forms.Button();
            this.bt_tdSua = new System.Windows.Forms.Button();
            this.bt_tdThem = new System.Windows.Forms.Button();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.dtNgayApDung = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbTenLoai = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNhanVien);
            this.tabControl1.Controls.Add(this.tabThucDon);
            this.tabControl1.Location = new System.Drawing.Point(-6, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1089, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabNhanVien.Controls.Add(this.lbMaNhanVien);
            this.tabNhanVien.Controls.Add(this.bt_nvTimKiem);
            this.tabNhanVien.Controls.Add(this.bt_nvXoa);
            this.tabNhanVien.Controls.Add(this.bt_nvSua);
            this.tabNhanVien.Controls.Add(this.bt_nvThem);
            this.tabNhanVien.Controls.Add(this.button1);
            this.tabNhanVien.Controls.Add(this.dtNgaySinh);
            this.tabNhanVien.Controls.Add(this.txtChucVu);
            this.tabNhanVien.Controls.Add(this.txtMatKhau);
            this.tabNhanVien.Controls.Add(this.txtTenDangNhap);
            this.tabNhanVien.Controls.Add(this.txtHoVaTen);
            this.tabNhanVien.Controls.Add(this.label7);
            this.tabNhanVien.Controls.Add(this.label6);
            this.tabNhanVien.Controls.Add(this.label5);
            this.tabNhanVien.Controls.Add(this.label4);
            this.tabNhanVien.Controls.Add(this.label3);
            this.tabNhanVien.Controls.Add(this.label2);
            this.tabNhanVien.Controls.Add(this.label1);
            this.tabNhanVien.Controls.Add(this.dataGridView1);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 25);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(1081, 528);
            this.tabNhanVien.TabIndex = 0;
            this.tabNhanVien.Text = "Nhân Viên";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Location = new System.Drawing.Point(140, 60);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(42, 17);
            this.lbMaNhanVien.TabIndex = 6;
            this.lbMaNhanVien.Text = "None";
            // 
            // bt_nvTimKiem
            // 
            this.bt_nvTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_nvTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_nvTimKiem.FlatAppearance.BorderSize = 0;
            this.bt_nvTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_nvTimKiem.Location = new System.Drawing.Point(559, 178);
            this.bt_nvTimKiem.Name = "bt_nvTimKiem";
            this.bt_nvTimKiem.Size = new System.Drawing.Size(80, 49);
            this.bt_nvTimKiem.TabIndex = 5;
            this.bt_nvTimKiem.Text = "Tìm kiếm";
            this.bt_nvTimKiem.UseVisualStyleBackColor = false;
            this.bt_nvTimKiem.Click += new System.EventHandler(this.bt_nvTimKiem_Click);
            // 
            // bt_nvXoa
            // 
            this.bt_nvXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_nvXoa.Location = new System.Drawing.Point(915, 30);
            this.bt_nvXoa.Name = "bt_nvXoa";
            this.bt_nvXoa.Size = new System.Drawing.Size(80, 49);
            this.bt_nvXoa.TabIndex = 5;
            this.bt_nvXoa.Text = "Xóa";
            this.bt_nvXoa.UseVisualStyleBackColor = false;
            this.bt_nvXoa.Click += new System.EventHandler(this.bt_nvXoa_Click);
            // 
            // bt_nvSua
            // 
            this.bt_nvSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_nvSua.Location = new System.Drawing.Point(915, 178);
            this.bt_nvSua.Name = "bt_nvSua";
            this.bt_nvSua.Size = new System.Drawing.Size(80, 49);
            this.bt_nvSua.TabIndex = 5;
            this.bt_nvSua.Text = "Sửa";
            this.bt_nvSua.UseVisualStyleBackColor = false;
            this.bt_nvSua.Click += new System.EventHandler(this.bt_nvSua_Click);
            // 
            // bt_nvThem
            // 
            this.bt_nvThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_nvThem.Location = new System.Drawing.Point(915, 102);
            this.bt_nvThem.Name = "bt_nvThem";
            this.bt_nvThem.Size = new System.Drawing.Size(80, 49);
            this.bt_nvThem.TabIndex = 5;
            this.bt_nvThem.Text = "Thêm";
            this.bt_nvThem.UseVisualStyleBackColor = false;
            this.bt_nvThem.Click += new System.EventHandler(this.bt_nvThem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(741, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "MM/dd/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(143, 153);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtNgaySinh.TabIndex = 4;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(143, 205);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(200, 22);
            this.txtChucVu.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(559, 102);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(202, 22);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(559, 57);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(202, 22);
            this.txtTenDangNhap.TabIndex = 3;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(143, 104);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoVaTen.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật khẩu: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên đăng nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chức vụ: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabThucDon
            // 
            this.tabThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabThucDon.Controls.Add(this.cbTenLoai);
            this.tabThucDon.Controls.Add(this.txtMaThucDon);
            this.tabThucDon.Controls.Add(this.label14);
            this.tabThucDon.Controls.Add(this.button6);
            this.tabThucDon.Controls.Add(this.bt_tdTimkiem);
            this.tabThucDon.Controls.Add(this.bt_tdXoa);
            this.tabThucDon.Controls.Add(this.bt_tdSua);
            this.tabThucDon.Controls.Add(this.bt_tdThem);
            this.tabThucDon.Controls.Add(this.txtTenMonAn);
            this.tabThucDon.Controls.Add(this.txtDonViTinh);
            this.tabThucDon.Controls.Add(this.txtGia);
            this.tabThucDon.Controls.Add(this.dtNgayApDung);
            this.tabThucDon.Controls.Add(this.label13);
            this.tabThucDon.Controls.Add(this.label12);
            this.tabThucDon.Controls.Add(this.label11);
            this.tabThucDon.Controls.Add(this.label10);
            this.tabThucDon.Controls.Add(this.label9);
            this.tabThucDon.Controls.Add(this.label8);
            this.tabThucDon.Controls.Add(this.dataGridView2);
            this.tabThucDon.Location = new System.Drawing.Point(4, 25);
            this.tabThucDon.Name = "tabThucDon";
            this.tabThucDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabThucDon.Size = new System.Drawing.Size(1081, 528);
            this.tabThucDon.TabIndex = 1;
            this.tabThucDon.Text = "Thực đơn";
            // 
            // txtMaThucDon
            // 
            this.txtMaThucDon.AutoSize = true;
            this.txtMaThucDon.BackColor = System.Drawing.Color.White;
            this.txtMaThucDon.Location = new System.Drawing.Point(669, 61);
            this.txtMaThucDon.Name = "txtMaThucDon";
            this.txtMaThucDon.Size = new System.Drawing.Size(0, 17);
            this.txtMaThucDon.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(553, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Mã Thực Đơn: ";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(787, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 47);
            this.button6.TabIndex = 4;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bt_tdTimkiem
            // 
            this.bt_tdTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_tdTimkiem.Location = new System.Drawing.Point(595, 210);
            this.bt_tdTimkiem.Name = "bt_tdTimkiem";
            this.bt_tdTimkiem.Size = new System.Drawing.Size(86, 47);
            this.bt_tdTimkiem.TabIndex = 4;
            this.bt_tdTimkiem.Text = "Tìm kiếm";
            this.bt_tdTimkiem.UseVisualStyleBackColor = false;
            this.bt_tdTimkiem.Click += new System.EventHandler(this.bt_tdTimkiem_Click);
            // 
            // bt_tdXoa
            // 
            this.bt_tdXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_tdXoa.Location = new System.Drawing.Point(937, 59);
            this.bt_tdXoa.Name = "bt_tdXoa";
            this.bt_tdXoa.Size = new System.Drawing.Size(86, 47);
            this.bt_tdXoa.TabIndex = 4;
            this.bt_tdXoa.Text = "Xóa";
            this.bt_tdXoa.UseVisualStyleBackColor = false;
            this.bt_tdXoa.Click += new System.EventHandler(this.bt_tdXoa_Click);
            // 
            // bt_tdSua
            // 
            this.bt_tdSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_tdSua.Location = new System.Drawing.Point(937, 210);
            this.bt_tdSua.Name = "bt_tdSua";
            this.bt_tdSua.Size = new System.Drawing.Size(86, 47);
            this.bt_tdSua.TabIndex = 4;
            this.bt_tdSua.Text = "Sửa";
            this.bt_tdSua.UseVisualStyleBackColor = false;
            this.bt_tdSua.Click += new System.EventHandler(this.bt_tdSua_Click);
            // 
            // bt_tdThem
            // 
            this.bt_tdThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_tdThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_tdThem.Location = new System.Drawing.Point(937, 134);
            this.bt_tdThem.Name = "bt_tdThem";
            this.bt_tdThem.Size = new System.Drawing.Size(86, 47);
            this.bt_tdThem.TabIndex = 4;
            this.bt_tdThem.Text = "Thêm";
            this.bt_tdThem.UseVisualStyleBackColor = false;
            this.bt_tdThem.Click += new System.EventHandler(this.bt_tdThem_Click);
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(175, 56);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(200, 22);
            this.txtTenMonAn.TabIndex = 3;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(175, 146);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(200, 22);
            this.txtDonViTinh.TabIndex = 3;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(175, 187);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(200, 22);
            this.txtGia.TabIndex = 3;
            // 
            // dtNgayApDung
            // 
            this.dtNgayApDung.CustomFormat = "MM/dd/yyyy";
            this.dtNgayApDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayApDung.Location = new System.Drawing.Point(175, 235);
            this.dtNgayApDung.Name = "dtNgayApDung";
            this.dtNgayApDung.Size = new System.Drawing.Size(200, 22);
            this.dtNgayApDung.TabIndex = 2;
            this.dtNgayApDung.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ngày áp dụng: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Giá: ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Đơn vị tính: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên loại: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên món ăn: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Quản Lý Thực Đơn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 283);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1078, 239);
            this.dataGridView2.TabIndex = 0;
            // 
            // cbTenLoai
            // 
            this.cbTenLoai.FormattingEnabled = true;
            this.cbTenLoai.Location = new System.Drawing.Point(175, 98);
            this.cbTenLoai.Name = "cbTenLoai";
            this.cbTenLoai.Size = new System.Drawing.Size(200, 24);
            this.cbTenLoai.TabIndex = 6;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabThucDon.ResumeLayout(false);
            this.tabThucDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabThucDon;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dtNgayApDung;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button bt_nvTimKiem;
        private System.Windows.Forms.Button bt_nvXoa;
        private System.Windows.Forms.Button bt_nvSua;
        private System.Windows.Forms.Button bt_nvThem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bt_tdTimkiem;
        private System.Windows.Forms.Button bt_tdXoa;
        private System.Windows.Forms.Button bt_tdSua;
        private System.Windows.Forms.Button bt_tdThem;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.Label txtMaThucDon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbTenLoai;
    }
}