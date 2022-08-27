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
    public partial class EntryForm : BaseForm
    {
	public EntryForm()
        {
            InitializeComponent();
        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }

        private void guestLoginButton_Click(object sender, EventArgs e)
        {
            new MainForm(false).Show();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {}
    }
}
