namespace AT2_WFCadastros
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar form = new FormCadastrar();
            form.ShowDialog();
        }

        private void mnsListar_Click(object sender, EventArgs e)
        {
            FormListar form = new FormListar();
            form.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
