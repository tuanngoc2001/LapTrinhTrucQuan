using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2;
using System.Threading;

namespace LTTQ
{
    public partial class dangnhap : Form
    {
        SQL ketnoi = new SQL();
        private Form active = null;
        public bool close = false;
        public dangnhap()
        {
            InitializeComponent();
        }
        public void loadform(Form child)
        {
            if (active != null)
            {
                active.Close();
            }
            active = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            lbquenmk.Controls.Add(child);
            lbquenmk.Tag = child;
            child.BringToFront();
            child.Show();
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private bool checkdangnhap()
        {
            string md5 = ketnoi.loaddulieu("SELECT CONVERT(VARCHAR(32), HashBytes('MD5', '" + txtpass.Text + "'), 2) as MD5").Rows[0]["MD5"].ToString();
            if(ketnoi.loaddulieu("SELECT MatKhau FROM QuanLiNhanVien WHERE TaiKhoan='" + txtemail.Text + "'").Rows[0]["MatKhau"].ToString().Equals(md5))
            {
                return true;
            }
            else
              return false;
     
        }
        public void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to escape ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes||close==true)
                 Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                loadform(new dangky());  
        }

     
        private bool check()
        {
            if (txtemail.Text != "" || txtpass.Text.Length > 3)
                return true;
            return false;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(check())
            {
                if(ketnoi.loaddulieu("SELECT * FROM QuanLiNhanVien where TaiKhoan='" + txtemail.Text + "'").Rows.Count > 0)
                {
                    if (checkdangnhap())
                    {
                        
                        MenuChinh.name = ketnoi.loaddulieu("select TenNV from NhanVien join QuanLiNhanVien on NhanVien.MaNV=QuanLiNhanVien.MaNV WHERE TaiKhoan='" + txtemail.Text + "'").Rows[0]["TenNV"].ToString();
                        MenuChinh.image = ketnoi.loaddulieu("select Anh from QuanLiNhanVien where TaiKhoan='" + txtemail.Text + "'").Rows[0]["Anh"].ToString();
                        //Load a = new Load();
                        ntfic.ShowBalloonTip(3000);
                        loadform(new Load());
                        //a.ShowDialog();
                        //this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản này chưa có trên hệ thống mời bạn đăng ký và đợi quản lý duyệt", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }    
            }    
            else
            {
                MessageBox.Show("Bạn cần nhập vào đầy đủ thông tin của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmatkhau.Checked) 
                txtpass.UseSystemPasswordChar = false;
            else
                txtpass.UseSystemPasswordChar = true;
        }

       
    }
}
