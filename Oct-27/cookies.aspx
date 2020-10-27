<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCookie.aspx.cs" Inherits="ASPCookies.WebFormCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Label ID="Label1" runat="server" Text="select brand preference" />
			<br />
			<br />
			<asp:CheckBox ID="Iphone" runat="server" Text="Iphone" />
			<br />
			<asp:CheckBox ID="Samsung" runat="server" Text="Samsung" />
			<br />
			<asp:CheckBox ID="Vivo" runat="server" Text="Vivo" />
			<br />
			<asp:CheckBox ID="Asus" runat="server" Text="Asus" />
			<br />
			<asp:CheckBox ID="Redmi" runat="server" Text="Redmi" />
			<br />
			<asp:CheckBox ID="Realme" runat="server" Text="Realme" />
			<br />
			<asp:CheckBox ID="Oneplus" runat="server" Text="Oneplus" />
			<br />
			<asp:CheckBox ID="Sony" runat="server" Text="Sony" />
			<br />
			<asp:CheckBox ID="Oppo" runat="server" Text="Oppo" />
			<br />
			<asp:CheckBox ID="Lenovo" runat="server" Text="Lenovo" />
			<br />

			<asp:Button ID="Button1" runat="server" Text="CheckOn" OnClick="Button1_Click" />

			<p>
				<asp:Label ID="Label2" runat="server" />
			</p>

        </div>
    </form>
</body>
</html>
