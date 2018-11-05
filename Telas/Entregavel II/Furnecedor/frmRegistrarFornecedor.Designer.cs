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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mkbCep = new System.Windows.Forms.MaskedTextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeJuridico = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidadeF = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mkbCep);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.lbltelefone);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNomeJuridico);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtCnpj);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.lblCidadeF);
            this.groupBox1.Controls.Add(this.lblestado);
            this.groupBox1.Controls.Add(this.lblCNPJ);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 251);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Fornecedores";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(403, 200);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(54, 25);
            this.txtNumero.TabIndex = 136;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 135;
            this.label2.Text = "Nº";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(88, 200);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(271, 25);
            this.txtRua.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Rua";
            // 
            // mkbCep
            // 
            this.mkbCep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbCep.Location = new System.Drawing.Point(88, 164);
            this.mkbCep.Mask = "00000-000";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(58, 25);
            this.mkbCep.TabIndex = 132;
            this.mkbCep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mkbCep_KeyUp);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(403, 164);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(54, 25);
            this.cboEstado.TabIndex = 131;
            // 
            // lblBairro
            // 
            this.lblBairro.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.White;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(48, 165);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 20);
            this.lblBairro.TabIndex = 130;
            this.lblBairro.Text = "CEP";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(271, 102);
            this.txtTelefone.Mask = "(99)9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(77, 25);
            this.txtTelefone.TabIndex = 129;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.BackColor = System.Drawing.Color.White;
            this.lbltelefone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(199, 103);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(66, 20);
            this.lbltelefone.TabIndex = 128;
            this.lbltelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(88, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 25);
            this.txtNome.TabIndex = 127;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNomeJuridico
            // 
            this.lblNomeJuridico.AutoSize = true;
            this.lblNomeJuridico.BackColor = System.Drawing.Color.White;
            this.lblNomeJuridico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJuridico.Location = new System.Drawing.Point(30, 36);
            this.lblNomeJuridico.Name = "lblNomeJuridico";
            this.lblNomeJuridico.Size = new System.Drawing.Size(54, 20);
            this.lblNomeJuridico.TabIndex = 126;
            this.lblNomeJuridico.Text = "Nome ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(88, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 25);
            this.txtEmail.TabIndex = 125;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(34, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 124;
            this.lblEmail.Text = "E-mail";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(88, 102);
            this.txtCnpj.Mask = "99.999.999/9999-99";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(105, 25);
            this.txtCnpj.TabIndex = 123;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(214, 164);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 25);
            this.txtCidade.TabIndex = 122;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblCidadeF
            // 
            this.lblCidadeF.AutoSize = true;
            this.lblCidadeF.BackColor = System.Drawing.Color.White;
            this.lblCidadeF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeF.Location = new System.Drawing.Point(152, 165);
            this.lblCidadeF.Name = "lblCidadeF";
            this.lblCidadeF.Size = new System.Drawing.Size(56, 20);
            this.lblCidadeF.TabIndex = 121;
            this.lblCidadeF.Text = "Cidade";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.BackColor = System.Drawing.Color.White;
            this.lblestado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(343, 165);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(54, 20);
            this.lblestado.TabIndex = 120;
            this.lblestado.Text = "Estado";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.BackColor = System.Drawing.Color.White;
            this.lblCNPJ.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(41, 100);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(41, 20);
            this.lblCNPJ.TabIndex = 119;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Catiotro_s.Properties.Resources.icons8_save_26;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(252, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 47);
            this.button1.TabIndex = 116;
            this.button1.Text = "Cadastrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegistrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catiotro_s.Properties.Resources.Backgorund_222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmRegistrarFornecedor";
            this.Size = new System.Drawing.Size(605, 388);
            this.Load += new System.EventHandler(this.RegistrarFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mkbCep;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeJuridico;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidadeF;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label1;
    }
}
