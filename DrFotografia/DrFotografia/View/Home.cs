using System;
using System.Windows.Forms;
using DrFotografia.Controller;
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
