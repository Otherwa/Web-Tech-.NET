<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator_Consume.aspx.cs" Inherits="SOAP_SERVER.Calculator_Consume" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
            <br/>
            <br/>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br/>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Sub" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Mul" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Div" OnClick="Button4_Click" />

        </div>
    </form>
</body>
</html>
