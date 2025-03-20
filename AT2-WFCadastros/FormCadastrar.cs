using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            cbxStatus.SelectedIndex = -1;
            dtpDataCadastro.Value = DateTime.Now;
        }

        public bool CamposNaoPreenchidos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
                return true;
            if (string.IsNullOrEmpty(txtNome.Text))
                return true;
            if (cbxStatus.SelectedIndex == -1)
                return true;
            if (dtpDataCadastro.Value == DateTime.Now)
                return true;
            if (string.IsNullOrEmpty(txtDescricao.Text))
                return true;

            return false;

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (CamposNaoPreenchidos() == true)
            {
                Erro("Todos os Campos devem ser preenchidos!");
                return;
            }
            Categoria categ = new Categoria();
            categ.Codigo = Convert.ToInt32(txtCodigo.Text);
            categ.Nome = txtNome.Text;
            categ.Descricao = txtDescricao.Text;
            categ.DataCadastro = dtpDataCadastro.Value;
            categ.Status = cbxStatus.SelectedIndex.ToString();

            categ.Cadastro();
           
            LimparCampos();
            
        }
    }
}
