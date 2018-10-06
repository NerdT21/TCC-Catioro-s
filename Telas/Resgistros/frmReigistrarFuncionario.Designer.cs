namespace Catiotro_s.Resgistros
{
    partial class frmReigistrarFuncionario
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
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailF = new System.Windows.Forms.TextBox();
            this.lblemailF = new System.Windows.Forms.Label();
            this.lblNumero2F = new System.Windows.Forms.Label();
            this.txtNomeF = new System.Windows.Forms.TextBox();
            this.lblCPFF = new System.Windows.Forms.Label();
            this.lblNomeF = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mkbEstado = new System.Windows.Forms.MaskedTextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.lclCel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(145, 132);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(91, 20);
            this.txtCPF.TabIndex = 70;
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(333, 97);
            this.mkbTelefone.Mask = "(99) 0000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(71, 20);
            this.mkbTelefone.TabIndex = 69;
            // 
            // txtEmailF
            // 
            this.txtEmailF.Location = new System.Drawing.Point(145, 62);
            this.txtEmailF.Name = "txtEmailF";
            this.txtEmailF.Size = new System.Drawing.Size(259, 20);
            this.txtEmailF.TabIndex = 68;
            // 
            // lblemailF
            // 
            this.lblemailF.AutoSize = true;
            this.lblemailF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailF.Location = new System.Drawing.Point(62, 56);
            this.lblemailF.Name = "lblemailF";
            this.lblemailF.Size = new System.Drawing.Size(66, 25);
            this.lblemailF.TabIndex = 67;
            this.lblemailF.Text = "E-mail";
            this.lblemailF.Click += new System.EventHandler(this.lblemailF_Click);
            // 
            // lblNumero2F
            // 
            this.lblNumero2F.AutoSize = true;
            this.lblNumero2F.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2F.Location = new System.Drawing.Point(242, 92);
            this.lblNumero2F.Name = "lblNumero2F";
            this.lblNumero2F.Size = new System.Drawing.Size(85, 25);
            this.lblNumero2F.TabIndex = 66;
            this.lblNumero2F.Text = "Telefone";
            // 
            // txtNomeF
            // 
            this.txtNomeF.Location = new System.Drawing.Point(145, 28);
            this.txtNomeF.Name = "txtNomeF";
            this.txtNomeF.Size = new System.Drawing.Size(259, 20);
            this.txtNomeF.TabIndex = 65;
            // 
            // lblCPFF
            // 
            this.lblCPFF.AutoSize = true;
            this.lblCPFF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFF.Location = new System.Drawing.Point(84, 126);
            this.lblCPFF.Name = "lblCPFF";
            this.lblCPFF.Size = new System.Drawing.Size(44, 25);
            this.lblCPFF.TabIndex = 64;
            this.lblCPFF.Text = "CPF";
            // 
            // lblNomeF
            // 
            this.lblNomeF.AutoSize = true;
            this.lblNomeF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeF.Location = new System.Drawing.Point(65, 28);
            this.lblNomeF.Name = "lblNomeF";
            this.lblNomeF.Size = new System.Drawing.Size(63, 25);
            this.lblNomeF.TabIndex = 63;
            this.lblNomeF.Text = "Nome";
            this.lblNomeF.Click += new System.EventHandler(this.lblNomeF_Click);
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidade.Location = new System.Drawing.Point(3, 167);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(127, 25);
            this.lblEspecialidade.TabIndex = 71;
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Click += new System.EventHandler(this.lblEspecialidade_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 167);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 68);
            this.textBox1.TabIndex = 72;
            // 
            // mkbEstado
            // 
            this.mkbEstado.Location = new System.Drawing.Point(145, 262);
            this.mkbEstado.Mask = "AA";
            this.mkbEstado.Name = "mkbEstado";
            this.mkbEstado.Size = new System.Drawing.Size(19, 20);
            this.mkbEstado.TabIndex = 78;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(6, 335);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(133, 25);
            this.lblDepartamento.TabIndex = 77;
            this.lblDepartamento.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(145, 339);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(259, 21);
            this.cboDepartamento.TabIndex = 76;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(235, 262);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(111, 20);
            this.txtCidade.TabIndex = 75;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(166, 259);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(71, 25);
            this.lblCidade.TabIndex = 74;
            this.lblCidade.Text = "Cidade";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(60, 259);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(68, 25);
            this.lblestado.TabIndex = 73;
            this.lblestado.Text = "Estado";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(145, 301);
            this.txtCEP.Mask = "99999-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(68, 20);
            this.txtCEP.TabIndex = 80;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(65, 296);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(45, 25);
            this.lblCEP.TabIndex = 79;
            this.lblCEP.Text = "CEP";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(146, 98);
            this.txtCel.Mask = "(99) 00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(91, 20);
            this.txtCel.TabIndex = 82;
            // 
            // lclCel
            // 
            this.lclCel.AutoSize = true;
            this.lclCel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclCel.Location = new System.Drawing.Point(43, 92);
            this.lclCel.Name = "lclCel";
            this.lclCel.Size = new System.Drawing.Size(72, 25);
            this.lclCel.TabIndex = 81;
            this.lclCel.Text = "Celular";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(333, 126);
            this.maskedTextBox1.Mask = "00000000-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBox1.TabIndex = 84;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(252, 125);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(36, 25);
            this.lblRG.TabIndex = 83;
            this.lblRG.Text = "RG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(450, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 118);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // frmReigistrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.lclCel);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.mkbEstado);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.mkbTelefone);
            this.Controls.Add(this.txtEmailF);
            this.Controls.Add(this.lblemailF);
            this.Controls.Add(this.lblNumero2F);
            this.Controls.Add(this.txtNomeF);
            this.Controls.Add(this.lblCPFF);
            this.Controls.Add(this.lblNomeF);
            this.Name = "frmReigistrarFuncionario";
            this.Size = new System.Drawing.Size(605, 388);
            this.Load += new System.EventHandler(this.ReigistrarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.TextBox txtEmailF;
        private System.Windows.Forms.Label lblemailF;
        private System.Windows.Forms.Label lblNumero2F;
        private System.Windows.Forms.TextBox txtNomeF;
        private System.Windows.Forms.Label lblCPFF;
        private System.Windows.Forms.Label lblNomeF;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox mkbEstado;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.Label lclCel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
