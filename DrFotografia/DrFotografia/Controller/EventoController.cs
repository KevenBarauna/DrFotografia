using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrFotografia.DAO;

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



    }
}
