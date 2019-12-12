using System;
using System.Windows.Forms;
using DrFotografia.View;

namespace DrFotografia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
            this.Hide();
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
