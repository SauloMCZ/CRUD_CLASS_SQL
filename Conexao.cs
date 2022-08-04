using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CRUD_CLASS_SQL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
           
            con.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            //Inserir  de conexão com SQL
        }
        public SqlConnection conectar()
        {
            if (con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar() 
        {
            if (con.State==System.Data.ConnectionState.Closed)
            {
                con.Close();

            }
        }
    }
    
}
