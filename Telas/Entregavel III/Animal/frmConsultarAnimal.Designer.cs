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
            this.txtprocurar = new System.Windows.Forms.TextBox();
            this.lblprocurar = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Location = new System.Drawing.Point(16, 79);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.Size = new System.Drawing.Size(573, 285);
            this.dgvAnimal.TabIndex = 10;
            this.dgvAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtprocurar
            // 
            this.txtprocurar.Location = new System.Drawing.Point(111, 27);
            this.txtprocurar.Name = "txtprocurar";
            this.txtprocurar.Size = new System.Drawing.Size(356, 20);
            this.txtprocurar.TabIndex = 8;
            this.txtprocurar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblprocurar
            // 
            this.lblprocurar.AutoSize = true;
            this.lblprocurar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprocurar.Location = new System.Drawing.Point(35, 27);
            this.lblprocurar.Name = "lblprocurar";
            this.lblprocurar.Size = new System.Drawing.Size(70, 21);
            this.lblprocurar.TabIndex = 7;
            this.lblprocurar.Text = "Procurar";
            this.lblprocurar.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(485, 24);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 29);
            this.btnProcurar.TabIndex = 11;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // frmConsultarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.dgvAnimal);
            this.Controls.Add(this.txtprocurar);
            this.Controls.Add(this.lblprocurar);
            this.Name = "frmConsultarAnimal";
            this.Size = new System.Drawing.Size(605, 388);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimal;
        private System.Windows.Forms.TextBox txtprocurar;
        private System.Windows.Forms.Label lblprocurar;
        private System.Windows.Forms.Button btnProcurar;
    }
}
