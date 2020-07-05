using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrFotografia.DAO
{
    class LucroDAO
    {

        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();
        //public string PegarLucroMes(string data)
        //{

        //    SqlDataReader dr;
        //    double LucroMes;
        //    double LucroEvento;

        //    cmd.CommandText = "SELECT valorpago FROM TB_EVENTO WHERE data LIKE '%/" + data + "/%'";

        //    try
        //    {
        //        cmd.Connection = conexao.Conectar();
        //        dr = cmd.ExecuteReader();

        //        if (dr.HasRows)
        //        {
        //            LucroEvento = Convert.ToDouble( dr["email"] );
        //        }

        //        LucroMes = LucroMes + LucroEvento;

        //    }
        //    catch (SqlException)
        //    {
        //        ExisteUsuario = false;
        //    }
        //    cmd.Parameters.Clear();
        //    conexao.Desconectar();


        //    return "";
        //}
    }
}
