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
    public partial class Form2 : Form
    {
        String connectionString = "Data source=UNIPI-GUIDE.db;Version=3"; 
        private SQLiteConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Οι δημιουργοί του application είναι οι φοιτητές: Μάξιμος Νικηφοράκης με ΑΜ:ΜΠΠΛ210 και ο Γιάννης Καραγεώργος με ΑΜ:ΜΠΠΛ21023");
        }

        private void button1_Click(object sender, EventArgs e)
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
                new Form3(username, password).Show();
            }
            else
            {
                textBox2.Clear();
                MessageBox.Show("Wrong email or/and password...");
            }
            reader.Close();
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }
    }
}
