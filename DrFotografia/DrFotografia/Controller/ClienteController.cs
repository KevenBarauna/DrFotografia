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
    class ClienteController
    {

        public bool NovoCliente(string Nome, string Email, string Telefone1, string Telefone2, string Telefone3, string Descricao)
        {

            ClienteDAO dao = new ClienteDAO();

            //VALIDA CAMPOS
            if (string.IsNullOrEmpty(Nome))
            {
                MessageBox.Show("Erro! Informe o nome do cliente.");
                return false;
            }
            if (string.IsNullOrEmpty(Telefone1))
            {
                MessageBox.Show("Erro! Informe o telefone do cliente.");
                return false;
            }

            //VALIDA SE JÁ EXISTE CLIENTE COM ESSE NOME
            bool ClienteExiste = dao.ValidarCliente(Nome, Telefone1);

            if (ClienteExiste == true)
            {
                MessageBox.Show("Erro! Já existe um cliente com esse nome e E-mail.");
                return false;
            }

            //SALVAR CLIENTE
            ClienteExiste = dao.DefineNovoCliente(Nome, Email, Telefone1, Telefone2, Telefone3, Descricao);
            if (ClienteExiste == true)
            {
                MessageBox.Show("Cliente cadastrado com sucesso");
            }

            return true;
        }//SALVAR NOVO CLIENTE

        public ClienteModel PegarDadosDoClientes(string Nome, string Telefone1)
        {
            ClienteModel cliente = new ClienteModel();
            ClienteDAO dao = new ClienteDAO();

            //VALIDA CAMPOS
            if (string.IsNullOrEmpty(Nome))
            {
                MessageBox.Show("Erro! O campo Nome é obrigatório");
                return cliente;
            }
            if (string.IsNullOrEmpty(Telefone1))
            {
                MessageBox.Show("Erro! O campo Telefone é obrigatório");
                return cliente;
            }

            //BUSCAR CLIENTES
            cliente = dao.ListarTodosClientesPorNomeTelefone(Nome,Telefone1);
            return cliente;
        }//RETORNA LISTA DE CLIENTES

        public ClienteModel PegarDadosDoUsuarioPorId(int id)
        {
            ClienteModel cliente = new ClienteModel();
            ClienteDAO dao = new ClienteDAO();

            //PEGAR DADOS DO USUARIO
            cliente = dao.ListarCliente(id);

            if (cliente.Id == 0)
            {
                MessageBox.Show("Erro! Esse cliente não existe");
                return cliente;
            }

            return cliente;
        }//RETORNA CLIENTE MODEL

        public bool EditarCliente(string Nome, string Email, string Telefone1, string Telefone2, string Telefone3, string Descricao, int Id)
        {

            ClienteDAO dao = new ClienteDAO();

            //VALIDA CAMPOS
            if (string.IsNullOrEmpty(Nome))
            {
                MessageBox.Show("Erro! O Nome é um campo obrigatório.");
                return false;
            }
            if (string.IsNullOrEmpty(Telefone1))
            {
                MessageBox.Show("Erro! O Telefone(1) é um campo obrigatório.");
                return false;
            }

            //SALVAR CLIENTE
            bool sucesso = dao.EditarCliente(Nome, Email, Telefone1, Telefone2, Telefone3, Descricao, Id);
            if (sucesso == true)
            {
                MessageBox.Show("Cliente Editado com sucesso");
            }

            return true;
        }//SALVAR NOVO USUARIO

        public List<ClienteModel> VerTodosOsClientes()
        {

            ClienteDAO dao = new ClienteDAO();
            List<ClienteModel> ListaCliente = new List<ClienteModel>();

            //PEGAR TODOS OS CLIENTES
            ListaCliente = dao.ListarTodosOsClientes();

            return ListaCliente;
        }//VER TODOS OS CLIENTES

        public bool ApagarCliente(int id)
        {
            bool apagado;
            ClienteDAO dao = new ClienteDAO();
            apagado = dao.ApagarCliente(id);

            if (apagado == true)
            {
                MessageBox.Show("Cliente apagado do banco de dados");
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao apagar cliente");
                return false;
            }

        }//APAGAR CLIENTE

        public void EnviarEmail(string Nome)
        {
            //UsuarioModel usuario = new UsuarioModel();
            //UsuarioDAO dao = new UsuarioDAO();

            ////PEGAR DADOS DO USUARIO
            //usuario = dao.BuscaDadosUsuarioPorNome(Nome);

            //if (usuario.Id == 0)
            //{
            //    MessageBox.Show("Erro! Não existe um usuário com esse nome e senha");
            //    return usuario;
            //}
            //else
            //{

            //    //GERAR NOVA SENHA
            //    Random NumeroAleatorio = new Random();
            //    string NovaSenha = NumeroAleatorio.Next().ToString();



            //    //ENVIAR E-MAIL
            //    SmtpClient cliente = new SmtpClient();
            //    NetworkCredential credenciais = new NetworkCredential();

            //    //CONFIGURAÇÕES DO CLIENTE
            //    cliente.Host = "smtp.gmail.com";
            //    cliente.Port = 587;
            //    cliente.EnableSsl = true;
            //    cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    cliente.UseDefaultCredentials = false;

            //    //DEFINIT ACESSO E-MAIL
            //    credenciais.UserName = "baianofotografia.keven";
            //    credenciais.Password = "12345678kel";

            //    //CREDENCIAIS NO CLIENTE
            //    cliente.Credentials = credenciais;

            //    //MENSAGEM
            //    MailMessage mensagem = new MailMessage();
            //    mensagem.From = new MailAddress("baianofotografia.keven@gmail.com");
            //    mensagem.Subject = "Nova senha do Dr Fotografia";
            //    mensagem.Body = "Sua nova senha é: " + NovaSenha;
            //    mensagem.To.Add(usuario.Email);

            //    //ENVIAR
            //    cliente.Send(mensagem);
            //    MessageBox.Show("E-mail enviado para: " + usuario.Email);

            //    //ATUALIZAR SEENHA NO BANCO DE DADOS
            //    EditarUsuario(usuario.Nome, NovaSenha, NovaSenha, usuario.Email, usuario.Id);



            //    //--------------------------------------------
            //}

            //return usuario;
        }//RETORNA CLIENTE MODEL



    }
}
