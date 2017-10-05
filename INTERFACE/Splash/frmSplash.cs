using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INTERFACE.Login;

namespace INTERFACE
{   
    public partial class frmSplash : Form
    {
       
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timerAbrirFormulario_Tick(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            timerAbrirFormulario.Enabled = false;
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void pbLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
