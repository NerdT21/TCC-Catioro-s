namespace Catiotro_s.Telas.Entregavel_II.Furnecedor
{
    partial class frmAlterarFornecedor
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 291);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alteração de Fornecedores";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(379, 244);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(60, 25);
            this.txtNumero.TabIndex = 136;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 135;
            this.label2.Text = "Nº";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(86, 248);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(252, 25);
            this.txtRua.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Rua";
            // 
            // mkbCep
            // 
            this.mkbCep.Location = new System.Drawing.Point(86, 181);
            this.mkbCep.Mask = "00000-000";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(58, 25);
            this.mkbCep.TabIndex = 132;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(397, 210);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(42, 25);
            this.cboEstado.TabIndex = 131;
            // 
            // lblBairro
            // 
            this.lblBairro.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(46, 183);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 20);
            this.lblBairro.TabIndex = 130;
            this.lblBairro.Text = "CEP";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(87, 124);
            this.txtTelefone.Mask = "(99)9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(77, 25);
            this.txtTelefone.TabIndex = 129;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(10, 123);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(67, 20);
            this.lbltelefone.TabIndex = 128;
            this.lbltelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 25);
            this.txtNome.TabIndex = 127;
            // 
            // lblNomeJuridico
            // 
            this.lblNomeJuridico.AutoSize = true;
            this.lblNomeJuridico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJuridico.Location = new System.Drawing.Point(28, 29);
            this.lblNomeJuridico.Name = "lblNomeJuridico";
            this.lblNomeJuridico.Size = new System.Drawing.Size(54, 20);
            this.lblNomeJuridico.TabIndex = 126;
            this.lblNomeJuridico.Text = "Nome ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 25);
            this.txtEmail.TabIndex = 125;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(32, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 124;
            this.lblEmail.Text = "E-mail";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(86, 95);
            this.txtCnpj.Mask = "99.999.999/9999-99";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(105, 25);
            this.txtCnpj.TabIndex = 123;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(87, 212);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 25);
            this.txtCidade.TabIndex = 122;
            // 
            // lblCidadeF
            // 
            this.lblCidadeF.AutoSize = true;
            this.lblCidadeF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeF.Location = new System.Drawing.Point(28, 215);
            this.lblCidadeF.Name = "lblCidadeF";
            this.lblCidadeF.Size = new System.Drawing.Size(56, 20);
            this.lblCidadeF.TabIndex = 121;
            this.lblCidadeF.Text = "Cidade";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(337, 212);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(54, 20);
            this.lblestado.TabIndex = 120;
            this.lblestado.Text = "Estado";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(39, 93);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(42, 20);
            this.lblCNPJ.TabIndex = 119;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Catiotro_s.Properties.Resources.icons8_edit_file_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(237, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 47);
            this.button1.TabIndex = 120;
            this.button1.Text = "Alterar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAlterarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlterarFornecedor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarFornecedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button button1;
    }
}