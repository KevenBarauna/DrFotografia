using System;
using System.Windows.Forms;
using DrFotografia.Controller;

namespace DrFotografia.View.Usuarios
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            bool usuarioCadastrado;

            UsuarioController usuario = new UsuarioController();
            usuarioCadastrado = usuario.NovoUsuario(TxtNome.Text,TxtSenha.Text,TxtSenhaConf.Text,TxtEmail.Text);

            if (usuarioCadastrado == true)
            {
                TxtNome.Text = "";
                TxtSenha.Text = "";
                TxtSenhaConf.Text = "";
                TxtEmail.Text = "";
            }

        }
    }
}
