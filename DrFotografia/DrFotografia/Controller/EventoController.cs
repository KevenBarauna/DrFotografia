using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrFotografia.DAO;
using DrFotografia.Model;

namespace DrFotografia.Controller
{
    class EventoController
    {
        EventoDAO dao = new EventoDAO();

        public bool NovoEvento(int idCliente, string valortotal, string valorpago, string tipo, string data, string hora, string local, string descricao)
        {
           
            if (string.IsNullOrEmpty(idCliente.ToString()) || idCliente == 0)
            {
                MessageBox.Show("Erro!  Cliente invalido");
                return false;
            }

            return dao.DefineNovoEvento(idCliente,valortotal,valorpago,tipo,data,hora,local,descricao);

        }

        public EventoModel PesquisarEvento(string nome, string data)
        {
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo nome é obrigatório");
            }
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("O campo data é obrigatório");
            }

            return dao.PesquisarEvento(nome, data);
        }

        public List<EventoModel> VerTodosOsEventos()
        {

            EventoDAO dao = new EventoDAO();
            List<EventoModel> ListaEvento = new List<EventoModel>();

            //PEGAR TODOS OS USUARIOS
            ListaEvento = dao.ListarTodosEvento();

            return ListaEvento;
        }//SALVAR NOVO USUARIO

        public bool EditarEvento(int idCliente, string valortotal, string valorpago, string tipo, string data, string hora, string local, string descricao)
        {

            if (string.IsNullOrEmpty(idCliente.ToString()) || idCliente == 0)
            {
                MessageBox.Show("Erro!  Cliente invalido");
                return false;
            }

            return dao.EditarEvento(idCliente, valortotal, valorpago, data, hora, local, descricao);

        }

    }
}
