<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UppercaseCounter.Default" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Räkna versaler</title>
    <link rel="stylesheet" href="Main.css" />
</head>
<body>
    <h1>Hur många versaler?</h1>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" ID="UppercaseInput" TextMode="MultiLine" />
    </div>
        <p>
            <asp:Label ID="UppercaseCount" runat="server" Text="" Visible="false"></asp:Label>
        </p>
        <p>
            <asp:Button Text="Bestäm antalet versaler" runat="server" ID="CalculateButton" OnClick="CalculateButton_Click" />
            <asp:Button Text="Återställ" runat="server" ID="ResetButton" OnClick="ResetButton_Click" Visible="false" />
        </p>
    </form>
</body>
</html>
