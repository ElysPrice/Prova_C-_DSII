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
    public partial class frmPesquisaCelCli : Form
    {
        public frmPesquisaCelCli()
        {
            InitializeComponent();
        }

        private void frmPesquisaCelCli_Load(object sender, EventArgs e)
        {
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=assistenciaETEC;Data Source=LAB-08-17;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQL = "SELECT * FROM tbCelCli";

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL, conexaoBanco);

            DataSet datasetCelCli = new DataSet();
            adaptador.Fill(datasetCelCli);

            dtCelCli.DataSource = datasetCelCli;
            dtCelCli.DataMember = datasetCelCli.Tables[0].TableName;
        }
    }
}
