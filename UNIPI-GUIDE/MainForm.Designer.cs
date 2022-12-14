
namespace UNIPI_GUIDE
{
    partial class MainForm
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.photosButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.facultyButton = new System.Windows.Forms.Button();
            this.reviewsButton = new System.Windows.Forms.Button();
            this.submitCommentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.BackColor = System.Drawing.Color.White;
            this.chooseColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chooseColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chooseColorButton.Location = new System.Drawing.Point(688, 194);
            this.chooseColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(100, 86);
            this.chooseColorButton.TabIndex = 8;
            this.chooseColorButton.Text = "Choose Color";
            this.toolTip1.SetToolTip(this.chooseColorButton, "Διάλεξε το χρώμα που σου αρέσει");
            this.chooseColorButton.UseVisualStyleBackColor = false;
            this.chooseColorButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(688, 31);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 86);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Κλείσιμο της εφαρμογής");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(BaseForm.baseExitButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.White;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.aboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aboutButton.Location = new System.Drawing.Point(688, 350);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(100, 86);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "About";
            this.toolTip1.SetToolTip(this.aboutButton, "Τα στοιχεία των δημιουργών της εφαρμογής");
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(BaseForm.baseAboutButton_Click);

            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(356, 121);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 258);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // photosButton
            // 
            this.photosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.photosButton.Location = new System.Drawing.Point(107, 194);
            this.photosButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photosButton.Name = "photosButton";
            this.photosButton.Size = new System.Drawing.Size(213, 68);
            this.photosButton.TabIndex = 12;
            this.photosButton.Text = "Φωτογραφίες";
            this.toolTip1.SetToolTip(this.photosButton, "φωτογραφίες του ΠΑΠΕΙ");
            this.photosButton.UseVisualStyleBackColor = true;
            this.photosButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // calendarButton
            // 
            this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.calendarButton.Location = new System.Drawing.Point(107, 121);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(213, 68);
            this.calendarButton.TabIndex = 11;
            this.calendarButton.Text = "Ημερολόγιο";
            this.toolTip1.SetToolTip(this.calendarButton, "ημερολόγιο");
            this.calendarButton.UseVisualStyleBackColor = true;
            this.calendarButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // facultyButton
            // 
            this.facultyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.facultyButton.Location = new System.Drawing.Point(107, 47);
            this.facultyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facultyButton.Name = "facultyButton";
            this.facultyButton.Size = new System.Drawing.Size(213, 68);
            this.facultyButton.TabIndex = 10;
            this.facultyButton.Text = "Καθηγητές";
            this.toolTip1.SetToolTip(this.facultyButton, "Οι καθηγητές του τμήματος");
            this.facultyButton.UseVisualStyleBackColor = true;
            this.facultyButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // reviewsButton
            // 
            this.reviewsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reviewsButton.Location = new System.Drawing.Point(107, 270);
            this.reviewsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reviewsButton.Name = "reviewsButton";
            this.reviewsButton.Size = new System.Drawing.Size(213, 68);
            this.reviewsButton.TabIndex = 7;
            this.reviewsButton.Text = "Κριτικές";
            this.toolTip1.SetToolTip(this.reviewsButton, "Διάβασε τις κριτικές για το τμήμα");
            this.reviewsButton.UseVisualStyleBackColor = true;
            this.reviewsButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // submitCommentsButton
            // 
            this.submitCommentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.submitCommentsButton.Location = new System.Drawing.Point(107, 343);
            this.submitCommentsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitCommentsButton.Name = "submitCommentsButton";
            this.submitCommentsButton.Size = new System.Drawing.Size(213, 68);
            this.submitCommentsButton.TabIndex = 6;
            this.submitCommentsButton.Text = "Υποβολή Σχολίων";
            this.toolTip1.SetToolTip(this.submitCommentsButton, "Η άποψή σας μας είναι απαραίτητη");
            this.submitCommentsButton.UseVisualStyleBackColor = true;
            this.submitCommentsButton.Visible = false;
            this.submitCommentsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.photosButton);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.facultyButton);
            this.Controls.Add(this.chooseColorButton);
            this.Controls.Add(this.reviewsButton);
            this.Controls.Add(this.submitCommentsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aboutButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Μενού";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button submitCommentsButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button reviewsButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.Button facultyButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button photosButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}