using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ETEC.Avaliacao.Interface
{
    public partial class frmClienteCelular : Form
    {
        public frmClienteCelular()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txbIDCli.Text = string.Empty;
            txbIDCel.Text = string.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaCelCli pesquisaCelCli = new frmPesquisaCelCli();
            pesquisaCelCli.Show();
        }

        private void btnAssociar_Click(object sender, EventArgs e)
        {
            if (txbIDCli.Text == string.Empty && txbIDCel.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!", "ETEC Zona Leste");
            }
            else
            {
                string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=assistenciaETEC;Data Source=LAB-08-17;password=info211";

                SqlConnection conexaoBanco = new SqlConnection(conexao);

                conexaoBanco.Open();

                string comandoSQL = "INSERT INTO tbCelCli VALUES ('" + txbIDCli.Text + "', '" +
                txbIDCel.Text + "')";

                SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
                execucaoSQL.ExecuteNonQuery();
                conexaoBanco.Close();

                MessageBox.Show("Cadastro realizado", "ETEC Zona Leste");
                limpar();
            }
        }
    }
}
