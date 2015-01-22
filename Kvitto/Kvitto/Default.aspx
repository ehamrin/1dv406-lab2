<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kvitto.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Receipt</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Submit">
    <div id="input">
        <fieldset>
            <legend>Fill in purchase amount</legend>
            <asp:TextBox ID="SumInput" runat="server" />
            <asp:RequiredFieldValidator class="error" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Field is required" Text="* Field is required" ControlToValidate="SumInput" Display="Dynamic" SetFocusOnError="True" />
            <asp:CompareValidator class="error" ID="CompareValidator1" runat="server" ErrorMessage="Double must be greater than 0" Type="Double" ControlToValidate="SumInput" Operator="GreaterThan" ValueToCompare="0" Display="Dynamic" SetFocusOnError="True" Text="* Double must be greater than 0" />
            <asp:Button ID="Submit" runat="server" Text="Calculate" OnClick="Submit_Click" />
        </fieldset>
    </div>

        <asp:Panel ID="Receipt" runat="server" Visible="False">
            <h1>Receipt</h1>
            <h2>eh222ve</h2>
            <p>Tel: 070-777 43 94</p>
            <p>Open: 9-15</p>
            <p>JAG GÖR INTE FEL</p>
            <hr />
            <div>Subtotal: <asp:Label ID="SubTotal" runat="server" Text="Label" /></div>
            <div>Rate: <asp:Label ID="Rate" runat="server" Text="Label" /></div>
            <div>Discount: <asp:Label ID="Discount" runat="server" Text="Label" /></div>
            <div>Total: <asp:Label ID="Total" runat="server" Text="Label" /></div>
            <hr />
            <p>Try again!</p>
            
        </asp:Panel>
    </form>
    <script src="/Content/Main.js" type="text/javascript"></script>
</body>
</html>
