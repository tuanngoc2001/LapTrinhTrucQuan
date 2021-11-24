using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ
{
    public partial class dangky : Form
    {
        //public string email { get; set; }
        public Form active = null;
        SQL ketnoi = new SQL();
        public dangky()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to escape ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Minimized;
        }
        public void loadform(Form child)
        {
            if (active != null)
            {
                active.Close();
            }

            //this.Close();
            active = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnldangky.Controls.Add(child);
            pnldangky.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private int check()
        {
            if (txtdangkyemail.Text == "" || txtdangkypass.Text == "" || txtdangkyrepass.Text == "")
                return 0;
            return 1;
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            if(check()==1)
            {
                if(ketnoi.loaddulieu("select * from QuanLiNhanVien where TaiKhoan='"+txtdangkyemail.Text+"' or email='"+txtdangkyrepass+"'").Rows.Count>0|| ketnoi.loaddulieu("select * from dangky where user='" + txtdangkyemail.Text + "' or email='" + txtdangkyrepass + "'").Rows.Count>0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu đã có rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                else
                {
                    string md5 = ketnoi.loaddulieu("SELECT CONVERT(VARCHAR(32), HashBytes('MD5', '" + txtdangkypass.Text + "'), 2) as MD5").Rows[0]["MD5"].ToString();
                    ketnoi.CapNhatDuLieu("Insert INTO dangky values('" + txtdangkyemail.Text + "','" + md5 + "','" + txtdangkyrepass.Text + "')");
                }    
            }    
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            loadform(new dangnhap());
            //dangnhap a = new dangnhap();
            //a.ShowDialog();
            //this.Close();
        }

        
    }
}
