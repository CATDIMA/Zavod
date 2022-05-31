using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SQLdatabase;
using MySql.Data.MySqlClient;

namespace Zavod
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void RegForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            Regex LoginRegex = new Regex("^[a-zA-Z](.[a-zA-Z0-9_-]*)$");
            Regex PasswordRegex = new Regex("(?=[#$-/:-?{-~!\" ^ _`\\[\\]a - zA - Z]*([0 - 9#$-/:-?{-~!\"^_`\\[\\]]))(?=[#$-/:-?{-~!\"^_`\\[\\]a-zA-Z0-9]*[a-zA-Z])[#$-/:-?{-~!\"^_`\\[\\]a-zA-Z0-9]{4,}");

            ErrorLabel.Visible = true;

            /*if(!LoginRegex.IsMatch(LoginTextBox.Text))
            {
                ErrorLabel.Text = "Неверный логин";
                return;
            }
            if(!PasswordRegex.IsMatch(PasswordTextBox.Text))
            {
                ErrorLabel.Text = "Неверный формат пароля";
                return;
            }
            else
            {
                ErrorLabel.Text = "";
            }*/

            Database db = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO Users (`id`, `login`, `pass`, `Name`) VALUES (NULL, @LOGIN, @PASS, @NAME);" +
                "CREATE TABLE " + LoginTextBox.Text + "_Workers (id INT, name VARCHAR(255) NOT NULL, " +
                "post VARCHAR(255), salary INT, birthday VARCHAR(255) NOT NULL);", db.GetConnection());
            
            command.Parameters.Add("@LOGIN", MySqlDbType.VarChar).Value = LoginTextBox.Text;
            command.Parameters.Add("@PASS", MySqlDbType.VarChar).Value = PasswordTextBox.Text;
            command.Parameters.Add("NAME", MySqlDbType.VarChar).Value = NameTextBox.Text;

            db.Connect();
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешная регистрация");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            db.Disconnect();
        }
    }
}

//Марийский Машиностроительный Завод