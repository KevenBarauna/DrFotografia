using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DrFotografia.Controller
{
    class GeradorBinario
    {

        public void SalvarArquivo()
        {
            //ACESSO AOS DADOS
            UsuarioController usuario = new UsuarioController();
            var dados = usuario.VerTodosOsUsuarios();

            using (var fileStream = new FileStream("Usuario.bin", FileMode.Create, FileAccess.Write))
            {

                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream,dados);

            }

                

        }


    }
}
