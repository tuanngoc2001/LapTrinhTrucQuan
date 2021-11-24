using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class doanhthu : Form
    {
        SQL ketnoi = new SQL();
        public doanhthu()
        {
           
            InitializeComponent();
        }
        Func<ChartPoint, string> label = chartpoin => string.Format("{0}  ({1:P})", chartpoin.Y, chartpoin.Participation);

        private void doanhthu_Load(object sender, EventArgs e)
        {
            dtgrvdoanhthu.DataSource = ketnoi.loaddulieu("select TOP(5) count(SoLuong) AS SoLuongBan,sum(SoLuong*DonGiaBan) as TongTien,DoChoi.MaDoChoi, Ten from HoaDon join DoChoi on HoaDon.MaDoChoi = DoChoi.MaDoChoi group by DoChoi.MaDoChoi, Ten  order by count(SoLuong) desc");
            dtgrvdoanhthu.Columns[0].HeaderText = "Mã Đồ Chơi";
            dtgrvdoanhthu.Columns[1].HeaderText = "Tên Đồ Chơi";
            dtgrvdoanhthu.Columns[2].HeaderText = "Số Lượng";
            dtgrvdoanhthu.Columns[1].HeaderText = "Tổng tiền bán";
            var s = "select sum(Sotien) as TongTien from tChiTietHDB ";
            
            float tongtien = float.Parse(ketnoi.loaddulieu(s).Rows[0]["TongTien"].ToString());
            for (var i = 0; i < 12; i++)
            {
                var s1 = "select sum(SoTien) as SoTien from tChiTietHDB where Month(NgayBan)=" + (i + 1).ToString();
                float tientheothang = float.Parse(ketnoi.loaddulieu(s1).Rows[0]["SoTien"].ToString());
                this.chart1.Series["DoanhThu"].Points.AddXY("Tháng "+(i+1).ToString(),tientheothang);
                //this.chart1.Series["DoanhThu"].Points[i].ToolTip = tientheothang.ToString("#.##");

            }

            for (int i = 0; i < 3; i++)
            {

                var s2 = "select sum(Sotien) as SoTien from tChiTietHDB WHERE Year(NgayBan)=" + (2019 + i).ToString();

                this.chart2.Series["DoanhThu"].Points.AddXY((2019 + i).ToString(),float.Parse(ketnoi.loaddulieu(s2).Rows[0]["SoTien"].ToString()));
               
                this.chart2.Series["DoanhThu"].Points[i].ToolTip = ketnoi.loaddulieu(s2).Rows[0]["SoTien"].ToString();
            }
        }
    

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
