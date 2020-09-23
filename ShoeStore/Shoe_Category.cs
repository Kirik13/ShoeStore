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
    public partial class Shoe_Category : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Shoe_Category()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe_Store.mdb;Persist Security Info=False;";
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

            if(Categ.Text != "" && GaranSrok.Text != "" && PravYxod.Text != "")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Shoe_Category'";
                OleDbDataReader reader = command.ExecuteReader();

                //string categ = "";

                while (reader.Read())
                {
                    
                    if(Categ.Text == reader["Категория"].ToString())
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
                    command1.CommandText = "insert into Shoe_Category(Категория,Гарантийный_срок,Правила_ухода) values(@cat,@garan,@prav)";
                    command1.Parameters.AddWithValue("@cat", Categ.Text);
                    command1.Parameters.AddWithValue("@garan", GaranSrok.Text);
                    command1.Parameters.AddWithValue("@prav", PravYxod.Text);
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

        private void GaranSrok_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 )
            {
                e.Handled = true;
            }
        }
    }
}
