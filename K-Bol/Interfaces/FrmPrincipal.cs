using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace K_Bol
{
    public partial class FrmPrincipal : Form
    {
   

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

       


        // METODO DE CHAMAR FORMULARIOS DENTRO DO PANEL
        public void PainelFormulario(Form frmExibir)
        {
            pnPrincipal.Visible = true;
            frmExibir.TopLevel = false;
            pnPrincipal.Controls.Add(frmExibir);
            frmExibir.Show();
        }

       
        private void btnCadastro_Click(object sender, EventArgs e)
        {
              FrmCadastro frm = new FrmCadastro(pnPrincipal.Size.Width, pnPrincipal.Size.Height);
              PainelFormulario(frm);
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            FrmConsulta frm = new FrmConsulta(pnPrincipal.Size.Width, pnPrincipal.Size.Height);
            PainelFormulario(frm);
        }
  
    }
}
