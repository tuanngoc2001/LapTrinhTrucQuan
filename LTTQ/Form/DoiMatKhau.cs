using LTTQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LTTQ
{
    public partial class DoiMatKhau : Form
    {
        SQL dtBase = new SQL();
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string s = "SELECT * from QuanLiNhanVien where TaiKhoan='" + txtTK.Text + "' and MatKhau='" + txtMKC.Text + "'";
            if (dtBase.loaddulieu(s).Rows.Count==1)
            {
                if (txtMKM.Text == txtXN.Text)
                {
                    if (txtMKM.Text.Length >= 8)
                    {
                        string md5 = dtBase.loaddulieu("SELECT CONVERT(VARCHAR(32), HashBytes('MD5', '" + txtMKM.Text + "'), 2) as MD5").Rows[0]["MD5"].ToString();
                        dtBase.CapNhatDuLieu("update QuanLiNhanVien set MatKhau = '" + md5 + "' where TaiKhoan = '" + txtTK.Text + "'");
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Thread.Sleep(2000);
                        Application.Exit();
                    }
                    else errorProvider1.SetError(txtMKM, "Mật khẩu phải có ít nhất 8 kí tự");
                }
                else
                {
                    errorProvider1.SetError(txtMKM, "Bạn chưa điền mật khẩu");
                    errorProvider1.SetError(txtXN, "Mật khẩu xác nhận chưa đúng");
                }
            }
            else
            {
                errorProvider1.SetError(txtTK, "Tên tài khoản không đúng");
                errorProvider1.SetError(txtMKC, "Mật khẩu hiện tại không đúng");
            }
        }
    }      
}
