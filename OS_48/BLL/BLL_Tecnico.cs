using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OS_48.DTO;
using OS_48.DAL;
using System.Data;


namespace OS_48.BLL
{
    internal class BLL_Tecnico
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;
        public void Inserir_Tecnico(DTO_Tecnico tecnico)
        {
            try
            {
                string sql = string.Format("insert into tecnico values(null,'{0}','{1}','{2}','{3}')", tecnico.Nome, tecnico.Espec_id, tecnico.Email, tecnico.Senha);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_Tecnico(DTO_Tecnico tecnico)
        {
            try
            {
                this.sql = string.Format("update tecnico set nome = '{0}',especialidade = '{1}',email = '{2}',senha = '{3}' where id = '{4}'",
                    tecnico.Nome, tecnico.Espec_id, tecnico.Email, tecnico.Senha, tecnico.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Excluir_Tecnico(DTO_Tecnico tecnico)
        {
            try
            {
                this.sql = String.Format("delete from tecnico where id ='{0}'", tecnico.Id);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Consultar_Tabela()
        {
            try
            {
                this.sql = "select * from tecnico";
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
