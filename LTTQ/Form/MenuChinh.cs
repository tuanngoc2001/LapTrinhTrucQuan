using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace LTTQ
{
    public partial class MenuChinh : Form
    {
        SQL ketnoi = new SQL();
        private Form active = null;
        //private Label lbform = null;
        Guna2Button btnnut = null;
        public static string image = "";
        public static string name = "";
        
        public MenuChinh()
        {
            InitializeComponent();
        }
        public void Loadform(Form child)
        {
            if (active != null)
            {
                active.Close();
            }
            active = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlmid.Controls.Add(child);
            pnlmid.Tag = child;
            child.BringToFront();
            child.Show();

        }

        private void MenuChinh_Load(object sender, EventArgs e)
        {
            pcboxanh.Image = Image.FromFile(Application.StartupPath + "\\image\\" + image);
            lbtime.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
            lbname.Text = name;
            lbuser.Text = name;
        }
        private void hover(Guna2Button btn)
        {
            
            btn.FillColor= System.Drawing.ColorTranslator.FromHtml("#248CF6");
            btn.Font=new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.ImageSize = new System.Drawing.Size(35, 35);
            btnnut = btn;
        }
        private void unhover()
        {
            if(btnnut!=null)
            {
                btnnut.FillColor = System.Drawing.ColorTranslator.FromHtml("#5E94FF");
                btnnut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnnut.ImageSize = new System.Drawing.Size(30, 30);
            }
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            unhover();
            hover(btntrangchu);
            Loadform(new Trangchu());

        }

        private void btndochoi_Click(object sender, EventArgs e)
        {
            unhover();
            hover(btndochoi);
            Loadform(new formDoChoi());
        }

        private void btnhangnhap_Click(object sender, EventArgs e)
        {
            unhover();
            hover(btnhangnhap);
            Loadform(new formHangNhap());
        }

        private void btnhangban_Click(object sender, EventArgs e)
        {
            unhover();
            hover(btnhangban);
            Loadform(new formHangBan());
        }

        private void bankho_Click(object sender, EventArgs e)
        {
            
            unhover();
            hover(btnkho);
            Loadform(new formKho());

        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {

            unhover();
            hover(btnnhanvien);
            Loadform(new formNhanVien());


        }

        private void btndoanhthu_Click(object sender, EventArgs e)
        {
            unhover();
            hover(btndoanhthu);
            Loadform(new doanhthu());
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void lbdoimk_Click(object sender, EventArgs e)
        {
            DoiMatKhau a = new DoiMatKhau();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Loadform(new Trangchu());
        }
    }
}
