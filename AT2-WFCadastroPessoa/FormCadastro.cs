using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AT2_WFCadastroPessoa
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtCodigo.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            mkdCpf.Clear();
            mkdDddCelular.Clear();
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
            cbxPossuiFilhos.CheckState = CheckState.Indeterminate;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            EtipoTelefone tipotelefone;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("O codigo não foi informado!", "Erro");
                return;
            }
            if (string.IsNullOrEmpty(mkdCpf.Text))
            {
                MessageBox.Show("O CPF não foi informado!", "Erro");
                return;
            }
            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                MessageBox.Show("O Nome não foi informado!", "Erro");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("O email não foi informado!", "Erro");
                return;
            }
            
            if (string.IsNullOrEmpty(mkdDddCelular.Text))
            {
                MessageBox.Show("O CPF não foi informado!", "Erro");
                return;
            }
            if (rdbPessoal.Checked)
            {
                tipotelefone = EtipoTelefone.Pessoal;
            }
            else if (rdbComercial.Checked)
            {
                tipotelefone = EtipoTelefone.Comercial;
            }
            else if (rdbRecado.Checked)
            {
                tipotelefone = EtipoTelefone.Recado;
            }
            else
            {
                MessageBox.Show("O tipo de telefone não foi informado", "Erro");
                return;
            }

            Pessoa p = new Pessoa();
            p.Codigo = int.Parse(txtCodigo.Text);
            p.CPF = mkdCpf.Text;
            p.NomeCompleto = txtNomeCompleto.Text;
            p.Email = txtEmail.Text;
            p.TipoTelefone = tipotelefone;
            p.DDD = mkdDddCelular.Text.Substring(1, 2);
            p.Telefone = mkdDddCelular.Text.Substring(5);


            if (cbxPossuiFilhos.CheckState == CheckState.Checked)
            {
                p.PossuiFilhos = true;
            }
            else if (cbxPossuiFilhos.CheckState == CheckState.Unchecked)
            {
                p.PossuiFilhos = false;
            }
            else
            {
                MessageBox.Show("Possui Filhos não foi marcado");
                return;
            }
                  
            Pessoa.ListaPessoas.Add(p);

            MessageBox.Show("Cadastro realizado com sucesso!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparFormulario();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
