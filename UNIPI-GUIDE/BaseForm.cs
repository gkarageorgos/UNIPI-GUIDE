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
        protected ToolStripMenuItem baseMenuToolStripMenuItem;
        protected MenuStrip baseMenuStrip;
        protected System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem photosToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem;

        protected Boolean user = false;


        protected void baseExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void baseAboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Οι δημιουργοί του application είναι οι φοιτητές: Μάξιμος Νικηφοράκης με ΑΜ:ΜΠΠΛ21054 και ο Γιάννης Καραγεώργος με ΑΜ:ΜΠΠΛ21023");
        }

        protected void initializeBaseUserMenuStrip(String exclude)
        {
            this.baseMenuStrip = new System.Windows.Forms.MenuStrip();
            this.baseMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

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
            if (exclude != "photos") initializePhotosToolStripMenuItem();
            if (exclude != "comments") initializeCommentsToolStripMenuItem();
        }

        private void initializeFacultyToolStripMenuItem()
        {
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facultyToolStripMenuItem.Text = "Καθηγητές";
            this.baseMenuToolStripMenuItem.DropDownItems.Add(this.facultyToolStripMenuItem);
        }

        private void initializeCalendarToolStripMenuItem()
        {
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calendarToolStripMenuItem.Text = "Ημερολόγιο";
            this.baseMenuToolStripMenuItem.DropDownItems.Add(this.calendarToolStripMenuItem);
        }

        private void initializePhotosToolStripMenuItem()
        {
            this.photosToolStripMenuItem.Name = "photosToolStripMenuItem";
            this.photosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.photosToolStripMenuItem.Text = "Φωτογραφίες";
            this.baseMenuToolStripMenuItem.DropDownItems.Add(this.photosToolStripMenuItem);
        }

        private void initializeCommentsToolStripMenuItem()
        {
            this.commentsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.commentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commentsToolStripMenuItem.Text = "Κριτικές";
            this.baseMenuToolStripMenuItem.DropDownItems.Add(this.commentsToolStripMenuItem);
        }


        private void InitializeComponent()
        {
            this.baseMenuStrip = new System.Windows.Forms.MenuStrip();
            this.baseMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.baseMenuStrip);
            this.MainMenuStrip = this.baseMenuStrip;
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.baseMenuStrip.ResumeLayout(false);
            this.baseMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
