using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class FacultyForm : BaseForm
    {
        String connectionString = "Data source=..\\..\\UNIPI-GUIDE.db;Version=3";
        private SQLiteConnection conn;
        Boolean student;
        public FacultyForm(Boolean user)
        {
            InitializeComponent();
            initializeBaseUserMenuStrip(exclude: "faculty", user);
            student = user;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath + "..\\..\\savetextfiles";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, Encoding.UTF8);
            }
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
                if (student)
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
