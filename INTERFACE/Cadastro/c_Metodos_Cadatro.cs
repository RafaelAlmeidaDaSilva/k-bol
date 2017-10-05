using System;

namespace INTERFACE.Cadastro
{
    class c_Metodos_Cadatro
    {
     
                        
        private double _mensalidade { get; set; }
        private double _desconto { get; set; }
        private double _total { get; set; }

        
        public const double _matricula = 70.00, _ValorPorMatricula = 160.00;

        //---------------------------------------------------[METODOS]-------------------------------------------------------\\

        //----------------------------------[Metodos principais utilizados pelo formulário]----------------------------------->
        public void Cadastrar(String NomeAluno,String IdKumon,String CPF,String Telefone, String NomeResponsavel)
        {

        }
        public void HabilitarCampos()
        {  
        }

        //-----------------------------------[Metodos Alteração de valores do formulario]------------------------------------->
        public void AumentarValorPorMateria(frmCadastrar frm, Double total, Double mensalidade) 
        {
            mensalidade += _ValorPorMatricula;
            total = _matricula + mensalidade;

            AtualizarValoresPagamento(frm, total, mensalidade);
            
        }
        public void DiminuirValorPorMateria(frmCadastrar frm, Double total, Double mensalidade) 
        {
            mensalidade = mensalidade - _ValorPorMatricula;
            total = _matricula + mensalidade;


            AtualizarValoresPagamento(frm, total, mensalidade);
        }
        private void AtualizarValoresPagamento(frmCadastrar frm, Double total, Double mensalidade)
        {
            frm.lbValorMatricula.Text = _matricula.ToString() + ",00";
            frm.lbValorMensalidade.Text = mensalidade.ToString() + ",00";
            frm.lbValorTotal.Text = total.ToString() + ",00";
        }
        public void Desconto(frmCadastrar frm,Double desconto, Double total)
        {   
         
            total = total - desconto;

            frm.lbValorMatricula.Text = _matricula.ToString() + ",00";
            frm.lbValorTotal.Text = total.ToString() + ",00";
           
        }
        public void DescontoMensal(frmCadastrar frm, Double desconto, Double total, Dou













    }
}
