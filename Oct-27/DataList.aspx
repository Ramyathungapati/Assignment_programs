<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datalistass.aspx.cs" Inherits="datalistass.datalistass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:DataList ID="datalist1" runat="server" >
			<ItemTemplate>
				<asp:Table ID="table1" runat="server" CellPadding="5" border="50"> 
                        <asp:TableRow>
                            <asp:TableCell> <strong>FirstName</strong> <span><%#Eval("Fname") %></span> </asp:TableCell>
                                 <asp:TableCell> <strong>LastName</strong>  <%# Eval("Lname") %> </asp:TableCell>
                                 <asp:TableCell> <strong>Designation</strong> <%# Eval("Designation") %></asp:TableCell>
                                 <asp:TableCell> <strong>Location</strong>  <%# Eval("Location") %> </asp:TableCell>
                                 <asp:TableCell> <strong>Country</strong> <%# Eval("Country") %></asp:TableCell>

                        </asp:TableRow>
                    </asp:Table>
				
			</ItemTemplate>
				</asp:DataList>
        </div>
    </form>
</body>
</html>