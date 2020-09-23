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
    public partial class Products : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Products()
        {
            
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe_Store.mdb;Persist Security Info=False;";
            Up();
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
            bool prov = false;

            if (NameTv.Text != "" && Cat.Text != "" && Tena.Text != "" && KolNaSkald.Text != "")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Products'";
                OleDbDataReader reader = command.ExecuteReader();

                //string categ = "";

                while (reader.Read())
                {

                    if (NameTv.Text == reader["Наименование_товара"].ToString())
                    {
                        prov = true;
                        break;
                    }
                }
                reader.Close();

                if (prov == false)
                {
                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connection;
                    command1.CommandText = "insert into Products(Наименование_товара,Категория,Цена,Количество_на_складе) values(@namTV,@Cat,@tena,@kol)";
                    command1.Parameters.AddWithValue("@namTV", NameTv.Text);
                    command1.Parameters.AddWithValue("@Cat",Cat.Text);
                    command1.Parameters.AddWithValue("@tena", Tena.Text);
                    command1.Parameters.AddWithValue("@kol", KolNaSkald.Text);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Информация успешно добавлена");
                }
                else
                {
                    MessageBox.Show("Такая категория уже есть");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
            connection.Close();
        }

        public void Up()
        {
            connection.Open();
            string query = "SELECT Категория  FROM Shoe_Category";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            Cat.Items.Clear();

            while (reader.Read())
            {
                Cat.Items.Add(reader[0].ToString() + " ");
            }

            reader.Close();
            connection.Close();

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Tena_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void KolNaSkald_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
