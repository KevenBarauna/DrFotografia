using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DrFotografia.Controller;
using DrFotografia.Model;

namespace DrFotografia.View.Usuarios
{
    public partial class TodosUsuarios : Form
    {
        public TodosUsuarios()
        {
            InitializeComponent();


            //LISTAR ENCOMENDAS

                UsuarioController usuario = new UsuarioController();
                List<UsuarioModel> ListaUsuario = new List<UsuarioModel>();

                ListaUsuario = usuario.VerTodosOsUsuarios();


                foreach (var us in ListaUsuario)
                {

                    ListViewItem listE = new ListViewItem(us.Id.ToString());
                   // listE.SubItems.Add();
                    listE.SubItems.Add(us.Nome);
                    listE.SubItems.Add(us.Email);

                    LvUsuarios.Items.Add(listE);

                }



        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
