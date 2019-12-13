
using DrFotografia.DAO;

namespace DrFotografia.Controller
{
    class SoftwareController
    {

        public void IniciaLogin()
        {
            SoftwareDAO dao = new SoftwareDAO();

            dao.IniciarLogin();

        }//QUANDO INICIAR LOGIN

        public void TesteConexao()
        {
            SoftwareDAO dao = new SoftwareDAO();

            dao.TesteConexao();

        }//QUANDO INICIAR LOGIN
    }
}
