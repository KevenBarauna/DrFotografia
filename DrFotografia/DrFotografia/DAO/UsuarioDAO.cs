using System.Data.SqlClient;


namespace DrFotografia.DAO
{
    class UsuarioDAO
    {

        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();

        public void DefineUsuarioLogado(string Nome, string Senha)
        {

            SqlDataReader dr;

            cmd.CommandText = "UPDATE TB_USUARIO SET logado = 1 WHERE nome = @nome AND senha = @senha";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@senha", Senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

            }
            catch (SqlException e)
            {
                //--IMPLEMENTAR
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

        }//DEFINE USUARIO LOGADO

        public bool ValidarLogin(string Nome, string Senha)
        {
            bool Liberado = false;

            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nome AND senha = @senha";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@senha", Senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Liberado = true;
                }

            }
            catch (SqlException e)
            {
                Liberado = false;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return Liberado;
        }//VERIFICA SE USUARIO E SENHAS ESTÃO CORRETOS

        public bool DefineNovoUsuario(string Nome, string Senha, string Email)
        {
            bool Liberado = false;
            cmd.CommandText = "INSERT INTO TB_USUARIO (nome,senha,email) VALUES (@nome,@senha,@email)";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@senha", Senha);
            cmd.Parameters.AddWithValue("@email", Email);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                Liberado = true;
            }
            catch (SqlException)
            {
                Liberado = false;
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return Liberado;

        }//INSERIR NOVO USUARIO

        public bool BuscaUsuarioPorNome(string Nome)
        {
            bool ExisteUsuario = false;

            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nome";

            cmd.Parameters.AddWithValue("@nome", Nome);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    ExisteUsuario = true;
                }

            }
            catch (SqlException e)
            {
                ExisteUsuario = false;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ExisteUsuario;
        }//VERIFICA SE TEM ESSE NOME NO BANCO

    }
}
