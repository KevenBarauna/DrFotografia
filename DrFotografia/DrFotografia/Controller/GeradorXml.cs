using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DrFotografia.Model;

namespace DrFotografia.Controller
{
    class GeradorXml
    {

        public void SalvarArquivo()
        {

            try
            {
                //ACESSO AOS DADOS
                UsuarioController usuario = new UsuarioController();
                var dados = usuario.VerTodosOsUsuarios();

                //GERAR XML
                var XmlSerializer = new XmlSerializer(typeof(List<UsuarioModel>));

                using (var stringWriter = new StringWriter())
                {
                    XmlSerializer.Serialize(stringWriter, dados);
                    MessageBox.Show(stringWriter.ToString());

                }

                //SALVAR
                var FieStrem = new FileStream("Usuario.xml", FileMode.Create ,FileAccess.Write);
                XmlSerializer.Serialize(FieStrem, dados);

                FieStrem.Close();

                MessageBox.Show("Arquivo gerado!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gerar arquivo " + e);
            }



        }

        public void LerXml()
        {
            var xmlSerializaer = new XmlSerializer(typeof(List<UsuarioModel>));

            List<UsuarioModel> Lusuario;

            using (var fileStrem = new FileStream("Usuario.xml", FileMode.Open, FileAccess.Read)) {

               Lusuario = (List<UsuarioModel>)xmlSerializaer.Deserialize(fileStrem);

            }

            foreach (var usuario in Lusuario)
            {
                MessageBox.Show(usuario.Nome);
            }
                
        }


    }
}
