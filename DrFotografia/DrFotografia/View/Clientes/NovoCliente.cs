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

namespace DrFotografia.View.Clientes
{
    public partial class NovoCliente : Form
    {
        public NovoCliente()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            ClienteController cliente = new ClienteController();
            bool ClienteSalvo = cliente.NovoCliente(TxtNome.Text,TxtEmail.Text,TxtTel1.Text,TxtTel2.Text,TxtTel3.Text,TxtDescricao.Text);

            if (ClienteSalvo == true)
            {
                TxtNome.Text = "";
                TxtEmail.Text = "";
                TxtTel1.Text = "";
                TxtTel2.Text = "";
                TxtTel3.Text = "";
                TxtDescricao.Text = "";
            }
        }
    }
}
