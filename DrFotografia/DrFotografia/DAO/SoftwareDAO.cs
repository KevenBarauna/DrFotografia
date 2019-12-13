using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DrFotografia.DAO
{
    class SoftwareDAO
    {
        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();


        public void TesteConexao()
        {

            try
            {
                cmd.CommandText = "SELECT * FROM TB_USUARIO";
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Erro ao conectar ao banco de dados :/ ");   
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

        }//TESTAR CONEXÃO COM O BANCO DE DADOS
        public void IniciarLogin()
        {
            cmd.CommandText = "UPDATE TB_USUARIO SET logado = 0";

            cmd.Connection = conexao.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexao.Desconectar();

        }//QUANDO INICIAR O LOGIN TODOS OS USURIOS RECEBEM 0


    }
}
