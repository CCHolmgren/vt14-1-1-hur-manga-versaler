<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UppercaseCounter.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" ID="UppercaseInput" Height="158px" Width="850px" TextMode="MultiLine" />
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
        </p>
        <p>
        <asp:Button Text="Bestäm antalet versaler" runat="server" ID="SendButton" OnClick="SendButton_Click" />
        </p>
    </form>
</body>
</html>
