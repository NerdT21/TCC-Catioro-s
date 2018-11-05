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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagto));
            this.nudFaltas = new System.Windows.Forms.NumericUpDown();
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mkbData = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgFuncionario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudFaltas
            // 
            this.nudFaltas.Location = new System.Drawing.Point(406, 185);
            this.nudFaltas.Name = "nudFaltas";
            this.nudFaltas.Size = new System.Drawing.Size(60, 20);
            this.nudFaltas.TabIndex = 143;
            // 
            // mkbCPF
            // 
            this.mkbCPF.Location = new System.Drawing.Point(250, 73);
            this.mkbCPF.Mask = "000.000.000-00";
            this.mkbCPF.Name = "mkbCPF";
            this.mkbCPF.ReadOnly = true;
            this.mkbCPF.Size = new System.Drawing.Size(84, 20);
            this.mkbCPF.TabIndex = 139;
            // 
            // txtSalFam
            // 
            this.txtSalFam.Location = new System.Drawing.Point(226, 312);
            this.txtSalFam.Name = "txtSalFam";
            this.txtSalFam.ReadOnly = true;
            this.txtSalFam.Size = new System.Drawing.Size(107, 20);
            this.txtSalFam.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 136;
            this.label3.Text = "Salário Família ";
            // 
            // TxtSalLiq
            // 
            this.TxtSalLiq.Location = new System.Drawing.Point(413, 261);
            this.TxtSalLiq.Name = "TxtSalLiq";
            this.TxtSalLiq.ReadOnly = true;
            this.TxtSalLiq.Size = new System.Drawing.Size(53, 20);
            this.TxtSalLiq.TabIndex = 135;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
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
            this.cboFuncionario.Location = new System.Drawing.Point(250, 46);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(265, 21);
            this.cboFuncionario.TabIndex = 132;
            this.cboFuncionario.SelectedIndexChanged += new System.EventHandler(this.cboFuncionario_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(203, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 131;
            this.label12.Text = "CPF ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(191, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 130;
            this.label11.Text = "Nome";
            // 
            // txtValTrans
            // 
            this.txtValTrans.Location = new System.Drawing.Point(248, 260);
            this.txtValTrans.Name = "txtValTrans";
            this.txtValTrans.ReadOnly = true;
            this.txtValTrans.Size = new System.Drawing.Size(51, 20);
            this.txtValTrans.TabIndex = 129;
            // 
            // txtINSS
            // 
            this.txtINSS.Location = new System.Drawing.Point(176, 224);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.ReadOnly = true;
            this.txtINSS.Size = new System.Drawing.Size(67, 20);
            this.txtINSS.TabIndex = 127;
            // 
            // txtIR
            // 
            this.txtIR.Location = new System.Drawing.Point(385, 224);
            this.txtIR.Name = "txtIR";
            this.txtIR.ReadOnly = true;
            this.txtIR.Size = new System.Drawing.Size(81, 20);
            this.txtIR.TabIndex = 126;
            // 
            // txtFGTS
            // 
            this.txtFGTS.Location = new System.Drawing.Point(298, 224);
            this.txtFGTS.Name = "txtFGTS";
            this.txtFGTS.ReadOnly = true;
            this.txtFGTS.Size = new System.Drawing.Size(55, 20);
            this.txtFGTS.TabIndex = 125;
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(306, 99);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.ReadOnly = true;
            this.txtDepto.Size = new System.Drawing.Size(209, 20);
            this.txtDepto.TabIndex = 124;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(397, 73);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(118, 20);
            this.txtSalario.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 120;
            this.label9.Text = "Vale Transporte ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 119;
            this.label8.Text = "FGTS ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 118;
            this.label7.Text = "IR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 117;
            this.label6.Text = "Faltas ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 116;
            this.label4.Text = "Atrasos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 115;
            this.label2.Text = "Horas extra ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 114;
            this.label1.Text = "Salário ";
            // 
            // pbxImgFuncionario
            // 
            this.pbxImgFuncionario.BackColor = System.Drawing.Color.White;
            this.pbxImgFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImgFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("pbxImgFuncionario.Image")));
            this.pbxImgFuncionario.Location = new System.Drawing.Point(55, 26);
            this.pbxImgFuncionario.Name = "pbxImgFuncionario";
            this.pbxImgFuncionario.Size = new System.Drawing.Size(126, 119);
            this.pbxImgFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImgFuncionario.TabIndex = 138;
            this.pbxImgFuncionario.TabStop = false;
            this.pbxImgFuncionario.Click += new System.EventHandler(this.pbxImgFuncionario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 144;
            this.label5.Text = "INSS";
            // 
            // mkbHE
            // 
            this.mkbHE.Location = new System.Drawing.Point(218, 185);
            this.mkbHE.Mask = "90:00";
            this.mkbHE.Name = "mkbHE";
            this.mkbHE.Size = new System.Drawing.Size(35, 20);
            this.mkbHE.TabIndex = 146;
            this.mkbHE.ValidatingType = typeof(System.DateTime);
            // 
            // mkbAtraso
            // 
            this.mkbAtraso.Location = new System.Drawing.Point(320, 184);
            this.mkbAtraso.Mask = "90:00";
            this.mkbAtraso.Name = "mkbAtraso";
            this.mkbAtraso.Size = new System.Drawing.Size(35, 20);
            this.mkbAtraso.TabIndex = 147;
            this.mkbAtraso.ValidatingType = typeof(System.DateTime);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
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
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 152;
            this.label10.Text = "Salário Líquido:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(194, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 153;
            this.label13.Text = "Departamento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(356, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 20);
            this.label14.TabIndex = 154;
            this.label14.Text = "Data";
            // 
            // mkbData
            // 
            this.mkbData.Location = new System.Drawing.Point(403, 310);
            this.mkbData.Mask = "00/00/0000";
            this.mkbData.Name = "mkbData";
            this.mkbData.Size = new System.Drawing.Size(64, 20);
            this.mkbData.TabIndex = 155;
            this.mkbData.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 147);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox3_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 147);
            this.groupBox2.TabIndex = 157;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "C";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(39, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 187);
            this.groupBox3.TabIndex = 157;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Credenciais da folha";
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox3_Paint);
            // 
            // frmFolhaPagto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catiotro_s.Properties.Resources.Backgorund_222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.mkbData);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mkbAtraso);
            this.Controls.Add(this.mkbHE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudFaltas);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmFolhaPagto";
            this.Size = new System.Drawing.Size(583, 405);
            ((System.ComponentModel.ISupportInitialize)(this.nudFaltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgFuncionario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFaltas;
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
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mkbData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
