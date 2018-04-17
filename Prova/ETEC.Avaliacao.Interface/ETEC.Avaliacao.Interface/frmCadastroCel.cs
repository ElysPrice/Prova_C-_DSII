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
    public partial class frmCadastroCel : Form
    {
        public frmCadastroCel()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            txbNomeCelular.Text = string.Empty;
            txbModelo.Text = string.Empty;
            txbAno.Text = string.Empty;
            txbMontadora.Text = string.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaCel pesquisaCel = new frmPesquisaCel();
            pesquisaCel.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeCelular.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!", "ETEC Zona Leste");
            }
            else
            {
                string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=assistenciaETEC;Data Source=LAB-08-17;password=info211";

                SqlConnection conexaoBanco = new SqlConnection(conexao);

                conexaoBanco.Open();

                string comandoSQL = "INSERT INTO tbCel VALUES ('" + txbNomeCelular.Text + "', '" +
                txbModelo.Text + "', '" +
                txbAno.Text + "', '" +
                txbMontadora.Text + "')";

                SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
                execucaoSQL.ExecuteNonQuery();
                conexaoBanco.Close();

                MessageBox.Show("Cadastro realizado", "ETEC Zona Leste");
                limpar();
            }
        }
    }
}
