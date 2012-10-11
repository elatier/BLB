<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchBonds.aspx.cs" Inherits="BuyLocalBonds.SearchBonds" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    Buy Local Bonds: Bond Search<table class="style1">
        <tr>
            <td class="style2">
                Price: Low</td>
            <td class="style2">
                <asp:TextBox ID="PriceLow" runat="server"></asp:TextBox>
                </td>
            <td class="style2">
                high</td>
            <td class="style2">
                <asp:TextBox ID="PriceHigh" runat="server" 
                    ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                CUPID</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                </td>
            <td class="style2">
                </td>
            <td class="style2">
                </td>
            <td class="style2">
                <asp:Button ID="Search" runat="server" Text="Button" onclick="Search_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:GridView ID="GvBondResults" runat="server" />

            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
