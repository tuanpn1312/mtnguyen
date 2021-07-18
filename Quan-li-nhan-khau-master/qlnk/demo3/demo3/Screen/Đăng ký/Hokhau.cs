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
    public partial class Hokhau : TempaltesForm
    {
        public Hokhau()
        {
            InitializeComponent();
        }
        string flag;
        ListHoKhau1 dshk = new ListHoKhau1();
        HoKhau1 sua = new HoKhau1();
        HoKhau1 xoa = new HoKhau1();
        DataTable dtbt;
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
                dtbt.Rows.Add(temp.sSosohk, temp.sHovatenchuho, temp.sCMND, temp.sGioitinh, temp.sNgaysinh, temp.sDantoc, temp.sQuoctich, temp.sNgaydangky, temp.sChoohientai);
                temp = temp.next;
            }
            dataGridViewHokhau1.DataSource = dtbt;
            dataGridViewHokhau1.RefreshEdit();
        }
        public void GhiHokhau()
        {
            FileStream fnv = new FileStream("..\\Hokhau.txt", FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            HoKhau1 temp = dshk.pHead;
            while (temp != null)
            {
                swrite.WriteLine(temp.sSosohk);
                swrite.WriteLine(temp.sHovatenchuho);
                swrite.WriteLine(temp.sCMND);
                swrite.WriteLine(temp.sGioitinh);
                swrite.WriteLine(temp.sNgaysinh);
                swrite.WriteLine(temp.sDantoc);
                swrite.WriteLine(temp.sQuoctich);
                swrite.WriteLine(temp.sNgaydangky);
                swrite.WriteLine(temp.sChoohientai);
                temp = temp.next;
            }
            temp = new HoKhau1();
            swrite.Flush();
            fnv.Close();
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
        private void Block()
        {
            textBoxSosohk.Enabled = false;
            textBoxHovaten.Enabled = false;
            textBoxCMND.Enabled = false;
            textBoxGioitinh.Enabled = false;
            textBoxNgaysinh.Enabled = false;
            textBoxDantoc.Enabled = false;
            textBoxQuoctich.Enabled = false;
            textBoxNgaydangky.Enabled = false;
            textBoxChohientai.Enabled = false;
            buttonLuu.Enabled = false;
        }
        private void Unlock()
        {
            textBoxSosohk.Enabled = true;
            textBoxHovaten.Enabled = true;
            textBoxCMND.Enabled = true;
            textBoxGioitinh.Enabled = true;
            textBoxNgaysinh.Enabled = true;
            textBoxDantoc.Enabled = true;
            textBoxQuoctich.Enabled = true;
            textBoxNgaydangky.Enabled = true;
            textBoxChohientai.Enabled = true;
            buttonLuu.Enabled = true;
        }
        private void Hokhau_Load(object sender, EventArgs e)
        {
            dtbt = createtable();
            DocHoKhau();
            Khoitao();
            Block();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            buttonThem.Enabled = false;
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            Unlock();
            textBoxSosohk.Text = " ";
            textBoxHovaten.Text = " ";
            textBoxCMND.Text = " ";
            textBoxGioitinh.Text = " ";
            textBoxNgaysinh.Text = " ";
            textBoxDantoc.Text = " ";
            textBoxQuoctich.Text = " ";
            textBoxNgaydangky.Text = " ";
            textBoxChohientai.Text = " ";
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            sua = dshk.pHead;
            while (sua.sSosohk != textBoxSosohk.Text) sua = sua.next;
            Unlock();
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            if (flag == "add")
            {
                HoKhau1 p = new HoKhau1();
                p.sSosohk = textBoxSosohk.Text;
                p.sHovatenchuho = textBoxHovaten.Text;
                p.sCMND = textBoxCMND.Text;
                p.sGioitinh = textBoxGioitinh.Text;
                p.sNgaysinh = textBoxNgaysinh.Text;
                p.sDantoc = textBoxDantoc.Text;
                p.sQuoctich = textBoxQuoctich.Text;
                p.sNgaydangky = textBoxNgaydangky.Text;
                p.sChoohientai = textBoxChohientai.Text;
                dshk.Addtail(p);
                dtbt.Rows.Add(p.sSosohk, p.sHovatenchuho, p.sCMND, p.sGioitinh, p.sNgaysinh, p.sDantoc, p.sQuoctich, p.sNgaydangky, p.sChoohientai);
                dataGridViewHokhau1.DataSource = dtbt;
                dataGridViewHokhau1.RefreshEdit();
            }
            if (flag == "edit")
            {
                HoKhau1 dssua = dshk.pHead;
                dshk.pHead = sua;
                sua.sSosohk = textBoxSosohk.Text;
                sua.sHovatenchuho = textBoxHovaten.Text;
                sua.sCMND = textBoxCMND.Text;
                sua.sGioitinh = textBoxGioitinh.Text;
                sua.sNgaysinh = textBoxNgaysinh.Text;
                sua.sDantoc = textBoxDantoc.Text;
                sua.sQuoctich = textBoxQuoctich.Text;
                sua.sNgaydangky = textBoxNgaydangky.Text;
                sua.sChoohientai = textBoxChohientai.Text;
                dshk.pHead = dssua;
                int index = dataGridViewHokhau1.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dataGridViewHokhau1.DataSource;
                if (dt.Rows.Count > 0)
                {
                    dataGridViewHokhau1.Rows[index].Cells[0].Value = textBoxSosohk.Text;
                    dataGridViewHokhau1.Rows[index].Cells[1].Value = textBoxHovaten.Text;
                    dataGridViewHokhau1.Rows[index].Cells[2].Value = textBoxCMND.Text;
                    dataGridViewHokhau1.Rows[index].Cells[3].Value = textBoxGioitinh.Text;
                    dataGridViewHokhau1.Rows[index].Cells[4].Value = textBoxNgaysinh.Text;
                    dataGridViewHokhau1.Rows[index].Cells[5].Value = textBoxDantoc.Text;
                    dataGridViewHokhau1.Rows[index].Cells[6].Value = textBoxQuoctich.Text;
                    dataGridViewHokhau1.Rows[index].Cells[7].Value = textBoxNgaydangky.Text;
                    dataGridViewHokhau1.Rows[index].Cells[8].Value = textBoxChohientai.Text;

                }
                dataGridViewHokhau1.RefreshEdit();
            }
            Unlock();
            GhiHokhau();
            Block();
        }

        private void dataGridViewHokhau1_SelectionChanged(object sender, EventArgs e)
        {

            int index = dataGridViewHokhau1.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridViewHokhau1.DataSource;
            if (dt.Rows.Count > 0)
            {
                textBoxSosohk.Text = dataGridViewHokhau1.Rows[index].Cells[0].Value.ToString();
                textBoxHovaten.Text = dataGridViewHokhau1.Rows[index].Cells[1].Value.ToString();
                textBoxCMND.Text = dataGridViewHokhau1.Rows[index].Cells[2].Value.ToString();
                textBoxGioitinh.Text = dataGridViewHokhau1.Rows[index].Cells[3].Value.ToString();
                textBoxNgaysinh.Text = dataGridViewHokhau1.Rows[index].Cells[4].Value.ToString();
                textBoxDantoc.Text = dataGridViewHokhau1.Rows[index].Cells[5].Value.ToString();
                textBoxQuoctich.Text = dataGridViewHokhau1.Rows[index].Cells[6].Value.ToString();
                textBoxNgaydangky.Text = dataGridViewHokhau1.Rows[index].Cells[7].Value.ToString();
                textBoxChohientai.Text = dataGridViewHokhau1.Rows[index].Cells[8].Value.ToString();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            flag = "delete";
            xoa = dshk.pHead;
            if (MessageBox.Show("Bạn có thật sự muốn xóa hộ khẩu này này?", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int temp = dataGridViewHokhau1.CurrentCell.RowIndex;
                    dshk.RemoveNode(xoa,temp);
                    DataGridViewRow index = dataGridViewHokhau1.CurrentRow;
                    dataGridViewHokhau1.Rows.Remove(index);
            }
            Block();
            buttonLuu.Enabled = true;
            dataGridViewHokhau1.RefreshEdit();
        }
    }
}
