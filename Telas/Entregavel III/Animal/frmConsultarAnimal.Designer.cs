namespace Catiotro_s.Consultar
{
    partial class frmConsultarAnimal
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
            this.dgvAnimal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.lblprocurar = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtDono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.AllowUserToAddRows = false;
            this.dgvAnimal.AllowUserToDeleteRows = false;
            this.dgvAnimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dgvAnimal.Location = new System.Drawing.Point(15, 90);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.ReadOnly = true;
            this.dgvAnimal.RowHeadersVisible = false;
            this.dgvAnimal.Size = new System.Drawing.Size(553, 270);
            this.dgvAnimal.TabIndex = 10;
            this.dgvAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Cliente";
            this.Column8.HeaderText = "Nome do Dono";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dsSexo";
            this.Column3.HeaderText = "Sexo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dsRaca";
            this.Column4.HeaderText = "Raça";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "dtDataNasc";
            this.Column7.HeaderText = "Nascimento";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dsPelagem";
            this.Column5.HeaderText = "Tipo da Pelagem";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dsCorPelagem";
            this.Column6.HeaderText = "Cor da pelagem";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txtAnimal
            // 
            this.txtAnimal.Location = new System.Drawing.Point(121, 24);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(219, 20);
            this.txtAnimal.TabIndex = 8;
            this.txtAnimal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblprocurar
            // 
            this.lblprocurar.AutoSize = true;
            this.lblprocurar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblprocurar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprocurar.Location = new System.Drawing.Point(11, 21);
            this.lblprocurar.Name = "lblprocurar";
            this.lblprocurar.Size = new System.Drawing.Size(104, 21);
            this.lblprocurar.TabIndex = 7;
            this.lblprocurar.Text = "Nome animal";
            this.lblprocurar.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.White;
            this.btnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Image = global::Catiotro_s.Properties.Resources.icons8_search_26;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.Location = new System.Drawing.Point(478, 29);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(90, 42);
            this.btnProcurar.TabIndex = 11;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtDono
            // 
            this.txtDono.Location = new System.Drawing.Point(121, 53);
            this.txtDono.Name = "txtDono";
            this.txtDono.Size = new System.Drawing.Size(219, 20);
            this.txtDono.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome dono";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::Catiotro_s.Properties.Resources.icons8_edit_file_30;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(15, 365);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 37);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.White;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Image = global::Catiotro_s.Properties.Resources.icons8_cancel_30;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(115, 365);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(94, 37);
            this.btnDeletar.TabIndex = 22;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // frmConsultarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catiotro_s.Properties.Resources.Backgorund_222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtDono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.dgvAnimal);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.lblprocurar);
            this.Name = "frmConsultarAnimal";
            this.Size = new System.Drawing.Size(583, 405);
            this.Load += new System.EventHandler(this.frmConsultarAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimal;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.Label lblprocurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtDono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
    }
}
