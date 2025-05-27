namespace HelpDesk
{
    partial class FormCadastroDeMaquina
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.lblUsuarioResp = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.txtSistemaOperacional = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuarioResponsavel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(134, 72);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(92, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Número de Série: ";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(137, 88);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(152, 20);
            this.txtSerie.TabIndex = 1;
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.Location = new System.Drawing.Point(332, 88);
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.Size = new System.Drawing.Size(152, 20);
            this.txtPatrimonio.TabIndex = 3;
            // 
            // lblUsuarioResp
            // 
            this.lblUsuarioResp.AutoSize = true;
            this.lblUsuarioResp.Location = new System.Drawing.Point(329, 174);
            this.lblUsuarioResp.Name = "lblUsuarioResp";
            this.lblUsuarioResp.Size = new System.Drawing.Size(111, 13);
            this.lblUsuarioResp.TabIndex = 2;
            this.lblUsuarioResp.Text = "Usuário Responsável:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(140, 135);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(152, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(137, 174);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(67, 13);
            this.lblLocalizacao.TabIndex = 4;
            this.lblLocalizacao.Text = "Localização:";
            // 
            // txtSistemaOperacional
            // 
            this.txtSistemaOperacional.Location = new System.Drawing.Point(332, 135);
            this.txtSistemaOperacional.Name = "txtSistemaOperacional";
            this.txtSistemaOperacional.Size = new System.Drawing.Size(152, 20);
            this.txtSistemaOperacional.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sistema Operacional:";
            // 
            // txtUsuarioResponsavel
            // 
            this.txtUsuarioResponsavel.Location = new System.Drawing.Point(332, 190);
            this.txtUsuarioResponsavel.Name = "txtUsuarioResponsavel";
            this.txtUsuarioResponsavel.Size = new System.Drawing.Size(152, 20);
            this.txtUsuarioResponsavel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nº Patrimônio:";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(140, 190);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(152, 20);
            this.txtLocalizacao.TabIndex = 11;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(137, 119);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "Modelo:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(198, 250);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(110, 23);
            this.btnContinuar.TabIndex = 12;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(316, 250);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormCadastroDeMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 505);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtUsuarioResponsavel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSistemaOperacional);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblLocalizacao);
            this.Controls.Add(this.txtPatrimonio);
            this.Controls.Add(this.lblUsuarioResp);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lbl1);
            this.DoubleBuffered = true;
            this.Name = "FormCadastroDeMaquina";
            this.Text = "Cadastro da Máquina";
            this.Load += new System.EventHandler(this.FormCadastroDeMaquina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.Label lblUsuarioResp;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.TextBox txtSistemaOperacional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuarioResponsavel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnLimpar;
    }
}