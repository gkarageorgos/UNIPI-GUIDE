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
    public partial class Form6 : Form
    {
        String username, password;
        String connectionString = "Data source=UNIPI-GUIDE.db;Version=3";
        private SQLiteConnection conn;
        public Form6(String str1, String str2)
        {
            InitializeComponent();
            username = str1;
            password = str2;            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath + "\\savetextfiles";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Οι δημιουργοί του application είναι οι φοιτητές: Μάξιμος Νικηφοράκης με ΑΜ:ΜΠΠΛ210 και ο Γιάννης Καραγεώργος με ΑΜ:ΜΠΠΛ21023");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            String selectSQL = "Select * from Professor";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (username != null)
                {
                    richTextBox1.AppendText(reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2) + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(reader.GetString(0) + ", " + reader.GetString(2) + Environment.NewLine);
                }
            }
            conn.Close();
        }
    }
}
