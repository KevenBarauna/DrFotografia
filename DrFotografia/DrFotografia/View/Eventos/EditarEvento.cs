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

namespace DrFotografia.View.Eventos
{
    public partial class EditarEvento : Form
    {
        public EditarEvento()
        {
            InitializeComponent();
        }

        private void BtnPesquisarEvento_Click(object sender, EventArgs e)
        {
            EventoController eventoctl = new EventoController();
            EventoModel evento = new EventoModel();

            ClienteController clientectl = new ClienteController();
            ClienteModel cliente = new ClienteModel();

            evento = eventoctl.PesquisarEvento(TxtNomeEventoPesquisa.Text,TxtDataEventoPesquisa.Text);
            cliente = clientectl.PegarDadosDoUsuarioPorId(Convert.ToInt32(evento.IdCliente));


            TxtValorTotal.Text = evento.ValorTotal;
            TxtvalorEntrada.Text = evento.ValorPago;

            TxtData.Text = evento.Data;
            TxtHora.Text = evento.Hora;
            TxtLocal.Text = evento.Local;
            TxtDescEvento.Text = evento.Descricao;

            TxtTipo.Text = evento.Tipo;

            TxtNome.Text = cliente.Nome;
            TxtTel1.Text = cliente.Telefone1;
            TxtTel2.Text = cliente.Telefone2;
            TxtTel3.Text = cliente.Telefone3;
            TxtEmail.Text = cliente.Email;
            TxtDescricao.Text = cliente.Descricao;

            //if (evento.Tipo == "Aniversário")
            //{
            //    RbAniversaio.Checked;
            //}



        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

        }
    }
}
