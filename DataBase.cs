using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace SQLdatabase
{
    public class Database
    {
        private static string ip;

        public static string IP
        {
            set { ip = value; }
        }

        MySqlConnection connection = new MySqlConnection("server=" + ip + ";" +
                                                         "port=3306;username=KTO;" +
                                                         "password=Qwerty_228;" +
                                                         "database=factories;");
        public void Connect()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Disconnect()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }

    public class Worker
    {
        private static int idCounter = 0;

        private int workerID;
        private string name;
        private string post;
        private int salary;
        private string dateOfBirth;

        public int ID
        {
            get { return workerID; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string Post
        {
            get { return post; }
            set { this.post = value; }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                this.salary = value;
            }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth;}
        }

        public Worker(string name, string post, int salary, string birthday)
        {
            this.name = name;
            this.post = post;
            this.salary = salary;
            this.dateOfBirth = birthday;
            this.workerID = idCounter++;
        }

        public Worker(int id, string name, string post, int salary, string birthday)
        {
            this.name = name;
            this.post = post;
            this.salary = salary;
            this.dateOfBirth = birthday;
            this.workerID = id;
        }
    }

    public static class Company
    {
        private static List<Worker> workers = new List<Worker>();
        //private static bool isSortAscending = true;
        private static DataGridView dataGrid;
        private static Label statusLabel;

        public static string login;
        public static string companyName = "Ваша организация";

        public static void Init(DataGridView data, Label status, Label company)
        {
            dataGrid = data;
            statusLabel = status;
            company.Text = companyName;
            fillList();
        }

        public static List<Worker> GetWorkers()
        {
            return workers;
        }

        public static void fillGrid()
        {
            dataGrid.Rows.Clear();
            foreach(Worker worker in workers)
            {
                dataGrid.Rows.Add(worker.ID.ToString(), worker.Name, worker.Post, worker.Salary.ToString(), worker.DateOfBirth);
            }
        }

        public static void fillList()
        {
            //заполнить лист рабочими
            statusLabel.ForeColor = System.Drawing.Color.Red;
            statusLabel.Text = "ЗАНЯТ";

            //чтение с бд в лист
            Database db = new Database();
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + login + "_Workers;", db.GetConnection());
            
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = command;
            mySqlDataAdapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0)
            {
                foreach(DataRow row in dataTable.Rows)
                {
                    workers.Add(new Worker(int.Parse(row.ItemArray[0].ToString()), row.ItemArray[1].ToString(), 
                                row.ItemArray[2].ToString(), int.Parse(row.ItemArray[3].ToString()), row.ItemArray[4].ToString()));
                }
            }

            statusLabel.ForeColor = System.Drawing.Color.Lime;
            statusLabel.Text = "ГОТОВ";
            fillGrid();
        }

        public static void addWorker(string name, string post, int salary, string birthday)
        {
            workers.Add(new Worker(name, post, salary, birthday));
            statusLabel.ForeColor = System.Drawing.Color.Red;
            statusLabel.Text = "ЗАНЯТ";

            //добавление в бд
            Database db = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `" + login + "_Workers` (`id`, `name`, `post`, `salary`, `birthday`) VALUES (@ID, @NAME, @POST, @SALARY, @BIRTHDAY);", db.GetConnection());
            command.Parameters.Add("@ID", MySqlDbType.Int64).Value = workers[workers.Count - 1].ID;
            command.Parameters.Add("@NAME", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@POST", MySqlDbType.VarChar).Value = post;
            command.Parameters.Add("@SALARY", MySqlDbType.Int64).Value = salary;
            command.Parameters.Add("@BIRTHDAY", MySqlDbType.VarChar).Value = birthday;

            db.Connect();
            if (command.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Не удалось подключиться к базе. Аварийное завершение");
                Application.Exit();
            }
            db.Disconnect();

            statusLabel.ForeColor = System.Drawing.Color.Lime;
            statusLabel.Text = "ГОТОВ";
            fillGrid();
        }

        public static void removeWorker(int index)
        {
            int i = 0;
            int removeID;
            for (; i < workers.Count; i++)
            {
                if (workers[i].ID == index)
                {
                    break;
                }
            }
            removeID = workers[i].ID;
            workers.RemoveAt(i);
            
            statusLabel.ForeColor = System.Drawing.Color.Red;
            statusLabel.Text = "ЗАНЯТ";

            //удаление в бд
            Database db = new Database();
            MySqlCommand command = new MySqlCommand("DELETE FROM `" + login + "_Workers` WHERE `id` = @ID;", db.GetConnection());
            command.Parameters.Add("@ID", MySqlDbType.Int64).Value = removeID;

            db.Connect();
            command.ExecuteNonQuery();
            db.Disconnect();

            statusLabel.ForeColor = System.Drawing.Color.Lime;
            statusLabel.Text = "ГОТОВ";
            
            fillGrid();
        }

        public static void sortByNames()
        {
            if(workers.Count > 1)
            {
                workers.Sort((w1, w2) => w1.Name.CompareTo(w2.Name));
            }
            fillGrid();
        }

        public static void sortBySalary()
        {
            //отсортировать лист по зп
            if (workers.Count > 1)
            {
                workers.Sort((w1, w2) => w1.Salary.CompareTo(w2.Salary));
            }
            fillGrid();
        }

        public static void sortByPost()
        {
            //отсортировать лист по должности (алфавитный порядок)
            if (workers.Count > 1)
            {
                workers.Sort((w1, w2) => w1.Post.CompareTo(w2.Post));
            }
            fillGrid();
        }

        public static void sortByBirthday()
        {
            //отсортировать лист по возрасту
            if (workers.Count > 1)
            {
                workers.Sort((w1, w2) => w1.DateOfBirth.CompareTo(w2.DateOfBirth));
            }
            fillGrid();
        }

        public static void sortByID()
        {
            if (workers.Count > 1)
            {
                workers.Sort((w1, w2) => w1.ID.CompareTo(w2.ID));
            }
            fillGrid();
        }

        public static void changeSortMode(int mode)
        {
            //сортировать по убыванию или возрастанию
            
        }
    }
}