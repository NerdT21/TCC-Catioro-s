namespace Catiotro_s.Consultar
{
    partial class frmConsultaFuncionario
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
            this.lblProcurar = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcurar
            // 
            this.lblProcurar.AutoSize = true;
            this.lblProcurar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurar.Location = new System.Drawing.Point(19, 12);
            this.lblProcurar.Name = "lblProcurar";
            this.lblProcurar.Size = new System.Drawing.Size(53, 21);
            this.lblProcurar.TabIndex = 0;
            this.lblProcurar.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(323, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column8,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column11,
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column13});
            this.dgvFuncionario.Location = new System.Drawing.Point(3, 71);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.Size = new System.Drawing.Size(577, 280);
            this.dgvFuncionario.TabIndex = 6;
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(79, 40);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(117, 20);
            this.txtCpf.TabIndex = 12;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Image = global::Catiotro_s.Properties.Resources.icons8_cancel_30;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(118, 359);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(94, 37);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::Catiotro_s.Properties.Resources.icons8_edit_file_30;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(18, 359);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 37);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Image = global::Catiotro_s.Properties.Resources.icons8_search_26;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.Location = new System.Drawing.Point(473, 15);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(94, 45);
            this.btnProcurar.TabIndex = 5;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
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
            // Column4
            // 
            this.Column4.DataPropertyName = "Depto";
            this.Column4.HeaderText = "Departamento";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Salario";
            this.Column8.HeaderText = "Salário";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "E-mail";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Cpf";
            this.Column5.HeaderText = "CPF";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Rg";
            this.Column6.HeaderText = "RG";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Telefone";
            this.Column7.HeaderText = "Telefone";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Cep";
            this.Column11.HeaderText = "CEP";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Cidade";
            this.Column9.HeaderText = "Cidade";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Estado";
            this.Column10.HeaderText = "Estado";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Rua";
            this.Column12.HeaderText = "Rua";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Numero";
            this.Column13.HeaderText = "Nº";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // frmConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblProcurar);
            this.Name = "frmConsultaFuncionario";
            this.Size = new System.Drawing.Size(583, 405);
            this.Load += new System.EventHandler(this.frmConsultaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}
