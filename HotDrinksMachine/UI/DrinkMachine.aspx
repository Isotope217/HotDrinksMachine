<%@ Page Title="DrinkMachine" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DrinkMachine.aspx.cs" Inherits="HotDrinksMachine.DrinkMachine" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Hot Drinks Machine</h2>

    <p>Please select a drink</p>

    <asp:Label ID="DrinkListRBLabel" runat="server" Font-Size="Large" ForeColor="Crimson"></asp:Label>
        <asp:RadioButtonList ID="DrinkRBList" runat="server" AutoPostBack="true">
            <asp:ListItem Value="LemonTea">Lemon Tea</asp:ListItem>
            <asp:ListItem Value="Coffee">Coffee</asp:ListItem>
            <asp:ListItem Value="Chocolate">Chocolate</asp:ListItem>
        </asp:RadioButtonList>

    <asp:Label ID="ResultLabel" runat="server"></asp:Label>
</asp:Content>

