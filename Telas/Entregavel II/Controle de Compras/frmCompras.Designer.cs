namespace Catiotro_s.Telas.Entregavel_II.Controle_de_Compras
{
    partial class frmCompras
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
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoPag = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mkbDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProduto
            // 
            this.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(118, 56);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(159, 25);
            this.cboProduto.TabIndex = 0;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(148, 169);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(77, 25);
            this.nudQuantidade.TabIndex = 2;
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fornecedor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de Compra";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Forma De Pagamento ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(148, 127);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(159, 25);
            this.txtProduto.TabIndex = 11;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Produto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboTipoPag
            // 
            this.cboTipoPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPag.FormattingEnabled = true;
            this.cboTipoPag.Items.AddRange(new object[] {
            "A vista",
            "Cartão",
            "Boleto"});
            this.cboTipoPag.Location = new System.Drawing.Point(148, 258);
            this.cboTipoPag.Name = "cboTipoPag";
            this.cboTipoPag.Size = new System.Drawing.Size(159, 25);
            this.cboTipoPag.TabIndex = 13;
            this.cboTipoPag.SelectedIndexChanged += new System.EventHandler(this.cboTipoPag_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sub. Total";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-21, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 5);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvCompras.Location = new System.Drawing.Point(326, 115);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.Size = new System.Drawing.Size(254, 184);
            this.dgvCompras.TabIndex = 17;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Nome";
            this.Column2.HeaderText = "Produto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Fornecedor";
            this.Column3.HeaderText = "Fornecedor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Preco";
            this.Column5.HeaderText = "Preço";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // mkbDataCompra
            // 
            this.mkbDataCompra.Location = new System.Drawing.Point(150, 214);
            this.mkbDataCompra.Mask = "00/00/0000";
            this.mkbDataCompra.Name = "mkbDataCompra";
            this.mkbDataCompra.Size = new System.Drawing.Size(74, 25);
            this.mkbDataCompra.TabIndex = 19;
            this.mkbDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.Location = new System.Drawing.Point(425, 304);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.ReadOnly = true;
            this.txtPrecoTotal.Size = new System.Drawing.Size(114, 25);
            this.txtPrecoTotal.TabIndex = 20;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(396, 56);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.Size = new System.Drawing.Size(145, 25);
            this.txtFornecedor.TabIndex = 21;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Location = new System.Drawing.Point(251, 351);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(106, 42);
            this.btnComprar.TabIndex = 22;
            this.btnComprar.Text = "Emitir";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Catiotro_s.Properties.Resources.icons8_plus_321;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(185, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 38);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Catiotro_s.Properties.Resources.Plano_de_Fundo_Catioro_s_DEFINITIVO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtPrecoTotal);
            this.Controls.Add(this.mkbDataCompra);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTipoPag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.cboProduto);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCompras";
            this.Size = new System.Drawing.Size(583, 405);
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoPag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.MaskedTextBox mkbDataCompra;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
