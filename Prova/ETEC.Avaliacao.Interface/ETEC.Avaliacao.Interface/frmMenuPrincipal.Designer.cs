namespace ETEC.Avaliacao.Interface
{
    partial class frmMenuPrincipal
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
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.lblOpcoes = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnCelular = new System.Windows.Forms.Button();
            this.btnReparo = new System.Windows.Forms.Button();
            this.btnAssociarCliCel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.Location = new System.Drawing.Point(176, 18);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(92, 13);
            this.lblApresentacao.TabIndex = 0;
            this.lblApresentacao.Text = "Seja bem-vindo(a)";
            // 
            // lblOpcoes
            // 
            this.lblOpcoes.AutoSize = true;
            this.lblOpcoes.Location = new System.Drawing.Point(141, 64);
            this.lblOpcoes.Name = "lblOpcoes";
            this.lblOpcoes.Size = new System.Drawing.Size(169, 13);
            this.lblOpcoes.TabIndex = 1;
            this.lblOpcoes.Text = "Selecione uma das opções abaixo";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(96, 97);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(250, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnCelular
            // 
            this.btnCelular.Location = new System.Drawing.Point(97, 141);
            this.btnCelular.Name = "btnCelular";
            this.btnCelular.Size = new System.Drawing.Size(250, 23);
            this.btnCelular.TabIndex = 3;
            this.btnCelular.Text = "Celular";
            this.btnCelular.UseVisualStyleBackColor = true;
            this.btnCelular.Click += new System.EventHandler(this.btnCelular_Click);
            // 
            // btnReparo
            // 
            this.btnReparo.Location = new System.Drawing.Point(96, 219);
            this.btnReparo.Name = "btnReparo";
            this.btnReparo.Size = new System.Drawing.Size(250, 23);
            this.btnReparo.TabIndex = 4;
            this.btnReparo.Text = "Solicitação de reparo";
            this.btnReparo.UseVisualStyleBackColor = true;
            this.btnReparo.Click += new System.EventHandler(this.btnReparo_Click);
            // 
            // btnAssociarCliCel
            // 
            this.btnAssociarCliCel.Location = new System.Drawing.Point(97, 181);
            this.btnAssociarCliCel.Name = "btnAssociarCliCel";
            this.btnAssociarCliCel.Size = new System.Drawing.Size(249, 23);
            this.btnAssociarCliCel.TabIndex = 5;
            this.btnAssociarCliCel.Text = "Associar cliente ao celular";
            this.btnAssociarCliCel.UseVisualStyleBackColor = true;
            this.btnAssociarCliCel.Click += new System.EventHandler(this.btnAssociarCliCel_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 270);
            this.Controls.Add(this.btnAssociarCliCel);
            this.Controls.Add(this.btnReparo);
            this.Controls.Add(this.btnCelular);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.lblOpcoes);
            this.Controls.Add(this.lblApresentacao);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal - Assistência ETEC Zona Leste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApresentacao;
        private System.Windows.Forms.Label lblOpcoes;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnCelular;
        private System.Windows.Forms.Button btnReparo;
        private System.Windows.Forms.Button btnAssociarCliCel;
    }
}