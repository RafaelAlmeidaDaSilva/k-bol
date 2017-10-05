using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INTERFACE.Cadastro;

namespace INTERFACE.Consulta
{
    public partial class frmConsultar : Form
    {
        public frmConsultar() // METODO CONSTRUTOR. 
        {
            InitializeComponent();  
        }
        public frmConsultar retornaInstancia()
        { return this; }
     
        private void btnCadastrarAluno_Click(object sender, EventArgs e)             //EVENTO "AO CLICAR" do Botão Cadastrar. 
        {
            
            frmCadastrar frm = new frmCadastrar();
            frm.ShowDialog();
        }

        private void btnInformacaoAluno_Click(object sender, EventArgs e)            //EVENTO "AO CLICAR" do Botão Informações do Aluno. 
        {
            MessageBox.Show("TELA DE INFORMAÇÃO DO ALUNO");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)                  //EVENTO "AO CLICAR" do Botão Pesquisar. 
        {
            MessageBox.Show("METODO CONSULTA DE ALUNO");
        }

        private void btnEfetuarPagamento_Click(object sender, EventArgs e)           //EVENTO "AO CLICAR"  Botão Efentuar Pagamento. 
        {
            MessageBox.Show("TELA DE EFETUAR PAGAMENTO");
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)            //EVENTO "AO ATUALIZAR O TEXTO" do campo Pesquisar. 
        {
            //CONSULTA DE ALUNO AO DIGITAR 
        }

       

    }
}
