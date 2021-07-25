<%@ Page Title="DrinkMachine" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DrinkMachine.aspx.cs" Inherits="HotDrinksMachine.DrinkMachine" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Hot Drinks Machine</h2>

    <fieldset>

        <legend>Please select a drink</legend>

        <asp:RadioButtonList ID="DrinkRBList" runat="server" AutoPostBack="true">
            <asp:ListItem Value="LemonTea">Lemon Tea</asp:ListItem>
            <asp:ListItem Value="Coffee">Coffee</asp:ListItem>
            <asp:ListItem Value="Chocolate">Chocolate</asp:ListItem>
        </asp:RadioButtonList>

    </fieldset>

    <asp:Repeater ID="ActionsRpt" runat="server">
        <HeaderTemplate>
            <dl>
                <dt>Actions</dt>
        </HeaderTemplate>

        <ItemTemplate>
                <dd><%# Container.DataItem?.ToString() ?? string.Empty%></dd>
        </ItemTemplate>

        <FooterTemplate>
            </dl>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

