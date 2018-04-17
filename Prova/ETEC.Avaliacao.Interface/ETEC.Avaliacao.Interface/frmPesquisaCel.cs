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
    public partial class frmPesquisaCel : Form
    {
        public frmPesquisaCel()
        {
            InitializeComponent();
        }

        private void frmPesquisaCel_Load(object sender, EventArgs e)
        {
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=assistenciaETEC;Data Source=LAB-08-17;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQL = "SELECT * FROM tbCel";

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL, conexaoBanco);

            DataSet datasetCel = new DataSet();
            adaptador.Fill(datasetCel);

            dtCelular.DataSource = datasetCel;
            dtCelular.DataMember = datasetCel.Tables[0].TableName;
        }
    }
}
