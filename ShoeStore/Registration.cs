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
    public partial class Registration : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Registration()
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

        private void Name1_Enter(object sender, EventArgs e)
        {
            Name1.Clear();
            Name1.ForeColor = Color.Black;
        }

        private void Surname_Enter(object sender, EventArgs e)
        {
            Surname.Clear();
            Surname.ForeColor = Color.Black;
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void Register2_Click(object sender, EventArgs e)
        {
            connection.Open();

            if (Password.Text != "Password" && Login.Text != "Username" && Surname.Text != "Surname" && Name1.Text != "Name" && Name1.Text != "" && Surname.Text != "" && Login.Text != "" && Password.Text != "")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Users(Логин,Пароль,Фамилия,Имя) values(@login,@pass,@firstname,@name)";
                command.Parameters.AddWithValue("@login", Login.Text);
                command.Parameters.AddWithValue("@pass", Password.Text);
                command.Parameters.AddWithValue("@firstname", Surname.Text);
                command.Parameters.AddWithValue("@name", Name1.Text);
                command.ExecuteNonQuery();

                Surname.Text = "Surname";
                Surname.ForeColor = Color.Black;

                Name1.Text = "Name";
                Name1.ForeColor = Color.Black;

                Login.Text = "Username";
                Surname.ForeColor = Color.Black;

                Password.Text = "Password";
                Password.ForeColor = Color.Black;

                MessageBox.Show("Вы успешно зарегистрировались");
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }

            connection.Close();
        }
    }
}
