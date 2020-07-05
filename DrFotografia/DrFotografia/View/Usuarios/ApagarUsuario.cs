using System;

using System.Windows.Forms;
using DrFotografia.Controller;
using DrFotografia.Model;

namespace DrFotografia.View.Usuarios
{
    public partial class ApagarUsuario : Form
    {

        UsuarioController usuairo = new UsuarioController();
        UsuarioModel usuarioM = new UsuarioModel();
        public ApagarUsuario()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BrnPesquisar_Click(object sender, EventArgs e)
        {

            //VALIDA SE É ADMIN
            bool admin;
            admin = usuairo.VerificaAdmin();

            if (admin == true)
            {
                //PEGA DADOS DO USUARIO
                usuarioM = usuairo.PegarDadosDoUsuarioPorNome(TxtNomePesquisa.Text);
                TxtNome.Text = usuarioM.Nome;
                TxtSenha.Text = usuarioM.Senha;
                TxtEmail.Text = usuarioM.Email;

            }
            else
            {
                MessageBox.Show("Você não tem permissão, fale com o adm");
            }
           
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            bool apagado;

            apagado = usuairo.apagarUsuario(usuarioM.Id);

            if (apagado == true)
            {
                TxtNome.Text = "";
                TxtSenha.Text = "";
                TxtEmail.Text = ""; 
            }
        }
    }
}
