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
    public partial class CalendarForm : BaseForm
    {
        private string[] events = { "Εξέταση βάσεων", "Δια ζώσης εξέταση στην java", "Υποβολή απαλλακτικής εργασίας C#" };
        public CalendarForm()
        {
            InitializeComponent();
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

        private void CalendarForm_Load(object sender, EventArgs e)
        {}
    }
}
