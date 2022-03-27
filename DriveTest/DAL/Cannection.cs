using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveTest.DAL
{
    public class Cannection
    {
        SqlConnection con = new SqlConnection();
        public Cannection()
        {
            con.ConnectionString = @"Data Source=LAPTOP-0HETLR36\SQLEXPRESS;Initial Catalog=DriveBasic;Integrated Security=True";
        }
        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
