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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        BLL_Usuario objbll_usuario = new BLL_Usuario();
        BLL_Setor objbll_setor = new BLL_Setor();
        DTO_Usuario objdto_usuario = new DTO_Usuario();

        public void CarregarGrid()
        {
            try
            {
                cbxsetor.DataSource = objbll_setor.Consultar_Tabela();
                cbxsetor.DisplayMember = "descricao";
                cbxsetor.ValueMember = "id";
                dgvusuario.DataSource = objbll_usuario.Consultar_Tabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                objdto_usuario.Nome = txtnome.Text;
                objdto_usuario.Telefone = txttelefone.Text;
                objdto_usuario.Email = txtemail.Text;
                objdto_usuario.Id_setor = int.Parse(cbxsetor.SelectedValue.ToString());
                objbll_usuario.Inserir_Usuario(objdto_usuario);
                MessageBox.Show("Usuario inserido com sucesso!");
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpar()
        {
            txtemail.Clear();
            txttelefone.Clear();
            txtnome.Clear();
            txtemail.Clear();
            cbxsetor.SelectedIndex = -1;
        }

        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnsair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                objdto_usuario.Id = int.Parse(txtid.Text);
                objbll_usuario.Excluir_Usuario(objdto_usuario);
                MessageBox.Show("Usuario excluído com sucesso!");
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
