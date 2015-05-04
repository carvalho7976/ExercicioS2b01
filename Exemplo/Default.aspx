<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Exemplo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="labelNome" Text="Nome" runat="server" />
        <asp:TextBox ID="textNome" runat="server" /> 
        <br />
        <asp:Label ID="labelSenha" Text="Senha" runat="server" />
        <asp:TextBox ID="textSenha" TextMode="Password" runat="server" /> 
        <br />
                <asp:Button Text="Enviar" ID="bntEnviar" OnClick="btn_enviar"  runat="server" />
        <asp:Button Text="botao2" runat="server" />

        <br />
        <asp:Label Text="" ID="labelResult" runat="server" />
    </div>
    </form>
</body>
</html>
