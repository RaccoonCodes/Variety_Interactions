<%@ Page Title="World Clock" Language="C#" MasterPageFile="~/Websites/MasterSite.Master" AutoEventWireup="true" CodeBehind="World_Clock.aspx.cs" Inherits="Variety_Interactions.Websites.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="WorldClockContent" ContentPlaceHolderID="ContentPages" runat="server">

    <h1 class="text center">World Clock</h1>
    <asp:Label ID="WorldTimeID" runat="server" Text="" CssClass="text"></asp:Label>
    <p>
        <br />
        Choose an area you want to see their current time: 
    </p>
    <asp:CheckBoxList ID="OtherRegionClock" runat="server" CssClass="text"></asp:CheckBoxList>
    <asp:Button ID="SubmitBtn" runat="server" Text="Enter" OnClick="SubmitBtn_Click" CssClass="btn btn-info" UseSubmitBehavior="False" />
    <br />
    <br />
    <div class="center">
        <asp:Label ID="WorldClockOther" runat="server" CssClass="text"></asp:Label>
    </div>
    <h1 class="text center">
        <br />
        Countdown to . . . </h1>
    <asp:RadioButtonList ID="EventRadioBtn" runat="server" CssClass="text radioSpace" RepeatDirection="Horizontal"></asp:RadioButtonList>
    <asp:Button ID="SubmitBtn2" runat="server" Text="Is in . . ." CssClass="btn btn-info" OnClick="SubmitBtn2_Click" UseSubmitBehavior="False" />

    <div class="center">
        <asp:Image ID="EventImages" runat="server" />
        <br />
        <asp:Label ID="CountDownResultsID" runat="server" CssClass="results text"></asp:Label>
    </div>
</asp:Content>
