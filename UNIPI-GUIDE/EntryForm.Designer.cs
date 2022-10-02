
namespace UNIPI_GUIDE
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.userLoginButton = new System.Windows.Forms.Button();
            this.guestLoginButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // userLoginButton
            // 
            this.userLoginButton.BackColor = System.Drawing.Color.Blue;
            this.userLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.userLoginButton.ForeColor = System.Drawing.Color.White;
            this.userLoginButton.Location = new System.Drawing.Point(103, 108);
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.Size = new System.Drawing.Size(160, 103);
            this.userLoginButton.TabIndex = 0;
            this.userLoginButton.Text = "Είσοδος";
            this.toolTip1.SetToolTip(this.userLoginButton, "Είσοδος ως φοιτητής");
            this.userLoginButton.UseVisualStyleBackColor = false;
            this.userLoginButton.Click += new System.EventHandler(this.userLoginButton_Click);
            // 
            // guestLoginButton
            // 
            this.guestLoginButton.BackColor = System.Drawing.Color.White;
            this.guestLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.guestLoginButton.ForeColor = System.Drawing.Color.Black;
            this.guestLoginButton.Location = new System.Drawing.Point(103, 217);
            this.guestLoginButton.Name = "guestLoginButton";
            this.guestLoginButton.Size = new System.Drawing.Size(160, 43);
            this.guestLoginButton.TabIndex = 1;
            this.guestLoginButton.Text = "Είσοδος Επισκεπτών";
            this.toolTip1.SetToolTip(this.guestLoginButton, "Είσοδος ως επισκέπτης");
            this.guestLoginButton.UseVisualStyleBackColor = false;
            this.guestLoginButton.Click += new System.EventHandler(this.guestLoginButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.White;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.aboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aboutButton.Location = new System.Drawing.Point(516, 349);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(100, 86);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "About";
            this.toolTip1.SetToolTip(this.aboutButton, "Τα στοιχεία των δημιουγών της εφαρμογής");
            this.aboutButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(516, 31);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 86);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Κλείσιμο της εφαρμογής");
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.helpToolStripMenuItem.Text = "Οδηγός χρήσης";
            this.helpToolStripMenuItem.Click += new System.EventHandler(helpToolStripMenuItem_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(218, 98);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(245, 183);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(628, 447);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.guestLoginButton);
            this.Controls.Add(this.userLoginButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIPI-GUIDE";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userLoginButton;
        private System.Windows.Forms.Button guestLoginButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

