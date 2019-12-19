using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrFotografia.DAO
{
    class EventoDAO
    {

        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();

        public bool DefineNovoEvento(int idCliente, string valortotal, string valorpago, string tipo, string data, string hora, string local, string descricao)
        {
            bool Liberado = false;
            cmd.CommandText = "INSERT INTO TB_EVENTO (idCliente,valortotal,valorpago,tipo,data,hora,local,descricao) VALUES (@idCliente,@valortotal,@valorpago,@tipo,@data,@hora,@local,@descricao)";

            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            cmd.Parameters.AddWithValue("@valortotal", valortotal);
            cmd.Parameters.AddWithValue("@valorpago", valorpago);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@local", local);
            cmd.Parameters.AddWithValue("@descricao", descricao);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                Liberado = true;
            }
            catch (SqlException)
            {
                Liberado = false;
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return Liberado;

        }//INSERIR NOVO EVENTO
    }
}
