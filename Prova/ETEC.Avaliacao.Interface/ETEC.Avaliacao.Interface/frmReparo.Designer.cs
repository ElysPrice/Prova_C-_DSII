namespace ETEC.Avaliacao.Interface
{
    partial class frmReparo
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
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.txbAnoCel = new System.Windows.Forms.TextBox();
            this.txbModeloCel = new System.Windows.Forms.TextBox();
            this.txbNomeCli = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.lblAnoCel = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblModeloCel = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblTituloApres = new System.Windows.Forms.Label();
            this.lblIDCli = new System.Windows.Forms.Label();
            this.txbIDCli = new System.Windows.Forms.TextBox();
            this.lblIDCel = new System.Windows.Forms.Label();
            this.txbIDCel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(282, 284);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(173, 20);
            this.txbCPF.TabIndex = 24;
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(35, 284);
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(176, 20);
            this.txbRG.TabIndex = 23;
            // 
            // txbAnoCel
            // 
            this.txbAnoCel.Location = new System.Drawing.Point(282, 222);
            this.txbAnoCel.Name = "txbAnoCel";
            this.txbAnoCel.Size = new System.Drawing.Size(173, 20);
            this.txbAnoCel.TabIndex = 22;
            // 
            // txbModeloCel
            // 
            this.txbModeloCel.Location = new System.Drawing.Point(35, 231);
            this.txbModeloCel.Name = "txbModeloCel";
            this.txbModeloCel.Size = new System.Drawing.Size(176, 20);
            this.txbModeloCel.TabIndex = 21;
            // 
            // txbNomeCli
            // 
            this.txbNomeCli.Location = new System.Drawing.Point(35, 105);
            this.txbNomeCli.Name = "txbNomeCli";
            this.txbNomeCli.Size = new System.Drawing.Size(421, 20);
            this.txbNomeCli.TabIndex = 20;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(357, 332);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(200, 332);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(59, 332);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(75, 23);
            this.btnSolicitar.TabIndex = 27;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // lblAnoCel
            // 
            this.lblAnoCel.AutoSize = true;
            this.lblAnoCel.Location = new System.Drawing.Point(279, 206);
            this.lblAnoCel.Name = "lblAnoCel";
            this.lblAnoCel.Size = new System.Drawing.Size(75, 13);
            this.lblAnoCel.TabIndex = 17;
            this.lblAnoCel.Text = "Ano do celular";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(279, 268);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 16;
            this.lblCPF.Text = "CPF";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(32, 268);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 14;
            this.lblRG.Text = "RG";
            // 
            // lblModeloCel
            // 
            this.lblModeloCel.AutoSize = true;
            this.lblModeloCel.Location = new System.Drawing.Point(32, 215);
            this.lblModeloCel.Name = "lblModeloCel";
            this.lblModeloCel.Size = new System.Drawing.Size(91, 13);
            this.lblModeloCel.TabIndex = 12;
            this.lblModeloCel.Text = "Modelo do celular";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(32, 89);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(84, 13);
            this.lblNomeCliente.TabIndex = 13;
            this.lblNomeCliente.Text = "Nome do cliente";
            // 
            // lblTituloApres
            // 
            this.lblTituloApres.AutoSize = true;
            this.lblTituloApres.Location = new System.Drawing.Point(180, 9);
            this.lblTituloApres.Name = "lblTituloApres";
            this.lblTituloApres.Size = new System.Drawing.Size(126, 13);
            this.lblTituloApres.TabIndex = 19;
            this.lblTituloApres.Text = "Solicitar reparo de celular";
            // 
            // lblIDCli
            // 
            this.lblIDCli.AutoSize = true;
            this.lblIDCli.Location = new System.Drawing.Point(32, 37);
            this.lblIDCli.Name = "lblIDCli";
            this.lblIDCli.Size = new System.Drawing.Size(67, 13);
            this.lblIDCli.TabIndex = 13;
            this.lblIDCli.Text = "ID do cliente";
            // 
            // txbIDCli
            // 
            this.txbIDCli.Location = new System.Drawing.Point(35, 53);
            this.txbIDCli.Name = "txbIDCli";
            this.txbIDCli.Size = new System.Drawing.Size(104, 20);
            this.txbIDCli.TabIndex = 20;
            // 
            // lblIDCel
            // 
            this.lblIDCel.AutoSize = true;
            this.lblIDCel.Location = new System.Drawing.Point(32, 151);
            this.lblIDCel.Name = "lblIDCel";
            this.lblIDCel.Size = new System.Drawing.Size(67, 13);
            this.lblIDCel.TabIndex = 13;
            this.lblIDCel.Text = "ID do celular";
            // 
            // txbIDCel
            // 
            this.txbIDCel.Location = new System.Drawing.Point(35, 167);
            this.txbIDCel.Name = "txbIDCel";
            this.txbIDCel.Size = new System.Drawing.Size(104, 20);
            this.txbIDCel.TabIndex = 20;
            // 
            // frmReparo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 378);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.txbAnoCel);
            this.Controls.Add(this.txbModeloCel);
            this.Controls.Add(this.txbIDCli);
            this.Controls.Add(this.txbIDCel);
            this.Controls.Add(this.txbNomeCli);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.lblAnoCel);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblIDCli);
            this.Controls.Add(this.lblIDCel);
            this.Controls.Add(this.lblModeloCel);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblTituloApres);
            this.Name = "frmReparo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar reparo de celular - Assistência ETEC Zona Leste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.TextBox txbAnoCel;
        private System.Windows.Forms.TextBox txbModeloCel;
        private System.Windows.Forms.TextBox txbNomeCli;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Label lblAnoCel;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblModeloCel;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblTituloApres;
        private System.Windows.Forms.Label lblIDCli;
        private System.Windows.Forms.TextBox txbIDCli;
        private System.Windows.Forms.Label lblIDCel;
        private System.Windows.Forms.TextBox txbIDCel;
    }
}