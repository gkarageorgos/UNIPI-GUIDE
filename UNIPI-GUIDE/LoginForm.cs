using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class LoginForm : BaseForm
    {
        String connectionString = "Data source=..\\..\\UNIPI-GUIDE.db;Version=3"; 
        private SQLiteConnection conn;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            String username = textBox1.Text;
            String password = textBox2.Text;
            //Parameterized query
            String selectSQL = "Select * from Student where " +
                "username=@username and password=@password";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
                MessageBox.Show("Login Success!");
                new MainForm(true).Show();
            }
            else
            {
                textBox2.Clear();
                MessageBox.Show("Wrong email or/and password...");
            }
            reader.Close();
            conn.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πληκτρολογήστε όνομα χρήστη και κωδικό για να εισέλθετε στην εφαρμογή.");
        }
    }
}
