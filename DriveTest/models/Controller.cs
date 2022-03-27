using DriveTest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveTest.models
{
    public class Controller
    {
        public string tem;
        public string menssagem = "";
        public string Access(string email, string senha)
        {
            Login logindal = new Login();
            tem = logindal.VerificarLogin(email, senha);
            logindal.Typeofuser(email);
            if (!logindal.menssagem.Equals(""))
            {
                this.menssagem = logindal.menssagem;
            }
            return tem = "positivo";
        }
        public string Cadastro(string email, string senha, string verifsenha)
        {
            return menssagem;
        }
    }
}
