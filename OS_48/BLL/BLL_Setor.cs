using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OS_48.DAL;
using OS_48.DTO;

namespace OS_48.BLL
{
    internal class BLL_Setor
    {
        ConexaoBD bd = new ConexaoBD();

        public DataTable Consultar_Tabela()
        {
            try
            {
                return bd.ConsultarTabelas("select * from setor");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
