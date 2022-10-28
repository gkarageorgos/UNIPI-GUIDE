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
    public partial class SubmitCommentsForm : BaseForm
    {
        String connectionString = "Data source=..\\..\\UNIPI-GUIDE.db;Version=3"; 
        private SQLiteConnection conn;
        public SubmitCommentsForm(Boolean user)
        {
            InitializeComponent();
            initializeBaseUserMenuStrip(exclude: "submitComments", user);
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            conn.Open();
            String review = richTextBox1.Text;
            String insertSQL = "Insert into Comments(review) " +
             "values(@review)";
            SQLiteCommand cmd = new SQLiteCommand(insertSQL, conn);
            cmd.Parameters.AddWithValue("@review", review);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
                MessageBox.Show("Σας ευχαριστούμε!");
            conn.Close();
            this.Hide();            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }
    }
}
