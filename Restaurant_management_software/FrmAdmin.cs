using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Restaurant_management_software
{
    public partial class FrmAdmin : Form
    {
        SQL_Connection connecter = new SQL_Connection();
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        public void TableNhanVien()
        {
            DataTable dta = new DataTable();
            dta = connecter.getData("select * from NhanVien order by MaNV");
            dataGridView1.DataSource = dta;
        }

        public void TableThucDon()
        {
            DataTable dta = new DataTable();
            dta = connecter.getData("select THUCDON.MaThucDon, LoaiThucDon.TenLoai, THUCDON.TenThucDon, THUCDON.DonViTinh, Gia.Gia, Gia.NgayADGia from THUCDON, Gia, LoaiThucDon where THUCDON.MaThucDon = Gia.MaThucDOn and ThucDon.MaLoai = LoaiThucDon.maLoai");
            dataGridView2.DataSource = dta;
        }

        private void ShowDataNhanVien()
        {
            lbMaNhanVien.DataBindings.Clear();
            lbMaNhanVien.DataBindings.Add("Text", dataGridView1.DataSource, "MaNV");

            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", dataGridView1.DataSource, "MaNV");

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", dataGridView1.DataSource, "HoTen");

            dtNgaySinh.DataBindings.Clear();
            dtNgaySinh.DataBindings.Add("Text", dataGridView1.DataSource, "NGAYSINH");

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", dataGridView1.DataSource, "TENDN");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dataGridView1.DataSource, "MATKHAU");

            txtChucVu.DataBindings.Clear();
            txtChucVu.DataBindings.Add("Text", dataGridView1.DataSource, "ChucVu");
        }
        private void ShowDataThucDon()
        {
            txtMaThucDon.DataBindings.Clear();
            txtMaThucDon.DataBindings.Add("Text", dataGridView2.DataSource, "MaThucDon");

            txtTenMonAn.DataBindings.Clear();
            txtTenMonAn.DataBindings.Add("Text", dataGridView2.DataSource, "TenThucDon");

            dtNgayApDung.DataBindings.Clear();
            dtNgayApDung.DataBindings.Add("Text", dataGridView2.DataSource, "NgayADGia");

            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.Add("Text", dataGridView2.DataSource, "DonViTinh");

            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dataGridView2.DataSource, "Gia");

            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", dataGridView2.DataSource, "TenLoai");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Clear();
            txtHoVaTen.Clear();
            txtChucVu.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
        }

        private void bt_nvTimKiem_Click(object sender, EventArgs e)
        {
            String sql = "select * from NhanVien where 1=1";
            if (txtHoVaTen.Text.Length != 0)
            {
                sql += " and HoTen = N" + "'" + txtHoVaTen.Text + "'";
            }
            
            if (dtNgaySinh.Value.ToString("yyyy-MM-dd").Length != 0)
            {
                sql += " and NgaySinh = " + "'" + dtNgaySinh.Value.ToString("MM/dd/yyyy") + "'";
            }

            if (txtTenDangNhap.Text.Length != 0)
            {
                sql += " and TenDN = " + "'" + txtTenDangNhap.Text + "'";
            }

            if (txtMatKhau.Text.Length != 0)
            {
                sql += " and MatKhau = " + "'" + txtMatKhau.Text + "'";
            }

            if (txtChucVu.Text.Length != 0)
            {
                sql += " and ChucVu = N" + "'" + txtChucVu.Text + "'";
            }

            DataTable data = new DataTable();
            data = connecter.getData(sql);
            dataGridView1.DataSource = data;
            System.Diagnostics.Debug.WriteLine(sql);
        }

        private void bt_nvXoa_Click(object sender, EventArgs e)
        {
            String sql = "delete from NhanVien where MaNV = " + txtMaNhanVien.Text;
            connecter.excute(sql);
            TableNhanVien();
            ShowDataNhanVien();
        }

        private void bt_nvSua_Click(object sender, EventArgs e)
        {
            String sql = "update NHANVIEN set HoTEN = N'" + txtHoVaTen.Text + "', " + "NgaySinh = '" + dtNgaySinh.Value.ToString("MM/dd/yyyy") + "', "
                + "TenDN = '" + txtTenDangNhap.Text + "', " + "MatKhau = '" + txtMatKhau.Text + "', " + "ChucVu = N'" + txtChucVu.Text + "'" + 
                "where MaNV = " + txtMaNhanVien.Text;
            connecter.excute(sql);
            TableNhanVien();
            ShowDataNhanVien();
        }

        private void bt_nvThem_Click(object sender, EventArgs e)
        {
            String sql = "insert into NhanVien Values(N'" + txtHoVaTen.Text + "', '" + dtNgaySinh.Value.ToString("MM/dd/yyyy") + "', '"
                + txtTenDangNhap.Text + "', '" + txtMatKhau.Text + "', N'" + txtChucVu.Text + "')";
            
            connecter.excute(sql);
            TableNhanVien();
            ShowDataNhanVien();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTenMonAn.Clear();
            //txtTenLoai.Clear();
            txtDonViTinh.Clear();
            txtGia.Clear();
            txtMaThucDon.Text = "None";

        }

        private void bt_tdSua_Click(object sender, EventArgs e)
        {
            String sql = "update ThucDon set TenThucDon = N'" + txtTenMonAn.Text + "', DonViTinh = N'" + txtDonViTinh.Text + "' where MaThucDon = "
                + txtMaThucDon.Text;
            String sql_1 = "update Gia set NgayADGia = '" + dtNgayApDung.Value.ToString("MM/dd/yyyy") + "', Gia = " + txtGia.Text + " where MaThucDon = "
                + txtMaThucDon.Text;

            System.Diagnostics.Debug.WriteLine(sql_1);
            connecter.excute(sql);
            connecter.excute(sql_1);
            TableThucDon();
            ShowDataThucDon();
        }

        private void bt_tdXoa_Click(object sender, EventArgs e)
        {
            String sql = "delete from ThucDon where MaThucDon = " + txtMaThucDon.Text;
            String sql_1 = "delete from Gia where MaThucDon = " + txtMaThucDon.Text;
            connecter.excute(sql);
            TableThucDon();
            ShowDataThucDon();
        }

        private void bt_tdThem_Click(object sender, EventArgs e)
        {
            String sql_get_max_id = "Select max(MaThucDon) as max_number from ThucDon";
            String max_id = connecter.GetMaxId(sql_get_max_id);

            String sql_get_id = "select MaLoai from LoaiThucDon where TenLoai = N'" + txtTenLoai.Text + "'";
            String id = connecter.GetMaLoai(sql_get_id);

            String sql = "insert into ThucDon values(" + id + ", N'" + txtTenMonAn.Text + "', N'" + txtDonViTinh.Text + "')";
            String sql_1 = "insert into Gia values(" + "'" + dtNgayApDung.Value.ToString("MM/dd/yyyy") + "', " + max_id + ", " + txtGia.Text + ")";
            connecter.excute(sql);
            connecter.excute(sql_1);
            TableThucDon();
            ShowDataThucDon();

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            TableNhanVien();
            TableThucDon();
            ShowDataNhanVien();
            ShowDataThucDon();

        }

        private void bt_tdTimkiem_Click(object sender, EventArgs e)
        {
            String sql = "select ThucDon.MaLoai, LoaiThucDon.TenLoai, ThucDon.TenThucDon, ThucDon.DonViTinh , Gia.Gia, Gia.NgayADGia  from Gia, LoaiThucDon, ThucDon where Gia.MaThucDon = ThucDon.MaThucDon and ThucDon.MaLoai = LoaiThucDon.MaLoai";
            if(txtTenMonAn.Text.Length != 0)
            {
                sql += " and ThucDon.TenThucDon = N" + "'" + txtTenMonAn.Text + "'";
            }
            if (txtTenLoai.Text.Length != 0)
            {
                sql += " and LoaiThucDon.TenLoai = N" + "'" + txtTenLoai.Text + "'";
            }
            if (txtDonViTinh.Text.Length != 0)
            {
                sql += " and ThucDon.DonViTinh = N" + "'" + txtDonViTinh.Text + "'";
            }
            if (txtGia.Text.Length != 0)
            {
                sql += " and Gia.Gia =" + txtGia.Text;
            }
            if (dtNgayApDung.Text.Length != 0)
            {
                sql += " and Gia.NgayADGia ='" + dtNgayApDung.Value.ToString("MM/dd/yyyy") + "'";
            }
            DataTable data = new DataTable();
            data = connecter.getData(sql);
            dataGridView2.DataSource = data;
            System.Diagnostics.Debug.WriteLine(sql);
        }
    }
}
