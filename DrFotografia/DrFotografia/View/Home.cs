using System;
using System.Windows.Forms;
using DrFotografia.View.Usuarios;

namespace DrFotografia.View
{
    public partial class Home : Form
    {
        public Home(string nome)
        {
            InitializeComponent();
            LblUsuario.Text = nome;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            PainelUsuarios tela = new PainelUsuarios();
            tela.Show();
        }
    }
}
