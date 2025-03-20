namespace AT2_WFCadastros
{
    partial class FormCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblDataCadastro = new Label();
            dtpDataCadastro = new DateTimePicker();
            lblStatus = new Label();
            cbxStatus = new ComboBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(21, 23);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(21, 41);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(59, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(99, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(196, 23);
            txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(99, 23);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(23, 79);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(23, 97);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(272, 23);
            txtDescricao.TabIndex = 5;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(166, 141);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(97, 15);
            lblDataCadastro.TabIndex = 6;
            lblDataCadastro.Text = "Data de Cadastro";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(166, 159);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(129, 23);
            dtpDataCadastro.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(23, 141);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cbxStatus.Location = new Point(23, 159);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(102, 23);
            cbxStatus.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(112, 208);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 40);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 260);
            Controls.Add(btnCadastrar);
            Controls.Add(cbxStatus);
            Controls.Add(lblStatus);
            Controls.Add(dtpDataCadastro);
            Controls.Add(lblDataCadastro);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblDataCadastro;
        private DateTimePicker dtpDataCadastro;
        private Label lblStatus;
        private ComboBox cbxStatus;
        private Button btnCadastrar;
    }
}