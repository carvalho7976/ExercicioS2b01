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
            if (textNome.Text.Equals("rogerio") && textSenha.Text.Equals("1234")) {
                labelResult.ForeColor = Color.Green;
                labelResult.Text = "Logado com sucesso!!!";
            }
            else if (textNome.Text == String.Empty || textSenha.Text == String.Empty) {
                labelResult.ForeColor = Color.Blue;
                labelResult.Text = "Campos devem ser preenchidos!!!!";
            }
            else {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Usuario ou Senha invalidos!!!";
            }

        }
    }
}