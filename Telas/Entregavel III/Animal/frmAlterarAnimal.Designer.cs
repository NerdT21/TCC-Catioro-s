﻿namespace Catiotro_s.Telas.Entregavel_III.Animal
{
    partial class frmAlterarAnimal
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
            this.mkbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblnasc = new System.Windows.Forms.Label();
            this.cboDono = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtCorPelo = new System.Windows.Forms.TextBox();
            this.txtTipoPelo = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.lblNomeDono = new System.Windows.Forms.Label();
            this.lblTipoPelo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCorPelo = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // mkbDataNasc
            // 
            this.mkbDataNasc.Location = new System.Drawing.Point(491, 86);
            this.mkbDataNasc.Mask = "00/00/0000";
            this.mkbDataNasc.Name = "mkbDataNasc";
            this.mkbDataNasc.Size = new System.Drawing.Size(67, 20);
            this.mkbDataNasc.TabIndex = 140;
            this.mkbDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lblnasc
            // 
            this.lblnasc.AutoSize = true;
            this.lblnasc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnasc.Location = new System.Drawing.Point(358, 86);
            this.lblnasc.Name = "lblnasc";
            this.lblnasc.Size = new System.Drawing.Size(127, 17);
            this.lblnasc.TabIndex = 139;
            this.lblnasc.Text = "Data de Nascimento";
            // 
            // cboDono
            // 
            this.cboDono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDono.FormattingEnabled = true;
            this.cboDono.Location = new System.Drawing.Point(395, 59);
            this.cboDono.Name = "cboDono";
            this.cboDono.Size = new System.Drawing.Size(163, 21);
            this.cboDono.TabIndex = 138;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(213, 298);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 56);
            this.btnRegistrar.TabIndex = 136;
            this.btnRegistrar.Text = "Alterar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.cboSexo.Location = new System.Drawing.Point(191, 59);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(84, 21);
            this.cboSexo.TabIndex = 135;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(122, 179);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(436, 89);
            this.txtObs.TabIndex = 134;
            // 
            // txtCorPelo
            // 
            this.txtCorPelo.Location = new System.Drawing.Point(395, 150);
            this.txtCorPelo.Name = "txtCorPelo";
            this.txtCorPelo.Size = new System.Drawing.Size(163, 20);
            this.txtCorPelo.TabIndex = 133;
            // 
            // txtTipoPelo
            // 
            this.txtTipoPelo.Location = new System.Drawing.Point(122, 150);
            this.txtTipoPelo.Name = "txtTipoPelo";
            this.txtTipoPelo.Size = new System.Drawing.Size(153, 20);
            this.txtTipoPelo.TabIndex = 132;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(191, 86);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(161, 20);
            this.txtRaca.TabIndex = 131;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(191, 33);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(198, 20);
            this.txtNomeAnimal.TabIndex = 130;
            // 
            // lblNomeDono
            // 
            this.lblNomeDono.AutoSize = true;
            this.lblNomeDono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDono.Location = new System.Drawing.Point(290, 60);
            this.lblNomeDono.Name = "lblNomeDono";
            this.lblNomeDono.Size = new System.Drawing.Size(99, 17);
            this.lblNomeDono.TabIndex = 129;
            this.lblNomeDono.Text = "Nome do dono";
            // 
            // lblTipoPelo
            // 
            this.lblTipoPelo.AutoSize = true;
            this.lblTipoPelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPelo.Location = new System.Drawing.Point(8, 151);
            this.lblTipoPelo.Name = "lblTipoPelo";
            this.lblTipoPelo.Size = new System.Drawing.Size(108, 17);
            this.lblTipoPelo.TabIndex = 128;
            this.lblTipoPelo.Text = "Tipo de pelagem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 127;
            this.label5.Text = "Raça";
            // 
            // lblCorPelo
            // 
            this.lblCorPelo.AutoSize = true;
            this.lblCorPelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorPelo.Location = new System.Drawing.Point(286, 151);
            this.lblCorPelo.Name = "lblCorPelo";
            this.lblCorPelo.Size = new System.Drawing.Size(103, 17);
            this.lblCorPelo.TabIndex = 126;
            this.lblCorPelo.Text = "Cor da pelagem";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(141, 60);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(36, 17);
            this.lblSexo.TabIndex = 125;
            this.lblSexo.Text = "Sexo";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(84, 179);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(32, 17);
            this.lblObs.TabIndex = 124;
            this.lblObs.Text = "Obs";
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAnimal.Location = new System.Drawing.Point(141, 33);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(44, 17);
            this.lblNomeAnimal.TabIndex = 123;
            this.lblNomeAnimal.Text = "Nome";
            // 
            // pbxImagem
            // 
            this.pbxImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagem.Location = new System.Drawing.Point(11, 11);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(124, 123);
            this.pbxImagem.TabIndex = 137;
            this.pbxImagem.TabStop = false;
            this.pbxImagem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAlterarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 366);
            this.Controls.Add(this.mkbDataNasc);
            this.Controls.Add(this.lblnasc);
            this.Controls.Add(this.cboDono);
            this.Controls.Add(this.pbxImagem);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtCorPelo);
            this.Controls.Add(this.txtTipoPelo);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.txtNomeAnimal);
            this.Controls.Add(this.lblNomeDono);
            this.Controls.Add(this.lblTipoPelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCorPelo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblNomeAnimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlterarAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarAnimal";
            this.Load += new System.EventHandler(this.frmAlterarAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mkbDataNasc;
        private System.Windows.Forms.Label lblnasc;
        private System.Windows.Forms.ComboBox cboDono;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtCorPelo;
        private System.Windows.Forms.TextBox txtTipoPelo;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label lblNomeDono;
        private System.Windows.Forms.Label lblTipoPelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCorPelo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblNomeAnimal;
    }
}