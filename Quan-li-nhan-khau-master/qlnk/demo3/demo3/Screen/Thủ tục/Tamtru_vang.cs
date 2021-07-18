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
    public partial class Tamtru_vang : TempaltesForm
    {
        public Tamtru_vang()
        {
            InitializeComponent();
        }
        string flag;
        Tamtru_tamvang1 sua = new Tamtru_tamvang1();
        Tamtru_tamvang1 xoa = new Tamtru_tamvang1();
        ListTamtru_tamvang1 dstttv = new ListTamtru_tamvang1();
        DataTable dtbt;
        public DataTable createtable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Ngày vắng");
            dt.Columns.Add("Vắng đến ngày");
            dt.Columns.Add("Lí do vắng");
            dt.Columns.Add("Người khai báo");
            dt.Columns.Add("Ngày lập");
            dt.Columns.Add("Ghi chú");
            return dt;
        }
        public void Khoitao()
        {
            Tamtru_tamvang1 temp = dstttv.pHead;
            while (temp != null)
            {
                dtbt.Rows.Add(temp.sHovaten, temp.sNgayvang, temp.sVangdenngay, temp.sLido , temp.sNguoikhaibao, temp.sNgaylap, temp.sGhichu);
                temp = temp.next;
            }
            dataGridViewTttv.DataSource = dtbt;
            dataGridViewTttv.RefreshEdit();
        }
        public void GhiTttv()
        {
            FileStream fnv = new FileStream("..\\Tamtrutamvang.txt", FileMode.Create);
            StreamWriter swrite = new StreamWriter(fnv, Encoding.UTF8);
            Tamtru_tamvang1 tam = dstttv.pHead;
            while (tam != null)
            {
                swrite.WriteLine(tam.sHovaten);
                swrite.WriteLine(tam.sNgayvang);
                swrite.WriteLine(tam.sVangdenngay);
                swrite.WriteLine(tam.sLido);
                swrite.WriteLine(tam.sNguoikhaibao);
                swrite.WriteLine(tam.sNgaylap);
                swrite.WriteLine(tam.sGhichu);
                tam = tam.next;
            }
            tam = new Tamtru_tamvang1();
            swrite.Flush();
            fnv.Close();
        }
        public void DocTttv()
        {
            StreamReader fp = new StreamReader("..\\Tamtrutamvang.txt");
            string line;
            int dem = 1, kiemtra;
            Tamtru_tamvang1 tam = new Tamtru_tamvang1();
            while ((line = fp.ReadLine()) != null)
            {
                kiemtra = 7 * (dem % 7) + 1;
                if (kiemtra == 8) tam.sHovaten = line;
                if (kiemtra == 15) tam.sNgayvang = line;
                if (kiemtra == 22) tam.sVangdenngay = line;
                if (kiemtra == 29) tam.sLido = line;
                if (kiemtra == 36) tam.sNguoikhaibao = line;
                if (kiemtra == 43) tam.sNgaylap = line;
                if (kiemtra == 1) tam.sGhichu = line;
                if (dem % 7 == 0)
                {
                    dstttv.Addtail(tam);
                    tam = new Tamtru_tamvang1();
                }
                dem++;
            }
            fp.Close();
        }
        private void Block()
        {
            textBoxHovaten.Enabled = false;
            textBoxNgayvang.Enabled = false;
            textBoxVangtoingay.Enabled = false;
            textBoxLido.Enabled = false;
            textBoxNguoikhaibao.Enabled = false;
            textBoxNgaylap.Enabled = false;
            textBoxGhichu.Enabled = false;
            btLuu.Enabled = false;
        }
        private void Unlock()
        {
            textBoxHovaten.Enabled = true;
            textBoxNgayvang.Enabled = true;
            textBoxVangtoingay.Enabled = true;
            textBoxLido.Enabled = true;
            textBoxNguoikhaibao.Enabled = true;
            textBoxNgaylap.Enabled = true;
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
            textBoxNgayvang.Text = " ";
            textBoxVangtoingay.Text = " ";
            textBoxLido.Text = " ";
            textBoxNguoikhaibao.Text = " ";
            textBoxNgaylap.Text = " ";
            textBoxGhichu.Text = " ";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            sua = dstttv.pHead;
            while (sua.sHovaten != textBoxHovaten.Text) sua = sua.next;
            Unlock();
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = true;
            if (flag == "add")
            {
                Tamtru_tamvang1 p = new Tamtru_tamvang1();
                p.sHovaten = textBoxHovaten.Text;
                p.sNgayvang = textBoxNgayvang.Text;
                p.sVangdenngay = textBoxVangtoingay.Text;
                p.sLido = textBoxLido.Text;
                p.sNguoikhaibao = textBoxNguoikhaibao.Text;
                p.sNgaylap = textBoxNgaylap.Text;
                p.sGhichu = textBoxGhichu.Text;
                dstttv.Addtail(p);
                dtbt.Rows.Add(p.sHovaten, p.sNgayvang, p.sVangdenngay, p.sLido, p.sNguoikhaibao, p.sNgaylap, p.sGhichu);
                dataGridViewTttv.DataSource = dtbt;
                dataGridViewTttv.RefreshEdit();
            }
            if (flag == "edit")
            {
                Tamtru_tamvang1 dssua = dstttv.pHead;
                dstttv.pHead = sua;
                dstttv.pHead.sHovaten = textBoxHovaten.Text;
                dstttv.pHead.sNgayvang = textBoxNgayvang.Text;
                dstttv.pHead.sVangdenngay = textBoxVangtoingay.Text;
                dstttv.pHead.sLido = textBoxLido.Text;
                dstttv.pHead.sNguoikhaibao = textBoxNguoikhaibao.Text;
                dstttv.pHead.sNgaylap = textBoxNgaylap.Text;
                dstttv.pHead.sGhichu = textBoxGhichu.Text;
                dstttv.pHead = dssua;
                int index = dataGridViewTttv.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dataGridViewTttv.DataSource;
                if (dt.Rows.Count > 0)
                {
                    dataGridViewTttv.Rows[index].Cells[0].Value = textBoxHovaten.Text;
                    dataGridViewTttv.Rows[index].Cells[1].Value = textBoxNgayvang.Text;
                    dataGridViewTttv.Rows[index].Cells[2].Value = textBoxVangtoingay.Text;
                    dataGridViewTttv.Rows[index].Cells[3].Value = textBoxLido.Text;
                    dataGridViewTttv.Rows[index].Cells[4].Value = textBoxNguoikhaibao.Text;
                    dataGridViewTttv.Rows[index].Cells[5].Value = textBoxNgaylap.Text;
                    dataGridViewTttv.Rows[index].Cells[6].Value = textBoxGhichu.Text;
                }
                dataGridViewTttv.RefreshEdit();
            }
            Unlock();
            GhiTttv();
            Block();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            flag = "delete";
            xoa = dstttv.pHead;
            if (MessageBox.Show("Bạn có thật sự muốn xóa hồ sơ báo tử này?", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int temp = dataGridViewTttv.CurrentCell.RowIndex;
                    dstttv.RemoveNode(xoa, temp);
                    DataGridViewRow index = dataGridViewTttv.CurrentRow;
                    dataGridViewTttv.Rows.Remove(index);
            }
            Block();
            btLuu.Enabled = true;
            dataGridViewTttv.RefreshEdit();
        }

        private void Tamtru_vang_Load(object sender, EventArgs e)
        {
            dtbt = createtable();
            DocTttv();
            Khoitao();
            Block();    
        }

        private void dataGridViewTttv_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewTttv.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridViewTttv.DataSource;
            if (dt.Rows.Count > 0)
            {
                textBoxHovaten.Text = dataGridViewTttv.Rows[index].Cells[0].Value.ToString();
                textBoxNgayvang.Text = dataGridViewTttv.Rows[index].Cells[1].Value.ToString();
                textBoxVangtoingay.Text = dataGridViewTttv.Rows[index].Cells[2].Value.ToString();
                textBoxLido.Text = dataGridViewTttv.Rows[index].Cells[3].Value.ToString();
                textBoxNguoikhaibao.Text = dataGridViewTttv.Rows[index].Cells[4].Value.ToString();
                textBoxNgaylap.Text = dataGridViewTttv.Rows[index].Cells[5].Value.ToString();
                textBoxGhichu.Text = dataGridViewTttv.Rows[index].Cells[6].Value.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
