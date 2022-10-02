using System;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public class BaseForm : Form
    {
        protected ToolStripMenuItem baseMenuToolStripMenuItem;
        protected MenuStrip baseMenuStrip;
        protected System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem iconsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem submitcommentsToolStripMenuItem;

        protected Boolean user = false;


        protected static void baseExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected static void baseAboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Οι δημιουργοί του application είναι οι φοιτητές: Μάξιμος Νικηφοράκης με ΑΜ:ΜΠΠΛ21054 και ο Γιάννης Καραγεώργος με ΑΜ:ΜΠΠΛ21023");
        }

        protected void initializeBaseUserMenuStrip(String exclude, Boolean user)
        {
            this.baseMenuStrip = new System.Windows.Forms.MenuStrip();
            this.baseMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitcommentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.baseMenuStrip.SuspendLayout();
            this.Controls.Add(this.baseMenuStrip);
            this.MainMenuStrip = this.baseMenuStrip;
            this.baseMenuStrip.ResumeLayout(false);
            this.baseMenuStrip.PerformLayout();
            // 
            // baseMenuStrip
            // 
            this.baseMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseMenuToolStripMenuItem});
            this.baseMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.baseMenuStrip.Name = "menuStrip1";
            this.baseMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.baseMenuStrip.TabIndex = 0;
            this.baseMenuStrip.Text = "menuStrip1";
            // 
            // baseMenuToolStripMenuItem
            // 
            this.baseMenuToolStripMenuItem.Name = "basemenuToolStripMenuItem";
            this.baseMenuToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.baseMenuToolStripMenuItem.Text = "Μενού";

            if (exclude != "faculty") initializeFacultyToolStripMenuItem();
            if (exclude != "calendar") initializeCalendarToolStripMenuItem();
            if (exclude != "icons") initializeIconsToolStripMenuItem();
            if (exclude != "comments") initializeCommentsToolStripMenuItem();
            if (exclude != "submitComments")
            {
                if (user)
                    initializeSubmitCommentsToolStripMenuItem();
            }
        }

        private void initializeFacultyToolStripMenuItem()
        {
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facultyToolStripMenuItem.Text = "Καθηγητές";
            this.facultyToolStripMenuItem.Click += new System.EventHandler(facultyToolStripMenuItem_Click);
            this.baseMenuToolStripMenuItem.DropDownItems.Add(this.facultyToolStripMenuItem);
        }

        private void initializeCalendarToolStripMenuItem()
        {
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calendarToolStripMenuItem.Text = "Ημερολόγιο";
            this.calendarToolStripMenuItem.Click += new System.EventHandler(calendarToolStripMenuItem_Click);
            this.baseMenuToolStripMenuItem.DropDownItems.Add(this.calendarToolStripMenuItem);
        }

        private void initializeIconsToolStripMenuItem()
        {
            this.iconsToolStripMenuItem.Name = "iconsToolStripMenuItem";
            this.iconsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iconsToolStripMenuItem.Text = "Φωτογραφίες";
            this.iconsToolStripMenuItem.Click += new System.EventHandler(iconsToolStripMenuItem_Click);
            this.baseMenuToolStripMenuItem.DropDownItems.Add(this.iconsToolStripMenuItem);
        }

        private void initializeCommentsToolStripMenuItem()
        {
            this.commentsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.commentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commentsToolStripMenuItem.Text = "Κριτικές";
            this.commentsToolStripMenuItem.Click += new System.EventHandler(commentsToolStripMenuItem_Click);
            this.baseMenuToolStripMenuItem.DropDownItems.Add(this.commentsToolStripMenuItem);
        }

        private void initializeSubmitCommentsToolStripMenuItem()
        {
            this.submitcommentsToolStripMenuItem.Name = "submitcommentsToolStripMenuItem";
            this.submitcommentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.submitcommentsToolStripMenuItem.Text = "Υποβολή σχολίων";
            this.submitcommentsToolStripMenuItem.Click += new System.EventHandler(submitcommentsToolStripMenuItem_Click);
            this.baseMenuToolStripMenuItem.DropDownItems.Add(this.submitcommentsToolStripMenuItem);
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FacultyForm(this.user).Show();        
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalendarForm(this.user).Show();
        }

        private void iconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IconsForm(this.user).Show();
        }

        private void commentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CommentsForm(this.user).Show();
        }

        private void submitcommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SubmitCommentsForm(this.user).Show();
        }
    }
}
