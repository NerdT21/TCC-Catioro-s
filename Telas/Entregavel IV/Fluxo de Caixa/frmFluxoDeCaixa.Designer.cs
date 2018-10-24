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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoDeCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFluxoDeCaixa
            // 
            this.dgvFluxoDeCaixa.AllowUserToAddRows = false;
            this.dgvFluxoDeCaixa.AllowUserToDeleteRows = false;
            this.dgvFluxoDeCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFluxoDeCaixa.Location = new System.Drawing.Point(161, 138);
            this.dgvFluxoDeCaixa.Name = "dgvFluxoDeCaixa";
            this.dgvFluxoDeCaixa.ReadOnly = true;
            this.dgvFluxoDeCaixa.Size = new System.Drawing.Size(240, 150);
            this.dgvFluxoDeCaixa.TabIndex = 0;
            // 
            // frmFluxoDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFluxoDeCaixa);
            this.Name = "frmFluxoDeCaixa";
            this.Size = new System.Drawing.Size(583, 405);
            this.Load += new System.EventHandler(this.frmFluxoDeCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoDeCaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFluxoDeCaixa;
    }
}
