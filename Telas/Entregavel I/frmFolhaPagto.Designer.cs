namespace Catiotro_s.Telas.Entregavel_I
{
    partial class frmFolhaPagto
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
            this.nudFaltas = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mkbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtSalFam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSalLiq = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValTrans = new System.Windows.Forms.TextBox();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.txtFGTS = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxImgFuncionario = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mkbHE = new System.Windows.Forms.MaskedTextBox();
            this.mkbAtraso = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFaltas
            // 
            this.nudFaltas.Location = new System.Drawing.Point(402, 169);
            this.nudFaltas.Name = "nudFaltas";
            this.nudFaltas.Size = new System.Drawing.Size(55, 20);
            this.nudFaltas.TabIndex = 143;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(5, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 5);
            this.panel1.TabIndex = 141;
            // 
            // mkbCPF
            // 
            this.mkbCPF.Location = new System.Drawing.Point(250, 68);
            this.mkbCPF.Mask = "000.000.000-00";
            this.mkbCPF.Name = "mkbCPF";
            this.mkbCPF.ReadOnly = true;
            this.mkbCPF.Size = new System.Drawing.Size(84, 20);
            this.mkbCPF.TabIndex = 139;
            // 
            // txtSalFam
            // 
            this.txtSalFam.Location = new System.Drawing.Point(297, 289);
            this.txtSalFam.Name = "txtSalFam";
            this.txtSalFam.ReadOnly = true;
            this.txtSalFam.Size = new System.Drawing.Size(107, 20);
            this.txtSalFam.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 136;
            this.label3.Text = "Salário Família ";
            // 
            // TxtSalLiq
            // 
            this.TxtSalLiq.Location = new System.Drawing.Point(405, 242);
            this.TxtSalLiq.Name = "TxtSalLiq";
            this.TxtSalLiq.ReadOnly = true;
            this.TxtSalLiq.Size = new System.Drawing.Size(53, 20);
            this.TxtSalLiq.TabIndex = 135;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(21, 347);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 41);
            this.btnCalcular.TabIndex = 133;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(250, 41);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(265, 21);
            this.cboFuncionario.TabIndex = 132;
            this.cboFuncionario.SelectedIndexChanged += new System.EventHandler(this.cboFuncionario_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(203, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 131;
            this.label12.Text = "CPF ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(191, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 130;
            this.label11.Text = "Nome";
            // 
            // txtValTrans
            // 
            this.txtValTrans.Location = new System.Drawing.Point(244, 244);
            this.txtValTrans.Name = "txtValTrans";
            this.txtValTrans.ReadOnly = true;
            this.txtValTrans.Size = new System.Drawing.Size(51, 20);
            this.txtValTrans.TabIndex = 129;
            // 
            // txtINSS
            // 
            this.txtINSS.Location = new System.Drawing.Point(172, 208);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.ReadOnly = true;
            this.txtINSS.Size = new System.Drawing.Size(67, 20);
            this.txtINSS.TabIndex = 127;
            // 
            // txtIR
            // 
            this.txtIR.Location = new System.Drawing.Point(381, 208);
            this.txtIR.Name = "txtIR";
            this.txtIR.ReadOnly = true;
            this.txtIR.Size = new System.Drawing.Size(76, 20);
            this.txtIR.TabIndex = 126;
            // 
            // txtFGTS
            // 
            this.txtFGTS.Location = new System.Drawing.Point(294, 208);
            this.txtFGTS.Name = "txtFGTS";
            this.txtFGTS.ReadOnly = true;
            this.txtFGTS.Size = new System.Drawing.Size(55, 20);
            this.txtFGTS.TabIndex = 125;
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(306, 94);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.ReadOnly = true;
            this.txtDepto.Size = new System.Drawing.Size(209, 20);
            this.txtDepto.TabIndex = 124;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(397, 68);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(118, 20);
            this.txtSalario.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 120;
            this.label9.Text = "Vale Transporte ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 119;
            this.label8.Text = "FGTS ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 118;
            this.label7.Text = "IR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 117;
            this.label6.Text = "Faltas ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 116;
            this.label4.Text = "Atrasos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 115;
            this.label2.Text = "Horas extra ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 114;
            this.label1.Text = "Salário ";
            // 
            // pbxImgFuncionario
            // 
            this.pbxImgFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImgFuncionario.Location = new System.Drawing.Point(59, 10);
            this.pbxImgFuncionario.Name = "pbxImgFuncionario";
            this.pbxImgFuncionario.Size = new System.Drawing.Size(126, 126);
            this.pbxImgFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImgFuncionario.TabIndex = 138;
            this.pbxImgFuncionario.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 144;
            this.label5.Text = "INSS";
            // 
            // mkbHE
            // 
            this.mkbHE.Location = new System.Drawing.Point(214, 169);
            this.mkbHE.Mask = "90:00";
            this.mkbHE.Name = "mkbHE";
            this.mkbHE.Size = new System.Drawing.Size(35, 20);
            this.mkbHE.TabIndex = 146;
            this.mkbHE.ValidatingType = typeof(System.DateTime);
            // 
            // mkbAtraso
            // 
            this.mkbAtraso.Location = new System.Drawing.Point(316, 168);
            this.mkbAtraso.Mask = "90:00";
            this.mkbAtraso.Name = "mkbAtraso";
            this.mkbAtraso.Size = new System.Drawing.Size(35, 20);
            this.mkbAtraso.TabIndex = 147;
            this.mkbAtraso.ValidatingType = typeof(System.DateTime);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(141, 347);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 41);
            this.btnLimpar.TabIndex = 148;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(453, 347);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(114, 41);
            this.btnSalvar.TabIndex = 150;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 152;
            this.label10.Text = "Salário Líquido:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(194, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 153;
            this.label13.Text = "Departamento";
            // 
            // frmFolhaPagto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mkbAtraso);
            this.Controls.Add(this.mkbHE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudFaltas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mkbCPF);
            this.Controls.Add(this.pbxImgFuncionario);
            this.Controls.Add(this.txtSalFam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSalLiq);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtValTrans);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.txtIR);
            this.Controls.Add(this.txtFGTS);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFolhaPagto";
            this.Size = new System.Drawing.Size(583, 405);
            ((System.ComponentModel.ISupportInitialize)(this.nudFaltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFaltas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mkbCPF;
        private System.Windows.Forms.PictureBox pbxImgFuncionario;
        private System.Windows.Forms.TextBox txtSalFam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSalLiq;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValTrans;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.TextBox txtIR;
        private System.Windows.Forms.TextBox txtFGTS;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mkbHE;
        private System.Windows.Forms.MaskedTextBox mkbAtraso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
    }
}
