using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLdatabase;

namespace Zavod
{
    public partial class AddWorkerForm : Form
    {
        public AddWorkerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text != "" && PostTextBox.Text != "" &&
                SalaryTextBox.Text != "" && BirthdayTexyBox.Text != "")
            {
                Company.addWorker(NameTextBox.Text, PostTextBox.Text, int.Parse(SalaryTextBox.Text), BirthdayTexyBox.Text);
            }
            else
            {
                return;
            }

            NameTextBox.Text = "";
            PostTextBox.Text = "";
            SalaryTextBox.Text = "";
            BirthdayTexyBox.Text = "";
        }


        private void AddWorkerForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        Point lastPoint;
        private void AddWorkerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
