using System;
using System.Windows.Forms;
using DrFotografia.Controller;
using DrFotografia.View;

namespace DrFotografia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SoftwareController sft = new SoftwareController();
            sft.TesteConexao();
            sft.IniciaLogin();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioController usuario = new UsuarioController();
            bool liberado = usuario.FazerLogin(TxtNome.Text,TxtSenha.Text);

            if (liberado == true)
            {
                this.Hide();
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
