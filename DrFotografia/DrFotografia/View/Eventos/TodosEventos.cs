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
    public partial class TodosEventos : Form
    {
        public TodosEventos()
        {
            InitializeComponent();

            //LISTAR EVENTOS

            EventoController evento = new EventoController();
            List<EventoModel> ListaEvento = new List<EventoModel>();

            ClienteController clientectl = new ClienteController();
            ClienteModel cliente = new ClienteModel();

            ListaEvento = evento.VerTodosOsEventos();

          //  cliente = clientectl.PegarDadosDoUsuarioPorId(Convert.ToInt32(evento.IdCliente));


            foreach (var us in ListaEvento)
            {

                ListViewItem listE = new ListViewItem(us.Id.ToString());
                cliente = clientectl.PegarDadosDoUsuarioPorId(Convert.ToInt32(us.IdCliente));
                listE.SubItems.Add(cliente.Nome);
                listE.SubItems.Add(cliente.Telefone1);
                listE.SubItems.Add(us.Tipo);
                listE.SubItems.Add(us.Data);
                listE.SubItems.Add(us.Hora);
                listE.SubItems.Add(us.Local);
                listE.SubItems.Add(us.Descricao);

                LvEvento.Items.Add(listE);

            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
