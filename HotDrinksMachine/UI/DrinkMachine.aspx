<%@ Page Title="DrinkMachine" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DrinkMachine.aspx.cs" Inherits="HotDrinksMachine.DrinkMachine" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
        <h1>Hot Drinks Machine</h1>

        <fieldset>

            <legend>Please select a drink</legend>

            <div class="row form-group drink-selection">
                <div class="col-md-4">
                    <asp:LinkButton runat="server" ID="CoffeeButton" OnClick="DrinkSelection_Click">
                        <i class="fa fa-coffee fa-5 coffee" aria-hidden="true"></i>
                    </asp:LinkButton>
                    <br />
                    <label for="CoffeeButton" class="drink-label"><asp:Literal ID="CoffeeLabel" runat="server"></asp:Literal></label>
                </div>
                <div class="col-md-4">
                    <asp:LinkButton runat="server" ID="LemonTeaButton" OnClick="DrinkSelection_Click">
                        <i class="fa fa-lemon-o fa-5 lemon-tea" aria-hidden="true"></i>
                    </asp:LinkButton>
                    <br />
                    <label for="LemonTeaButton" class="drink-label"><asp:Literal ID="LemonTeaLable" runat="server"></asp:Literal></label>
                </div>
                <div class="col-md-4">
                    <asp:LinkButton runat="server" ID="ChocolateButton" OnClick="DrinkSelection_Click">
                        <i class="fa fa-coffee fa-5 chocolate" aria-hidden="true"></i>
                    </asp:LinkButton>
                    <br />
                    <label for="ChocolateButton" class="drink-label"><asp:Literal ID="ChocolateLabel" runat="server"></asp:Literal></label>
                </div>
            </div>

        </fieldset>

        <asp:PlaceHolder ID="SelectedDrinkPH" runat="server" Visible="false">
            <div class="row form-group">
                <label class="drink-label">Selected drink: <asp:Literal ID="SelecteDrink" runat="server"></asp:Literal></label>
            </div>
            
            <div class="row form-group">
                <input type="button" id="makeDrink" value="Make Drink" class="btn btn-primary btn-lg">
            </div>
            
            <div id="progressBar" class="progress form-group hide">
                <div class="progress-bar" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100"></div>
            </div>

            <div class="form-group">
                <div id="actions">
        
                </div>
            </div>

            <div id="successMessage" class="hide">
                <div class="alert alert-success" role="alert">
                    <asp:Literal ID="SuccessAlert" runat="server"></asp:Literal>
                </div>
            </div>

            <div id="errorMessage" class="hide">
                <div class="alert alert-danger" role="alert">
                    <asp:Literal ID="ErrorAlert" runat="server"></asp:Literal>
                </div>
            </div>
            
                
        </asp:PlaceHolder>
    </div>

    <script>
        let json = <%=Recipe %>

        function addElement(elem, delay, callback) {
            setTimeout(function () {
                $('<div class="action">').css('opacity', 0).text(elem).appendTo($("#actions")).animate({ opacity: 1 }, 500, function () {
                    callback()
                });
            }, delay, );
            
        }

        function progressBar(total, currentValue) {
            let value = currentValue / total * 100;
            $('.progress-bar').css('width', value + '%').attr('aria-valuenow', value);
            if (value === 100) {
                $("#successMessage").removeClass('hide');
            }
        }

        $("#makeDrink").click(function () {

            $("#actions").empty();
            $("#successMessage").addClass('hide');
            $("#errorMessage").addClass('hide');

            if (json.length > 0 && json[0] !== "Unknown drink type") {
                $("#progressBar").removeClass('hide');
                $.each(json, function (i, v) {
                    addElement(json[i], i * 1200, function () { progressBar(json.length, (i + 1)) });
                });
            } else {
                $("#errorMessage").removeClass('hide');
            }
        });
    </script>

</asp:Content>

