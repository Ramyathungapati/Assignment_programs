<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="radiobuttonAss.aspx.cs" Inherits="radiobuttonAss.radiobuttonAss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:RadioButton ID="Red" runat="server" ForeColor="Red"  OnCheckedChanged="Red_CheckedChanged" TabIndex="5" Text="Red" />
            <asp:RadioButton ID="Blue" runat="server" ForeColor="Blue"  OnCheckedChanged="Blue_CheckedChanged" TabIndex="5" Text="Blue" />
            <asp:RadioButton ID="Green" runat="server"  ForeColor="Green"  OnCheckedChanged="Green_CheckedChanged" TabIndex="5" Text="Green" />
        </div>
        <div>
        <asp:Button ID="button" runat="server" Text="ok" OnClick="btn1_Click" />
        </div>
    </form>
    <asp:Label ID="label1" runat="server"></asp:Label>
</body>
</html>
