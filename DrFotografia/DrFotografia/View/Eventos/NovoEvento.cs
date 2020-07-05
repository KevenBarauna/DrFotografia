using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;
using DrFotografia.Controller;
using DrFotografia.Model;

namespace DrFotografia.View.Eventos
{
    public partial class NovoEvento : Form
    {
        ClienteModel clt = new ClienteModel();
        ClienteController cliente = new ClienteController();

        EventoController evento = new EventoController();

        public NovoEvento()
        {
            InitializeComponent();
        }

        private void NovoEvento_Load(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnPesquisarEnd_Click(object sender, EventArgs e)
        {
            CorreiosApi correios = new CorreiosApi();
            try
            {
                var retorno = correios.consultaCEP(TxtCep.Text);

                TxtEstado.Text = retorno.uf;
                TxtCidade.Text = retorno.cidade;
                TxtEndereco.Text = retorno.end;
                TxtBairro.Text = retorno.bairro;

                TxtLocal.Text = "Rua: " + retorno.end + " | " + retorno.bairro;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro! Verifique o CEP ou sua conexão", "Erro ao veridicar CEP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //(https://viacep.com.br/)
            }




        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            //VALICAR O CHACKBOX

            string tipo;

            if (RbAniversaio.Checked)
            {
                tipo = "Aniversário";
            }
            else if (RbBatizado.Checked)
            {
                tipo = "Batizado";
            }
            else if (RbBodas.Checked)
            {
                tipo = "Bodas";
            }
            else if (RbCasamento.Checked)
            {
                tipo = "Casamento";
            }
            else if (RbMakingof.Checked)
            {
                tipo = "Making off";
            }
            else
            {
                tipo = "Festa";
            }

            bool cadastrado = evento.NovoEvento(clt.Id, TxtValorTotal.Text, TxtvalorEntrada.Text, tipo, TxtData.Text, TxtHora.Text, TxtLocal.Text, TxtDescEvento.Text);

            if (cadastrado == true)
            {
                MessageBox.Show("Evento cadastrado");
                clt.Id = 0;
                TxtNomePesquisa.Text = "";
                TxtTel1Pesuisa.Text = "";
                TxtNome.Text = "";
                TxtEmail.Text = "";
                TxtTel1.Text = "";
                TxtTel2.Text = "";
                TxtTel3.Text = "";
                TxtDescricao.Text = "";

                TxtCep.Text = "";
                TxtEstado.Text = "";
                TxtCidade.Text = "";
                TxtEndereco.Text = "";
                TxtBairro.Text = "";

                TxtValorTotal.Text = "";
                TxtvalorEntrada.Text = "";

                //RbFesta.Checked

                TxtData.Text = "";
                TxtHora.Text = "";
                TxtLocal.Text = "";
                TxtDescEvento.Text = "";


            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            clt = cliente.PegarDadosDoClientes(TxtNomePesquisa.Text, TxtTel1Pesuisa.Text);

            TxtNome.Text = clt.Nome;
            TxtEmail.Text = clt.Email;
            TxtTel1.Text = clt.Telefone1;
            TxtTel2.Text = clt.Telefone1;
            TxtTel3.Text = clt.Telefone3;
            TxtDescricao.Text = clt.Descricao;
        }
    }
}
