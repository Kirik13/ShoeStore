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
            Up();
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
            DeletTB.Visible = false;
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
            DeletTB.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DeletTB.Visible = false;
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
            DeletTB.Visible = true;
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

        private void DeletTB_Click(object sender, EventArgs e)
        {
            Menu3.Visible = true;
            label3.Visible = true;
            Add.Visible = false;
            DeletTB.Visible = false;
            Chek.Visible = false;
            CategOb.Visible = true;
            
            Prod.Visible = true;
        }

        private void Menu3_Click(object sender, EventArgs e)
        {
            Menu3.Visible = false;
            label3.Visible = false;
            CategOb.Visible = false;
         
            Prod.Visible = false;
            Chek.Visible = true;
            Add.Visible = true;
            DeletTB.Visible = true;
        }

        private void CategOb_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        public void Up()
        {
            connection.Open();
            string query = "SELECT Категория  FROM Shoe_Category";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            categorii.Items.Clear();

            while (reader.Read())
            {
                categorii.Items.Add(reader[0].ToString() + " ");
            }

            reader.Close();
            connection.Close();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (categorii.Text != "")
            {

                connection.Open();
                OleDbCommand command5 = new OleDbCommand();
                command5.Connection = connection;
                command5.CommandText = "delete * from Shoe_Category where [Категория]=@cat";
                command5.Parameters.AddWithValue("@cat", categorii.Text);
                command5.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Удаление прошло успешно");
            }
            else
            {
                MessageBox.Show("Выберите удаляемую категорию");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            Menu3.Visible = false;
            label3.Visible = false;
            CategOb.Visible = false;
           
            Prod.Visible = false;
            Chek.Visible = true;
            Add.Visible = true;
            DeletTB.Visible = true;
        }

        private void Prod_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];
            Mec.MaxLength = 2;
            God.MaxLength = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            Menu3.Visible = false;
            label3.Visible = false;
            CategOb.Visible = false;

            Prod.Visible = false;
            Chek.Visible = true;
            Add.Visible = true;
            DeletTB.Visible = true;
        }

        private void Mec_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void God_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            connection.Open();

            bool prov = false;
            string data = Day.Text + "." + Mec.Text + "." + God.Text;
            if (Day.Text != "" && Mec.Text != "" && God.Text != "" && Mec.Text.Length == 2 && God.Text.Length == 4)
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Sales'";
                OleDbDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {

                    if (data == reader["Дата"].ToString())
                    {
                        prov = true;
                        break;
                    }
                }
                reader.Close();

                if (prov == false)
                {

                    MessageBox.Show("Нету такой даты");
                }
                else
                {
                    OleDbCommand command5 = new OleDbCommand();
                    command5.Connection = connection;
                    command5.CommandText = "delete * from Sales where [Дата]=@data";
                    command5.Parameters.AddWithValue("@data", data);
                    command5.ExecuteNonQuery();

                    MessageBox.Show("Удаление прошло успешно");

                }
            }
            else
            {
                MessageBox.Show("Поля не заполнины либо некорректно введенна дата");
            }
            connection.Close();
        }
    }
}
