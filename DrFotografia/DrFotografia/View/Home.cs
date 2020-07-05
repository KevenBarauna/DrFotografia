using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DrFotografia.Controller;
using DrFotografia.Model;
using DrFotografia.View.Eventos;
using DrFotografia.View.Usuarios;

namespace DrFotografia.View
{
    public partial class Home : Form
    {
        public Home(string nome)
        {
            InitializeComponent();
            LblUsuario.Text = nome;


            //LISTAR EVENTOS

            //--PEGAR DADOS EVENTO--
            EventoController evento = new EventoController();
            List<EventoModel> ListaEvento = new List<EventoModel>();
            ListaEvento = evento.VerTodosOsEventos();

            //--PEGAR DADOS CLIENTE--
            ClienteController cliente = new ClienteController();
            List<ClienteModel> ListaCliente = new List<ClienteModel>();
            


            foreach (var ev in ListaEvento)
            {
                var NomeCliente = cliente.PegarDadosDoUsuarioPorId(ev.IdCliente);
                ListViewItem listE = new ListViewItem(NomeCliente.Nome);
                listE.SubItems.Add(ev.Data);
                LvEventos.Items.Add(listE);

            }


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            PainelUsuarios tela = new PainelUsuarios();
            tela.Show();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            PainelClientes tela = new PainelClientes();
            tela.Show();
        }

        private void BtnTrocarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login tela = new Login();
            tela.Show();
        }

        private void BtnEventos_Click(object sender, EventArgs e)
        {
            PainelEvento tela = new PainelEvento();
            tela.Show();
        }

        private void BtnnGerarTxt_Click(object sender, EventArgs e)
        {
            GeradorTxt arquivo = new GeradorTxt();
            arquivo.SalvarAquivo();
        }

        private void BtnXml_Click(object sender, EventArgs e)
        {
            GeradorXml arquivo = new GeradorXml();
            arquivo.SalvarArquivo();
            arquivo.LerXml();
        }

        private void BtnJosn_Click(object sender, EventArgs e)
        {
            GeradorJson arquivo = new GeradorJson();
            var json = arquivo.SalvarArquivo();
            arquivo.LerJson(json);
        }

        private void BtnBinario_Click(object sender, EventArgs e)
        {
            GeradorBinario arquivo = new GeradorBinario();
            arquivo.SalvarArquivo();
        }
    }
}
