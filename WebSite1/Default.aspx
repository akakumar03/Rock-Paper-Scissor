<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 130px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Play" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:RadioButton ID="Rock" runat="server" GroupName="rb" OnCheckedChanged="Rock_CheckedChanged" />
            <br />
            <asp:RadioButton ID="Paper" runat="server" GroupName="rb" />
            <br />
            <asp:RadioButton ID="Scissor" runat="server" GroupName="rb" OnCheckedChanged="RadioButton3_CheckedChanged" />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
