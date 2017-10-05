using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INTERFACE.Consulta;
using INTERFACE.Cadastro;

namespace INTERFACE.Principal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmConsultar frm = new frmConsultar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmConsultar frm = new frmConsultar();
            if (Application.OpenForms[frm.Name] == null)
            {
                frmConsultar frmConsultar = frm.retornaInstancia();
                frm.MdiParent = this;
                frmConsultar.Show();
            }
            else
            {
                frmConsultar frmConsulta = frm.retornaInstancia();
                frmConsulta.Select();
            }

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            if (Application.OpenForms[frm.Name] == null)
            {
                frmCadastrar frmCadastrar = frm.retornaInstancia();
                frm.MdiParent = this;
                frmCadastrar.Show();
            }
            else
            {
                frmCadastrar frmCadastrar = frm.retornaInstancia();
                frmCadastrar.Select();
            }

        }


    }
}
