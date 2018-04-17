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
    public partial class frmCadastroCli : Form
    {
        public frmCadastroCli()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!", "ETEC Zona Leste");
            }
            else
            {
                string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=assistenciaETEC;Data Source=LAB-08-17;password=info211";

                SqlConnection conexaoBanco = new SqlConnection(conexao);

                conexaoBanco.Open();

                string comandoSQL = "INSERT INTO tbCliente VALUES ('" + txbNome.Text + "', '" +
                txbTelefone.Text + "', '" +
                txbDataNasc.Text + "', '" +
                txbRG.Text + "', '" +
                txbCPF.Text + "', '" +
                txbEndereco.Text + "', '" +
                txbEmail.Text + "')";

                SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
                execucaoSQL.ExecuteNonQuery();
                conexaoBanco.Close();

                MessageBox.Show("Cadastro realizado", "ETEC Zona Leste");
                limpar();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaCli pesquisaCliente = new frmPesquisaCli();
            pesquisaCliente.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            txbNome.Text = string.Empty;
            txbTelefone.Text = string.Empty;
            txbDataNasc.Text = string.Empty;
            txbRG.Text = string.Empty;
            txbCPF.Text = string.Empty;
            txbEndereco.Text = string.Empty;
            txbEmail.Text = string.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
