<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_20210605_1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 198px;
        }
        .auto-style2 {
            width: 198px;
            height: 397px;
        }
        .auto-style3 {
            height: 397px;
            width: 715px;
        }
        .auto-style4 {
            width: 715px;
        }
        .auto-style5 {
            margin-top: 0px;
        }
        .auto-style6 {
            margin: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 933px">
            <table style="width:100%;">
                <tr>
                    <th class="auto-style1">查詢工具</th>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="29px" Width="776px">
                            <asp:ListItem Value="SELECT-FROM-WHERE">SELECT-FROM-WHERE</asp:ListItem>
                            <asp:ListItem Value="DELETE">DELETE</asp:ListItem>
                            <asp:ListItem Value="INSERT">INSERT</asp:ListItem>
                            <asp:ListItem Value="UPDATE">UPDATE</asp:ListItem>
                            <asp:ListItem Value="IN">IN</asp:ListItem>
                            <asp:ListItem Value="NOT IN">NOT IN</asp:ListItem>
                            <asp:ListItem Value="EXISTS">EXISTS</asp:ListItem>
                            <asp:ListItem Value="NOT EXISTS">NOT EXISTS</asp:ListItem>
                            <asp:ListItem Value="COUNT">COUNT</asp:ListItem>
                            <asp:ListItem Value="SUM">SUM</asp:ListItem>
                            <asp:ListItem Value="MAX">MAX</asp:ListItem>
                            <asp:ListItem Value="MIN">MIN</asp:ListItem>
                            <asp:ListItem Value="AVG">AVG</asp:ListItem>
                            <asp:ListItem Value="HAVING">HAVING</asp:ListItem>
                            <asp:ListItem Value="SQL">SQL</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style2">查詢關鍵字</th>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server" Height="370px" OnTextChanged="TextBox1_TextChanged" style="margin-left: 1px; " Width="776px" CssClass="auto-style5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查詢" Height="42px" Width="783px" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td class="auto-style6">
                        <asp:Label ID="Label1" runat="server" Height="49px" Width="780px" style="TEXT-ALIGN:left"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <th class="auto-style6">
                        <asp:Label ID="Label2" runat="server" Text="查詢結果" Height="35px" Width="768px" style="TEXT-ALIGN:left"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <td></td>
                    <td class="auto-style1">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
