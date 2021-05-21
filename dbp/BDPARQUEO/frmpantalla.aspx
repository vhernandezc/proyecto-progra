<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmpantalla.aspx.cs" Inherits="BDPARQUEO.frmpantalla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btncerrar" runat="server" Text="cerrar" Width="238px" />
        </p>
        <p>
&nbsp; &nbsp;matricula&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; propietario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; fecha_Ingreso&nbsp;&nbsp;&nbsp;&nbsp; DPI&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telefono&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Color&nbsp;&nbsp;</p>
        <p>
&nbsp;<asp:TextBox ID="txtmatricula" runat="server" Width="71px"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="txtpropietario" runat="server" OnTextChanged="txtpropietario_TextChanged" Width="74px"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="txtfecha_ingreso" runat="server" MaxLength="10" OnTextChanged="txtfecha_ingreso_TextChanged" Width="70px"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="txtDPI" runat="server" TextMode="Number" Width="69px"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number" Width="71px"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="txtcolor" runat="server" Width="69px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnguargar" runat="server" OnClick="btnguargar_Click" Text="Guardar" Width="238px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <asp:GridView ID="GridViewDatos" runat="server" OnRowCommand="gv_Rowcommand">
        </asp:GridView>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    </form>
    </body>
</html>
