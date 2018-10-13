namespace Catiotro_s.Resgistros
{
    partial class frmRegistrarFornecedor
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidadeF = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeJuridico = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.mkbCep = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(157, 101);
            this.txtCnpj.Mask = "99.999.999/9999-99";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(105, 20);
            this.txtCnpj.TabIndex = 100;
            this.txtCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_CNPJ_MaskInputRejected);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(157, 187);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 20);
            this.txtCidade.TabIndex = 98;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidadeF_TextChanged);
            // 
            // lblCidadeF
            // 
            this.lblCidadeF.AutoSize = true;
            this.lblCidadeF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeF.Location = new System.Drawing.Point(75, 180);
            this.lblCidadeF.Name = "lblCidadeF";
            this.lblCidadeF.Size = new System.Drawing.Size(71, 25);
            this.lblCidadeF.TabIndex = 97;
            this.lblCidadeF.Text = "Cidade";
            this.lblCidadeF.Click += new System.EventHandler(this.lblCidadeF_Click);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(287, 185);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(68, 25);
            this.lblestado.TabIndex = 96;
            this.lblestado.Text = "Estado";
            this.lblestado.Click += new System.EventHandler(this.lblestado_Click);
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(90, 95);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(55, 25);
            this.lblCNPJ.TabIndex = 95;
            this.lblCNPJ.Text = "CNPJ";
            this.lblCNPJ.Click += new System.EventHandler(this.lblCNPJ_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(83, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 105;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 20);
            this.txtEmail.TabIndex = 106;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(159, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 20);
            this.txtNome.TabIndex = 108;
            // 
            // lblNomeJuridico
            // 
            this.lblNomeJuridico.AutoSize = true;
            this.lblNomeJuridico.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJuridico.Location = new System.Drawing.Point(79, 31);
            this.lblNomeJuridico.Name = "lblNomeJuridico";
            this.lblNomeJuridico.Size = new System.Drawing.Size(68, 25);
            this.lblNomeJuridico.TabIndex = 107;
            this.lblNomeJuridico.Text = "Nome ";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(158, 130);
            this.txtTelefone.Mask = "(99)9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(77, 20);
            this.txtTelefone.TabIndex = 112;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(61, 125);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(83, 25);
            this.lbltelefone.TabIndex = 111;
            this.lbltelefone.Text = "Telefone";
            // 
            // lblBairro
            // 
            this.lblBairro.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(83, 210);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(45, 25);
            this.lblBairro.TabIndex = 113;
            this.lblBairro.Text = "CEP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Catiotro_s.Properties.Resources.icons8_save_26;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(243, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 47);
            this.button1.TabIndex = 116;
            this.button1.Text = "Cadastrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(357, 188);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(42, 21);
            this.cboEstado.TabIndex = 117;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mkbCep
            // 
            this.mkbCep.Location = new System.Drawing.Point(157, 215);
            this.mkbCep.Mask = "00000-000";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(58, 20);
            this.mkbCep.TabIndex = 118;
            this.mkbCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // frmRegistrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mkbCep);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeJuridico);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidadeF);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblCNPJ);
            this.Name = "frmRegistrarFornecedor";
            this.Size = new System.Drawing.Size(605, 388);
            this.Load += new System.EventHandler(this.RegistrarFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidadeF;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeJuridico;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.MaskedTextBox mkbCep;
    }
}
