using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class EntryForm : BaseForm
    {
        SoundPlayer player;
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
        {
            player = new SoundPlayer("media/welcome.wav");
            player.Play();
            axWindowsMediaPlayer1.URL = "media/PAPEI.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "media/presentation.mkv";
        }
    }
}
