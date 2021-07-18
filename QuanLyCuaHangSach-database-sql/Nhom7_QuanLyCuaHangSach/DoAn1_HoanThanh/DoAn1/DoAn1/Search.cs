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

namespace DoAn1
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCart_MouseEnter(object sender, EventArgs e)
        {
            //BtnCart.ForeColor = Color.Red;
            //BtnCart.IconColor = Color.Red;
        }

        private void BtnCart_MouseLeave(object sender, EventArgs e)
        {
            //BtnCart.ForeColor = Color.White;
            //BtnCart.IconColor = Color.White;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            ShowAllBook();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ShowBookByName();
        }
        public void ShowBookByName()
        {
            string name = txtSearch.Text;
            Sach.SachController book = new Sach.SachController();
            dataGridViewBook.ReadOnly = true;
            dataGridViewBook.RowTemplate.Height = 80;
            dataGridViewBook.DataSource = book.getBookByName(name);
            dataGridViewBook.AllowUserToAddRows = false;
            dataGridViewBook.ClearSelection();
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
        private void listBoxGender_Click(object sender, EventArgs e)
        {
            if(listBoxGender.SelectedItem != null)
            {
                string cate = listBoxGender.SelectedItem.ToString();
                ShowBookByCate(cate);
            }
        }
        public void ShowBookByCate(string cate)
        {
            Sach.SachController book = new Sach.SachController();
            dataGridViewBook.ReadOnly = true;
            dataGridViewBook.RowTemplate.Height = 80;
            dataGridViewBook.DataSource = book.getBookByCate(cate);
            dataGridViewBook.AllowUserToAddRows = false;
            dataGridViewBook.ClearSelection();
        }

    }
}
