<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" width="75px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" OnTextChanged="txtStaffID_TextChanged"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name" width="75px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="lblLastName" runat="server" Text="Last Name" width="75px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDepartment" runat="server" Text="Department  "></asp:Label>
            <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDate" runat="server" Text="Date" width="75px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkStatus" runat="server" Text="Status" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="84px" />
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        </p>
    </form>
</body>
</html>
