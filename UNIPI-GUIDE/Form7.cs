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
    public partial class Form7 : Form
    {
        private string[] events = { "Εξέταση βάσεων", "Δια ζώσης εξέταση στην java", "Υποβολή απαλλακτικής εργασίας C#" };
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("Οι δημιουργοί του application είναι οι φοιτητές: Μάξιμος Νικηφοράκης με ΑΜ:ΜΠΠΛ210 και ο Γιάννης Καραγεώργος με ΑΜ:ΜΠΠΛ21023");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime[] dates = monthCalendar1.BoldedDates;
            for (int i = 0; i < dates.Length; i++)
            {
                if (monthCalendar1.SelectionRange.Start == dates[i])
                {
                    MessageBox.Show(events[i]);
                    continue;
                }
            }
        }
    }
}
