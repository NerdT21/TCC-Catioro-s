namespace Catiotro_s.Telas.Entregavel_III.Cliente
{
    partial class frmAlterarCliente
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mkbCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mkbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mkbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mkbRG = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(446, 214);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(44, 20);
            this.txtNumero.TabIndex = 140;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(408, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 139;
            this.label11.Text = "Nº";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(88, 214);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(286, 20);
            this.txtRua.TabIndex = 138;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(48, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 137;
            this.label9.Text = "Rua";
            // 
            // mkbCadastro
            // 
            this.mkbCadastro.Location = new System.Drawing.Point(177, 252);
            this.mkbCadastro.Mask = "00/00/0000";
            this.mkbCadastro.Name = "mkbCadastro";
            this.mkbCadastro.Size = new System.Drawing.Size(67, 20);
            this.mkbCadastro.TabIndex = 135;
            this.mkbCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(48, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 136;
            this.label13.Text = "Data de cadastro";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(88, 182);
            this.txtCEP.Mask = "99999-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(58, 20);
            this.txtCEP.TabIndex = 134;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(48, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 133;
            this.label10.Text = "CEP";
            // 
            // cboUF
            // 
            this.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(446, 181);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(44, 21);
            this.cboUF.TabIndex = 132;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(218, 182);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(156, 20);
            this.txtCidade.TabIndex = 128;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(46, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 5);
            this.panel1.TabIndex = 131;
            // 
            // mkbNascimento
            // 
            this.mkbNascimento.Location = new System.Drawing.Point(142, 97);
            this.mkbNascimento.Mask = "00/00/0000";
            this.mkbNascimento.Name = "mkbNascimento";
            this.mkbNascimento.Size = new System.Drawing.Size(72, 20);
            this.mkbNascimento.TabIndex = 120;
            this.mkbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 20);
            this.txtEmail.TabIndex = 118;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Image = global::Catiotro_s.Properties.Resources.icons8_edit_file_30;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(239, 307);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 47);
            this.btnAlterar.TabIndex = 129;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(291, 97);
            this.mkbTelefone.Mask = "(00)00000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(83, 20);
            this.mkbTelefone.TabIndex = 122;
            // 
            // mkbCPF
            // 
            this.mkbCPF.Location = new System.Drawing.Point(131, 126);
            this.mkbCPF.Mask = "000.000.000-00";
            this.mkbCPF.Name = "mkbCPF";
            this.mkbCPF.Size = new System.Drawing.Size(83, 20);
            this.mkbCPF.TabIndex = 124;
            // 
            // mkbRG
            // 
            this.mkbRG.Location = new System.Drawing.Point(291, 123);
            this.mkbRG.Mask = "00.000.000-0";
            this.mkbRG.Name = "mkbRG";
            this.mkbRG.Size = new System.Drawing.Size(83, 20);
            this.mkbRG.TabIndex = 125;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(259, 20);
            this.txtNome.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(380, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 127;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(158, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 126;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(218, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 123;
            this.label6.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(48, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 121;
            this.label5.Text = "Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(256, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(94, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 117;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 116;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 114;
            this.label1.Text = "Nome";
            // 
            // pbxImagem
            // 
            this.pbxImagem.BackColor = System.Drawing.Color.White;
            this.pbxImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagem.Location = new System.Drawing.Point(395, 32);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(112, 113);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagem.TabIndex = 130;
            this.pbxImagem.TabStop = false;
            this.pbxImagem.Click += new System.EventHandler(this.pbxImagem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 285);
            this.groupBox1.TabIndex = 141;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Cliente";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // frmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catiotro_s.Properties.Resources.Backgorund_222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 366);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mkbCadastro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mkbNascimento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pbxImagem);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.mkbTelefone);
            this.Controls.Add(this.mkbCPF);
            this.Controls.Add(this.mkbRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mkbCadastro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mkbNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.MaskedTextBox mkbCPF;
        private System.Windows.Forms.MaskedTextBox mkbRG;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}