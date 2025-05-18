using System.Data.SqlClient;
using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private string connectionString = "Data Source=mydb.db;Version=3;";
        public Form1()
        {
            this.Text = "rr";
            this.Size = new Size(800, 650);
            b1 = new Button()
            {
                   Text = "Проверить подключение к бд",
                   Location = new Point(1,40),
                   Size = new Size(200,50)
                   
            };
            b2 = new Button()
            {
                Text = "Проверить подключение к бд",
                Location = new Point(1, 90),
                Size = new Size(200, 50)

            };
            b3 = new Button()
            {
                Text = "Проверить подключение к бд",
                Location = new Point(1, 140),
                Size = new Size(200, 50)

            };
            b4 = new Button()
            {
                Text = "Проверить подключение к бд",
                Location = new Point(1, 190),
                Size = new Size(200, 50)

            };
            b5 = new Button()
            {
                Text = "Проверить подключение к бд",
                Location = new Point(1, 240),
                Size = new Size(200, 50)

            };
            b6 = new Button()
            {
                Text = "Проверить подключение к бд",
                Location = new Point(1, 290),
                Size = new Size(200, 50)

            };
            b7 = new Button()
            {
                Text = "Проверить подключение к бд",
                Location = new Point(1, 340),
                Size = new Size(200, 50)

            };
            b1.Click += connect;
            this.Controls.Add(b1);
            this.Controls.Add(b2);
            this.Controls.Add(b3);
            this.Controls.Add(b4);
            this.Controls.Add(b5);
            this.Controls.Add(b6);
            this.Controls.Add(b7);
        }
         
        private void connect(object sender ,EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT 1", connection))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Cтатус подключения  к бд: " + true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cтатус подключения  к бд {false },Ошибка выполнения запроса: {ex.Message}");
            }
            connection.Close();

        }
    }
}
