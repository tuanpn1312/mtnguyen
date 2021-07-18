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
    public partial class Dienbien : TempaltesForm
    {
        public Dienbien()
        {
            InitializeComponent();
        }
        string flag;
        Dienbien1 sua1 = new Dienbien1();
        Dienbien1 xoa1 = new Dienbien1();
        ListDienbien1 dsdienbien = new ListDienbien1();
        DataTable dtbt;
        public DataTable createtable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Nơi đi");
            dt.Columns.Add("Ngày đi");
            dt.Columns.Add("Nơi đến");
            dt.Columns.Add("Ngày đến");
            dt.Columns.Add("Lí do");
            dt.Columns.Add("Ngày lập");
            return dt;
        }
        public void Khoitao()
        {
            Dienbien1 temp = dsdienbien.pHead;
            while (temp != null)
            {
                dtbt.Rows.Add(temp.sHovaten, temp.sNoidi, temp.sNgaydi, temp.sNoiden, temp.sNgayden, temp.sLido,temp.sNgaylap);
                temp = temp.next;
            }
            dataGridViewDienbien.DataSource = dtbt;
            dataGridViewDienbien.RefreshEdit();
        }
        public void GhiDienbien()
        {
            FileStream fnv = new FileStream("..\\Dienbien.txt", FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            Dienbien1 temp = dsdienbien.pHead;
            while (temp != null)
            {
                swrite.WriteLine(temp.sHovaten);
                swrite.WriteLine(temp.sNoidi);
                swrite.WriteLine(temp.sNgaydi);
                swrite.WriteLine(temp.sNoiden);
                swrite.WriteLine(temp.sNgayden);
                swrite.WriteLine(temp.sLido);
                swrite.WriteLine(temp.sNgaylap);
                temp = temp.next;
            }
            temp = new Dienbien1();
            swrite.Flush();
            fnv.Close();
        }
        public void DocDienbien()
        {
            StreamReader fp = new StreamReader("..\\Dienbien.txt");
            string line;
            int dem = 1, kiemtra;
            Dienbien1 temp = new Dienbien1();
            while ((line = fp.ReadLine()) != null)
            {
                kiemtra = 7 * (dem % 7) + 1;
                if (kiemtra == 8) temp.sHovaten = line;
                if (kiemtra == 15) temp.sNoidi = line;
                if (kiemtra == 22) temp.sNgaydi = line;
                if (kiemtra == 29) temp.sNoiden = line;
                if (kiemtra == 36) temp.sNgayden = line;
                if (kiemtra == 43) temp.sLido = line;
                if (kiemtra == 1) temp.sNgaylap = line;
                if (dem % 7 == 0)
                {
                    dsdienbien.Addtail(temp);
                    temp = new Dienbien1();
                }
                dem++;
            }
            fp.Close();
        }
        private void Block()
        {
            textBoxHovaten.Enabled = false;
            textBoxNoidi.Enabled = false;
            textBoxNgaydi.Enabled = false;
            textBoxNoiden.Enabled = false;
            textBoxNgayden.Enabled = false;
            textBoxLido.Enabled = false;
            textBoxNgaylap.Enabled = false;
            btLuu.Enabled =false;
        }
        private void Unlock()
        {
            textBoxHovaten.Enabled = true;
            textBoxNoidi.Enabled = true;
            textBoxNgaydi.Enabled = true;
            textBoxNoiden.Enabled = true;
            textBoxNgayden.Enabled = true;
            textBoxLido.Enabled = true;
            textBoxNgaylap.Enabled = true;
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
            textBoxNoidi.Text = " ";
            textBoxNgaydi.Text = " ";
            textBoxNoiden.Text = " ";
            textBoxNgayden.Text = " ";
            textBoxLido.Text = " ";
            textBoxNgaylap.Text = " ";
        }

        private void dataGridViewDienbien_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewDienbien.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridViewDienbien.DataSource;
            if (dt.Rows.Count > 0)
            {
                textBoxHovaten.Text = dataGridViewDienbien.Rows[index].Cells[0].Value.ToString();
                textBoxNoiden.Text = dataGridViewDienbien.Rows[index].Cells[1].Value.ToString();
                textBoxNgayden.Text = dataGridViewDienbien.Rows[index].Cells[2].Value.ToString();
                textBoxNoidi.Text = dataGridViewDienbien.Rows[index].Cells[3].Value.ToString();
                textBoxNgaydi.Text = dataGridViewDienbien.Rows[index].Cells[4].Value.ToString();
                textBoxLido.Text = dataGridViewDienbien.Rows[index].Cells[5].Value.ToString();
                textBoxNgaylap.Text = dataGridViewDienbien.Rows[index].Cells[6].Value.ToString();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            flag = "delete";
            xoa1 = dsdienbien.pHead;
            if (MessageBox.Show("Bạn có thật sự muốn xóa hồ sơ diễn biến này?", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int temp = dataGridViewDienbien.CurrentCell.RowIndex;
                    dsdienbien.RemoveNode(xoa1, temp);
                    DataGridViewRow index = dataGridViewDienbien.CurrentRow;
                    dataGridViewDienbien.Rows.Remove(index);
            }
            Block();
            btLuu.Enabled = true;
            dataGridViewDienbien.RefreshEdit();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = btLuu.Enabled = true;
            if (flag == "add")
            {
                Dienbien1 p = new Dienbien1();
                p.sHovaten = textBoxHovaten.Text;
                p.sNoidi = textBoxNoidi.Text;
                p.sNgaydi = textBoxNgaydi.Text;
                p.sNoiden = textBoxNoiden.Text;
                p.sNgayden = textBoxNgayden.Text;
                p.sLido = textBoxLido.Text;
                p.sNgaylap = textBoxNgaylap.Text;
                dsdienbien.Addtail(p);
                dtbt.Rows.Add(p.sHovaten, p.sNoidi, p.sNgaydi, p.sNoiden, p.sNgayden, p.sLido);
                dataGridViewDienbien.DataSource = dtbt;
                dataGridViewDienbien.RefreshEdit();
            }
            if (flag == "edit")
            {
                Dienbien1 dssua = dsdienbien.pHead;
                dsdienbien.pHead = sua1;
                dsdienbien.pHead.sHovaten = textBoxHovaten.Text;
                dsdienbien.pHead.sNoidi = textBoxNoidi.Text;
                dsdienbien.pHead.sNgaydi = textBoxNgaydi.Text;
                dsdienbien.pHead.sNoiden = textBoxNoiden.Text;
                dsdienbien.pHead.sNgayden = textBoxNgayden.Text;
                dsdienbien.pHead.sLido = textBoxLido.Text;
                dsdienbien.pHead.sNgaylap = textBoxNgaylap.Text;
                dsdienbien.pHead = dssua;
                int index = dataGridViewDienbien.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dataGridViewDienbien.DataSource;
                if (dt.Rows.Count > 0)
                {
                    dataGridViewDienbien.Rows[index].Cells[0].Value = textBoxHovaten.Text;
                    dataGridViewDienbien.Rows[index].Cells[1].Value = textBoxNoidi.Text;
                    dataGridViewDienbien.Rows[index].Cells[2].Value = textBoxNgaydi.Text;
                    dataGridViewDienbien.Rows[index].Cells[3].Value = textBoxNoiden.Text;
                    dataGridViewDienbien.Rows[index].Cells[4].Value = textBoxNgayden.Text;
                    dataGridViewDienbien.Rows[index].Cells[5].Value = textBoxLido.Text;
                    dataGridViewDienbien.Rows[index].Cells[6].Value = textBoxNgaylap.Text;
                }
                dataGridViewDienbien.RefreshEdit();
            }
            Block();
            GhiDienbien();
            Block();
        }

        private void Dienbien_Load(object sender, EventArgs e)
        {
            dtbt = createtable();
            DocDienbien();
            Khoitao();
            Block();
        }

        private void dataGridViewDienbien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            sua1 = dsdienbien.pHead;
            while (sua1.sHovaten != textBoxHovaten.Text) sua1 = sua1.next;
            Unlock();
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = false;
        }

     
    }

}

