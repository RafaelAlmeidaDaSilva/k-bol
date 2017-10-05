using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACE.Cadastro
{
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()//CONSTRUTOR #1
        {
            InitializeComponent();
        }

        public frmCadastrar retornaInstancia()
        { return this; }

        double descontoAnterior = 0;

        //-------------------------------------------------------[EVENTOS]-------------------------------------------------\\


        //---------------------------------------------[Tratamentos de digitação dos Campos]------------------------------------------------->
        private void mbCPF_KeyPress(object sender, KeyPressEventArgs e)                          // [MASC BOX]   "CPF"
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void txtDescontoMensal_KeyPress(object sender, KeyPressEventArgs e)              // [TEXT BOX]   "DESCONTO MENSAL"
        {

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)',';
            if (e.KeyChar == (char)13)
            {
                c_Metodos_Cadatro Metodos = new c_Metodos_Cadatro();
                double mensalidade = Convert.ToDouble(lbValorMensalidade.Text),
                       total = Convert.ToDouble(lbValorTotal.Text),
                       desconto = Convert.ToDouble(txtDescontoMensal.Text);

                Metodos.DescontoMensal(this, desconto, total, mensalidade);
            }
        }
        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)                    // [TEXT BOX]   "DESCONTO"
        {

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)',';
            if (e.KeyChar == (char)13)
            {
                try
                {
                    double total = Convert.ToDouble(lbValorTotal.Text),
                        desconto = Convert.ToDouble(txtDesconto.Text);
                        

                    c_Metodos_Cadatro Metodos = new c_Metodos_Cadatro();
                    
                    if (descontoAnterior != desconto)
                    {
                        descontoAnterior = desconto;
                        Metodos.Desconto(this, desconto, total);
                        
                    }
                  
                    if(txtDesconto.Text == "0,00")
                    {
                        double teste = Double.Parse(lbValorTotal.Text) + descontoAnterior;
                        lbValorTotal.Text = Convert.ToString(teste);

                    }
                    
                    txtDesconto.Clear();

                }catch(FormatException)
                {
                    MessageBox.Show("Valor do campo DESCONTO inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void txtNomeAluno_KeyPress(object sender, KeyPressEventArgs e)                   // [TEXT BOX]   "NOME ALUNO"
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void txtIdAluno_KeyPress(object sender, KeyPressEventArgs e)                     // [TEXT BOX]   "ID ALUNO"
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void txtNomeResponsavel_KeyPress(object sender, KeyPressEventArgs e)             // [TEXT BOX]   "NOME RESPONSAVEL"
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        private void mbTelefone_KeyPress(object sender, KeyPressEventArgs e)                     // [MASC BOX]   "TELEFONE"
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }


        //----------------------------------------------[Checks de ativação do responsável]-------------------------------------------------->
        private void rbResponsavelSim_CheckedChanged(object sender, EventArgs e)                 // [RADIO BUTTON] "SIM"
        {
            txtNomeResponsavel.Enabled = true;
        }
        private void rbResponsavelNao_CheckedChanged(object sender, EventArgs e)                 // [RADIO BUTTON] "NAO"
        {
            this.txtNomeResponsavel.Enabled = false;
        }


        //------------------------------------------------[Checks de Marcação de Matéria]---------------------------------------------------->
        private void cbMatematica_CheckedChanged(object sender, EventArgs e)                     // [CHECK BOX]  "MATEMATICA"
        {
            c_Metodos_Cadatro MetodosCadastro = new c_Metodos_Cadatro();

            double mensalidade = Convert.ToDouble(lbValorMensalidade.Text),
                            total = Convert.ToDouble(lbValorTotal.Text);
            if (cbMatematica.Checked)
            {


                MetodosCadastro.AumentarValorPorMateria(this, total, mensalidade);

            }
            else
            {

                MetodosCadastro.DiminuirValorPorMateria(this, total, mensalidade);

            }
        }
        private void cbPortugues_CheckedChanged(object sender, EventArgs e)                      // [CHECK BOX]  "MATEMATICA
        {
            c_Metodos_Cadatro MetodosCadastro = new c_Metodos_Cadatro();

            double mensalidade = Convert.ToDouble(lbValorMensalidade.Text),
                         total = Convert.ToDouble(lbValorTotal.Text);

            if (cbPortugues.Checked)
            {


                MetodosCadastro.AumentarValorPorMateria(this, total, mensalidade);

            }
            else
            {

                MetodosCadastro.DiminuirValorPorMateria(this, total, mensalidade);

            }
        }
        private void cbIngles_CheckedChanged(object sender, EventArgs e)                         // [CHECK BOX]  "INGLES"
        {
            c_Metodos_Cadatro MetodosCadastro = new c_Metodos_Cadatro();

            double mensalidade = Convert.ToDouble(lbValorMensalidade.Text),
                         total = Convert.ToDouble(lbValorTotal.Text);

            if (cbIngles.Checked)
            {


                MetodosCadastro.AumentarValorPorMateria(this, total, mensalidade);

            }
            else
            {

                MetodosCadastro.DiminuirValorPorMateria(this, total, mensalidade);

            }
        }
        private void cbJapones_CheckedChanged(object sender, EventArgs e)                        // [CHECK BOX]  "MATEMÁTICA"
        {
            c_Metodos_Cadatro MetodosCadastro = new c_Metodos_Cadatro();

            double mensalidade = Convert.ToDouble(lbValorMensalidade.Text),
                         total = Convert.ToDouble(lbValorTotal.Text);
            if (cbJapones.Checked)
            {


                MetodosCadastro.AumentarValorPorMateria(this, total, mensalidade);

            }
            else
            {

                MetodosCadastro.DiminuirValorPorMateria(this, total, mensalidade);

            }
        }





    }
}
