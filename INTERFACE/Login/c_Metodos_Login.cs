using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE.Login
{
    public class c_Metodos_Login
    {
        public void visibilidade(int porcento, bool VerdOufals, frmLogin frm)   
        {
            frm.Opacity = porcento;          // GRAU DE VISIBILIDADE 
            frm.ShowInTaskbar = VerdOufals; // ATIVAR OU DESATIVAR JANELA DA BARRA DE TAREFAZ.
            
        }


        public bool VerificarCamposTelaLogin(string login, string senha)   
        {
            if ((login == "") || (senha == ""))
            { return false; }
            else
            { return true; }
        }



    }
}
