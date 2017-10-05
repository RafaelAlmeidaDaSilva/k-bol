using BANCO;
using COLECAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace NEGOCIO
{
    public class UsuarioNegocio
    {
            
            AcessoDadosSqlServer acessoDadosSQLServer = new AcessoDadosSqlServer();


            public string InserirUsuario(Usuario usuario) //METODO: que acessa a Stored Procedure "uspUsuarioInserir"
            {
                try
                {
                    //Limpa parametros
                    acessoDadosSQLServer.LimparParametros();
                    //Adiciona parâmetros que irão ao BD
                    acessoDadosSQLServer.AdicionarParametros("@codUsuario", usuario.CodUsuario);
                    acessoDadosSQLServer.AdicionarParametros("@loginUsuario", usuario.NomeUsuario);
                    acessoDadosSQLServer.AdicionarParametros("@senhaUsuario", usuario.Senha);

                    //acessa informações dda classe que acessa o BD
                    string codAluno = acessoDadosSQLServer.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "uspUsuarioInserir").ToString();
                    return codAluno;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }


            public string AlterarUsuario(Usuario usuario) //METODO: que acessa a Stored Procedure "uspUsuarioAlterar"
            {
                try
                {
                    //Limpa parametros
                    acessoDadosSQLServer.LimparParametros();
                    //Adiciona parâmetros que irão ao BD
                    acessoDadosSQLServer.AdicionarParametros("@codUsuario", usuario.CodUsuario);
                    acessoDadosSQLServer.AdicionarParametros("@loginUsuario", usuario.NomeUsuario);
                    acessoDadosSQLServer.AdicionarParametros("@senhaUsuario", usuario.Senha);

                    //acessa informações dda classe que acessa o BD
                    string codUsuario = acessoDadosSQLServer.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "uspUsuarioAlterar").ToString();
                    return codUsuario;
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
            }


            public string ConsultarUsuarioLoginSenha(string nome, string senha) //METODO: que acessa a Stored Procedure "uspUsuarioConsultarLoginSenha"
            {
                try
                {
                    acessoDadosSQLServer.LimparParametros();
                    acessoDadosSQLServer.AdicionarParametros("@login", nome);
                    acessoDadosSQLServer.AdicionarParametros("@senha", senha);

                    string CodUsuario = acessoDadosSQLServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioConsultarLoginSenha").ToString();
                    return CodUsuario;
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
            }


        
    }
}
