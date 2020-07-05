using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrFotografia.Model;

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

        public EventoModel PesquisarEvento(string nome, string data)
        {

            SqlDataReader dr;
            EventoModel evento = new EventoModel();

            //cmd.CommandText = "SELECT * FROM TB_EVENTO WHERE data=@data AND nome=@nome";



            cmd.CommandText = "SELECT " +
               "e.id, e.idCliente, e.valorpago, e.valortotal, e.tipo, e.data, e.hora, e.local, e.descricao," +
               "c.nome, c.telefone1, c.telefone2, c.telefone3, c.id, c.email, c.descricao " + "" +
               "FROM TB_EVENTO AS e INNER JOIN TB_CLIENTE as c on c.nome = @nome AND e.data = @data";

            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@nome", nome);

            try
            {

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    evento.Id = Convert.ToInt32(dr["id"]);
                    evento.IdCliente = Convert.ToInt32(dr["idCliente"]);
                    evento.ValorPago = dr["valorpago"].ToString();
                    evento.ValorTotal = dr["valortotal"].ToString();
                    evento.Tipo = dr["tipo"].ToString();
                    evento.Data = dr["data"].ToString();
                    evento.Hora = dr["hora"].ToString();
                    evento.Local = dr["local"].ToString();
                    evento.Descricao = dr["descricao"].ToString();

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro!" + e);
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return evento;

        }//INSERIR NOVO EVENTO

        public List<EventoModel> ListarTodosEvento()
        {

            SqlDataReader dr;
            

            List<EventoModel> ListaEvento = new List<EventoModel>();
            

            cmd.CommandText = "SELECT * FROM TB_EVENTO";


            try
            {

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

              
                while (dr.HasRows)
                {

                    try
                    {
                        dr.Read();

                        EventoModel evento = new EventoModel();

                        evento.Id = Convert.ToInt32(dr["id"]);
                        evento.IdCliente = Convert.ToInt32(dr["idCliente"]);
                        evento.ValorPago = dr["valorpago"].ToString();
                        evento.ValorTotal = dr["valortotal"].ToString();
                        evento.Tipo = dr["tipo"].ToString();
                        evento.Data = dr["data"].ToString();
                        evento.Hora = dr["hora"].ToString();
                        evento.Local = dr["local"].ToString();
                        evento.Descricao = dr["descricao"].ToString();

                        ListaEvento.Add(evento);
                    }
                    catch (Exception)
                    {

                        break;
                    }
                    

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro!" + e);
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListaEvento;

        }//RETORNA TODOS OS USAURIOS

        public bool EditarEvento(int idCliente, string valortotal, string valorpago, string data, string hora, string local, string descricao)
        {
            bool Liberado = false;
            cmd.CommandText = "INSERT INTO TB_EVENTO (idCliente,valortotal,valorpago,tipo,data,hora,local,descricao) VALUES (@idCliente,@valortotal,@valorpago,@tipo,@data,@hora,@local,@descricao)";
            cmd.CommandText = "UPDATE TB_EVENTO SET idCliente = @idCliente, valortotal = @valortotal, valorpago = @valorpago, data = @data, hora=@hora, local=@local, descricao = @descricao WHERE id = @id";


            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            cmd.Parameters.AddWithValue("@valortotal", valortotal);
            cmd.Parameters.AddWithValue("@valorpago", valorpago);
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
