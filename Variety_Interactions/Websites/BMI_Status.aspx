<%@ Page Title="BMI Check" Language="C#" MasterPageFile="~/Websites/MasterSite.Master" AutoEventWireup="true" CodeBehind="BMI_Status.aspx.cs" Inherits="Variety_Interactions.Websites.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPages" runat="server">

    <script type="text/javascript">
        function validatefun(sender, args) {
            var controlId = sender.controltovalidate;
            var control = document.getElementById(controlId);
            var value = control.value;

            // Validate that the input consists of digits only
            if (/^\d+$/.test(value)) {
                args.IsValid = true;
            } else {
                args.IsValid = false;
            }
        }
    </script>

    <script type="text/javascript">
        function validateDouble(sender, args) {
            var controlId = sender.controltovalidate;
            var control = document.getElementById(controlId);
            var value = control.value;

            // Validate that the input is a valid double (integer or decimal)
            if (/^\d+(\.\d+)?$/.test(value)) {
                args.IsValid = true;
            } else {
                args.IsValid = false;
            }
        }
    </script>



    <div class="center text">
        <h1>BMI Calculator</h1>
    </div>

    <div class="row text">
        <p>Please input the following information to obtain your current BMI</p>
        <p>
            Height:
            <asp:TextBox ID="ft_measureID" runat="server"></asp:TextBox>
            ft
            <asp:TextBox ID="inch_measureID" runat="server"></asp:TextBox>
            in
        </p>

        <asp:CustomValidator ID="CustomValidator_ft" runat="server" ControlToValidate="ft_measureID"
            ClientValidationFunction="validatefun" ErrorMessage="Please enter a valid value for ft" ForeColor="Red">
        </asp:CustomValidator>
        <asp:CustomValidator ID="CustomValidator_inch" runat="server" ControlToValidate="inch_measureID"
            ClientValidationFunction="validatefun" ErrorMessage="Please enter a valid value for inches" ForeColor="Red">
        </asp:CustomValidator>

        <p>
            <br />
            Current Weight: 
            <asp:TextBox ID="Weight_ID" runat="server"></asp:TextBox>
            Ib
        </p>
        <asp:CustomValidator ID="CustomValidator_Weight" runat="server" ControlToValidate="Weight_ID"
            ClientValidationFunction="validateDouble" ErrorMessage="Please enter a valid value for weight" ForeColor="Red">
        </asp:CustomValidator>
        <asp:Button ID="Calculate_BTN" runat="server" Text="Enter" CssClass="btn btn-outline-info" OnClick="Calculate_BTN_Click" />
        <b class="center">BMI Categories
            <br />
            Underweight = <18.5
            <br />
            Normal weight = 18.5–24.9
            <br />
            Overweight = 25–29.9
            <br />
            Obesity = BMI of 30 or greater
        </b>
    </div>
    <div class="center text_size">
        <br />
        <asp:Label ID="Output_ID" runat="server"></asp:Label>
    </div>
</asp:Content>
