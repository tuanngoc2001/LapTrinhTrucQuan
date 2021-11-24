using System;
using System.Data;
using System.Windows.Forms;

namespace LTTQ
{
    public partial class formHangBan : Form
    {
        SQL dtBase = new SQL();
        public string HDB = "";

        public formHangBan()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dgvHangBan.DataSource = dtBase.loaddulieu("select SoHDB, MaNV, MaKH, MaDoChoi, SoLuong, KhuyenMai, Ngayban from HoaDon");
        }
        private void dgvHangBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHDB.Text = dgvHangBan.CurrentRow.Cells[0].Value.ToString();
            cboMaNV.Text = dgvHangBan.CurrentRow.Cells[1].Value.ToString();
            txtMaKH.Text = dgvHangBan.CurrentRow.Cells[2].Value.ToString();
            cboDoChoi.Text = dgvHangBan.CurrentRow.Cells[3].Value.ToString();
            txtSL.Text = dgvHangBan.CurrentRow.Cells[4].Value.ToString();
            txtKM.Text = dgvHangBan.CurrentRow.Cells[5].Value.ToString();
            dtpNgayBan.Value = (DateTime)dgvHangBan.Rows[e.RowIndex].Cells[6].Value;
            dtpNgayBan.Format = DateTimePickerFormat.Custom;
            dtpNgayBan.CustomFormat = "dd/MM/yyyy";

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }

        private void formHangBan_Load(object sender, EventArgs e)
        {
            int tt = dtBase.loaddulieu("SELECT * FROM HoaDon").Rows.Count + 1;
            txtHDB.Text = "HDB" + tt.ToString();

            dtpNgayBan.Format = DateTimePickerFormat.Custom;
            dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            DataTable HangBan = dtBase.loaddulieu("select * from HoaDon");
            cboDoChoi.DataSource = dtBase.loaddulieu("select MaDoChoi from DoChoi");
            cboDoChoi.DisplayMember = "MaDoChoi";
            cboDoChoi.ValueMember = "MaDoChoi";
            cboDoChoi.Text = "";
            cboMaNV.DataSource = dtBase.loaddulieu("Select MaNV from NhanVien");
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.Text = "";
            LoadData();
            dgvHangBan.Columns[0].HeaderText = "Số hóa đơn bán";
            dgvHangBan.Columns[1].HeaderText = "Mã nhân viên";
            dgvHangBan.Columns[2].HeaderText = "Mã khách hàng";
            dgvHangBan.Columns[3].HeaderText = "Mã đồ chơi";
            dgvHangBan.Columns[4].HeaderText = "Số lượng";
            dgvHangBan.Columns[5].HeaderText = "Khuyến mại";
            dgvHangBan.Columns[6].HeaderText = "Ngày bán";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlInsert;
            if (txtHDB.Text == "" || cboMaNV.Text == "" || txtMaKH.Text == "" || cboDoChoi.Text == "" || txtSL.Text == "" || txtKM.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                return;
            }
            sqlInsert = "insert into HoaDon values ('" + txtHDB.Text + "','" + cboMaNV.Text + "', '" + txtMaKH.Text + "','" + cboDoChoi.Text + "', '" + int.Parse(txtSL.Text) + "','" + float.Parse(txtKM.Text) + "','" + dtpNgayBan.Value + "')";
            dtBase.CapNhatDuLieu(sqlInsert);
            LoadData();
            int tt = dtBase.loaddulieu("SELECT * FROM HoaDon").Rows.Count + 1;
            txtHDB.Text = "HDB" + tt.ToString();
            cboMaNV.Text = "";
            txtMaKH.Text = "";
            cboDoChoi.Text = "";
            txtSL.Text = "";
            txtKM.Text = "";
            dtpNgayBan.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string s = "update HoaDon set SoHDB='" + txtHDB.Text + "' ,MaNV='" + cboMaNV.Text + "' " +
                 ",MaKH='" + txtMaKH.Text + "',MaDoChoi='" + cboDoChoi.Text + "',SoLuong='" + txtSL.Text + "',KhuyenMai='" + txtKM.Text + "',NgayNhap='" + dtpNgayBan.Value + "' where SoHDB ='" + txtHDB.Text + "'";
            dtBase.CapNhatDuLieu("update HoaDon set SoHDB='" + txtHDB.Text + "' ,MaNV='" + cboMaNV.Text + "' " +
                 ",MaKH='" + txtMaKH.Text + "',MaDoChoi='" + cboDoChoi.Text + "',SoLuong='" + txtSL.Text + "',KhuyenMai='" + txtKM.Text + "',NgayBan='" + dtpNgayBan.Value + "' where SoHDB ='" + txtHDB.Text + "'");
            LoadData();
            int tt = dtBase.loaddulieu("SELECT * FROM HoaDon").Rows.Count + 1;
            txtHDB.Text = "HDB" + tt.ToString();
            cboMaNV.Text = "";
            txtMaKH.Text = "";
            cboDoChoi.Text = "";
            txtSL.Text = "";
            txtKM.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sqlSelect = "select SoHDB, MaNV, MaKH, MaDoChoi, SoLuong, KhuyenMai, NgayBan from HoaDon";
            if(txtTim.Text.Trim() != "")
            {
                sqlSelect = sqlSelect + " Where MaDoChoi like '%" + txtTim.Text + "%'";
                dgvHangBan.DataSource = dtBase.loaddulieu(sqlSelect);
                //dgvHangBan.DataSource = dtBase.loaddulieu("SELECT *FROM HoaDon");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboDoChoi.Text == "")
            {
                MessageBox.Show("Chọn mã đồ chơi để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa", "Lựa chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.CapNhatDuLieu("delete HoaDon where MaDoChoi = '" + cboDoChoi.Text + "'");
                LoadData();
            }
            txtHDB.Text = "";
            cboMaNV.Text = "";
            txtMaKH.Text = "";
            cboDoChoi.Text = "";
            txtSL.Text = "";
            txtKM.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }    
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cboDoChoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            string sqlSelect = "select SoHDB, MaNV, MaKH, MaDoChoi, SoLuong, KhuyenMai, NgayBan from HoaDon";
            if (txtTim.Text.Trim() != "")
            {
                sqlSelect = sqlSelect + " Where MaDoChoi like '%" + txtTim.Text + "%'";
                dgvHangBan.DataSource = dtBase.loaddulieu(sqlSelect);
                //dgvHangBan.DataSource = dtBase.loaddulieu("SELECT *FROM HoaDon");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.ShowDialog();
        }
    }
}
