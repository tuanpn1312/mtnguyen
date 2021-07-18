using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            DayOfWeek dow = DateTime.Today.DayOfWeek;
            var src = DateTime.Now;
            var hm = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, 0);
            string time = timeNow.ToString("HH:mm:ss");

            Time.Text = time;
            labelMoment.Text = dow.ToString();
            Date.Text = hm.ToString();

            timer1.Start();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            txtMess.BackColor = System.Drawing.SystemColors.Window;
            timer1.Start();
            if(Global.Global.maChucVu != 1)
            {
                txtMess.ReadOnly = true;
            }
        }
    }
}
