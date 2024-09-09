<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giải phương trình bậc 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Giải phương trình bậc 1: ax + b = 0</h2>
            <label for="txtA">Nhập a:</label>
            <asp:TextBox ID="txt_a" runat="server"></asp:TextBox><br /><br />
            <label for="txtB">Nhập b:</label>
            <asp:TextBox ID="txt_b" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btn_Tinh" runat="server" Text="Tính" OnClick="btnSolve_Click" Width="64px" /><br /><br />
            <asp:Label ID="lbl_KQ" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
