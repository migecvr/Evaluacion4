<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidores.aspx.cs" Inherits="MedidorASP.IngresarMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class ="mensajes">

                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>

            </div>
            <div class="card">
                <div class="card-header bg-success text-white">
                    <h3>Ingresar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                       <label for="NumSerie">N° de Serie: </label>
                        <asp:TextBox ID="NumSerie" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="NumSerie" ForeColor="red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label1" runat="server" Font-Size="Smaller" ForeColor="Red"></asp:Label>

                    <div class="form-group">
                       <label for="TipoDdl">Tipo: </label>
                        <asp:DropDownList runat="server" ID="TipoDdl" CssClass="form-control form-select">

                            <asp:ListItem Text="Empresa" Value="01"></asp:ListItem> 
                            <asp:ListItem Text="Cliente" Value="02"></asp:ListItem> 
                            
                        </asp:DropDownList>
                    </div>
                    

                   

                    <div class="form-group">
                       
                        <asp:Button runat="server" ID="btnAgregarMedidor" Text="Ingresar" CssClass="btn btn-primary mt-2" OnClick="btnAgregarMedidor_Click" />

                    </div>
  
                   

                </div>
            </div>
        </div>
    </div>
</asp:Content>
