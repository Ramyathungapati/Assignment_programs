<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryState.aspx.cs" Inherits="QueryStrings.QueryState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<table  border="1">
			<tr>
				<td class="auto-style12">UserName</td>
				<td class="auto-style13">
					<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style15">Password</td>
				<td class="auto-style16">
					<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style12">
					<asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />&nbsp;
					<asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" />
				</td>
				<td >&nbsp;</td>
			</tr>
				<td colspan="2">
				<asp:Label ID="lblstatus" runat="server" ForeColor="Purple"></asp:Label>
			</td>

		</table>
    </form>
</body>
</html>
