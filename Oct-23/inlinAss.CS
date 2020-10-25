<%@ Page Language="VB" %>

<!DOCTYPE html>

<script runat="server">

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Response.Write("This is my assignment")

    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="click me" BorderStyle ="Dashed" Font-Bold="true" ForeColor="green" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
