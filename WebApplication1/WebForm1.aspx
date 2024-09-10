<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giải phương trình bậc 1</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="content">
                <div>
            <h2>Giải phương trình bậc 1: ax + b = 0</h2>
            <label for="txt_a">Nhập a:</label>
            <asp:TextBox ID="txt_a" runat="server" Height="24px"></asp:TextBox><br /><br />
            <label for="txt_b">Nhập b:</label>
            <asp:TextBox ID="txt_b" runat="server" Height="24px" Width="160px"></asp:TextBox><br /><br />
            <asp:Button ID="btn_Tinh" runat="server" Text="Tính"  Width="62px" OnClick="btn_Tinh_Click" Height="29px" /><br /><br />
            <asp:Label ID="lbl_KQ" runat="server"></asp:Label>
                </div>
            </div>
         </div>
    </form>
</body>
</html>
