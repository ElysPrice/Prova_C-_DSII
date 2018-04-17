using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ETEC.Avaliacao.Interface
{
    public partial class frmReparo : Form
    {
        public frmReparo()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            if (txbIDCli.Text == string.Empty && txbIDCel.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!", "ETEC Zona Leste");
            }
            else
            {
                MessageBox.Show("Soliticitação de reparo finalizada, aguarde contato.", "ETEC Zona Leste");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void limpar()
        {
            txbIDCli.Text = string.Empty;
            txbNomeCli.Text = string.Empty;
            txbIDCel.Text = string.Empty;
            txbModeloCel.Text = string.Empty;
            txbAnoCel.Text = string.Empty;
            txbRG.Text = string.Empty;
            txbCPF.Text = string.Empty;
        }
    }
}
