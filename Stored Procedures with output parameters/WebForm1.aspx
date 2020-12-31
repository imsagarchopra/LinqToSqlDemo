<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Stored_Procedures_with_output_parameters.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <asp:Label ID="lblDept" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnGetEmployeesByDepartment" runat="server" OnClick="btnGetEmployeesByDepartment_Click" Text="Get Employees By Department" />
        </div>
    </form>
</body>
</html>
