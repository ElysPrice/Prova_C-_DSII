namespace ETEC.Avaliacao.Interface
{
    partial class frmCadastroCel
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txbMontadora = new System.Windows.Forms.TextBox();
            this.txbAno = new System.Windows.Forms.TextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbNomeCelular = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblMontadora = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTituloApres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(262, 248);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txbMontadora
            // 
            this.txbMontadora.Location = new System.Drawing.Point(31, 198);
            this.txbMontadora.Name = "txbMontadora";
            this.txbMontadora.Size = new System.Drawing.Size(420, 20);
            this.txbMontadora.TabIndex = 25;
            // 
            // txbAno
            // 
            this.txbAno.Location = new System.Drawing.Point(278, 128);
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(173, 20);
            this.txbAno.TabIndex = 22;
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(31, 137);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(176, 20);
            this.txbModelo.TabIndex = 21;
            // 
            // txbNomeCelular
            // 
            this.txbNomeCelular.Location = new System.Drawing.Point(31, 78);
            this.txbNomeCelular.Name = "txbNomeCelular";
            this.txbNomeCelular.Size = new System.Drawing.Size(421, 20);
            this.txbNomeCelular.TabIndex = 20;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(388, 248);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(144, 248);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(23, 248);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblMontadora
            // 
            this.lblMontadora.AutoSize = true;
            this.lblMontadora.Location = new System.Drawing.Point(28, 182);
            this.lblMontadora.Name = "lblMontadora";
            this.lblMontadora.Size = new System.Drawing.Size(58, 13);
            this.lblMontadora.TabIndex = 18;
            this.lblMontadora.Text = "Montadora";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(275, 112);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 17;
            this.lblAno.Text = "Ano";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(28, 121);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 12;
            this.lblModelo.Text = "Modelo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome do celular";
            // 
            // lblTituloApres
            // 
            this.lblTituloApres.AutoSize = true;
            this.lblTituloApres.Location = new System.Drawing.Point(190, 28);
            this.lblTituloApres.Name = "lblTituloApres";
            this.lblTituloApres.Size = new System.Drawing.Size(98, 13);
            this.lblTituloApres.TabIndex = 19;
            this.lblTituloApres.Text = "Cadastro de celular";
            // 
            // frmCadastroCel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txbMontadora);
            this.Controls.Add(this.txbAno);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.txbNomeCelular);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblMontadora);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTituloApres);
            this.Name = "frmCadastroCel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de celular - Assistência ETEC Zona Leste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbMontadora;
        private System.Windows.Forms.TextBox txbAno;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.TextBox txbNomeCelular;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblMontadora;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTituloApres;
    }
}