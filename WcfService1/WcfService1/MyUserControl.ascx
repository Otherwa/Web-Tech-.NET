<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyUserControl.ascx.cs" Inherits="WcfService1.MyUserControl" %>
<form runat="server">
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="143px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="City"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Height="37px" Width="144px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" Height="51px" Width="90px" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
</form>
