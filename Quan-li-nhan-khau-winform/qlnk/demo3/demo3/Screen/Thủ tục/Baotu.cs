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

namespace demo3.Screen.Thủ_tục
{
    public partial class Baotu : TempaltesForm
    {
        string flag;
        Baotu1 sua = new Baotu1();
        Baotu1 xoa = new Baotu1();
        ListBaotu1 dsbaotu = new ListBaotu1();
        DataTable dtbt;
        public Baotu()
        {
            InitializeComponent();
        }
        public DataTable createtable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Ngày mất");
            dt.Columns.Add("Lí do mất");
            dt.Columns.Add("Người khai");
            dt.Columns.Add("Ngày khai");
            dt.Columns.Add("Ghi chú");
            return dt;
        }
        public void Khoitao()
        {
            Baotu1 temp = dsbaotu.pHead;
            while (temp != null)
            {
                dtbt.Rows.Add(temp.sHovaten, temp.sNgaymat, temp.sLidomat, temp.sNguoikhai, temp.sNgaykhai, temp.sGhichu);
                temp = temp.next;
            }
            dataGridViewBaotu.DataSource = dtbt;
            dataGridViewBaotu.RefreshEdit();
        }
        public void GhiBaotu()
        {
            FileStream fnv = new FileStream("..\\Baotu.txt", FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            Baotu1 temp = dsbaotu.pHead;
            while (temp != null)
            {
                swrite.WriteLine(temp.sHovaten);
                swrite.WriteLine(temp.sNgaymat);
                swrite.WriteLine(temp.sLidomat);
                swrite.WriteLine(temp.sNguoikhai);
                swrite.WriteLine(temp.sNgaykhai);
                swrite.WriteLine(temp.sGhichu);
                temp = temp.next;
            }
            temp = new Baotu1();
            swrite.Flush();
            fnv.Close();
        }
        public void DocBaotu()
        {
            StreamReader fp = new StreamReader("..\\Baotu.txt");
            string line;
            int dem = 1, kiemtra;
            Baotu1 temp = new Baotu1();
            while ((line = fp.ReadLine()) != null)
            {
                kiemtra = 6 * (dem % 6) + 1;
                if (kiemtra == 7) temp.sHovaten = line;
                if (kiemtra == 13) temp.sNgaymat = line;
                if (kiemtra == 19) temp.sLidomat = line;
                if (kiemtra == 25) temp.sNguoikhai = line;
                if (kiemtra == 31) temp.sNgaykhai = line;
                if (kiemtra == 1) temp.sGhichu = line;
                if (dem % 6 == 0)
                {
                    dsbaotu.Addtail(temp);
                    temp = new Baotu1();
                }
                dem++;
            }
            fp.Close();
        }
        private void Block()
        {
            textBoxHovaten.Enabled = false;
            textBoxNgaymat.Enabled = false;
            textBoxLidomat.Enabled = false;
            textBoxNguoikhai.Enabled = false;
            textBoxNgaykhai.Enabled = false;
            textBoxGhichu.Enabled = false;
            btLuu.Enabled = false;
        }
        private void Unlock()
        {
            textBoxHovaten.Enabled = true;
            textBoxNgaymat.Enabled = true;
            textBoxLidomat.Enabled = true;
            textBoxNguoikhai.Enabled = true;
            textBoxNgaykhai.Enabled = true;
            textBoxGhichu.Enabled = true;
            btLuu.Enabled = true;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            Unlock();
            textBoxHovaten.Text = " ";
            textBoxNgaymat.Text = " ";
            textBoxLidomat.Text = " ";
            textBoxNguoikhai.Text = " ";
            textBoxNgaykhai.Text = " ";
            textBoxGhichu.Text = " ";
        }

        private void dataGridViewBaotu_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewBaotu.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridViewBaotu.DataSource;
            if (dt.Rows.Count > 0)
            {
                textBoxHovaten.Text = dataGridViewBaotu.Rows[index].Cells[0].Value.ToString();
                textBoxNgaymat.Text = dataGridViewBaotu.Rows[index].Cells[1].Value.ToString();
                textBoxLidomat.Text = dataGridViewBaotu.Rows[index].Cells[2].Value.ToString();
                textBoxNguoikhai.Text = dataGridViewBaotu.Rows[index].Cells[3].Value.ToString();
                textBoxNgaykhai.Text = dataGridViewBaotu.Rows[index].Cells[4].Value.ToString();
                textBoxGhichu.Text = dataGridViewBaotu.Rows[index].Cells[5].Value.ToString();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            flag = "delete";
            xoa = dsbaotu.pHead;
            if (MessageBox.Show("Bạn có thật sự muốn xóa hồ sơ báo tử này?", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                    int temp = dataGridViewBaotu.CurrentCell.RowIndex;
                    dsbaotu.RemoveNode(xoa,temp);
                    DataGridViewRow index = dataGridViewBaotu.CurrentRow;
                    dataGridViewBaotu.Rows.Remove(index);
            }
            Block();
            btLuu.Enabled = true;
            dataGridViewBaotu.RefreshEdit();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = true;
                if (flag == "add")
                {
                    Baotu1 p = new Baotu1();
                    p.sHovaten = textBoxHovaten.Text;
                    p.sNgaymat = textBoxNgaymat.Text;
                    p.sLidomat = textBoxLidomat.Text;
                    p.sNguoikhai = textBoxNguoikhai.Text;
                    p.sNgaykhai = textBoxNgaykhai.Text;
                    p.sGhichu = textBoxGhichu.Text;
                    dsbaotu.Addtail(p);
                    dtbt.Rows.Add(p.sHovaten, p.sNgaymat, p.sLidomat, p.sNguoikhai, p.sNgaykhai, p.sGhichu);
                    dataGridViewBaotu.DataSource = dtbt;
                    dataGridViewBaotu.RefreshEdit();
                }
                if (flag == "edit")
                {
                    Baotu1 dssua = dsbaotu.pHead;
                    dsbaotu.pHead = sua;
                    dsbaotu.pHead.sHovaten = textBoxHovaten.Text;
                    dsbaotu.pHead.sNgaymat = textBoxNgaymat.Text;
                    dsbaotu.pHead.sLidomat = textBoxLidomat.Text;
                    dsbaotu.pHead.sNguoikhai = textBoxNguoikhai.Text;
                    dsbaotu.pHead.sNgaykhai = textBoxNgaykhai.Text;
                    dsbaotu.pHead.sGhichu = textBoxGhichu.Text;
                    dsbaotu.pHead = dssua;
                    int index = dataGridViewBaotu.CurrentCell.RowIndex;
                    DataTable dt = (DataTable)dataGridViewBaotu.DataSource;
                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewBaotu.Rows[index].Cells[0].Value = textBoxHovaten.Text;
                        dataGridViewBaotu.Rows[index].Cells[1].Value = textBoxNgaymat.Text;
                        dataGridViewBaotu.Rows[index].Cells[2].Value = textBoxLidomat.Text;
                        dataGridViewBaotu.Rows[index].Cells[3].Value = textBoxNguoikhai.Text;
                        dataGridViewBaotu.Rows[index].Cells[4].Value = textBoxNgaykhai.Text;
                        dataGridViewBaotu.Rows[index].Cells[5].Value = textBoxGhichu.Text;
                    }
                    dataGridViewBaotu.RefreshEdit();
                }
                Unlock();
                GhiBaotu();
                Block();
            
        }

        private void Baotu_Load(object sender, EventArgs e)
        {
            dtbt = createtable();
            DocBaotu();
            Khoitao();
            Block();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            sua = dsbaotu.pHead;
            while (sua.sHovaten != textBoxHovaten.Text) sua = sua.next;
            Unlock();
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = false;
        }

        private void textBoxNgaykhai_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGhichu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


















































































































































































































































































































































































































































































































































































































































 