
namespace DriveTest.Showing
{
    partial class CadastreSe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nicknamecad = new System.Windows.Forms.TextBox();
            this.Emailcad = new System.Windows.Forms.TextBox();
            this.Passwordcad = new System.Windows.Forms.TextBox();
            this.Finishcad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nickname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // Nicknamecad
            // 
            this.Nicknamecad.Location = new System.Drawing.Point(210, 86);
            this.Nicknamecad.Name = "Nicknamecad";
            this.Nicknamecad.Size = new System.Drawing.Size(100, 22);
            this.Nicknamecad.TabIndex = 3;
            // 
            // Emailcad
            // 
            this.Emailcad.Location = new System.Drawing.Point(178, 147);
            this.Emailcad.Name = "Emailcad";
            this.Emailcad.Size = new System.Drawing.Size(132, 22);
            this.Emailcad.TabIndex = 4;
            // 
            // Passwordcad
            // 
            this.Passwordcad.Location = new System.Drawing.Point(210, 218);
            this.Passwordcad.Name = "Passwordcad";
            this.Passwordcad.PasswordChar = '*';
            this.Passwordcad.Size = new System.Drawing.Size(100, 22);
            this.Passwordcad.TabIndex = 5;
            // 
            // Finishcad
            // 
            this.Finishcad.Location = new System.Drawing.Point(142, 318);
            this.Finishcad.Name = "Finishcad";
            this.Finishcad.Size = new System.Drawing.Size(95, 40);
            this.Finishcad.TabIndex = 6;
            this.Finishcad.Text = "Finish cad";
            this.Finishcad.UseVisualStyleBackColor = true;
            this.Finishcad.Click += new System.EventHandler(this.Finishcad_Click);
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.Finishcad);
            this.Controls.Add(this.Passwordcad);
            this.Controls.Add(this.Emailcad);
            this.Controls.Add(this.Nicknamecad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastreSe";
            this.Text = "CadastreSe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nicknamecad;
        private System.Windows.Forms.TextBox Emailcad;
        private System.Windows.Forms.TextBox Passwordcad;
        private System.Windows.Forms.Button Finishcad;
    }
}