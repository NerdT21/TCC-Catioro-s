﻿namespace Catiotro_s.Telas.Entregavel_I
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.mkbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtSalFam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSalLiq = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValTrans = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.txtFGTS = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.txtHE = new System.Windows.Forms.TextBox();
            this.txtAtraso = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudFaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFaltas
            // 
            this.nudFaltas.Location = new System.Drawing.Point(432, 180);
            this.nudFaltas.Name = "nudFaltas";
            this.nudFaltas.Size = new System.Drawing.Size(55, 20);
            this.nudFaltas.TabIndex = 143;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(141, 332);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 21);
            this.lblTotal.TabIndex = 142;
            this.lblTotal.Text = "-";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(65, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 20);
            this.panel1.TabIndex = 141;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(201, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 21);
            this.label14.TabIndex = 140;
            this.label14.Text = "Departamento";
            // 
            // mkbCPF
            // 
            this.mkbCPF.Location = new System.Drawing.Point(256, 39);
            this.mkbCPF.Mask = "000.000.000-00";
            this.mkbCPF.Name = "mkbCPF";
            this.mkbCPF.ReadOnly = true;
            this.mkbCPF.Size = new System.Drawing.Size(84, 20);
            this.mkbCPF.TabIndex = 139;
            // 
            // txtSalFam
            // 
            this.txtSalFam.Location = new System.Drawing.Point(177, 292);
            this.txtSalFam.Name = "txtSalFam";
            this.txtSalFam.Size = new System.Drawing.Size(107, 20);
            this.txtSalFam.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 136;
            this.label3.Text = "Salário Família ";
            // 
            // TxtSalLiq
            // 
            this.TxtSalLiq.Location = new System.Drawing.Point(410, 292);
            this.TxtSalLiq.Name = "TxtSalLiq";
            this.TxtSalLiq.Size = new System.Drawing.Size(118, 20);
            this.TxtSalLiq.TabIndex = 135;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 21);
            this.label13.TabIndex = 134;
            this.label13.Text = "Total R$:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(252, 351);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 41);
            this.btnCalcular.TabIndex = 133;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(256, 12);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(265, 21);
            this.cboFuncionario.TabIndex = 132;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(209, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 21);
            this.label12.TabIndex = 131;
            this.label12.Text = "CPF ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(197, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 21);
            this.label11.TabIndex = 130;
            this.label11.Text = "Nome";
            // 
            // txtValTrans
            // 
            this.txtValTrans.Location = new System.Drawing.Point(423, 249);
            this.txtValTrans.Name = "txtValTrans";
            this.txtValTrans.Size = new System.Drawing.Size(98, 20);
            this.txtValTrans.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 128;
            this.label10.Text = "Salário líquido ";
            // 
            // txtINSS
            // 
            this.txtINSS.Location = new System.Drawing.Point(115, 214);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(169, 20);
            this.txtINSS.TabIndex = 127;
            // 
            // txtIR
            // 
            this.txtIR.Location = new System.Drawing.Point(187, 249);
            this.txtIR.Name = "txtIR";
            this.txtIR.Size = new System.Drawing.Size(97, 20);
            this.txtIR.TabIndex = 126;
            // 
            // txtFGTS
            // 
            this.txtFGTS.Location = new System.Drawing.Point(335, 215);
            this.txtFGTS.Name = "txtFGTS";
            this.txtFGTS.Size = new System.Drawing.Size(186, 20);
            this.txtFGTS.TabIndex = 125;
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(317, 65);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.ReadOnly = true;
            this.txtDepto.Size = new System.Drawing.Size(204, 20);
            this.txtDepto.TabIndex = 124;
            // 
            // txtHE
            // 
            this.txtHE.Location = new System.Drawing.Point(145, 179);
            this.txtHE.Name = "txtHE";
            this.txtHE.Size = new System.Drawing.Size(72, 20);
            this.txtHE.TabIndex = 123;
            // 
            // txtAtraso
            // 
            this.txtAtraso.Location = new System.Drawing.Point(294, 180);
            this.txtAtraso.Name = "txtAtraso";
            this.txtAtraso.Size = new System.Drawing.Size(72, 20);
            this.txtAtraso.TabIndex = 122;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(403, 39);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(118, 20);
            this.txtSalario.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 21);
            this.label9.TabIndex = 120;
            this.label9.Text = "Vale-Transporte ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 119;
            this.label8.Text = "FGTS ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 118;
            this.label7.Text = "Imposto de renda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 117;
            this.label6.Text = "Faltas ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 116;
            this.label4.Text = "Atrasos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 115;
            this.label2.Text = "Horas extra ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
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
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 144;
            this.label5.Text = "INSS";
            // 
            // frmFolhaPagto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudFaltas);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mkbCPF);
            this.Controls.Add(this.pbxImgFuncionario);
            this.Controls.Add(this.txtSalFam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSalLiq);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtValTrans);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.txtIR);
            this.Controls.Add(this.txtFGTS);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.txtHE);
            this.Controls.Add(this.txtAtraso);
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
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mkbCPF;
        private System.Windows.Forms.PictureBox pbxImgFuncionario;
        private System.Windows.Forms.TextBox txtSalFam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSalLiq;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValTrans;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.TextBox txtIR;
        private System.Windows.Forms.TextBox txtFGTS;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.TextBox txtHE;
        private System.Windows.Forms.TextBox txtAtraso;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
