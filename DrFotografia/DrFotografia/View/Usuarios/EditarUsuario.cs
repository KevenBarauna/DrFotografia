using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrFotografia.Controller;
using DrFotografia.Model;

namespace DrFotografia.View.Usuarios
{
    public partial class EditarUsuario : Form
    {

        UsuarioController usuairo = new UsuarioController();
        UsuarioModel usuarioM = new UsuarioModel();
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BrnPesquisar_Click(object sender, EventArgs e)
        {
            
            usuarioM = usuairo.PegarDadosDoUsuario(TxtNomePesquisa.Text,TxtSenhaPesquisa.Text);
            TxtNome.Text = usuarioM.Nome;
            TxtSenha.Text = usuarioM.Senha;
            TxtConfSenha.Text = usuarioM.Senha;
            TxtEmail.Text = usuarioM.Email;

            if (usuarioM.Id != 0)
            {
                this.TxtNome.ReadOnly = false;
                this.TxtSenha.ReadOnly = false;
                this.TxtConfSenha.ReadOnly = false;
                this.TxtEmail.ReadOnly = false;
            }
            if (usuarioM.Id == 0)
            {
                this.TxtNome.ReadOnly = true;
                this.TxtSenha.ReadOnly = true;
                this.TxtConfSenha.ReadOnly = true;
                this.TxtEmail.ReadOnly = true;
            }

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            usuairo.EditarUsuario(TxtNome.Text, TxtSenha.Text, TxtConfSenha.Text, TxtEmail.Text, usuarioM.Id);
        }
    }
}
