using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public class BaseForm : Form
    {
        protected void baseExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void baseAboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Οι δημιουργοί του application είναι οι φοιτητές: Μάξιμος Νικηφοράκης με ΑΜ:ΜΠΠΛ21054 και ο Γιάννης Καραγεώργος με ΑΜ:ΜΠΠΛ21023");
        }
    }
}
