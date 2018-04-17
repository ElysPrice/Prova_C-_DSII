namespace ETEC.Avaliacao.Interface
{
    partial class frmClienteCelular
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
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.lblIDCel = new System.Windows.Forms.Label();
            this.txbIDCel = new System.Windows.Forms.TextBox();
            this.txbIDCli = new System.Windows.Forms.TextBox();
            this.btnAssociar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblApres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(200, 60);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(53, 13);
            this.lblIDCliente.TabIndex = 0;
            this.lblIDCliente.Text = "ID Cliente";
            // 
            // lblIDCel
            // 
            this.lblIDCel.AutoSize = true;
            this.lblIDCel.Location = new System.Drawing.Point(200, 130);
            this.lblIDCel.Name = "lblIDCel";
            this.lblIDCel.Size = new System.Drawing.Size(53, 13);
            this.lblIDCel.TabIndex = 1;
            this.lblIDCel.Text = "ID Celular";
            // 
            // txbIDCel
            // 
            this.txbIDCel.Location = new System.Drawing.Point(203, 146);
            this.txbIDCel.Name = "txbIDCel";
            this.txbIDCel.Size = new System.Drawing.Size(63, 20);
            this.txbIDCel.TabIndex = 2;
            // 
            // txbIDCli
            // 
            this.txbIDCli.Location = new System.Drawing.Point(203, 76);
            this.txbIDCli.Name = "txbIDCli";
            this.txbIDCli.Size = new System.Drawing.Size(63, 20);
            this.txbIDCli.TabIndex = 3;
            // 
            // btnAssociar
            // 
            this.btnAssociar.Location = new System.Drawing.Point(25, 224);
            this.btnAssociar.Name = "btnAssociar";
            this.btnAssociar.Size = new System.Drawing.Size(75, 23);
            this.btnAssociar.TabIndex = 4;
            this.btnAssociar.Text = "Associar";
            this.btnAssociar.UseVisualStyleBackColor = true;
            this.btnAssociar.Click += new System.EventHandler(this.btnAssociar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(150, 224);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(265, 224);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(381, 224);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblApres
            // 
            this.lblApres.AutoSize = true;
            this.lblApres.Location = new System.Drawing.Point(168, 21);
            this.lblApres.Name = "lblApres";
            this.lblApres.Size = new System.Drawing.Size(130, 13);
            this.lblApres.TabIndex = 7;
            this.lblApres.Text = "Associação cliente-celular";
            // 
            // frmClienteCelular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 266);
            this.Controls.Add(this.lblApres);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAssociar);
            this.Controls.Add(this.txbIDCli);
            this.Controls.Add(this.txbIDCel);
            this.Controls.Add(this.lblIDCel);
            this.Controls.Add(this.lblIDCliente);
            this.Name = "frmClienteCelular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar cliente ao celular - Assistência ETEC Zona Leste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Label lblIDCel;
        private System.Windows.Forms.TextBox txbIDCel;
        private System.Windows.Forms.TextBox txbIDCli;
        private System.Windows.Forms.Button btnAssociar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblApres;
    }
}