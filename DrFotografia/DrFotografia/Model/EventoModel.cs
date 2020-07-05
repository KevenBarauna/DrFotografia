using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrFotografia.Model
{
    class EventoModel
    {

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string ValorPago { get; set; }
        public string ValorTotal { get; set; }
        public string Tipo { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public UsuarioModel usuario { get; set; }
    }
}
