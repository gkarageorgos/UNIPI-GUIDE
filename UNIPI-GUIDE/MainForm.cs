using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class MainForm : Form
    {
        private String username, password;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(String str1,String str2)
        {
            InitializeComponent();
            username = str1;
            password = str2;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form5().Show();            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form6(username, password).Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Form8().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Οι δημιουργοί του application είναι οι φοιτητές: Μάξιμος Νικηφοράκης με ΑΜ:ΜΠΠΛ210 και ο Γιάννης Καραγεώργος με ΑΜ:ΜΠΠΛ21023");
        }
    }
}
