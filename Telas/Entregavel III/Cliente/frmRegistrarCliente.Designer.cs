namespace Catiotro_s.Resgistros
{
    partial class frmRegistrarCliente
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
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mkbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
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
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.mkbCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(248, 191);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(156, 20);
            this.txtCidade.TabIndex = 38;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(76, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 5);
            this.panel1.TabIndex = 44;
            // 
            // mkbNascimento
            // 
            this.mkbNascimento.Location = new System.Drawing.Point(172, 106);
            this.mkbNascimento.Mask = "00/00/0000";
            this.mkbNascimento.Name = "mkbNascimento";
            this.mkbNascimento.Size = new System.Drawing.Size(72, 20);
            this.mkbNascimento.TabIndex = 30;
            this.mkbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(145, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Image = global::Catiotro_s.Properties.Resources.icons8_save_26;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(248, 323);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 47);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(321, 106);
            this.mkbTelefone.Mask = "(00)00000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(83, 20);
            this.mkbTelefone.TabIndex = 32;
            // 
            // mkbCPF
            // 
            this.mkbCPF.Location = new System.Drawing.Point(161, 135);
            this.mkbCPF.Mask = "000.000.000-00";
            this.mkbCPF.Name = "mkbCPF";
            this.mkbCPF.Size = new System.Drawing.Size(83, 20);
            this.mkbCPF.TabIndex = 34;
            // 
            // mkbRG
            // 
            this.mkbRG.Location = new System.Drawing.Point(321, 132);
            this.mkbRG.Mask = "00.000.000-0";
            this.mkbRG.Name = "mkbRG";
            this.mkbRG.Size = new System.Drawing.Size(83, 20);
            this.mkbRG.TabIndex = 35;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(145, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(259, 20);
            this.txtNome.TabIndex = 25;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(410, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(188, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(248, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Telefone";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nascimento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(286, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(124, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome";
            // 
            // cboUF
            // 
            this.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(476, 190);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(44, 21);
            this.cboUF.TabIndex = 45;
            this.cboUF.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(78, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(118, 191);
            this.txtCEP.Mask = "99999-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(58, 20);
            this.txtCEP.TabIndex = 103;
            this.txtCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCEP_MaskInputRejected);
            this.txtCEP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCEP_KeyUp);
            // 
            // mkbCadastro
            // 
            this.mkbCadastro.Location = new System.Drawing.Point(207, 261);
            this.mkbCadastro.Mask = "00/00/0000";
            this.mkbCadastro.Name = "mkbCadastro";
            this.mkbCadastro.Size = new System.Drawing.Size(67, 20);
            this.mkbCadastro.TabIndex = 108;
            this.mkbCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(78, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 109;
            this.label13.Text = "Data de cadastro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(78, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 110;
            this.label9.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(118, 223);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(286, 20);
            this.txtRua.TabIndex = 111;
            this.txtRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(438, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 112;
            this.label11.Text = "Nº";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(476, 223);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(44, 20);
            this.txtNumero.TabIndex = 113;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // pbxImagem
            // 
            this.pbxImagem.BackColor = System.Drawing.Color.White;
            this.pbxImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagem.Location = new System.Drawing.Point(425, 41);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(112, 113);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagem.TabIndex = 43;
            this.pbxImagem.TabStop = false;
            this.pbxImagem.Click += new System.EventHandler(this.pbxImagem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 282);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Cliente";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // frmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Catiotro_s.Properties.Resources.Backgorund_222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.Controls.Add(this.btnCadastrar);
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
            this.Name = "frmRegistrarCliente";
            this.Size = new System.Drawing.Size(605, 388);
            this.Load += new System.EventHandler(this.RegistrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mkbNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.Button btnCadastrar;
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
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox mkbCadastro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
