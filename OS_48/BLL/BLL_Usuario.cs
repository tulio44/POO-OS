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
    internal class BLL_Usuario
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;
        public void Inserir_Usuario(DTO_Usuario usuario)
        {
            try
            {
                string sql = string.Format("insert into usuario values(null,'{0}','{1}','{2}','{3}','{4}')", usuario.Nome, usuario.Email, usuario.Telefone, usuario.Id_setor, usuario.Senha);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_Usuario(DTO_Usuario usuario)
        {
            try
            {
                this.sql = string.Format("update usuario set nome = '{0}',email = '{1}',telefone = '{2}',setor = '{3}' ,senha = '{4}' where id = '{5}'",
                    usuario.Nome, usuario.Email, usuario.Telefone, usuario.Id_setor, usuario.Senha, usuario.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Excluir_Usuario(DTO_Usuario usuario)
        {
            try
            {
                this.sql = String.Format("delete from usuario where id ='{0}'", usuario.Id);
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
                this.sql = "select * from usuario";
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
