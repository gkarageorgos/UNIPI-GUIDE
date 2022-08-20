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
    public partial class EntryFrom : Form
    {
	public EntryFrom()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }

        private void guestLoginButton_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Οι δημιουργοί του application είναι οι φοιτητές: Μάξιμος Νικηφοράκης με ΑΜ:ΜΠΠΛ21054 και ο Γιάννης Καραγεώργος με ΑΜ:ΜΠΠΛ21023");
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
