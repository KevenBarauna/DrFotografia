using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrFotografia.View.Clientes;

namespace DrFotografia.View
{
    public partial class PainelClientes : Form
    {
        public PainelClientes()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            NovoCliente tela = new NovoCliente();
            tela.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditaCliente tela = new EditaCliente();
            tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApagarCliente tela = new ApagarCliente();
            tela.Show();
            this.Hide();
        }

        private void BtnTodosUsuarios_Click(object sender, EventArgs e)
        {
            TodosClientes tela = new TodosClientes();
            tela.Show();
            this.Hide();
        }
    }
}
