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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SQL da = new SQL();
            formHangBan f = new formHangBan();
            dt = da.loaddulieu("select SoHDB, MaNV, MaKH, HoaDon.MaDoChoi, SoLuong, KhuyenMai, NgayBan, DonGiaBan " +
                "from HoaDon join DoChoi on HoaDon.MaDoChoi = DoChoi.MaDoChoi");
            HoaDonBan rp = new HoaDonBan();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
