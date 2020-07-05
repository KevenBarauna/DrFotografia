using System.Collections.Generic;
using System.Windows.Forms;
using DrFotografia.DAO;
using DrFotografia.Model;
using DrFotografia.View;
using System.Net;//
using System.Net.Mail;//
using System;

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
        }//SALVAR NOVO USUARIO

        public UsuarioModel PegarDadosDoUsuario(string Nome, string Senha)
        {
            UsuarioModel usuario = new UsuarioModel();
            UsuarioDAO dao = new UsuarioDAO();

            //VALIDA CAMPOS
            if (string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Senha))
            {
                MessageBox.Show("Erro! Os campos Nome e Senha são obrigatórios");
                return usuario;
            }

            //VALIDA SE JÁ EXISTE USUARIO COM ESSE NOME
            bool UsuarioExiste = dao.BuscaUsuarioPorNome(Nome);

            if (UsuarioExiste == false)
            {
                MessageBox.Show("Erro! Não existe um usuário com esse nome e senha");
                return usuario;
            }

            //BUSCAR USUÁRIO
            usuario = dao.BuscaUsuarioPorNomeSenha(Nome, Senha);
            return usuario;
        }//RETORNA USUARIO MODEL

        public UsuarioModel PegarDadosDoUsuarioPorNome(string Nome)
        {
            UsuarioModel usuario = new UsuarioModel();
            UsuarioDAO dao = new UsuarioDAO();

            //PEGAR DADOS DO USUARIO
            usuario = dao.BuscaDadosUsuarioPorNome(Nome);

            if (usuario.Id == 0)
            {
                MessageBox.Show("Erro! Não existe um usuário com esse nome e senha");
                return usuario;
            }

            return usuario;
        }//RETORNA USUARIO MODEL

        public bool EditarUsuario(string Nome, string Senha, string Senhaconf, string Email, int Id)
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
            UsuarioExiste = dao.EditarUsuario(Nome, Senha, Email, Id);
            if (UsuarioExiste == true)
            {
                MessageBox.Show("Usuário Editado com sucesso");
            }

            return true;
        }//SALVAR NOVO USUARIO

        public List<UsuarioModel> VerTodosOsUsuarios()
        {

            UsuarioDAO dao = new UsuarioDAO();
            List<UsuarioModel> ListaUsuarios = new List<UsuarioModel>();

            //PEGAR TODOS OS USUARIOS
            ListaUsuarios = dao.ListarTodosNomesUsuarios();

            if (ListaUsuarios == null)
            {
                UsuarioModel usuario = new UsuarioModel();
                usuario.Id = 0;
                usuario.Nome = "Erro";
                usuario.Email = "Erro";
                ListaUsuarios.Add(usuario);
                return ListaUsuarios;
            }

            return ListaUsuarios;
        }//SALVAR NOVO USUARIO

        public bool VerificaAdmin()
        {
            bool acesso;
            UsuarioDAO dao = new UsuarioDAO();
            acesso = dao.ValidarAdmin();

            return acesso;

        }//VERIFICA SE USUARIO LOGADO É ADMIN

        public bool apagarUsuario(int id)
        {
            bool apagado;
            UsuarioDAO dao = new UsuarioDAO();
            apagado = dao.ApagarUsuario(id);

            if (apagado == true)
            {
                MessageBox.Show("Usuário apagado do banco de dados");
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao apagar usuário");
                return false;
            }

        }//VERIFICA SE USUARIO LOGADO É ADMIN

        public UsuarioModel RedefinirSenha(string Nome)
        {
            UsuarioModel usuario = new UsuarioModel();
            UsuarioDAO dao = new UsuarioDAO();

            //PEGAR DADOS DO USUARIO
            usuario = dao.BuscaDadosUsuarioPorNome(Nome);

            if (usuario.Id == 0)
            {
                MessageBox.Show("Erro! Não existe um usuário com esse nome e senha");
                return usuario;
            }
            else
            {

                //GERAR NOVA SENHA
                Random NumeroAleatorio = new Random();
                string NovaSenha = NumeroAleatorio.Next().ToString();
                


                //ENVIAR E-MAIL
                SmtpClient cliente = new SmtpClient();
                NetworkCredential credenciais = new NetworkCredential();

                //CONFIGURAÇÕES DO CLIENTE
                cliente.Host = "smtp.gmail.com";
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;

                //DEFINIT ACESSO E-MAIL
                credenciais.UserName = "baianofotografia.keven";
                credenciais.Password = "12345678kel";

                //CREDENCIAIS NO CLIENTE
                cliente.Credentials = credenciais;

                //MENSAGEM
                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress("baianofotografia.keven@gmail.com");
                mensagem.Subject = "Nova senha do Dr Fotografia";
                mensagem.Body = "Sua nova senha é: " + NovaSenha;
                mensagem.To.Add(usuario.Email);

                //ENVIAR
                cliente.Send(mensagem);
                MessageBox.Show("E-mail enviado para: " + usuario.Email);

                //ATUALIZAR SEENHA NO BANCO DE DADOS
                EditarUsuario(usuario.Nome, NovaSenha, NovaSenha, usuario.Email,usuario.Id);



                //--------------------------------------------
            }

            return usuario;
        }//RETORNA USUARIO MODEL


    }
}
