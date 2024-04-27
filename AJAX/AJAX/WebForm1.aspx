<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AJAX.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="height:100vh">
        <div>
            <h1><asp:Label ID="Label1" runat="server" Text="Atharv Desai"/></h1>
           
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            
            <asp:Timer ID="Timer1" runat="server" Interval="6000" OnTick="Tick"></asp:Timer>
            <asp:Timer ID="Timer2" runat="server" Interval="1000" OnTick="Timer2_Tick"></asp:Timer>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <asp:Label ID="Label2" runat="server" Text="Quotes"/></h1>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text=""/></h1>
           
                </ContentTemplate>
                <Triggers>
                      <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick" />
                      <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
