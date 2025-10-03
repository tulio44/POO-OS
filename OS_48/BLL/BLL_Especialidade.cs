using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OS_48.DAL;
using OS_48.DTO;
using System.Data;

namespace OS_48.BLL
{
    internal class BLL_Especialidade
    {
        ConexaoBD bd = new ConexaoBD();

        public DataTable Consultar_Tabela()
        {
            try
            {
                return bd.ConsultarTabelas("select * from especialidade");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
