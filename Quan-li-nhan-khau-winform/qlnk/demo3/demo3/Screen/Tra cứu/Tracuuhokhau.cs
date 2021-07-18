using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo3.Giải_thuật;

namespace demo3.Screen.Tra_cứu
{
    public partial class Tracuuhokhau : TempaltesForm
    {
        public Tracuuhokhau()
        {
            InitializeComponent();
        }
        ListHoKhau1 dshk = new ListHoKhau1();
        ListHoKhau1 dstam = new ListHoKhau1();
        HoKhau1 tam = new HoKhau1();
        DataTable dtbt,dtbttam;
        public DataTable createtable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Số sổ hộ khẩu");
            dt.Columns.Add("Họ và tên chủ hộ");
            dt.Columns.Add("CMND");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Dân tộc");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("Ngày đăng ký");
            dt.Columns.Add("Chỗ ở hiện tại");
            return dt;
        }
        public void Khoitao()
        {
            HoKhau1 temp = dshk.pHead;
            while (temp != null)
            {
                dtbt.Rows.Add(temp.sSosohk,temp.sHovatenchuho,temp.sCMND,temp.sGioitinh,temp.sNgaysinh,temp.sDantoc,temp.sQuoctich,temp.sNgaydangky,temp.sChoohientai);
                temp = temp.next;
            }
            dataGridView1.DataSource = dtbt;
            dataGridView1.Refresh();
        }
        public void Khoitaodstam()
        {
            HoKhau1 temp = dstam.pHead;
            while (temp != null)
            {
                dtbttam.Rows.Add(temp.sSosohk, temp.sHovatenchuho, temp.sCMND, temp.sGioitinh, temp.sNgaysinh, temp.sDantoc, temp.sQuoctich, temp.sNgaydangky, temp.sChoohientai);
                temp = temp.next;
            }
            dataGridView1.DataSource = dtbttam;
            dataGridView1.Refresh();
        }
        public void DocHoKhau()
        {
            StreamReader fp = new StreamReader("..\\Hokhau.txt");
            string line;
            int dem = 1, kiemtra;
            HoKhau1 temp = new HoKhau1();
            while ((line = fp.ReadLine()) != null)
            {
                kiemtra = 9 * (dem % 9) + 1;
                if (kiemtra == 10) temp.sSosohk = line;
                if (kiemtra == 19) temp.sHovatenchuho = line;
                if (kiemtra == 28) temp.sCMND = line;
                if (kiemtra == 37) temp.sGioitinh = line;
                if (kiemtra == 46) temp.sNgaysinh = line;
                if (kiemtra == 55) temp.sDantoc = line;
                if (kiemtra == 64) temp.sQuoctich = line;
                if (kiemtra == 73) temp.sNgaydangky = line;
                if (kiemtra == 1) temp.sChoohientai = line;
                if (dem % 9 == 0)
                {
                    dshk.Addtail(temp);
                    temp = new HoKhau1();
                }
                dem++;
            }
            fp.Close();
        }
        public void BlockTimkiem()
        {
            button1.Enabled = false;
            buttonHienthi.Enabled = true;
            textBox1.Enabled = false;
        }
        public void UnlockTimkiem()
        {
            button1.Enabled = true;
            buttonHienthi.Enabled = false;
            textBox1.Enabled = true;
        }
        public void Themvaocombobox()
        {
            comboBox1.Items.Add("Số sổ hộ khẩu");
            comboBox1.Items.Add("Họ và tên chủ hộ");
            comboBox1.Items.Add("CMND");
            comboBox1.Items.Add("Giới tính");
            comboBox1.Items.Add("Ngày sinh");
            comboBox1.Items.Add("Dân tộc");
            comboBox1.Items.Add("Quốc tịch");
            comboBox1.Items.Add("Ngày đăng ký");
            comboBox1.Items.Add("Chỗ ở hiện tại");
        }
        private void Tracuuhokhau_Load(object sender, EventArgs e)
        {
            dtbt = createtable();
            dtbttam = createtable();
            //Themvaocombobox();
            DocHoKhau();
            Khoitao();
        }

        private void buttonHienthi_Click(object sender, EventArgs e)
        {
            dtbttam.Clear();
            dshk.DeleteList();
            dstam.DeleteList();
            DocHoKhau();
            dataGridView1.DataSource = dtbt;
            dataGridView1.Refresh();
            UnlockTimkiem();
            textBox1.Clear(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Số sổ hộ khẩu":
                    {
                        dstam = dshk.SearchSosohk(textBox1.Text);
                        break;
                    }
                case "Họ và tên chủ hộ":
                    {
                        dstam = dshk.SearchHovatenchuho(textBox1.Text);
                        break;
                    }
                case "CMND":
                    {
                        dstam = dshk.SearchCMND(textBox1.Text);
                        break;
                    }
                case "Giới tính":
                    {
                        dstam = dshk.SearchGioitinh(textBox1.Text);
                        break;
                    }
                case "Ngày sinh":
                    {
                        dstam = dshk.SearchNgaysinh(textBox1.Text);
                        break;
                    }
                case "Dân tộc":
                    {
                        dstam = dshk.SearchDantoc(textBox1.Text);
                        break;
                    }
                case "Quốc tịch":
                    {
                        dstam = dshk.SearchQuoctich(textBox1.Text);
                        break;
                    }
                case "Ngày đăng ký":
                    {
                        dstam = dshk.SearchNgaydangky(textBox1.Text);
                        break;
                    }
                case "Chỗ ở hiện tại":
                    {
                        dstam = dshk.SearchChoohientai(textBox1.Text);
                        break;
                    }
            }
            Khoitaodstam();
            BlockTimkiem();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

    }
}
