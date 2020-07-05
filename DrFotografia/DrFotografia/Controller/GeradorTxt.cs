
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DrFotografia.Controller;
using DrFotografia.Model;

namespace DrFotografia.Controller
{
    class GeradorTxt
    {

        public void SalvarAquivo()
        {
            try
            {


                //CRIAR PASTA
                DirectoryInfo raiz = new DirectoryInfo(@"C:\Users\keven.barauna\Desktop");
                raiz.CreateSubdirectory("DrFotografia_Txt");

                //GERAR ARQUIVO TXT
                StreamWriter STW_Arquivo;

                //NOME DO AQUIVO
                STW_Arquivo = new StreamWriter(@"C:\Users\keven.barauna\Desktop\DrFotografia_Txt\Arq_Cache.txt");


                //ACESSO AOS DADOS
                UsuarioController usuario = new UsuarioController();
                var dados = usuario.VerTodosOsUsuarios();

                //ESCREVER
                foreach (var item in dados)
                {
                    STW_Arquivo.WriteLine("");
                    STW_Arquivo.WriteLine(item.Id);
                    STW_Arquivo.WriteLine(item.Nome);
                    STW_Arquivo.WriteLine(item.Email);
                    STW_Arquivo.WriteLine("");
                }


                //FECHAR
                STW_Arquivo.Close();

                MessageBox.Show("Arquivo gerado!");


            }
            catch (System.Exception)
            {

                MessageBox.Show("Erro ao gerar arquivo");
            }

        }



    }
}
