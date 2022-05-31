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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Company.Init(MainTable, StatusLabel, NameLabel);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorker = new AddWorkerForm();
            addWorker.Show();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(MainTable.SelectedRows.Count >= 1)
            {
                foreach(DataGridViewRow worker in MainTable.SelectedRows)
                {
                    Company.removeWorker(int.Parse(worker.Cells[0].Value.ToString()));
                }
            }
        }

        private void IDSortButton_Click(object sender, EventArgs e)
        {
            Company.sortByID();
        }

        private void NameSortButton_Click(object sender, EventArgs e)
        {
            Company.sortByNames();
        }

        private void PostSortButton_Click(object sender, EventArgs e)
        {
            Company.sortByPost();
        }

        private void SalaryPostButton_Click(object sender, EventArgs e)
        {
            Company.sortBySalary();
        }

        private void DateSortButton_Click(object sender, EventArgs e)
        {
            Company.sortByBirthday();
        }

        Point lastPoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
