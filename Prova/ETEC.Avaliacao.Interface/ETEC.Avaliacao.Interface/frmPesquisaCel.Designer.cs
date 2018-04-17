namespace ETEC.Avaliacao.Interface
{
    partial class frmPesquisaCel
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
            this.dtCelular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtCelular)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCelular
            // 
            this.dtCelular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCelular.Location = new System.Drawing.Point(12, 12);
            this.dtCelular.Name = "dtCelular";
            this.dtCelular.Size = new System.Drawing.Size(460, 338);
            this.dtCelular.TabIndex = 0;
            // 
            // frmPesquisaCel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.dtCelular);
            this.Name = "frmPesquisaCel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de cadastros (Celular) - Assistência ETEC Zona Leste";
            this.Load += new System.EventHandler(this.frmPesquisaCel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCelular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtCelular;
    }
}