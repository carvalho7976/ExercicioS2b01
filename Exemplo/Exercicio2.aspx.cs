using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


namespace Exemplo {
    public partial class Exercicio2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void btn_enviar(Object sender, EventArgs e) {

            string nome = textNome.Text;
            switch (nome) {
                case "Eduardo":
                    if (textSenha.Text.Equals("1234")) {
                        Response.Redirect("Gerentes.aspx");
                    }
                    else {
                        labelResult.Text = "Usuario ou Senha invalidos!";
                    }
                    break;
                case "Maria":
                    if (textSenha.Text.Equals("1234")) {
                        Response.Redirect("Funcionarios.aspx");
                    }
                    else {
                        labelResult.Text = "Usuario ou Senha invalidos!!!";
                    }
                    break;
                case "Jose":
                    if (textSenha.Text.Equals("1234")) {
                        Response.Redirect("Funcionarios.aspx");
                    }
                    else {
                        labelResult.Text = "Usuario ou Senha invalidos!!!";
                    }
                    break;

                default:
                    labelResult.Text = "Usuario nao encontrado, procure o administrador do sistema";
                    break;
            }


        }
    }
}