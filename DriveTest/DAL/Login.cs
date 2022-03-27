using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveTest.DAL
{
    public class Login
    {
        public string tem;
        public string Type;
        public string menssagem;
        public string Verif;
        SqlCommand cmd = new SqlCommand();
        Cannection con = new Cannection();
        SqlDataReader dr;
        public string VerificarLogin(string email, string senha)
        {
            cmd.CommandText = "select * from Contas2 where email = @email and password = @senha";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = "positivo";
                }
            }
            catch (SqlException)
            {
                this.menssagem = "erro com DB";
            }
            return tem;
        }
        public string Typeofuser(string email)
        {
            Verif = cmd.CommandText = "select typyofuser from Contas2 where email = @email";
            cmd.Parameters.AddWithValue("@email", email);
            if(Verif == "ADM")
            {
                Type = "ADM";
            }
            return Type;
        }
        public string Cadastrar(string email, string senha, string verifsenha)
        {
            return menssagem;
        }
    }
}
