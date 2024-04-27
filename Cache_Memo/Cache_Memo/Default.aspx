<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cache_Memo.Default" %>
<%@ OutputCache Duration="60" VaryByParam="None"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Current Time</h1>
            <asp:Label ID="lbltime" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
