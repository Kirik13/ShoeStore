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
    public partial class Authorization : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public static string id_p;
        public Authorization()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe_Store.mdb;Persist Security Info=False;";
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            Login.Clear();
            Login.ForeColor = Color.Black;
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            Password.Clear();
            Password.ForeColor = Color.Black;
        }


        private void id()
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select Код from Users where Логин='" + Login.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id_p = reader["Код"].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
        private void SingIN_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Users where Логин='" + Login.Text + "' and Пароль='" + Password.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {

                id();

                string dostyp = "";

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "select * from Users where Код=" + Convert.ToInt32(id_p) + "";
                OleDbDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    dostyp = reader1["Доступ"].ToString();
                }
                if (dostyp == "1")
                {
                    this.Hide();
                    MenuAdmin admin = new MenuAdmin();
                    admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Это не админ");
                }
            }
            else
            {
                MessageBox.Show("Нету такого пользователя");
            }
            connection.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
