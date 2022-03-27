
namespace DriveTest.Showing
{
    partial class Form2
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
            this.Welcome = new System.Windows.Forms.Label();
            this.Yours_archies = new System.Windows.Forms.Button();
            this.Add_archive = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(347, 28);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(75, 17);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Bem-vindo";
            // 
            // Yours_archies
            // 
            this.Yours_archies.Location = new System.Drawing.Point(57, 113);
            this.Yours_archies.Name = "Yours_archies";
            this.Yours_archies.Size = new System.Drawing.Size(172, 143);
            this.Yours_archies.TabIndex = 1;
            this.Yours_archies.Text = "Suas pastas";
            this.Yours_archies.UseVisualStyleBackColor = true;
            // 
            // Add_archive
            // 
            this.Add_archive.Location = new System.Drawing.Point(269, 113);
            this.Add_archive.Name = "Add_archive";
            this.Add_archive.Size = new System.Drawing.Size(172, 143);
            this.Add_archive.TabIndex = 2;
            this.Add_archive.Text = "Adcionar arquivo";
            this.Add_archive.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(495, 84);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Add_archive);
            this.Controls.Add(this.Yours_archies);
            this.Controls.Add(this.Welcome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button Yours_archies;
        private System.Windows.Forms.Button Add_archive;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}