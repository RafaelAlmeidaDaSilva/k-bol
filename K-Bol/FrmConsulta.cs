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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }
       public FrmConsulta(int width, int height) {
            //Inicializa com as configuraçoes do formulario atuais.
            InitializeComponent();           
            // faz com que o formualario fique do tamanho do Panel da tela principal
            this.Width = width;
            this.Height = height;
        }

       private void FrmConsulta_Load(object sender, EventArgs e)
       {
           pConsulta.Location = new Point((this.Size.Width / 2) - (this.pConsulta.Size.Width / 2), (this.Size.Height / 2) - (this.pConsulta.Size.Height / 2));
       }
    }
}
