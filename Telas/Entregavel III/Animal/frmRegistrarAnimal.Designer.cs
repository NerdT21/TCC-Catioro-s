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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboDono = new System.Windows.Forms.ComboBox();
            this.lblnasc = new System.Windows.Forms.Label();
            this.mkbCadastro = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAnimal.Location = new System.Drawing.Point(91, 18);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(53, 21);
            this.lblNomeAnimal.TabIndex = 0;
            this.lblNomeAnimal.Text = "Nome";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(111, 167);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(38, 21);
            this.lblObs.TabIndex = 1;
            this.lblObs.Text = "Obs";
            this.lblObs.Click += new System.EventHandler(this.lblObs_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(101, 44);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(43, 21);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCorPelo
            // 
            this.lblCorPelo.AutoSize = true;
            this.lblCorPelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorPelo.Location = new System.Drawing.Point(32, 126);
            this.lblCorPelo.Name = "lblCorPelo";
            this.lblCorPelo.Size = new System.Drawing.Size(120, 21);
            this.lblCorPelo.TabIndex = 3;
            this.lblCorPelo.Text = "Cor da pelagem";
            this.lblCorPelo.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Raça";
            // 
            // lblTipoPelo
            // 
            this.lblTipoPelo.AutoSize = true;
            this.lblTipoPelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPelo.Location = new System.Drawing.Point(24, 100);
            this.lblTipoPelo.Name = "lblTipoPelo";
            this.lblTipoPelo.Size = new System.Drawing.Size(125, 21);
            this.lblTipoPelo.TabIndex = 7;
            this.lblTipoPelo.Text = "Tipo de pelagem";
            // 
            // lblNomeDono
            // 
            this.lblNomeDono.AutoSize = true;
            this.lblNomeDono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDono.Location = new System.Drawing.Point(8, 313);
            this.lblNomeDono.Name = "lblNomeDono";
            this.lblNomeDono.Size = new System.Drawing.Size(115, 21);
            this.lblNomeDono.TabIndex = 8;
            this.lblNomeDono.Text = "Nome do dono";
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(155, 18);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(246, 20);
            this.txtNomeAnimal.TabIndex = 9;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(155, 77);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(198, 20);
            this.txtRaca.TabIndex = 10;
            // 
            // txtTipoPelo
            // 
            this.txtTipoPelo.Location = new System.Drawing.Point(155, 103);
            this.txtTipoPelo.Name = "txtTipoPelo";
            this.txtTipoPelo.Size = new System.Drawing.Size(198, 20);
            this.txtTipoPelo.TabIndex = 11;
            // 
            // txtCorPelo
            // 
            this.txtCorPelo.Location = new System.Drawing.Point(155, 129);
            this.txtCorPelo.Name = "txtCorPelo";
            this.txtCorPelo.Size = new System.Drawing.Size(198, 20);
            this.txtCorPelo.TabIndex = 12;
            this.txtCorPelo.TextChanged += new System.EventHandler(this.txtCorPelo_TextChanged);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(155, 155);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(166, 33);
            this.txtObs.TabIndex = 16;
            this.txtObs.TextChanged += new System.EventHandler(this.txtObs_TextChanged);
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.cboSexo.Location = new System.Drawing.Point(155, 44);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(142, 21);
            this.cboSexo.TabIndex = 17;
            this.cboSexo.Text = "Escolha o sexo do animal";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(460, 316);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 56);
            this.btnRegistrar.TabIndex = 117;
            this.btnRegistrar.Text = "Cadastrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(460, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 123);
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(73, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 10);
            this.panel1.TabIndex = 119;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboDono
            // 
            this.cboDono.FormattingEnabled = true;
            this.cboDono.Location = new System.Drawing.Point(129, 316);
            this.cboDono.Name = "cboDono";
            this.cboDono.Size = new System.Drawing.Size(121, 21);
            this.cboDono.TabIndex = 120;
            // 
            // lblnasc
            // 
            this.lblnasc.AutoSize = true;
            this.lblnasc.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnasc.Location = new System.Drawing.Point(32, 221);
            this.lblnasc.Name = "lblnasc";
            this.lblnasc.Size = new System.Drawing.Size(145, 20);
            this.lblnasc.TabIndex = 121;
            this.lblnasc.Text = "Data de Nascimento";
            // 
            // mkbCadastro
            // 
            this.mkbCadastro.Location = new System.Drawing.Point(183, 223);
            this.mkbCadastro.Mask = "00/00/0000";
            this.mkbCadastro.Name = "mkbCadastro";
            this.mkbCadastro.Size = new System.Drawing.Size(67, 20);
            this.mkbCadastro.TabIndex = 122;
            this.mkbCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // frmRegistrarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mkbCadastro);
            this.Controls.Add(this.lblnasc);
            this.Controls.Add(this.cboDono);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "frmRegistrarAnimal";
            this.Size = new System.Drawing.Size(605, 388);
            this.Load += new System.EventHandler(this.RegistrarAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboDono;
        private System.Windows.Forms.Label lblnasc;
        private System.Windows.Forms.MaskedTextBox mkbCadastro;
    }
}
