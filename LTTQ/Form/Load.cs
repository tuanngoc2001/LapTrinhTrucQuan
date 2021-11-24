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
    public partial class Load : Form
    {
       
        int s=0;
        public Load()
        {
            
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
            process.Start();
            lbtime.Text ="0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s == 100)
            {
                timer1.Stop();
                MenuChinh a = new MenuChinh();
                a.ShowDialog();
                this.Close();
            }
            else
            {
                s += 1;
                lbtime.Text = (s.ToString() + " %");
            }    


        }

        
    }
}
