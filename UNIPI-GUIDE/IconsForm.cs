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
    public partial class IconsForm : BaseForm
    {
        
        private int i = 1;
        public IconsForm(Boolean user)
        {
            InitializeComponent();
            initializeBaseUserMenuStrip(exclude: "icons", user);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"..\..\images\icon"+i+".jpg";
            i += 1;
            if (i == 6)
                i = 1;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"..\..\images\icon1.jpg";
            i += 1;
        }

        private void aboutbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
