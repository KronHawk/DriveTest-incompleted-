
namespace DriveTest
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Email_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Cadastro = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Email_box
            // 
            this.Email_box.Location = new System.Drawing.Point(313, 116);
            this.Email_box.Name = "Email_box";
            this.Email_box.Size = new System.Drawing.Size(169, 22);
            this.Email_box.TabIndex = 0;
            this.Email_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(310, 172);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // Password_box
            // 
            this.Password_box.Location = new System.Drawing.Point(313, 226);
            this.Password_box.Name = "Password_box";
            this.Password_box.PasswordChar = '*';
            this.Password_box.Size = new System.Drawing.Size(169, 22);
            this.Password_box.TabIndex = 3;
            this.Password_box.TextChanged += new System.EventHandler(this.Password_box_TextChanged);
            // 
            // Login
            // 
            this.Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login.Location = new System.Drawing.Point(257, 293);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(103, 38);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Cadastro
            // 
            this.Cadastro.Location = new System.Drawing.Point(412, 293);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(103, 38);
            this.Cadastro.TabIndex = 5;
            this.Cadastro.Text = "Cadastrar";
            this.Cadastro.UseVisualStyleBackColor = true;
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(313, 383);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(151, 33);
            this.About.TabIndex = 6;
            this.About.Text = "Sobre esse app";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Email_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Email_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Cadastro;
        private System.Windows.Forms.Button About;
    }
}

