<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAdmissionForm.aspx.cs" Inherits="ASPRegistrationOfStudent.StudentAdmissionForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student RegistrationForm</title>
	<style type="text/css">
		.auto-style1 {
			width: 208px;
		}
		.auto-style2 {
			width: 320px;
		}
		.auto-style3 {
			width: 208px;
			height: 26px;
		}
		.auto-style4 {
			width: 320px;
			height: 26px;
		}
		.auto-style5 {
			width: 320px;
			height: 26px;
			margin-left: 40px;
		}
		.auto-style6 {
			width: 500px;
		}
		.auto-style7 {
			width: 208px;
			height: 29px;
		}
		.auto-style8 {
			width: 320px;
			height: 29px;
		}
		.auto-style9 {
			height: 29px;
		}
		.auto-style10 {
			margin-left: 442px;
		}
		</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<table style="width:100%; background-color:antiquewhite">
			<tr>
				<td class="auto-style7">FirstName</td>
				<td class="auto-style8">
					<asp:TextBox ID="TextBox1" runat="server" Width="248px"></asp:TextBox>
				</td>
				<td class="auto-style9">
					<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required FirstName" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">LastName</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox2" runat="server" Width="246px"></asp:TextBox>
				</td>
				<td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Required LastName" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">Father&#39;s Name</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox3" runat="server" Width="244px"></asp:TextBox>
				</td>
				<td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Required Father's Name" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">Mother&#39;s Name</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox4" runat="server" Width="244px"></asp:TextBox>
				</td>
				<td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Required Mother's Name" ForeColor="Red"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style3">Gender</td>
				<td class="auto-style4">
					<asp:RadioButton ID="RadioButton3" runat="server" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:RadioButton ID="RadioButton4" runat="server" Text="Female" />
				</td>
				
			</tr>
			<tr>
				<td class="auto-style1">Aggregate</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox6" runat="server" Width="243px"></asp:TextBox>
				</td>
				<td>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Required Aggregate" ForeColor="#FF3300"></asp:RequiredFieldValidator>
				&nbsp;&nbsp;&nbsp;
					<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="Aggregrate limit doesnt reach" ForeColor="Red" MaximumValue="100" MinimumValue="60" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style3">Course </td>
				<td class="auto-style5">
					<asp:RadioButton ID="RadioButton1" runat="server" Text="ECE" ForeColor="#0033CC" />
					<br />
					<asp:CheckBox ID="Checkbox1" runat="server" Text="Digit Communication" />
					&nbsp;<asp:CheckBox ID="Checkbox2" runat="server" Text="Analog" />
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:CheckBox ID="Checkbox3" runat="server" Text="Micro Controller" />

					<br />

					<asp:RadioButton ID="RadioButton2" runat="server" Text="CSE" ForeColor="Blue" />
					<br />
					<asp:CheckBox ID="Checkbox4" runat="server" Text="Computer Operationg Architecture" />
					&nbsp;
					<asp:CheckBox ID="Checkbox5" runat="server" Text="Data Structures" />
					&nbsp;<asp:CheckBox ID="Checkbox6" runat="server" Text="Computer Network" />
				</td>
			</tr>
		</table><br />
		<asp:Button ID="Button1" runat="server" Text="Submit" Width="135px" CssClass="auto-style10" BackColor="#FFFF99" BorderColor="#663300" ForeColor="#003366" Height="32px" />
		<br />
		<br />

		
    	<table style="width:100%; background-color:gainsboro">
			<tr>
				<td class="auto-style6">
					<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" />
				</td>
				
			</tr>
		</table>
		
    </form>
</body>
</html>
