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
    public partial class LoginForm : Form
    {
        private Regex IPregex = new Regex("([0-9]{1,3}[\\.]){3}[0-9]{1,3}");

        private bool Check()
        {
            if(!IPregex.IsMatch(IPTextBox.Text))
            {
                return false;
            }
            else
            {
                Database.IP = IPTextBox.Text;
            }
            return true;
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            bool isOK = Check();
            if(!isOK)
            {
                ErrorLabel.Visible = true;
                return;
            }

            string UserLogin = LoginTextBox.Text;
            string UserPassword = PasswordTextBox.Text;

            Database database = new Database();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Users` WHERE `login` = @UL AND `pass` = @UP;", database.GetConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = UserLogin;
            command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = UserPassword;

            mySqlDataAdapter.SelectCommand = command;
            mySqlDataAdapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0)
            {
                Company.login = UserLogin;
                Company.companyName = dataTable.Rows[0].ItemArray[3].ToString();
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Не работает :(");
                return;
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            Database.IP = IPTextBox.Text;
            this.Hide();
            RegForm regForm = new RegForm();
            regForm.Show();
        }
    }
}
