using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrFotografia.DAO
{
    class _Conexao
    {

        SqlConnection con = new SqlConnection();

        public _Conexao()
        {
            con.ConnectionString = "Data Source = localhost; Initial Catalog = DalRo; Integrated Security = True";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }


    }
}
