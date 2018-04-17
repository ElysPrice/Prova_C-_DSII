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
    public partial class frmPesquisaCli : Form
    {
        public frmPesquisaCli()
        {
            InitializeComponent();
        }

        private void frmPesquisaCli_Load(object sender, EventArgs e)
        {
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=assistenciaETEC;Data Source=LAB-08-17;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQL = "SELECT * FROM tbCliente";

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL, conexaoBanco);

            DataSet datasetCliente = new DataSet();
            adaptador.Fill(datasetCliente);

            dtCliente.DataSource = datasetCliente;
            dtCliente.DataMember = datasetCliente.Tables[0].TableName;
        }
    }
}
