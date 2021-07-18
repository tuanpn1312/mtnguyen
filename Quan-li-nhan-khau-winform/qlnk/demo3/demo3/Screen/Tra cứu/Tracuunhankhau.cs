using demo3.Giải_thuật;
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

namespace demo3.Screen
{
    public partial class Tracuunhankhau : TempaltesForm
    {
        public Tracuunhankhau()
        {
            InitializeComponent();
        }
        ListNhankhau1 dsnk = new ListNhankhau1();
        ListNhankhau1 dstam = new ListNhankhau1();
        Nhankhau1 tam = new Nhankhau1();
        DataTable dtbt, dtbttam;
        public DataTable createtable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Số sổ hộ khẩu");
            dt.Columns.Add("Quan hệ với chủ hộ");
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Dân tộc");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("CMND");
            dt.Columns.Add("Ngày cấp");
            dt.Columns.Add("Nơi cấp");
            dt.Columns.Add("Trình độ học vấn");
            dt.Columns.Add("Nghề nghiệp");
            dt.Columns.Add("Nơi làm việc");
            dt.Columns.Add("Tiền án");
            dt.Columns.Add("Nơi sinh");
            dt.Columns.Add("Nguyên quán");
            dt.Columns.Add("Nơi ở thường trú");
            dt.Columns.Add("Nơi ở hiện tại");
            dt.Columns.Add("Ghi chú");
            return dt;
        }
        public void Khoitao()
        {
            Nhankhau1 temp = dsnk.pHead;
            while (temp != null)
            {
                dtbt.Rows.Add(temp.sSosohk, temp.sQuanhe, temp.sHovaten, temp.sNgaysinh, temp.sDantoc, temp.sGioitinh, temp.sQuoctich,
                    temp.sCmnd, temp.sNgaycap, temp.sNoicap, temp.sTDhocvan, temp.sNghenghiep, temp.sNoilamviec, temp.sTienan,
                    temp.sNoisinh, temp.sNguyenquan, temp.sNoiott, temp.sChoohientai, temp.sGhichu);
                temp = temp.next;
            }
            dataGridView1.DataSource = dtbt;
            dataGridView1.RefreshEdit();
        }
        public void Khoitaodstam()
        {
            Nhankhau1 temp = dstam.pHead;
            while (temp != null)
            {
                dtbttam.Rows.Add(temp.sSosohk, temp.sQuanhe, temp.sHovaten, temp.sNgaysinh, temp.sDantoc, temp.sGioitinh, temp.sQuoctich,
                    temp.sCmnd, temp.sNgaycap, temp.sNoicap, temp.sTDhocvan, temp.sNghenghiep, temp.sNoilamviec, temp.sTienan,
                    temp.sNoisinh, temp.sNguyenquan, temp.sNoiott, temp.sChoohientai, temp.sGhichu);
                temp = temp.next;
            }
            dataGridView1.DataSource = dtbttam;
            dataGridView1.Refresh();
        }
        public void DocNhanKhau()
        {
            StreamReader fp = new StreamReader("..\\Nhankhau.txt");
            string line;
            int dem = 1, kiemtra;
            Nhankhau1 temp = new Nhankhau1();
            while ((line = fp.ReadLine()) != null)
            {
                kiemtra = 19 * (dem % 19) + 1;
                if (kiemtra == 20) temp.sSosohk = line;
                if (kiemtra == 39) temp.sQuanhe = line;
                if (kiemtra == 58) temp.sHovaten = line;
                if (kiemtra == 77) temp.sNgaysinh = line;
                if (kiemtra == 96) temp.sDantoc = line;
                if (kiemtra == 115) temp.sGioitinh = line;
                if (kiemtra == 134) temp.sQuoctich = line;
                if (kiemtra == 153) temp.sCmnd = line;
                if (kiemtra == 172) temp.sNgaycap = line;
                if (kiemtra == 191) temp.sNoicap = line;
                if (kiemtra == 210) temp.sTDhocvan = line;
                if (kiemtra == 229) temp.sNghenghiep = line;
                if (kiemtra == 248) temp.sNoilamviec = line;
                if (kiemtra == 267) temp.sTienan = line;
                if (kiemtra == 286) temp.sNoisinh = line;
                if (kiemtra == 305) temp.sNguyenquan = line;
                if (kiemtra == 324) temp.sNoiott = line;
                if (kiemtra == 343) temp.sChoohientai = line;
                if (kiemtra == 1) temp.sGhichu = line;
                if (dem % 19 == 0)
                {
                    dsnk.Addtail(temp);
                    temp = new Nhankhau1();
                }
                dem++;
            }
            fp.Close();
        }
        public void BlockTimkiem()
        {
            button1.Enabled = false;
            button2.Enabled = true;
            textBox1.Enabled = false;
        }
        public void UnlockTimkiem()
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = true;
        }
        public void Themvaocombobox()
        {
            comboBox1.Items.Add("Số sổ hộ khẩu");
            comboBox1.Items.Add("Họ và tên");
            comboBox1.Items.Add("Ngày sinh");
            comboBox1.Items.Add("Dân tộc");
            comboBox1.Items.Add("Giới tính");
            comboBox1.Items.Add("Quốc tịch");
            comboBox1.Items.Add("CMND");
            comboBox1.Items.Add("Ngày cấp");
            comboBox1.Items.Add("Nơi cấp");
            comboBox1.Items.Add("Trình độ học vấn");
            comboBox1.Items.Add("Nghề nghiệp");
            comboBox1.Items.Add("Quan hệ với chủ hộ");
            comboBox1.Items.Add("Tiền án");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Số sổ hộ khẩu":
                    {
                        dstam = dsnk.SearchSosohk(textBox1.Text);
                        break;
                    }
                case "Họ và tên":
                    {
                        dstam = dsnk.SearchHovaten(textBox1.Text);
                        break;
                    }
                case "Ngày sinh":
                    {
                        dstam = dsnk.SearchNgaysinh(textBox1.Text);
                        break;
                    }
                case "Dân tộc":
                    {
                        dstam = dsnk.SearchDantoc(textBox1.Text);
                        break;
                    }
                case "Giới tính":
                    {
                        dstam = dsnk.SearchGioitinh(textBox1.Text);
                        break;
                    }
                case "Quốc tịch":
                    {
                        dstam = dsnk.SearchQuoctich(textBox1.Text);
                        break;
                    }
                case "CMND":
                    {
                        dstam = dsnk.SearchCMND(textBox1.Text);
                        break;
                    }
                case "Ngày cấp":
                    {
                        dstam = dsnk.SearchNgaycap(textBox1.Text);
                        break;
                    }
                case "Nơi cấp":
                    {
                        dstam = dsnk.SearchNoicap(textBox1.Text);
                        break;
                    }
                case "Trình độ học vấn":
                    {
                        dstam = dsnk.SearchTDhocvan(textBox1.Text);
                        break;
                    }
                case "Nghề nghiệp":
                    {
                        dstam = dsnk.SearchNghenghiep(textBox1.Text);
                        break;
                    }
                case "Quan hệ với chủ hộ":
                    {
                        dstam = dsnk.SearchQuanhe(textBox1.Text);
                        break;
                    }
                case "Tiền án":
                    {
                        dstam = dsnk.SearchTienan(textBox1.Text);
                        break;
                    }

            }
            Khoitaodstam();
            BlockTimkiem();
        }

        private void Tracuunhankhau_Load(object sender, EventArgs e)
        {
            dtbt = createtable();
            dtbttam = createtable();
            Themvaocombobox();
            DocNhanKhau();
            Khoitao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtbttam.Clear();
            dsnk.DeleteList();
            dstam.DeleteList();
            DocNhanKhau();
            dataGridView1.DataSource = dtbt;
            dataGridView1.Refresh();
            UnlockTimkiem();
            textBox1.Clear();
        }
    }
}
