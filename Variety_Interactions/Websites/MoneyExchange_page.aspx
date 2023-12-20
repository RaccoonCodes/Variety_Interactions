<%@ Page Title="Money Exchange" Language="C#" MasterPageFile="~/Websites/MasterSite.Master" AutoEventWireup="true" CodeBehind="MoneyExchange_page.aspx.cs" Inherits="Variety_Interactions.Websites.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="MoneyExchangeContent" ContentPlaceHolderID="ContentPages" runat="server">

    <h1 class="center text">Money Exchange</h1>
    <p class="center text">Currency Updated:12/7/2023</p>
    <div class="pad">
        <p>
            I want to exchange
        <asp:TextBox ID="InputCashID" runat="server"></asp:TextBox>
            <asp:DropDownList ID="CurrencyID" runat="server"></asp:DropDownList>
            to
    <asp:DropDownList ID="Currency2ID" runat="server"></asp:DropDownList>
        </p>

        <asp:Button runat="server" Text="Enter" CssClass="btn btn-primary" ID="BtnEnterID" OnClick="BtnEnterID_Click"></asp:Button>
        <asp:RegularExpressionValidator ID="Reg_Expr_Input" runat="server" ErrorMessage="Please input valid value" ValidationExpression="^\d*(\.\d+)?$" ControlToValidate="InputCashID" ForeColor="Red"></asp:RegularExpressionValidator>
        <p>&nbsp</p>
        <asp:Label ID="ResultsID" runat="server" CssClass="text"></asp:Label>
        <p>&nbsp</p>
        <asp:Label ID="MathWork" runat="server" CssClass="text"></asp:Label>

    </div>
</asp:Content>
