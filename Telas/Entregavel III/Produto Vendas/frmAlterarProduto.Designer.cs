namespace Catiotro_s.Telas.Entregavel_III.Produto_Vendas
{
    partial class frmAlterarProduto
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(263, 72);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(159, 20);
            this.txtMarca.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(128, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Nome do Produto";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::Catiotro_s.Properties.Resources.icons8_edit_file_30;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(237, 275);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 47);
            this.btnAlterar.TabIndex = 65;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // nudPreco
            // 
            this.nudPreco.DecimalPlaces = 2;
            this.nudPreco.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPreco.Location = new System.Drawing.Point(263, 179);
            this.nudPreco.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(73, 20);
            this.nudPreco.TabIndex = 64;
            this.nudPreco.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(132, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Preço do Produto";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(263, 98);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(159, 75);
            this.txtDesc.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(105, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Descrição da Produto";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(263, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Marca";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(88, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 227);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Produto";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // frmAlterarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catiotro_s.Properties.Resources.Backgorund_222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 366);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.nudPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlterarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catioro\'s";
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}