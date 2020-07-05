using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using DrFotografia.Model;

namespace DrFotografia.Controller
{
    class GeradorJson
    {

        public string SalvarArquivo()
        {

            //ACESSO AOS DADOS
            UsuarioController usuario = new UsuarioController();
            var dados = usuario.VerTodosOsUsuarios();


            var javascriptSerializer = new JavaScriptSerializer();
            var json = javascriptSerializer.Serialize(dados);
            MessageBox.Show(json);

            return json;

        }

        public void LerJson(string json)
        {
            var javascriptSerializer = new JavaScriptSerializer();
            var CopiaDooUsuario = (List<UsuarioModel>)javascriptSerializer.Deserialize(json, typeof(List<UsuarioModel>));

            foreach (var us in CopiaDooUsuario)
            {
                MessageBox.Show("Dados recebidos em Json: " + us.Nome);
            }

        }


    }
}
