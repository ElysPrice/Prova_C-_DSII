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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCli cadastroCliente = new frmCadastroCli();
            cadastroCliente.Show();
        }

        private void btnCelular_Click(object sender, EventArgs e)
        {
            frmCadastroCel cadastroCelular = new frmCadastroCel();
            cadastroCelular.Show();
        }

        private void btnReparo_Click(object sender, EventArgs e)
        {
            frmReparo solicitarRep = new frmReparo();
            solicitarRep.Show();
        }

        private void btnAssociarCliCel_Click(object sender, EventArgs e)
        {
            frmClienteCelular assocCliCel = new frmClienteCelular();
            assocCliCel.Show();
        }

    }
}
