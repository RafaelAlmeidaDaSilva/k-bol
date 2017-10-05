using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;
using COLECAO;
using INTERFACE.Principal;





namespace INTERFACE.Login
{
    public partial class frmLogin : Form
    { 
        
        public frmLogin() //METODO CONSTRUTOR #1. 
        {
            InitializeComponent();
        }
      
    //----------------------------------------------------------[EVENTOS]----------------------------------------------------\\
        private void btnEntrar_Click(object sender, EventArgs e)                 //[BUTTON] "BOTÃO ENTRAR"
        {
            c_Metodos_Login Metodos = new c_Metodos_Login();
            if (Metodos.VerificarCamposTelaLogin(txtLogin.Text, txtSenha.Text))
            {
                try
                {
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                    string CodUsuario = usuarioNegocio.ConsultarUsuarioLoginSenha(txtLogin.Text, txtSenha.Text);

                    if (CodUsuario != "")
                    {
                        frmPrincipal frm = new frmPrincipal();

                        c_Metodos_Login metodosLogin = new c_Metodos_Login();
                        metodosLogin.visibilidade(0, false, this);
                        frm.ShowDialog();
                        
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Usuario ou Senha invalidos.");
                   
                }      
            }
            else
            {
                MessageBox.Show("Preecha todos os campos!!");
            }
        }
        private void frmLogin_KeyUp(object sender, KeyEventArgs key)             //[FORM]   "FORMULÁRIO DE LOGIN"
        {

            if ((key.KeyCode == Keys.Enter) || (key.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e) //[FORM]   "FORMULÁRIO DE LOGIN"
        {
            Application.Exit();
        }


    }
}
