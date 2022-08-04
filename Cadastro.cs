using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CRUD_CLASS_SQL
{
    public class Cadastro
    {
        SqlCommand comand = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem = "";

        public Cadastro(string Nome , string Telefone)
            {
            comand.CommandText = "INSERT INTO CLIENTES (NOME,TELEFONE) VALUES (@NOME,@TELEFONE)";
            comand.Parameters.AddWithValue("@NOME",Nome);
            comand.Parameters.AddWithValue("@TELEFONE",Telefone);

            try
            {
                comand.Connection = conexao.conectar();
                comand.ExecuteNonQuery();
                this.mensagem = "Gravado com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem="Erro ao gravar";
            }
            }
        
    }
}
