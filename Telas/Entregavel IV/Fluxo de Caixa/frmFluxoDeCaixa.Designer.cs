namespace Catiotro_s.Telas.Entregavel_IV.Floxo_de_Caixa
{
    partial class frmFluxoDeCaixa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFluxoDeCaixa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoDeCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFluxoDeCaixa
            // 
            this.dgvFluxoDeCaixa.AllowUserToAddRows = false;
            this.dgvFluxoDeCaixa.AllowUserToDeleteRows = false;
            this.dgvFluxoDeCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFluxoDeCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvFluxoDeCaixa.Location = new System.Drawing.Point(37, 49);
            this.dgvFluxoDeCaixa.Name = "dgvFluxoDeCaixa";
            this.dgvFluxoDeCaixa.ReadOnly = true;
            this.dgvFluxoDeCaixa.Size = new System.Drawing.Size(504, 308);
            this.dgvFluxoDeCaixa.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DataReferencia";
            this.Column1.HeaderText = "Data de Referência";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ganhos";
            this.Column2.HeaderText = "Total Ganhos";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Despesas";
            this.Column3.HeaderText = "Total Despesas";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Saldo";
            this.Column4.HeaderText = "Saldo Final";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmFluxoDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catiotro_s.Properties.Resources.Backgorund_222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvFluxoDeCaixa);
            this.Name = "frmFluxoDeCaixa";
            this.Size = new System.Drawing.Size(583, 405);
            this.Load += new System.EventHandler(this.frmFluxoDeCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoDeCaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFluxoDeCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
