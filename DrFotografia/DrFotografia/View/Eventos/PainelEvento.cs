using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrFotografia.View.Eventos
{
    public partial class PainelEvento : Form
    {
        public PainelEvento()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            NovoEvento tela = new NovoEvento();
            tela.Show();
            this.Hide();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarEvento tela = new EditarEvento();
            tela.Show();
            this.Hide();
        }

        private void BtnTodosUsuarios_Click(object sender, EventArgs e)
        {
            TodosEventos tela = new TodosEventos();
            tela.Show();
            this.Hide();
        }
    }
}
