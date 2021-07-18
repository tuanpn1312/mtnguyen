using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class ManageMemberCard : Form
    {
        public ManageMemberCard()
        {
            InitializeComponent();
        }

        KhachHang.KhachHang khachHang = new KhachHang.KhachHang();

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            try
            {
                string cmnd = txtID.Text;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                DateTime date = dateTimePicker1.Value;
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                if (((this_year - born_year) < 5) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Tuổi Phải Từ 10 - 100", "Tuổi Không Hợp Lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    if (khachHang.insertCustomer(cmnd, name, date, phone, address))
                    {
                        MessageBox.Show("Thêm Khách Hàng Thành Công", "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearText();
                        showAllCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống", "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {

            }
        }

        bool verif()
        {
            if ((txtAddress.Text.Trim() == "")
                   || (txtID.Text.Trim() == "")
                   || (txtName.Text.Trim() == "")
                   || (txtName.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void clearText()
        {
            txtAddress.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void ManageMemberCard_Load(object sender, EventArgs e)
        {
            showAllCustomer();
        }

        public void showAllCustomer()
        {
            Sach.SachController book = new Sach.SachController();
            dataGridViewBook.ReadOnly = true;
            dataGridViewBook.RowTemplate.Height = 80;
            dataGridViewBook.DataSource = khachHang.getAllUser();
            dataGridViewBook.AllowUserToAddRows = false;
            dataGridViewBook.ClearSelection();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                showCustomerByCMND();
            }
            catch (Exception)
            {

            }
        }

        public void showCustomerByCMND()
        {
            string search = txtSearch.Text;
            Sach.SachController book = new Sach.SachController();
            dataGridViewBook.ReadOnly = true;
            dataGridViewBook.RowTemplate.Height = 80;
            dataGridViewBook.DataSource = khachHang.getUserByCMND(search);
            dataGridViewBook.AllowUserToAddRows = false;
            dataGridViewBook.ClearSelection();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showAllCustomer();
            clearText();
        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = khachHang.getAllUser();

            if (table.Rows.Count > 0)
            {
                txtID.Text = dataGridViewBook.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataGridViewBook.CurrentRow.Cells[1].Value.ToString();
                txtPhone.Text = dataGridViewBook.CurrentRow.Cells[2].Value.ToString();
                txtAddress.Text = dataGridViewBook.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridViewBook.CurrentRow.Cells[4].Value;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string cmnd = txtID.Text;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                DateTime date = dateTimePicker1.Value;
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                if (((this_year - born_year) < 5) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Tuổi Phải Từ 10 - 100", "Tuổi Không Hợp Lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    if (khachHang.updateCustomer(cmnd, name, date, phone, address))
                    {
                        MessageBox.Show("Sửa Khách Hàng Thành Công", "Sửa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearText();
                        showAllCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Sửa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống", "Sửa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {

            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string cmnd = txtID.Text;
                if ((MessageBox.Show("Are you sure you want to delete this customer", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (khachHang.deleteCustomer(cmnd))
                    {
                        MessageBox.Show("Customer Deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showAllCustomer();
                        clearText();
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}