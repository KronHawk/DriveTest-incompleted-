using DriveTest.models;
using DriveTest.Showing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutMe Sobre = new AboutMe();
            Sobre.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Controller controle = new Controller();
            controle.Access(Email_box.Text, Password_box.Text);
            if (controle.tem)
            {
                Form2 formlog = new Form2();
                formlog.Show()
            }
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void Password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
