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

namespace LTTQ
{
    public partial class formNhanVien : Form
    {
        SQL dtBase = new SQL();
        public formNhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            DataTable dtNV = dtBase.loaddulieu("Select *from NhanVien");
            dgvNhanVien.DataSource = dtNV;
        }

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            LoadData();
            dgvNhanVien.Columns[0].HeaderText = "Mã NV";
            dgvNhanVien.Columns[1].HeaderText = "Tên NV";
            dgvNhanVien.Columns[2].HeaderText = "Giới Tính";
            dgvNhanVien.Columns[3].HeaderText = "ngày sinh";
            dgvNhanVien.Columns[4].HeaderText = "Quê quán";
            dgvNhanVien.Columns[5].HeaderText = "Số CMT";
            dgvNhanVien.Columns[6].HeaderText = "Số DT";
            dgvNhanVien.Columns[7].HeaderText = "Chức vụ";
        }

      

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtQueQuan.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtCMND.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtSDT.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtCHucVu.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') || Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9'))
                && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Bạn phải nhập số");
                e.Handled = true;
            }
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtGioiTinh.Text == "" || txtCHucVu.Text == "" ||
              txtNgaySinh.Text == "" || txtQueQuan.Text == "" || txtCMND.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu", "Thông báo");
                return;
            }
            //lấy ra 1 dataTable có câu lệnh Select * from NhanVien
            DataTable dtNV = dtBase.loaddulieu("Select * from NhanVien" +
               " where MaNV = '" + txtMa.Text + "'");
            if (dtNV.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên này đã có, mời bạn nhập mã khác", "Thông báo");
                txtMa.Focus();
                return;
            }
            string sqlInsert = "insert into NhanVien values('" + txtMa.Text + "',N'" + txtTen.Text + "','" + txtGioiTinh.Text + "'," +
                "'" + txtNgaySinh.Text + "',N'" + txtQueQuan.Text + "','" + txtCMND.Text + "','" + txtSDT.Text + "',N'" + txtCHucVu.Text + "')";
            dtBase.CapNhatDuLieu(sqlInsert);
            LoadData();
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            dtBase.CapNhatDuLieu("update NhanVien set TenNV = N'" + txtTen.Text + "' , " +
               "  GioiTinh = N'" + txtGioiTinh.Text + "', NgaySinh = N'" + txtNgaySinh.Text + "', QueQuan = N'" + txtQueQuan.Text + "', SoCMT = N'" + txtCMND.Text + "', SDT = N'" + txtSDT.Text + "', ChucVu = N'" + txtCHucVu.Text + "' where MaNV ='" + txtMa.Text + "' ");
            LoadData();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa " + txtMa.Text, "Lựa chọn ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.CapNhatDuLieu("Delete NhanVien where MaNV ='" + txtMa.Text + "'");
                LoadData();
            }
        }
    }
}
