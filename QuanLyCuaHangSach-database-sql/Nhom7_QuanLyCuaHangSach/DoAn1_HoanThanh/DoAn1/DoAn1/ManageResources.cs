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
using DoAn1.Connection;
using FontAwesome.Sharp;

namespace DoAn1
{
    public partial class ManageResources : Form
    {
        public ManageResources()
        {
            InitializeComponent();
        }

        Sach.SachController sach = new Sach.SachController();

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.White;
            iconButton1.IconColor = Color.FromArgb(225, 186, 145);

        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FromArgb(225, 186, 145);
            iconButton1.IconColor = Color.White;

        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            BtnAdd.BackColor = Color.Green;
            BtnAdd.IconColor = Color.FromArgb(225, 186, 145);

        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            BtnAdd.BackColor = Color.FromArgb(225, 186, 145);
            BtnAdd.IconColor = Color.White;

        }

        private void BtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            BtnUpdate.BackColor = Color.Turquoise;
            BtnUpdate.IconColor = Color.FromArgb(225, 186, 145);

        }

        private void BtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            BtnUpdate.BackColor = Color.FromArgb(225, 186, 145);
            BtnUpdate.IconColor = Color.White;

        }

        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
            BtnDelete.BackColor = Color.Red;
            BtnDelete.IconColor = Color.FromArgb(225, 186, 145);

        }

        private void BtnDelete_MouseLeave(object sender, EventArgs e)
        {
            BtnDelete.BackColor = Color.FromArgb(225, 186, 145);
            BtnDelete.IconColor = Color.White;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            string ID = txtMaSach.Text;
            string name = txtTenSach.Text;
            string tacgia = txtTacGia.Text;
            string nxb = txtNXB.Text;
            string moTa = txtMota.Text;
            string danhMuc = txtTheLoai.Text;
            int sl = Convert.ToInt32(txtQuantity.Text);
            int gia = Convert.ToInt32(txtGia.Text);

            if (verif())
            {
                if (sach.updateBook(ID, name, tacgia, nxb, moTa, danhMuc, sl, gia))
                {
                    MessageBox.Show("Sửa Sách Thành Công", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearText();
                    ShowAllBook();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = sach.getAllBook();

            if (table.Rows.Count > 0)
            {
                txtMaSach.Text = dataGridViewBook.CurrentRow.Cells[0].Value.ToString();
                txtTenSach.Text = dataGridViewBook.CurrentRow.Cells[1].Value.ToString();
                txtTacGia.Text = dataGridViewBook.CurrentRow.Cells[2].Value.ToString();
                txtNXB.Text = dataGridViewBook.CurrentRow.Cells[3].Value.ToString();
                txtMota.Text = dataGridViewBook.CurrentRow.Cells[4].Value.ToString();
                txtTheLoai.Text = dataGridViewBook.CurrentRow.Cells[5].Value.ToString();
                txtQuantity.Text = dataGridViewBook.CurrentRow.Cells[6].Value.ToString();
                txtGia.Text = dataGridViewBook.CurrentRow.Cells[8].Value.ToString();
            }
        }

        public void ShowAllBook()
        {
            Sach.SachController book = new Sach.SachController();
            dataGridViewBook.ReadOnly = true;
            dataGridViewBook.RowTemplate.Height = 80;
            dataGridViewBook.DataSource = book.getAllBook();
            dataGridViewBook.AllowUserToAddRows = false;
            dataGridViewBook.ClearSelection();
        }

        private void ManageResources_Load(object sender, EventArgs e)
        {
            ShowAllBook();
        }

        public void ShowBookByName()
        {
            string name = txtSearch.Text;
            dataGridViewBook.ReadOnly = true;
            dataGridViewBook.RowTemplate.Height = 80;
            dataGridViewBook.DataSource = sach.getBookByName(name);
            dataGridViewBook.AllowUserToAddRows = false;
            dataGridViewBook.ClearSelection();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ShowBookByName();
        }

        private void clearText()
        {
            txtMota.Text = "";
            txtGia.Text = "";
            txtMaSach.Text = "";
            txtNXB.Text = "";
            txtQuantity.Text = "";
            txtTacGia.Text = "";
            txtTenSach.Text = "";
            txtTheLoai.Text = "";
        }

        private bool verif()
        {
            if ((txtMota.Text.Trim() == "")
                   || (txtGia.Text.Trim() == "")
                   || (txtMaSach.Text.Trim() == "")
                   || (txtQuantity.Text.Trim() == "")
                   || (txtTacGia.Text.Trim() == "")
                   || (txtTenSach.Text.Trim() == "")
                   || (txtNXB.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            clearText();
            ShowAllBook();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = txtMaSach.Text;
                if ((MessageBox.Show("Are you sure you want to delete this book", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (sach.deleteBook(ID))
                    {
                        MessageBox.Show("Book Deleted", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllBook();
                        clearText();
                    }
                    else
                    {
                        MessageBox.Show("Book Not Deleted", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
