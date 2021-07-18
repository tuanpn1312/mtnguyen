using DoAn1.Sach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        Sach.SachController sachController = new Sach.SachController();

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPurchase_MouseEnter(object sender, EventArgs e)
        {
            BtnPurchase.ForeColor = Color.White;
            BtnPurchase.BackColor = Color.Green;
        }

        private void BtnPurchase_MouseLeave(object sender, EventArgs e)
        {
            BtnPurchase.ForeColor = Color.White;
            BtnPurchase.BackColor = Color.Transparent;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Green;
            btnAdd.ForeColor = Color.FromArgb(208, 165, 112);
            btnAdd.IconColor = Color.FromArgb(208, 165, 112);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(208, 165, 112);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconColor = Color.White;
        }

        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.FromArgb(208, 165, 112);
            btnXoa.IconColor = Color.FromArgb(208, 165, 112);
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.FromArgb(208, 165, 112);
            btnXoa.ForeColor = Color.White;
            btnXoa.IconColor = Color.White;
        }

        private void BtnSearch_MouseEnter(object sender, EventArgs e)
        {
            BtnSearch.BackColor = Color.White;
            BtnSearch.IconColor = Color.FromArgb(23, 22, 50);
        }

        private void BtnSearch_MouseLeave(object sender, EventArgs e)
        {
            BtnSearch.BackColor = Color.FromArgb(23, 22, 50);
            BtnSearch.IconColor = Color.White;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
                string ID = txtSearch.Text;
                if (sachController.checkIDBook(ID))
                {
                    MessageBox.Show("Sách Không tồn tại", "Hoá Đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSearch.Text == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Sách", "Hoá Đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int SoLuongSachDangCoTrongHoaDon = LaySoLuongSachTrongHoaDon();
                    int SoLuongTrongKho = sachController.LaySoLuongSachTon(ID);
                    if (SoLuongSachDangCoTrongHoaDon == SoLuongTrongKho)
                    {
                        MessageBox.Show("Số Lượng Sách Không Đủ", "Hoá Đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int quantity = 1;
                        if (KiemTraSachCoTrongHoaDonChua())
                        {
                            Global.Global.listHoaDon.Add(new SachModel(ID, Global.Global.TenSach, quantity, Global.Global.Gia));
                            fillGrid();
                            txtSearch.Text = "";
                        }
                        else
                        {
                            TangSoSachCoTrongHoaDon();
                            fillGrid();
                            txtSearch.Text = "";
                        }
                    }
                }
        }

        private bool KiemTraSachCoTrongHoaDonChua()
        {
            string ID = txtSearch.Text;

            for (int i = 0; i < Global.Global.listHoaDon.Count; i++)
            {
                if (Global.Global.listHoaDon[i].maSach == ID)
                {
                    return false;
                }
            }
            return true;
        }

        private int LaySoLuongSachTrongHoaDon()
        {
            string ID = txtSearch.Text;

            if (Global.Global.listHoaDon.Count > 0)
            {
                for (int i = 0; i < Global.Global.listHoaDon.Count; i++)
                {
                    if (Global.Global.listHoaDon[i].maSach == ID)
                    {
                         return Global.Global.listHoaDon[i].soLuongTon;
                    }
                }
            }
            return 0;
        }

        private void TangSoSachCoTrongHoaDon()
        {
            string ID = txtSearch.Text;

            if (Global.Global.listHoaDon.Count > 0)
            {
                for (int i = 0; i < Global.Global.listHoaDon.Count; i++)
                {
                    if (Global.Global.listHoaDon[i].maSach == ID)
                    {
                        Global.Global.listHoaDon[i].soLuongTon++;
                    }
                }
            }
        }

        private void fillGrid()
        {
            dataGridViewBook.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridViewBook.RowTemplate.Height = 80;

            dataGridViewBook.DataSource = null;

            dataGridViewBook.DataSource = Global.Global.listHoaDon;

            dataGridViewBook.Columns[2].Visible = false;

            dataGridViewBook.Columns[3].Visible = false;

            dataGridViewBook.Columns[4].Visible = false;

            dataGridViewBook.Columns[5].Visible = false;

            setHeader();

            dataGridViewBook.AllowUserToAddRows = false;

            dataGridViewBook.ClearSelection();
        }

        private void setHeader()
        {
            dataGridViewBook.Columns["maSach"].HeaderText = "Mã Sách";

            dataGridViewBook.Columns["tenSach"].HeaderText = "Tên Sách";

            dataGridViewBook.Columns["soLuongTon"].HeaderText = "Số Lượng Mua";

            dataGridViewBook.Columns["gia"].HeaderText = "Giá";
        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewBook.Rows[e.RowIndex];
                    Global.Global.setMaSach(row.Cells[0].Value.ToString());
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (SachModel sach in Global.Global.listHoaDon)
                {
                    if (string.Equals(sach.maSach, Global.Global.MaSach))
                    {
                        Global.Global.listHoaDon.Remove(sach);
                        fillGrid();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {

        }
    }
}
