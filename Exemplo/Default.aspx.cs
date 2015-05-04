using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Exemplo {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void btn_enviar(Object sender, EventArgs e) {
            if (textNome.Text.Equals("rogerio") && textSenha.Text.Equals("1234")) {
                labelResult.ForeColor = Color.Green;
                labelResult.Text = "Logado com sucesso!!!";
            }
            else {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Usuario ou Senha Invalidos!!!!!!";
            }

        }


    }
}