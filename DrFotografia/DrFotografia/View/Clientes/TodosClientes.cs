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
    public partial class TodosClientes : Form
    {
        public TodosClientes()
        {
            InitializeComponent();


            //LISTAR ENCOMENDAS

            ClienteController cliente = new ClienteController();
            List<ClienteModel> ListaCliente = new List<ClienteModel>();

            ListaCliente = cliente.VerTodosOsClientes();


            foreach (var clt in ListaCliente)
            {

                ListViewItem listE = new ListViewItem(clt.Id.ToString());
                // listE.SubItems.Add();
                listE.SubItems.Add(clt.Nome);
                listE.SubItems.Add(clt.Email);
                listE.SubItems.Add(clt.Telefone1);
                listE.SubItems.Add(clt.Telefone2);
                listE.SubItems.Add(clt.Telefone3);
                listE.SubItems.Add(clt.Descricao);

                LvClientes.Items.Add(listE);

            }



        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
