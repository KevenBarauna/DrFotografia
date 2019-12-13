﻿using System.Windows.Forms;
using DrFotografia.DAO;
using DrFotografia.View;

namespace DrFotografia.Controller
{
    class UsuarioController
    {
        public bool FazerLogin(string nome, string senha)
        {
            bool acesso;

            UsuarioDAO dao = new UsuarioDAO();
            acesso = dao.ValidarLogin(nome, senha);


            if (acesso == true)
            {
                dao.DefineUsuarioLogado(nome, senha);
                Home tela = new Home(nome);
                tela.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Erro");
                return false;
            }

        }//Quando for fazer Login

        public bool NovoUsuario(string Nome, string Senha, string Senhaconf, string Email)
        {

            UsuarioDAO dao = new UsuarioDAO();

            //VALIDA CAMPOS
            if (string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Senha) || string.IsNullOrEmpty(Senhaconf) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Erro! Todos os campos são obrigatórios.");
                return false;
            }

            //VALIDA SE JÁ EXISTE USUARIO COM ESSE NOME
            bool UsuarioExiste = dao.BuscaUsuarioPorNome(Nome);

            if (UsuarioExiste == true)
            {
                MessageBox.Show("Erro! Já existe um usuário com esse nome.");
                return false;
            }


            //VALIDA SE SENHAS SÃO IGUAIS
            if (Senha != Senhaconf)
            {
                MessageBox.Show("Erro! As senhas estão diferentes.");
                return false;
            }


            //VALIDA SE O CAMPO E-MAIL
            if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Erro! Informe seu E-mail.");
                return false;
            }
            if (!Email.Contains("@"))
            {
                MessageBox.Show("Erro! Informe um E-mail válido.");
                return false;
            }

            //SALVAR USUARIO
            UsuarioExiste = dao.DefineNovoUsuario(Nome, Senha, Email);
            if (UsuarioExiste == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso");
            }

            return true;
        }

    }
}
