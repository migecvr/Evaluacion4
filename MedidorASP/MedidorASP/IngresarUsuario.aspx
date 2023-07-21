<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarUsuario.aspx.cs" Inherits="MedidorASP.IngresarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class ="mensajes">

                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>

            </div>
            <div class="card">
                <div class="card-header bg-warning text-dark">
                    <h3>Ingresar Usuario</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                       <label for="rutTxt">Rut: </label>
                        <asp:TextBox ID="rutTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="rutTxt" ForeColor="red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label1" runat="server" Font-Size="Smaller" ForeColor="Red"></asp:Label>

                    <div class="form-group">
                       <label for="nombreTxt">Nombre: </label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="nombreTxt" ForeColor="red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label4" runat="server" Font-Size="Smaller" ForeColor="Red"></asp:Label>

                    <div class="form-group">
                       <label for="apellidoTxt">Apellido: </label>
                        <asp:TextBox ID="apellidoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="apellidoTxt" ForeColor="red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label5" runat="server" Font-Size="Smaller" ForeColor="Red"></asp:Label>

                    <div class="form-group">
                       <label for="TipoUsuarioDdl">Tipo de Usuario: </label>
                        <asp:DropDownList runat="server" ID="TipoUsuarioDdl" CssClass="form-control form-select">

                            <asp:ListItem Text="Administrador" Value="01"></asp:ListItem> 
                            <asp:ListItem Text="Gerente" Value="02"></asp:ListItem>
                            <asp:ListItem Text="Empleado_Comun" Value="03"></asp:ListItem>
                            
                        </asp:DropDownList>
                    </div>

                    <div class="form-group mt-4">
                       <label for="correoTxt">Correo Electrónico: </label>
                        <asp:TextBox ID="correoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="correoTxt" ForeColor="red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label2" runat="server" Font-Size="Smaller" ForeColor="Red"></asp:Label>

                    <div class="form-group">
                       <label for="contraseniaTxt">Contraseña: </label>
                        <asp:TextBox ID="contraseniaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="contraseniaTxt" ForeColor="red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label3" runat="server" Font-Size="Smaller" ForeColor="Red"></asp:Label>
                    

                   

                    <div class="form-group">
                       
                        <asp:Button runat="server" ID="btnAgregarUsuario" Text="Ingresar" CssClass="btn btn-primary mt-2" OnClick="btnAgregarUsuario_Click" />

                    </div>
  
                   

                </div>
            </div>
        </div>
    </div>
</asp:Content>
