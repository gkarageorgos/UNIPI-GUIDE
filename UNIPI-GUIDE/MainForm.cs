using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class MainForm : BaseForm
    {
        
        public MainForm(Boolean user)
        {
            InitializeComponent();
            this.user = user;
            if (user) submitCommentsButton.Visible = true;
            initializeRichTextBoxText();
        }

        private void initializeRichTextBoxText()
        {
            String text = File.ReadAllText(@"..\\..\\texts\\intro.txt");
            this.richTextBox1.Text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SubmitCommentsForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            new CommentsForm(user).Show();            
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
            new FacultyForm(user).Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new CalendarForm().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new IconsForm().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
