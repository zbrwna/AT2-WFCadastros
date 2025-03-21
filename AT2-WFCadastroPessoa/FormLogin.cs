namespace AT2_WFCadastroPessoa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 1001;
            us.Login = "sistema";
            us.Senha = "123456";

            Usuario.ListaUsuarios.Add(us);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.TodosOsUsuarios())        
            {
                if((txtLogin.Text == user.Login) &&
                    (txtSenha.Text == user.Senha))
                {
                    FormMain form = new FormMain();
                    form.ShowDialog();

                    txtLogin.Clear();
                    txtSenha.Clear();

                    return;
                }
            }
            txtSenha.Clear();
            Erro("Usuário e/ou Senha não encontrados!");
            return;

        }
    }
}
