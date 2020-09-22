using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShoeStore
{
    public partial class MenuAdmin : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public MenuAdmin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe_Store.mdb;Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            label2.Visible = false;
            dataGridView1.Visible = true;
            back1.Visible = true;

            Menu.Visible = false;

            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(34, 36, 49);
            dataGridView1.GridColor = Color.FromArgb(78, 184, 206);
            dataGridView1.ForeColor = Color.FromArgb(78, 184, 206);
            dataGridView1.RowHeadersVisible = false;

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select [Категория],[Гарантийный_срок],[Правила_ухода] from Shoe_Category";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();

        }

        private void Register2_Click(object sender, EventArgs e)
        {
            tb1.Visible = true;
            tb2.Visible = true;
            tb3.Visible = true;
            Chek.Visible = false;
            label2.Visible = true;
            Menu.Visible = true;
            Add.Visible = false;
        }

        private void back1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            back1.Visible = false;
            tb1.Visible = true;
            tb2.Visible = true;
            tb3.Visible = true;
            label2.Visible = true;
            Menu.Visible = true;
        }

        private void tb2_Click(object sender, EventArgs e)
        {
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            label2.Visible = false;
            dataGridView2.Visible = true;
            back2.Visible = true;

            Menu.Visible = false;

            dataGridView2.DefaultCellStyle.BackColor = Color.FromArgb(34, 36, 49);
            dataGridView2.GridColor = Color.FromArgb(78, 184, 206);
            dataGridView2.ForeColor = Color.FromArgb(78, 184, 206);
            dataGridView2.RowHeadersVisible = false;

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select [Наименование_товара],[Категория],[Цена],[Количество_на_складе] from Products";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            connection.Close();

        }

        private void back2_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            back2.Visible = false;
            tb1.Visible = true;
            tb2.Visible = true;
            tb3.Visible = true;
            label2.Visible = true;
            Menu.Visible = true;
        }

        private void tb3_Click(object sender, EventArgs e)
        {
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            label2.Visible = false;
            dataGridView3.Visible = true;
            back3.Visible = true;

            Menu.Visible = false;

            dataGridView3.DefaultCellStyle.BackColor = Color.FromArgb(34, 36, 49);
            dataGridView3.GridColor = Color.FromArgb(78, 184, 206);
            dataGridView3.ForeColor = Color.FromArgb(78, 184, 206);
            dataGridView3.RowHeadersVisible = false;

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select [Номер_товара],[Наименование_товара],[Количество],[Скидка],[Дата] from Sales";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;

            connection.Close();
        }

        private void back3_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            back3.Visible = false;
            tb1.Visible = true;
            tb2.Visible = true;
            tb3.Visible = true;
            label2.Visible = true;
            Menu.Visible = true;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            Chek.Visible = true;
            label2.Visible = false;
            Menu.Visible = false;
            Add.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Chek.Visible = false;
            dtb1.Visible = true;
            dtb2.Visible = true;
            dtb3.Visible = true;
            Add.Visible = false;
            label1.Visible = true;
            Menu2.Visible = true;
        }

        private void Menu2_Click(object sender, EventArgs e)
        {
            Chek.Visible = true;
            dtb1.Visible = false;
            dtb2.Visible = false;
            dtb3.Visible = false;
            Add.Visible = true;
            label1.Visible = false;
            Menu2.Visible = false;

        }

        private void dtb1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shoe_Category shoe_Category = new Shoe_Category();
            shoe_Category.Show();
        }

        private void dtb2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products();
            products.Show();
        }

        private void dtb3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales sales = new Sales();
            sales.Show();
        }
    }
}
