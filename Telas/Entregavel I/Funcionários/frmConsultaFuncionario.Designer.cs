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
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.btnFolhaDePagamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcurar
            // 
            this.lblProcurar.AutoSize = true;
            this.lblProcurar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurar.Location = new System.Drawing.Point(20, 12);
            this.lblProcurar.Name = "lblProcurar";
            this.lblProcurar.Size = new System.Drawing.Size(85, 25);
            this.lblProcurar.TabIndex = 0;
            this.lblProcurar.Text = "Procurar";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(111, 18);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(323, 20);
            this.txtProcurar.TabIndex = 3;
            this.txtProcurar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(479, 54);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 29);
            this.btnProcurar.TabIndex = 5;
            this.btnProcurar.Text = "procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(15, 89);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(573, 285);
            this.dgvFuncionario.TabIndex = 6;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(440, 18);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(114, 21);
            this.cboDepartamento.TabIndex = 7;
            // 
            // btnFolhaDePagamento
            // 
            this.btnFolhaDePagamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolhaDePagamento.Location = new System.Drawing.Point(259, 54);
            this.btnFolhaDePagamento.Name = "btnFolhaDePagamento";
            this.btnFolhaDePagamento.Size = new System.Drawing.Size(175, 29);
            this.btnFolhaDePagamento.TabIndex = 8;
            this.btnFolhaDePagamento.Text = "Folha de Pagamento";
            this.btnFolhaDePagamento.UseVisualStyleBackColor = true;
            // 
            // frmConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFolhaDePagamento);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.lblProcurar);
            this.Name = "frmConsultaFuncionario";
            this.Size = new System.Drawing.Size(605, 388);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Button btnFolhaDePagamento;
    }
}
