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
    public partial class ApagarCliente : Form
    {
        ClienteController cliente = new ClienteController();
        ClienteModel clt = new ClienteModel();
        public ApagarCliente()
        {
            InitializeComponent();
        }

        private void BrnPesquisar_Click(object sender, EventArgs e)
        {

            //VERIFCAR ADM
            UsuarioController usuario = new UsuarioController();
            bool adm = usuario.VerificaAdmin();

            //PESUISAR
            if (adm == true)
            {
                clt = cliente.PegarDadosDoClientes(TxtNomePesquisa.Text, TxtTel1Pesuisa.Text);

                TxtNome.Text = clt.Nome;
                TxtEmail.Text = clt.Email;
                TxtTel1.Text = clt.Telefone1;
                TxtDescricao.Text = clt.Descricao;
            }
            else
            {
                MessageBox.Show("Você não tem permissão, fale com o adm");
            }
            
           
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
           bool apagado = cliente.ApagarCliente(clt.Id);

            if (apagado == true)
            {
                TxtNome.Text = "";
                TxtEmail.Text = "";
                TxtTel1.Text = "";
                TxtDescricao.Text = "";
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
