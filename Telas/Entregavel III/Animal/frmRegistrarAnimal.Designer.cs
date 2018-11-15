namespace Catiotro_s.Resgistros
{
    partial class frmRegistrarAnimal
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
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCorPelo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTipoPelo = new System.Windows.Forms.Label();
            this.lblNomeDono = new System.Windows.Forms.Label();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtTipoPelo = new System.Windows.Forms.TextBox();
            this.txtCorPelo = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboDono = new System.Windows.Forms.ComboBox();
            this.lblnasc = new System.Windows.Forms.Label();
            this.mkbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeAnimal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAnimal.Location = new System.Drawing.Point(148, 52);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(45, 17);
            this.lblNomeAnimal.TabIndex = 0;
            this.lblNomeAnimal.Text = "Nome";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.BackColor = System.Drawing.Color.Transparent;
            this.lblObs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(91, 198);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(32, 17);
            this.lblObs.TabIndex = 1;
            this.lblObs.Text = "Obs";
            this.lblObs.Click += new System.EventHandler(this.lblObs_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(148, 79);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(37, 17);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCorPelo
            // 
            this.lblCorPelo.AutoSize = true;
            this.lblCorPelo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorPelo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorPelo.Location = new System.Drawing.Point(293, 170);
            this.lblCorPelo.Name = "lblCorPelo";
            this.lblCorPelo.Size = new System.Drawing.Size(104, 17);
            this.lblCorPelo.TabIndex = 3;
            this.lblCorPelo.Text = "Cor da pelagem";
            this.lblCorPelo.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Raça";
            // 
            // lblTipoPelo
            // 
            this.lblTipoPelo.AutoSize = true;
            this.lblTipoPelo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPelo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPelo.Location = new System.Drawing.Point(15, 170);
            this.lblTipoPelo.Name = "lblTipoPelo";
            this.lblTipoPelo.Size = new System.Drawing.Size(109, 17);
            this.lblTipoPelo.TabIndex = 7;
            this.lblTipoPelo.Text = "Tipo de pelagem";
            // 
            // lblNomeDono
            // 
            this.lblNomeDono.AutoSize = true;
            this.lblNomeDono.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeDono.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDono.Location = new System.Drawing.Point(297, 79);
            this.lblNomeDono.Name = "lblNomeDono";
            this.lblNomeDono.Size = new System.Drawing.Size(101, 17);
            this.lblNomeDono.TabIndex = 8;
            this.lblNomeDono.Text = "Nome do dono";
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(198, 52);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(198, 20);
            this.txtNomeAnimal.TabIndex = 9;
            this.txtNomeAnimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAnimal_KeyPress);
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(198, 105);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(161, 20);
            this.txtRaca.TabIndex = 10;
            this.txtRaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAnimal_KeyPress);
            // 
            // txtTipoPelo
            // 
            this.txtTipoPelo.Location = new System.Drawing.Point(129, 169);
            this.txtTipoPelo.Name = "txtTipoPelo";
            this.txtTipoPelo.Size = new System.Drawing.Size(153, 20);
            this.txtTipoPelo.TabIndex = 11;
            this.txtTipoPelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAnimal_KeyPress);
            // 
            // txtCorPelo
            // 
            this.txtCorPelo.Location = new System.Drawing.Point(402, 169);
            this.txtCorPelo.Name = "txtCorPelo";
            this.txtCorPelo.Size = new System.Drawing.Size(163, 20);
            this.txtCorPelo.TabIndex = 12;
            this.txtCorPelo.TextChanged += new System.EventHandler(this.txtCorPelo_TextChanged);
            this.txtCorPelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAnimal_KeyPress);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(129, 198);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(436, 89);
            this.txtObs.TabIndex = 16;
            this.txtObs.TextChanged += new System.EventHandler(this.txtObs_TextChanged);
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.cboSexo.Location = new System.Drawing.Point(198, 78);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(84, 21);
            this.cboSexo.TabIndex = 17;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = global::Catiotro_s.Properties.Resources.icons8_save_261;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(241, 339);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 48);
            this.btnRegistrar.TabIndex = 117;
            this.btnRegistrar.Text = "Cadastrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboDono
            // 
            this.cboDono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDono.FormattingEnabled = true;
            this.cboDono.Location = new System.Drawing.Point(402, 78);
            this.cboDono.Name = "cboDono";
            this.cboDono.Size = new System.Drawing.Size(163, 21);
            this.cboDono.TabIndex = 120;
            // 
            // lblnasc
            // 
            this.lblnasc.AutoSize = true;
            this.lblnasc.BackColor = System.Drawing.Color.Transparent;
            this.lblnasc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnasc.Location = new System.Drawing.Point(365, 105);
            this.lblnasc.Name = "lblnasc";
            this.lblnasc.Size = new System.Drawing.Size(131, 17);
            this.lblnasc.TabIndex = 121;
            this.lblnasc.Text = "Data de Nascimento";
            // 
            // mkbDataNasc
            // 
            this.mkbDataNasc.Location = new System.Drawing.Point(498, 105);
            this.mkbDataNasc.Mask = "00/00/0000";
            this.mkbDataNasc.Name = "mkbDataNasc";
            this.mkbDataNasc.Size = new System.Drawing.Size(67, 20);
            this.mkbDataNasc.TabIndex = 122;
            this.mkbDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // pbxImagem
            // 
            this.pbxImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagem.Location = new System.Drawing.Point(18, 30);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(124, 123);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagem.TabIndex = 118;
            this.pbxImagem.TabStop = false;
            this.pbxImagem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(186)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 306);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Animal";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // frmRegistrarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catiotro_s.Properties.Resources.Plano_de_Fundo_Catioro_s_DEFINITIVO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.mkbDataNasc);
            this.Controls.Add(this.lblnasc);
            this.Controls.Add(this.cboDono);
            this.Controls.Add(this.pbxImagem);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtCorPelo);
            this.Controls.Add(this.txtTipoPelo);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.txtNomeAnimal);
            this.Controls.Add(this.lblNomeDono);
            this.Controls.Add(this.lblTipoPelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCorPelo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblNomeAnimal);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarAnimal";
            this.Size = new System.Drawing.Size(583, 405);
            this.Load += new System.EventHandler(this.RegistrarAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCorPelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTipoPelo;
        private System.Windows.Forms.Label lblNomeDono;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtTipoPelo;
        private System.Windows.Forms.TextBox txtCorPelo;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.ComboBox cboDono;
        private System.Windows.Forms.Label lblnasc;
        private System.Windows.Forms.MaskedTextBox mkbDataNasc;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
