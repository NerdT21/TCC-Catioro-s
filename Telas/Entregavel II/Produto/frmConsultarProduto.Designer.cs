﻿namespace Catiotro_s.Telas.Entregavel_II.Produto
{
    partial class frmConsultarProduto
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
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtprocurar = new System.Windows.Forms.TextBox();
            this.lblprocurar = new System.Windows.Forms.Label();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(486, 25);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 29);
            this.btnProcurar.TabIndex = 18;
            this.btnProcurar.Text = "procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // txtprocurar
            // 
            this.txtprocurar.Location = new System.Drawing.Point(112, 28);
            this.txtprocurar.Name = "txtprocurar";
            this.txtprocurar.Size = new System.Drawing.Size(356, 20);
            this.txtprocurar.TabIndex = 17;
            // 
            // lblprocurar
            // 
            this.lblprocurar.AutoSize = true;
            this.lblprocurar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprocurar.Location = new System.Drawing.Point(36, 28);
            this.lblprocurar.Name = "lblprocurar";
            this.lblprocurar.Size = new System.Drawing.Size(70, 21);
            this.lblprocurar.TabIndex = 16;
            this.lblprocurar.Text = "Procurar";
            this.lblprocurar.Click += new System.EventHandler(this.lblprocurar_Click);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(16, 78);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(573, 285);
            this.dgvFornecedor.TabIndex = 15;
            // 
            // frmConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtprocurar);
            this.Controls.Add(this.lblprocurar);
            this.Controls.Add(this.dgvFornecedor);
            this.Name = "frmConsultarProduto";
            this.Size = new System.Drawing.Size(605, 388);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtprocurar;
        private System.Windows.Forms.Label lblprocurar;
        private System.Windows.Forms.DataGridView dgvFornecedor;
    }
}
