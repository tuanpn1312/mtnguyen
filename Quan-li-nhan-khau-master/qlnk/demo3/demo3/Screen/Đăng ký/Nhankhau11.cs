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

namespace demo3.Screen.Đăng_ký
{
    public partial class Nhankhau11 : TempaltesForm
    {
        public Nhankhau11()
        {
            InitializeComponent();
        }
        string flag;
        ListHoKhau1 dshk = new ListHoKhau1();
        ListNhankhau1 dsnk = new ListNhankhau1();
        Nhankhau1 sua = new Nhankhau1();
        Nhankhau1 xoa = new Nhankhau1();
        DataTable dtbt;
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
        public void Khoitaocombobox()
        {
            List<string> item = new List<string>();
            HoKhau1 temp = dshk.pHead;
            while (temp != null)
            {
                item.Add(temp.sSosohk);
                temp = temp.next;
            }
            comboBox1.DataSource = item;
        }
        public void GhiNhankhau()
        {
            FileStream fnv = new FileStream("..\\Nhankhau.txt", FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            Nhankhau1 temp = dsnk.pHead;
            while (temp != null)
            {
                swrite.WriteLine(temp.sSosohk);
                swrite.WriteLine(temp.sQuanhe);
                swrite.WriteLine(temp.sHovaten);
                swrite.WriteLine(temp.sNgaysinh);
                swrite.WriteLine(temp.sDantoc);
                swrite.WriteLine(temp.sGioitinh);
                swrite.WriteLine(temp.sQuoctich);
                swrite.WriteLine(temp.sCmnd);
                swrite.WriteLine(temp.sNgaycap);
                swrite.WriteLine(temp.sNoicap);
                swrite.WriteLine(temp.sTDhocvan);
                swrite.WriteLine(temp.sNghenghiep);
                swrite.WriteLine(temp.sNoilamviec);
                swrite.WriteLine(temp.sTienan);
                swrite.WriteLine(temp.sNoisinh);
                swrite.WriteLine(temp.sNguyenquan);
                swrite.WriteLine(temp.sNoiott);
                swrite.WriteLine(temp.sChoohientai);
                swrite.WriteLine(temp.sGhichu);
                temp = temp.next;
            }
            temp = new Nhankhau1();
            swrite.Flush();
            fnv.Close();
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
        public void DocHokhau()
        {
            StreamReader fp = new StreamReader("..\\Hokhau.txt");
            string line;
            int dem = 1, kiemtra;
            HoKhau1 temp = new HoKhau1();
            while ((line = fp.ReadLine()) != null)
            {
                kiemtra = 9 * (dem % 9) + 1;
                if (kiemtra == 10) temp.sSosohk = line;
                if (dem % 9 == 0)
                {
                    dshk.Addtail(temp);
                    temp = new HoKhau1();
                }
                dem++;
            }
            fp.Close();
        }   
        private void Block()
        {
            comboBox1.Enabled = false;
            textBoxQuanhe.Enabled = false;
            textBoxHovaten.Enabled = false;
            textBoxNgaysinh.Enabled = false;
            textBoxDantoc.Enabled = false;
            TextboxGioitinh.Enabled = false;
            textBoxQuoctich.Enabled = false;
            textBoxCMND.Enabled = false;
            textBoxNgaycap.Enabled = false;
            textBoxNoicap.Enabled = false;
            textBoxTdhocvan.Enabled = false;
            textBoxNghenghiep.Enabled = false;
            textBoxNoilamviec.Enabled = false;
            textBoxTienan.Enabled = false;
            textBoxNoisinh.Enabled = false;
            textBoxNguyenquan.Enabled = false;
            textBoxChoothuongtru.Enabled = false;
            textBoxNoiohientai.Enabled = false;
            textBoxGhichu.Enabled = false;
            buttonLuu.Enabled = false;
        }
        private void Unlock()
        {
            comboBox1.Enabled = true;
            textBoxQuanhe.Enabled = true;
            textBoxHovaten.Enabled = true;
            textBoxNgaysinh.Enabled = true;
            textBoxDantoc.Enabled = true;
            TextboxGioitinh.Enabled = true;
            textBoxQuoctich.Enabled = true;
            textBoxCMND.Enabled = true;
            textBoxNgaycap.Enabled = true;
            textBoxNoicap.Enabled = true;
            textBoxTdhocvan.Enabled = true;
            textBoxNghenghiep.Enabled = true;
            textBoxNoilamviec.Enabled = true;
            textBoxTienan.Enabled = true;
            textBoxNoisinh.Enabled = true;
            textBoxNguyenquan.Enabled = true;
            textBoxChoothuongtru.Enabled = true;
            textBoxNoiohientai.Enabled = true;
            textBoxGhichu.Enabled = true;
            buttonLuu.Enabled = true;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            buttonThem.Enabled = false;
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            Unlock();
            comboBox1.Text = " ";
            textBoxQuanhe.Text = " ";
            textBoxHovaten.Text = " ";
            textBoxNgaysinh.Text = " ";
            textBoxDantoc.Text = " ";
            TextboxGioitinh.Text = " ";
            textBoxQuoctich.Text = " ";
            textBoxCMND.Text = " ";
            textBoxNgaycap.Text = " ";
            textBoxTdhocvan.Text = " ";
            textBoxNghenghiep.Text = " ";
            textBoxNoilamviec.Text = " ";
            textBoxTienan.Text = " ";
            textBoxNoisinh.Text = " ";
            textBoxNguyenquan.Text = " ";
            textBoxChoothuongtru.Text = " ";
            textBoxNoiohientai.Text = " ";
            textBoxGhichu.Text = " ";
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            sua = dsnk.pHead;
            while (sua.sHovaten != textBoxHovaten.Text)
            {
                sua = sua.next;
            }
            Unlock();
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            flag = "delete";
            xoa = dsnk.pHead;
            if (MessageBox.Show("Bạn có thật sự muốn xóa hộ khẩu này này?", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int temp = dataGridView1.CurrentCell.RowIndex;
                    dsnk.RemoveNode(xoa, temp);
                    DataGridViewRow index = dataGridView1.CurrentRow;
                    dataGridView1.Rows.Remove(index);
            }
            Block();
            buttonLuu.Enabled = true;
            dataGridView1.RefreshEdit();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            if (flag == "add")
            {
                Nhankhau1 p = new Nhankhau1();
                p.sSosohk = comboBox1.Text;
                p.sQuanhe = textBoxQuanhe.Text;
                p.sHovaten = textBoxHovaten.Text;
                p.sNgaysinh = textBoxNgaysinh.Text;
                p.sDantoc = textBoxDantoc.Text;
                p.sGioitinh = TextboxGioitinh.Text;
                p.sQuoctich = textBoxQuoctich.Text;
                p.sCmnd = textBoxCMND.Text;
                p.sNgaycap = textBoxNgaycap.Text;
                p.sNoicap = textBoxNoicap.Text;
                p.sTDhocvan = textBoxTdhocvan.Text;
                p.sNghenghiep = textBoxNghenghiep.Text;
                p.sNoilamviec = textBoxNoilamviec.Text;
                p.sTienan = textBoxTienan.Text;
                p.sNoisinh = textBoxNoisinh.Text;
                p.sNguyenquan = textBoxNguyenquan.Text;
                p.sNoiott = textBoxChoothuongtru.Text;
                p.sChoohientai = textBoxNoiohientai.Text;
                p.sGhichu = textBoxGhichu.Text;
                dsnk.Addtail(p);
                dtbt.Rows.Add(p.sSosohk, p.sQuanhe, p.sHovaten, p.sNgaysinh, p.sDantoc, p.sGioitinh, p.sQuoctich, p.sCmnd, p.sNgaycap,
                            p.sNoicap, p.sTDhocvan, p.sNghenghiep, p.sNoilamviec, p.sTienan, p.sNoisinh, p.sNguyenquan, p.sNoiott, p.sChoohientai,
                            p.sGhichu);
                dataGridView1.DataSource = dtbt;
                dataGridView1.RefreshEdit();
            }
            if (flag == "edit")
            {
                Nhankhau1 dssua = dsnk.pHead;
                dsnk.pHead = sua;
                dsnk.pHead.sSosohk = comboBox1.Text;
                sua.sQuanhe = textBoxQuanhe.Text;
                sua.sHovaten = textBoxHovaten.Text;
                sua.sNgaysinh = textBoxNgaysinh.Text;
                sua.sDantoc = textBoxDantoc.Text;
                sua.sGioitinh = TextboxGioitinh.Text;
                sua.sQuoctich = textBoxQuoctich.Text;
                sua.sCmnd = textBoxCMND.Text;
                sua.sNgaycap = textBoxNgaycap.Text;
                sua.sNoicap = textBoxNoicap.Text;
                sua.sTDhocvan = textBoxTdhocvan.Text;
                sua.sNghenghiep = textBoxNghenghiep.Text;
                sua.sNoilamviec = textBoxNoilamviec.Text;
                sua.sTienan = textBoxTienan.Text;
                sua.sNoisinh = textBoxNoisinh.Text;
                sua.sNguyenquan = textBoxNguyenquan.Text;
                sua.sNoiott = textBoxChoothuongtru.Text;
                sua.sChoohientai = textBoxNoiohientai.Text;
                sua.sGhichu = textBoxGhichu.Text;
                dsnk.pHead = dssua;
                int index = dataGridView1.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dataGridView1.DataSource;
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Rows[index].Cells[0].Value = comboBox1.Text;
                    dataGridView1.Rows[index].Cells[1].Value = textBoxQuanhe.Text;
                    dataGridView1.Rows[index].Cells[2].Value = textBoxHovaten.Text;
                    dataGridView1.Rows[index].Cells[3].Value = textBoxNgaysinh.Text;
                    dataGridView1.Rows[index].Cells[4].Value = textBoxDantoc.Text;
                    dataGridView1.Rows[index].Cells[5].Value = TextboxGioitinh.Text;
                    dataGridView1.Rows[index].Cells[6].Value = textBoxQuoctich.Text;
                    dataGridView1.Rows[index].Cells[7].Value = textBoxCMND.Text;
                    dataGridView1.Rows[index].Cells[8].Value = textBoxNgaycap.Text;
                    dataGridView1.Rows[index].Cells[9].Value = textBoxNoicap.Text;
                    dataGridView1.Rows[index].Cells[10].Value = textBoxTdhocvan.Text;
                    dataGridView1.Rows[index].Cells[11].Value = textBoxNghenghiep.Text;
                    dataGridView1.Rows[index].Cells[12].Value = textBoxNoilamviec.Text;
                    dataGridView1.Rows[index].Cells[13].Value = textBoxTienan.Text;
                    dataGridView1.Rows[index].Cells[14].Value = textBoxNoisinh.Text;
                    dataGridView1.Rows[index].Cells[15].Value = textBoxNguyenquan.Text;
                    dataGridView1.Rows[index].Cells[16].Value = textBoxChoothuongtru.Text;
                    dataGridView1.Rows[index].Cells[17].Value = textBoxNoiohientai.Text;
                    dataGridView1.Rows[index].Cells[18].Value = textBoxGhichu.Text;
                }
                dataGridView1.RefreshEdit();
            }
            Unlock();
            GhiNhankhau();
            Block();
        }
        private void Nhankhau11_Load(object sender, EventArgs e)
        {
            dtbt = createtable();
            DocHokhau();
            Khoitaocombobox();
            DocNhanKhau();
            Khoitao();
            Block();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dt.Rows.Count > 0)
            {
                comboBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                textBoxQuanhe.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                textBoxHovaten.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                textBoxNgaysinh.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                textBoxDantoc.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                TextboxGioitinh.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                textBoxQuoctich.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
                textBoxCMND.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
                textBoxNgaycap.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
                textBoxNoicap.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
                textBoxTdhocvan.Text = dataGridView1.Rows[index].Cells[10].Value.ToString();
                textBoxNghenghiep.Text = dataGridView1.Rows[index].Cells[11].Value.ToString();
                textBoxNoilamviec.Text = dataGridView1.Rows[index].Cells[12].Value.ToString();
                textBoxTienan.Text = dataGridView1.Rows[index].Cells[13].Value.ToString();
                textBoxNoisinh.Text = dataGridView1.Rows[index].Cells[14].Value.ToString();
                textBoxNguyenquan.Text = dataGridView1.Rows[index].Cells[15].Value.ToString();
                textBoxChoothuongtru.Text = dataGridView1.Rows[index].Cells[16].Value.ToString();
                textBoxNoiohientai.Text = dataGridView1.Rows[index].Cells[17].Value.ToString();
                textBoxGhichu.Text = dataGridView1.Rows[index].Cells[18].Value.ToString();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxQuoctich_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
