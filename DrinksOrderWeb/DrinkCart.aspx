<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DrinkCart.aspx.cs" Inherits="DrinkCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .all {            
            font-family: 微軟正黑體;
        }
        .title {
            font-family: 微軟正黑體;
            font-size: large;
            font-weight: bold;
            background-color: #00FFFF;
        }        
        .pay {
            background-color: #66FF66;
            font-family: 微軟正黑體;
        }
        .auto-style1 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" class="all" runat="server">
        <div class="title">飲料購物車</div>
        <div>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <div>
            應付金額：<strong><asp:Label ID="lblTotalPrice" runat="server" Text="0"></asp:Label>
            </strong>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/DrinkOrder.aspx" Text="繼續選購" />
        </p>
        <div>
            <asp:Button ID="btnConfirm" runat="server" Height="28px" Text="前往付款" OnClick="btnConfirm_Click" />
            <asp:Panel ID="Panel1" runat="server" Visible="False" CssClass="pay">
                <br />
                請輸入付款金額：<asp:TextBox ID="tbPay" runat="server" Width="100px"></asp:TextBox>
                <strong>
                <asp:Label ID="lblError" runat="server" CssClass="auto-style1" Text="金額不足" Visible="False"></asp:Label>
                </strong>
                <br />
                <br />
                <strong>找零：<asp:Label ID="lblFeedBack" runat="server" Text="0"></asp:Label>
                </strong>
                <br />
                <br />
                <asp:Button ID="btnAccounting" runat="server" OnClick="btnAccounting_Click" Text="結帳" Width="78px" />
                <br />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
