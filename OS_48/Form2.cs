using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_48.DTO;
using OS_48.BLL;


namespace OS_48
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        BLL_Usuario objbll_usuario = new BLL_Usuario();
        BLL_Setor objbll_Setor = new BLL_Setor();
        DTO_Usuario blldto_usuario = new DTO_Usuario();

        public void CarregarGrid()
        {
            try
            {
                cbxSetor.DataSource = objbll_Setor.Consultar_Tabela();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void carregargrid() 
        {
            try 
            {
                cbxSetor.DataSource = objbll_Setor.Consultar_Tabela();
                cbxSetor.DisplayMember = "descricao";
                cbxSetor.ValueMember = "id";
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message ); 
            }
        }

        private void cbxSetor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

