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
        }
    }
}
