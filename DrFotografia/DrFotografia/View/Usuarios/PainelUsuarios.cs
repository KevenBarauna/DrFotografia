using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrFotografia.View.Usuarios
{
    public partial class PainelUsuarios : Form
    {
        public PainelUsuarios()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            NovoUsuario tela = new NovoUsuario();
            tela.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            EditarUsuario tela = new EditarUsuario();
            tela.Show();
            this.Hide();
        }
    }
}
