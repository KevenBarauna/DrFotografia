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

namespace DrFotografia.View.Clientes
{
    public partial class EditaCliente : Form
    {
        ClienteController cliente = new ClienteController();
        ClienteModel clt = new ClienteModel();
        public EditaCliente()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BrnPesquisar_Click(object sender, EventArgs e)
        {
           
            clt = cliente.PegarDadosDoClientes(TxtNomePesquisa.Text, TxtTel1Pesuisa.Text);

            TxtNome.Text = clt.Nome;
            TxtEmail.Text = clt.Email;
            TxtTel1.Text = clt.Telefone1;
            TxtTel2.Text = clt.Telefone1;
            TxtTel3.Text = clt.Telefone3;
            TxtDescricao.Text = clt.Descricao;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

           bool LimparCampos = cliente.EditarCliente(TxtNome.Text,TxtEmail.Text,TxtTel1.Text,TxtTel2.Text,TxtTel3.Text,TxtDescricao.Text,clt.Id);
            
            if (LimparCampos == true)
            {
                TxtNome.Text = "";
                TxtEmail.Text = "";
                TxtTel1.Text = "";
                TxtTel2.Text = "";
                TxtTel3.Text = "";
                TxtDescricao.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TodosClientes tela = new TodosClientes();
            tela.Show();
        }
    }
}
