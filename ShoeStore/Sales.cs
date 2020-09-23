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
    public partial class Sales : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Sales()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe_Store.mdb;Persist Security Info=False;";
            Up();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Up()
        {
            connection.Open();
            string query = "SELECT  Наименование_товара FROM Products";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            NamTV.Items.Clear();

            while (reader.Read())
            {
                NamTV.Items.Add(reader[0].ToString() + " ");
            }

            reader.Close();
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin admin = new MenuAdmin();
            admin.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            connection.Open();

            if (Kol.Text != "" && NamTV.Text != "" && Skidka.Text != "" && Data.Text != "")
            {
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "insert into Sales(Наименование_товара,Количество,Скидка,Дата) values(@namTV,@Cat,@tena,@kol)";
                command1.Parameters.AddWithValue("@namTV", NamTV.Text);
                command1.Parameters.AddWithValue("@Cat", Kol.Text);
                command1.Parameters.AddWithValue("@tena", Skidka.Text);
                command1.Parameters.AddWithValue("@kol", Data.Text);
                command1.ExecuteNonQuery();
                MessageBox.Show("Информация успешно добавлена");
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
            connection.Close();
        }

        private void Kol_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Skidka_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Data_KeyPress(object sender, KeyPressEventArgs e)
        {
           
             char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46)
            {
                e.Handled = true;
            }
        }
    }
}
