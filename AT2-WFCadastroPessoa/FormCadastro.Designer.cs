namespace AT2_WFCadastroPessoa
{
    partial class FormCadastro
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
            mkdCpf = new MaskedTextBox();
            txtNomeCompleto = new TextBox();
            txtEmail = new TextBox();
            mkdDddCelular = new MaskedTextBox();
            cbxPossuiFilhos = new CheckBox();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            lblCpf = new Label();
            lblNomeCompleto = new Label();
            lblEmail = new Label();
            lblDddCelular = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(14, 17);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(14, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // mkdCpf
            // 
            mkdCpf.Location = new Point(134, 35);
            mkdCpf.Mask = "000-000-000-00";
            mkdCpf.Name = "mkdCpf";
            mkdCpf.Size = new Size(128, 23);
            mkdCpf.TabIndex = 2;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(14, 90);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(248, 23);
            txtNomeCompleto.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 4;
            // 
            // mkdDddCelular
            // 
            mkdDddCelular.Location = new Point(12, 204);
            mkdDddCelular.Mask = "(00) 00000-0000";
            mkdDddCelular.Name = "mkdDddCelular";
            mkdDddCelular.Size = new Size(100, 23);
            mkdDddCelular.TabIndex = 5;
            // 
            // cbxPossuiFilhos
            // 
            cbxPossuiFilhos.AutoSize = true;
            cbxPossuiFilhos.Location = new Point(15, 244);
            cbxPossuiFilhos.Name = "cbxPossuiFilhos";
            cbxPossuiFilhos.Size = new Size(99, 19);
            cbxPossuiFilhos.TabIndex = 6;
            cbxPossuiFilhos.Text = "Possui Filhos?";
            cbxPossuiFilhos.UseVisualStyleBackColor = true;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Location = new Point(150, 186);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(112, 100);
            gbxTipoTelefone.TabIndex = 7;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(4, 69);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(4, 44);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(4, 22);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(134, 17);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 8;
            lblCpf.Text = "CPF";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(14, 72);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 9;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(14, 131);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "E-mail";
            // 
            // lblDddCelular
            // 
            lblDddCelular.AutoSize = true;
            lblDddCelular.Location = new Point(14, 186);
            lblDddCelular.Name = "lblDddCelular";
            lblDddCelular.Size = new Size(73, 15);
            lblDddCelular.TabIndex = 11;
            lblDddCelular.Text = "DDD/Celular";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.save;
            btnSalvar.Location = new Point(154, 292);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(108, 47);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = Properties.Resources.left;
            btnVoltar.Location = new Point(27, 292);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(108, 47);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 370);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(lblDddCelular);
            Controls.Add(lblEmail);
            Controls.Add(lblNomeCompleto);
            Controls.Add(lblCpf);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(cbxPossuiFilhos);
            Controls.Add(mkdDddCelular);
            Controls.Add(txtEmail);
            Controls.Add(txtNomeCompleto);
            Controls.Add(mkdCpf);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private MaskedTextBox mkdCpf;
        private TextBox txtNomeCompleto;
        private TextBox txtEmail;
        private MaskedTextBox mkdDddCelular;
        private CheckBox cbxPossuiFilhos;
        private GroupBox gbxTipoTelefone;
        private Label lblCpf;
        private Label lblNomeCompleto;
        private Label lblEmail;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private Label lblDddCelular;
        private Button btnSalvar;
        private Button btnVoltar;
    }
}