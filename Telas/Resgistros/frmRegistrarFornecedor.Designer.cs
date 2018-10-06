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
            this.txtCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mkbEstado = new System.Windows.Forms.MaskedTextBox();
            this.txtCidadeF = new System.Windows.Forms.TextBox();
            this.lblCidadeF = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtNomeFor = new System.Windows.Forms.TextBox();
            this.lblNomeFantasiaFor = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtNomeJuridico = new System.Windows.Forms.TextBox();
            this.lblNomeJuridico = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.Location = new System.Drawing.Point(158, 125);
            this.txtCPF_CNPJ.Mask = "99.999.999/9999-99";
            this.txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            this.txtCPF_CNPJ.Size = new System.Drawing.Size(105, 20);
            this.txtCPF_CNPJ.TabIndex = 100;
            this.txtCPF_CNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_CNPJ_MaskInputRejected);
            // 
            // mkbEstado
            // 
            this.mkbEstado.Location = new System.Drawing.Point(355, 221);
            this.mkbEstado.Mask = "AA";
            this.mkbEstado.Name = "mkbEstado";
            this.mkbEstado.Size = new System.Drawing.Size(20, 20);
            this.mkbEstado.TabIndex = 99;
            this.mkbEstado.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkbEstado_MaskInputRejected);
            // 
            // txtCidadeF
            // 
            this.txtCidadeF.Location = new System.Drawing.Point(157, 218);
            this.txtCidadeF.Name = "txtCidadeF";
            this.txtCidadeF.Size = new System.Drawing.Size(123, 20);
            this.txtCidadeF.TabIndex = 98;
            this.txtCidadeF.TextChanged += new System.EventHandler(this.txtCidadeF_TextChanged);
            // 
            // lblCidadeF
            // 
            this.lblCidadeF.AutoSize = true;
            this.lblCidadeF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeF.Location = new System.Drawing.Point(75, 211);
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
            this.lblestado.Location = new System.Drawing.Point(287, 216);
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
            this.lblCNPJ.Location = new System.Drawing.Point(91, 119);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(56, 25);
            this.lblCNPJ.TabIndex = 95;
            this.lblCNPJ.Text = "CNPJ";
            this.lblCNPJ.Click += new System.EventHandler(this.lblCNPJ_Click);
            // 
            // txtNomeFor
            // 
            this.txtNomeFor.Location = new System.Drawing.Point(159, 59);
            this.txtNomeFor.Name = "txtNomeFor";
            this.txtNomeFor.Size = new System.Drawing.Size(215, 20);
            this.txtNomeFor.TabIndex = 94;
            this.txtNomeFor.TextChanged += new System.EventHandler(this.txtNomeFor_TextChanged);
            // 
            // lblNomeFantasiaFor
            // 
            this.lblNomeFantasiaFor.AutoSize = true;
            this.lblNomeFantasiaFor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasiaFor.Location = new System.Drawing.Point(13, 59);
            this.lblNomeFantasiaFor.Name = "lblNomeFantasiaFor";
            this.lblNomeFantasiaFor.Size = new System.Drawing.Size(134, 25);
            this.lblNomeFantasiaFor.TabIndex = 93;
            this.lblNomeFantasiaFor.Text = "Nome fantasia";
            this.lblNomeFantasiaFor.Click += new System.EventHandler(this.lblNomeFor_Click);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(287, 241);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(45, 25);
            this.lblCEP.TabIndex = 101;
            this.lblCEP.Text = "CEP";
            this.lblCEP.Click += new System.EventHandler(this.lblCEP_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(331, 247);
            this.txtCEP.Mask = "99999-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(58, 20);
            this.txtCEP.TabIndex = 102;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(84, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 105;
            this.lblEmail.Text = "E-mail";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(158, 91);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(215, 20);
            this.txtemail.TabIndex = 106;
            // 
            // txtNomeJuridico
            // 
            this.txtNomeJuridico.Location = new System.Drawing.Point(159, 31);
            this.txtNomeJuridico.Name = "txtNomeJuridico";
            this.txtNomeJuridico.Size = new System.Drawing.Size(215, 20);
            this.txtNomeJuridico.TabIndex = 108;
            // 
            // lblNomeJuridico
            // 
            this.lblNomeJuridico.AutoSize = true;
            this.lblNomeJuridico.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJuridico.Location = new System.Drawing.Point(13, 31);
            this.lblNomeJuridico.Name = "lblNomeJuridico";
            this.lblNomeJuridico.Size = new System.Drawing.Size(134, 25);
            this.lblNomeJuridico.TabIndex = 107;
            this.lblNomeJuridico.Text = "Nome Juridico";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(158, 282);
            this.txtNumero.Mask = "9999-9999";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(58, 20);
            this.txtNumero.TabIndex = 110;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(61, 276);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(85, 25);
            this.lblTel.TabIndex = 109;
            this.lblTel.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(159, 154);
            this.txtTelefone.Mask = "9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(57, 20);
            this.txtTelefone.TabIndex = 112;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(62, 149);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(85, 25);
            this.lbltelefone.TabIndex = 111;
            this.lbltelefone.Text = "Telefone";
            // 
            // txtBairro
            // 
            this.txtBairro.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.txtBairro.Location = new System.Drawing.Point(158, 247);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(123, 20);
            this.txtBairro.TabIndex = 114;
            // 
            // lblBairro
            // 
            this.lblBairro.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(83, 241);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(63, 25);
            this.lblBairro.TabIndex = 113;
            this.lblBairro.Text = "Bairro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(446, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 123);
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegistrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtNomeJuridico);
            this.Controls.Add(this.lblNomeJuridico);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtCPF_CNPJ);
            this.Controls.Add(this.mkbEstado);
            this.Controls.Add(this.txtCidadeF);
            this.Controls.Add(this.lblCidadeF);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.txtNomeFor);
            this.Controls.Add(this.lblNomeFantasiaFor);
            this.Name = "frmRegistrarFornecedor";
            this.Size = new System.Drawing.Size(605, 388);
            this.Load += new System.EventHandler(this.RegistrarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCPF_CNPJ;
        private System.Windows.Forms.MaskedTextBox mkbEstado;
        private System.Windows.Forms.TextBox txtCidadeF;
        private System.Windows.Forms.Label lblCidadeF;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtNomeFor;
        private System.Windows.Forms.Label lblNomeFantasiaFor;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtNomeJuridico;
        private System.Windows.Forms.Label lblNomeJuridico;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
