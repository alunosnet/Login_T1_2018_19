<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="segura.aspx.cs" Inherits="Login_T1.segura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Isto é uma página segura!</h1>
            <asp:Button ID="Button1" runat="server" Text="Log Out" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
