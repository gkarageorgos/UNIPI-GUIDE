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
        string[] images = { "Ano_Syros", "Cent George", "port_of_Syros", "Town_Hall_of_Hermoupolis", "Vaporia_Hermoupoli", "ΑγιοςΝικολαος" };
        private int i = 0;
        public IconsForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"images\"+images[i]+".jpg";
            i += 1;
            if (i == 6)
                i = 0;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"images\" + images[0] + ".jpg";
            i += 1;
        }
    }
}
