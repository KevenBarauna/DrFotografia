using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DrFotografia.Model;

namespace DrFotografia.DAO
{
    class ClienteDAO
    {

        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();

        public bool ValidarCliente(string Nome, string Telefone1)
        {
            bool ClienteExiste = false;

            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM TB_CLIENTE WHERE nome = @nome AND telefone1 = @telefone1";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@telefone1", Telefone1);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    ClienteExiste = true;
                }

            }
            catch (SqlException)
            {
                ClienteExiste = false;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ClienteExiste;
        }//VERIFICA SE CLIENTE EXISTE

        public bool DefineNovoCliente(string Nome, string Email, string telefone1, string telefone2, string telefone3, string Descricao)
        {
            bool Liberado = false;
            cmd.CommandText = "INSERT INTO TB_CLIENTE (nome,email,telefone1,telefone2,telefone3,descricao) VALUES (@nome,@email,@telefone1,@telefone2,@telefone3,@descricao)";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@descricao", Descricao);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@telefone1", telefone1);
            cmd.Parameters.AddWithValue("@telefone2", telefone2);
            cmd.Parameters.AddWithValue("@telefone3", telefone3);

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

        }//INSERIR NOVO CLIENTE

        public ClienteModel ListarTodosClientesPorNomeTelefone(string Nome, string Telefone)
        {

            SqlDataReader dr;

            ClienteModel cliente = new ClienteModel();

            cmd.CommandText = "SELECT * FROM TB_CLIENTE WHERE nome = @nome AND telefone1 = @telefone";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@telefone", Telefone);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                  
                        dr.Read();

                        cliente.Id = Convert.ToInt32(dr["id"]);
                        cliente.Nome = dr["nome"].ToString();
                        cliente.Email = dr["email"].ToString();
                        cliente.Telefone1 = dr["telefone1"].ToString();
                        cliente.Telefone2 = dr["telefone2"].ToString();
                        cliente.Telefone3 = dr["telefone3"].ToString();
                        cliente.Descricao = dr["descricao"].ToString();

                }

            }
            catch (SqlException)
            {
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return cliente;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return cliente;
        }//VERIFICA SE TEM ESSE NOME NO BANCO

        public bool EditarCliente(string Nome, string Email, string telefone1, string telefone2, string telefone3, string Descricao, int id)
        {
            
            cmd.CommandText = "UPDATE TB_CLIENTE SET nome = @nome, email = @email,telefone1 = @telefone1, telefone2 = @telefone2, telefone3 = @telefone3 , descricao = @descricao WHERE id = @id";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@descricao", Descricao);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@telefone1", telefone1);
            cmd.Parameters.AddWithValue("@telefone2", telefone2);
            cmd.Parameters.AddWithValue("@telefone3", telefone3);
            cmd.Parameters.AddWithValue("@id", id);


            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return true;
            }
            catch (SqlException)
            {
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }



        }//EDITA USUARIO

        public List<ClienteModel> ListarTodosOsClientes()
        {

            SqlDataReader dr;


            List<ClienteModel> ListadeCliente = new List<ClienteModel>();

            cmd.CommandText = "SELECT * FROM TB_CLIENTe";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.HasRows)
                {
                    try
                    {
                        dr.Read();

                        ClienteModel cliente = new ClienteModel();

                        cliente.Id = Convert.ToInt32(dr["id"]);
                        cliente.Nome = dr["nome"].ToString();
                        cliente.Descricao = dr["descricao"].ToString();
                        cliente.Email = dr["email"].ToString();
                        cliente.Telefone1 = dr["telefone1"].ToString();
                        cliente.Telefone2 = dr["telefone2"].ToString();
                        cliente.Telefone3 = dr["telefone3"].ToString();
                       // cliente.Telefone4 = dr["telefone4"].ToString();

                        ListadeCliente.Add(cliente);
                    }
                    catch (Exception)
                    {

                        break;
                    }

                }

            }
            catch (SqlException)
            {
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return ListadeCliente;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeCliente;
        }//LIStaR TODOS OS CLIENTES

        public ClienteModel ListarCliente(int id)
        {

            SqlDataReader dr;

            ClienteModel cliente = new ClienteModel();

            cmd.CommandText = "SELECT * FROM TB_CLIENTE WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                   
                        dr.Read();

                        cliente.Id = Convert.ToInt32(dr["id"]);
                        cliente.Nome = dr["nome"].ToString();
                        cliente.Descricao = dr["descricao"].ToString();
                        cliente.Email = dr["email"].ToString();
                        cliente.Telefone1 = dr["telefone1"].ToString();
                        cliente.Telefone2 = dr["telefone2"].ToString();
                        cliente.Telefone3 = dr["telefone3"].ToString();
                      //  cliente.Telefone4 = dr["telefone4"].ToString();                  

                }

            }
            catch (SqlException)
            {
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return cliente;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return cliente;
        }//LIStaR CLIENTE

        public bool ApagarCliente(int id)
        {

            SqlDataReader dr;

            cmd.CommandText = "DELETE FROM TB_CLIENTE WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

            }
            catch (SqlException)
            {
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return true;

        }//APAGAR CLIENTE

    }
}
