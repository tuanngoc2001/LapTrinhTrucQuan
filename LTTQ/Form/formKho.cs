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
using Excel = Microsoft.Office.Interop.Excel;

namespace LTTQ
{
    public partial class formKho : Form
    {
        SQL dtBase = new SQL();
        string s = "";
        public formKho()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            DataTable dtKho = dtBase.loaddulieu(("Select MaKho,Ten,TinhTrang," +
                                                      "SoLuongTon from Kho join DoChoi on Kho.MaDoChoi=DoChoi.MaDoChoi"));
            dgvKho.DataSource = dtKho;
        }
        private void formKho_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            cbo1.Text = "";
            cbo1.DataSource = dtBase.loaddulieu("Select Ten, MaDoChoi from DoChoi");
            cbo1.DisplayMember = "Ten";
            cbo1.ValueMember = "MaDoChoi";
            LoadData();
            dgvKho.Columns[0].HeaderText = "Mã Kho";
            dgvKho.Columns[1].HeaderText = "Tên đồ chơi";
            dgvKho.Columns[2].HeaderText = "Tình trạng";
            dgvKho.Columns[3].HeaderText = " Số lượng tồn";
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvKho.CurrentRow.Cells[0].Value.ToString();
            cbo1.Text = "";
            cbo1.SelectedText = dgvKho.CurrentRow.Cells[1].Value.ToString();
            txtTinhTrang.Text = dgvKho.CurrentRow.Cells[2].Value.ToString();
            txtSLT.Text = dgvKho.CurrentRow.Cells[3].Value.ToString();
            s = dtBase.loaddulieu("Select Anh from DoChoi join Kho on DoChoi.MaDoChoi=Kho.MaDoChoi where MaKho='" + txtMa.Text + "'").Rows[0]["Anh"].ToString();
            picAnhKho.Image = Image.FromFile(Application.StartupPath + "\\image\\" + s);
        }
        private void txtSLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') || Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9'))
               && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Bạn phải nhập số");
                e.Handled = true;
            }
        }

        private void btnTimkiem1_Click(object sender, EventArgs e)
        {
            string sql = "Select MaKho,Ten,TinhTrang," + "SoLuongTon from Kho join DoChoi on Kho.MaDoChoi=DoChoi.MaDoChoi where MaKho is not null";
            if (txtMa.Text.Trim() != "")
            {
                sql += " and MaKho like '%" + txtMa.Text + "%'";
            }
            if (txtTinhTrang.Text.Trim() != "")
            {
                sql += " and TinhTrang like '%" + txtTinhTrang.Text + "%'";
            }

            if (cbo1.Text != "")
            {
                sql = sql + " and DoChoi.MaDoChoi='" + cbo1.SelectedValue.ToString() + "'";
            }

            dgvKho.DataSource = dtBase.loaddulieu(sql);
        }

        private void btnLamMoi2_Click(object sender, EventArgs e)
        {
            dgvKho.DataSource = dtBase.loaddulieu("Select MaKho,Ten,TinhTrang," +
                                                      "SoLuongTon from Kho join DoChoi on Kho.MaDoChoi=DoChoi.MaDoChoi");
            txtMa.Text = "";
            txtSLT.Text = "";
            txtTinhTrang.Text = "";
            cbo1.Text = "";
        }

        private void btnInExcel1_Click(object sender, EventArgs e)
        {
            DataTable dtKho = dtBase.loaddulieu(("Select MaKho,Ten,TinhTrang," +
                                                    "SoLuongTon from Kho join DoChoi on Kho.MaDoChoi=DoChoi.MaDoChoi"));
            if (dtKho.Rows.Count > 0) //TH có dữ liệu để ghi
            {

                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];


                //Định dạng tiêu đề bảng
                exSheet.get_Range("A2:G2").Font.Bold = true;
                exSheet.get_Range("A2:G2").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A2").Value = "STT";
                exSheet.get_Range("B2").Value = "Mã Kho";
                exSheet.get_Range("C2").Value = "Tên Đồ Chơi";
                exSheet.get_Range("C2").ColumnWidth = 20;
                exSheet.get_Range("D2").Value = "Tình Trạng";
                exSheet.get_Range("E2").Value = "Số lượng Tồn";


                //In dữ liệu
                for (int i = 0; i < dtKho.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 3).ToString() + ":G" + (i + 3).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 3).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 3).ToString()).Value = dtKho.Rows[i]["MaKho"].ToString();
                    exSheet.get_Range("C" + (i + 3).ToString()).Value = dtKho.Rows[i]["Ten"].ToString();
                    exSheet.get_Range("D" + (i + 3).ToString()).Value = dtKho.Rows[i]["TinhTrang"].ToString();
                    exSheet.get_Range("E" + (i + 3).ToString()).Value = dtKho.Rows[i]["SoLuongTon"].ToString();

                }
                exSheet.Name = "Kho";
                exBook.Activate(); //Kích hoạt file Excel
                                   //Thiết lập các thuộc tính của SaveFileDialog
                SaveFileDialog dlgSave = new SaveFileDialog();
                dlgSave.Filter = "Excel Document(*.xls)|*.xls  |Word Document(*.doc) |*.doc|All files(*.*)|*.*";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xls";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                }
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
                MessageBox.Show("Không có danh sách kho");
        }
    }
}
