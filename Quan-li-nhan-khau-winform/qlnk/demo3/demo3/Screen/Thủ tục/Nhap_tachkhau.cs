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
    public partial class Nhap_tachkhau : TempaltesForm
    {
        public Nhap_tachkhau()
        {
            InitializeComponent();
        }
        string flag;
        Nhap_tachkhau1 sua1 = new Nhap_tachkhau1();
        Nhap_tachkhau1 xoa1 = new Nhap_tachkhau1();
        ListNhap_tachkhau1 dsnhaptachkhau = new ListNhap_tachkhau1();
        DataTable dtbt;
        public DataTable createtable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Số sổ hộ khẩu hiện tại");
            dt.Columns.Add("Số sổ hộ khẩu đã nhập");
            dt.Columns.Add("Quan hệ với chủ hộ");
            dt.Columns.Add("Ngày nhập");
            return dt;
        }
        public void Khoitao()
        {
            Nhap_tachkhau1 temp = dsnhaptachkhau.pHead;
            while (temp != null)
            {
                dtbt.Rows.Add(temp.sHovaten, temp.sSohkht, temp.sSohkdn, temp.sQhe, temp.sNgaynhap);
                temp = temp.next;
            }
            dataGridViewNhaptachkhau.DataSource = dtbt;
            dataGridViewNhaptachkhau.RefreshEdit();
        }
        public void GhiNhaptachkhau()
        {
            FileStream fnv = new FileStream("..\\Nhaptachkhau.txt", FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            Nhap_tachkhau1 temp = dsnhaptachkhau.pHead;
            while (temp != null)
            {
                swrite.WriteLine(temp.sHovaten);
                swrite.WriteLine(temp.sSohkht);
                swrite.WriteLine(temp.sSohkdn);
                swrite.WriteLine(temp.sQhe);
                swrite.WriteLine(temp.sNgaynhap);
                temp = temp.next;
            }
            temp = new Nhap_tachkhau1();
            swrite.Flush();
            fnv.Close();
        }
        public void DocNhaptachkhau()
        {
            StreamReader fp = new StreamReader("..\\Nhaptachkhau.txt");
            string line;
            int dem = 1, kiemtra;
            Nhap_tachkhau1 temp = new Nhap_tachkhau1();
            while ((line = fp.ReadLine()) != null)
            {
                kiemtra = 5 * (dem % 5) + 1;
                if (kiemtra == 6) temp.sHovaten = line;
                if (kiemtra == 11) temp.sSohkht = line;
                if (kiemtra == 16) temp.sSohkdn = line;
                if (kiemtra == 21) temp.sQhe = line;
                if (kiemtra == 1) temp.sNgaynhap = line;
                if (dem % 5 == 0)
                {
                    dsnhaptachkhau.Addtail(temp);
                    temp = new Nhap_tachkhau1();
                }
                dem++;
            }
            fp.Close();
        }
        private void Block()
        {
            hovaten.Enabled = false;
            sosohokhauhientai.Enabled = false;
            sosohokhaunhap.Enabled = false;
            quanhechuho.Enabled = false;
            ngaynhap.Enabled = false;
            btLuu.Enabled = false;
        }
        private void Unlock()
        {
            hovaten.Enabled = true;
            sosohokhauhientai.Enabled = true;
            sosohokhaunhap.Enabled = true;
            quanhechuho.Enabled = true;
            ngaynhap.Enabled = true;
            btLuu.Enabled = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            Unlock();
            hovaten.Text = " ";
            sosohokhauhientai.Text = " ";
            sosohokhaunhap.Text = " ";
            quanhechuho.Text = " ";
            ngaynhap.Text = " ";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            sua1 = dsnhaptachkhau.pHead;
            while (sua1.sHovaten != hovaten.Text) sua1 = sua1.next;
            Unlock();
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            flag = "delete";
            xoa1 = dsnhaptachkhau.pHead;
            if (MessageBox.Show("Bạn có thật sự muốn xóa hồ sơ diễn biến này?", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int temp = dataGridViewNhaptachkhau.CurrentCell.RowIndex;
                    dsnhaptachkhau.RemoveNode(xoa1, temp);
                    DataGridViewRow index = dataGridViewNhaptachkhau.CurrentRow;
                    dataGridViewNhaptachkhau.Rows.Remove(index);
            }
            Block();
            btLuu.Enabled = true;
            dataGridViewNhaptachkhau.RefreshEdit();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = btLuu.Enabled = true;
            if (flag == "add")
            {
                Nhap_tachkhau1 p = new Nhap_tachkhau1();
                p.sHovaten = hovaten.Text;
                p.sSohkht = sosohokhauhientai.Text;
                p.sSohkdn = sosohokhaunhap.Text;
                p.sQhe = quanhechuho.Text;
                p.sNgaynhap = ngaynhap.Text;
                dsnhaptachkhau.Addtail(p);
                dtbt.Rows.Add(p.sHovaten, p.sSohkht, p.sSohkdn, p.sQhe, p.sNgaynhap);
                dataGridViewNhaptachkhau.DataSource = dtbt;
                dataGridViewNhaptachkhau.RefreshEdit();
            }
            if (flag == "edit")
            {
                Nhap_tachkhau1 dssua = dsnhaptachkhau.pHead;
                dsnhaptachkhau.pHead = sua1;
                dsnhaptachkhau.pHead.sHovaten = hovaten.Text;
                dsnhaptachkhau.pHead.sSohkht = sosohokhauhientai.Text;
                dsnhaptachkhau.pHead.sSohkdn = sosohokhaunhap.Text;
                dsnhaptachkhau.pHead.sQhe = quanhechuho.Text;
                dsnhaptachkhau.pHead.sNgaynhap = ngaynhap.Text;
                dsnhaptachkhau.pHead = dssua;
                int index = dataGridViewNhaptachkhau.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dataGridViewNhaptachkhau.DataSource;
                if (dt.Rows.Count > 0)
                {
                    dataGridViewNhaptachkhau.Rows[index].Cells[0].Value = hovaten.Text;
                    dataGridViewNhaptachkhau.Rows[index].Cells[1].Value = sosohokhauhientai.Text;
                    dataGridViewNhaptachkhau.Rows[index].Cells[2].Value = sosohokhaunhap.Text;
                    dataGridViewNhaptachkhau.Rows[index].Cells[3].Value = quanhechuho.Text;
                    dataGridViewNhaptachkhau.Rows[index].Cells[4].Value = ngaynhap.Text;
                }
                dataGridViewNhaptachkhau.RefreshEdit();
            }
            Unlock();
            GhiNhaptachkhau();
            Block();
        }

        private void dataGridViewNhaptachkhau_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewNhaptachkhau.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridViewNhaptachkhau.DataSource;
            if (dt.Rows.Count > 0)
            {
                hovaten.Text = dataGridViewNhaptachkhau.Rows[index].Cells[0].Value.ToString();
                sosohokhauhientai.Text = dataGridViewNhaptachkhau.Rows[index].Cells[1].Value.ToString();
                sosohokhaunhap.Text = dataGridViewNhaptachkhau.Rows[index].Cells[2].Value.ToString();
                quanhechuho.Text = dataGridViewNhaptachkhau.Rows[index].Cells[3].Value.ToString();
                ngaynhap.Text = dataGridViewNhaptachkhau.Rows[index].Cells[4].Value.ToString();
            }
        }

        private void Nhap_tachkhau_Load(object sender, EventArgs e)
        {
            dtbt = createtable();
            DocNhaptachkhau();
            Khoitao();
            Block();
        }

    

        private void uu_Click(object sender, EventArgs e)
        {

        }

        private void hovaten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sosohokhauhientai_TextChanged(object sender, EventArgs e)
        {

        }

        private void ngaynhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
