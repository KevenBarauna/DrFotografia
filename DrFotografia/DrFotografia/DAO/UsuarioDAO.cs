﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DrFotografia.Model;

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
            catch (SqlException)
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
            catch (SqlException)
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
            catch (SqlException)
            {
                ExisteUsuario = false;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ExisteUsuario;
        }//VERIFICA SE TEM ESSE NOME NO BANCO

        public UsuarioModel BuscaUsuarioPorNomeSenha(string Nome, string Senha)
        {
            UsuarioModel usuario = new UsuarioModel();

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
                    dr.Read();

                    usuario.Id = Convert.ToInt32( dr["id"] );
                    usuario.Nome = dr["nome"].ToString();
                    usuario.Senha = dr["senha"].ToString();
                    usuario.Email = dr["email"].ToString();
                }

            }
            catch (SqlException)
            {
                return null;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return usuario;
        }//PEGA TODOS OS DADOS DO USUARIO

        public UsuarioModel BuscaDadosUsuarioPorNome(string Nome)
        {
            UsuarioModel usuario = new UsuarioModel();

            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nome";

            cmd.Parameters.AddWithValue("@nome", Nome);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    usuario.Id = Convert.ToInt32(dr["id"]);
                    usuario.Nome = dr["nome"].ToString();
                    usuario.Senha = dr["senha"].ToString();
                    usuario.Email = dr["email"].ToString();
                }

            }
            catch (SqlException)
            {
                return null;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return usuario;
        }//PEGA TODOS OS DADOS DO USUARIO

        public bool EditarUsuario(string nome, string senha, string email, int id)
        {

            cmd.CommandText = "UPDATE TB_USUARIO SET nome = @nome, senha = @senha, email = @email WHERE id = @id";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@email", email);
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
                return false;
            }



        }//EDITA USUARIO

        public List<UsuarioModel> ListarTodosNomesUsuarios()
        {

            SqlDataReader dr;


            List<UsuarioModel> ListadeUsuario = new List<UsuarioModel>();

            cmd.CommandText = "SELECT * FROM TB_USUARIO";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.HasRows)
                {
                    try
                    {
                        dr.Read();

                        UsuarioModel usuario = new UsuarioModel();

                        usuario.Id = Convert.ToInt32(dr["id"]);
                        usuario.Nome = dr["nome"].ToString();
                        usuario.Email = dr["email"].ToString();

                        ListadeUsuario.Add(usuario);
                    }
                    catch (Exception)
                    {

                        break;
                    }
                    
                }

            }
            catch (SqlException)
            {
                return ListadeUsuario;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeUsuario;
        }//VERIFICA SE TEM ESSE NOME NO BANCO

        public bool ValidarAdmin()
        {

            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE logado = 1";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    dr.Read();

                    UsuarioModel usuario = new UsuarioModel();

                    usuario.Id = Convert.ToInt32(dr["id"]);

                    if (usuario.Id == 3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            }
            catch (SqlException)
            {
                return false;
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return false;
        }//VERIFICA SE USUARIO E ADMIN

        public bool ApagarUsuario(int id)
        {

            SqlDataReader dr;

            cmd.CommandText = "DELETE FROM TB_USUARIO WHERE id = @id";

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

        }//APAGAR USUARIO

    }
}
