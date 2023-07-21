<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarUsuario.aspx.cs" Inherits="MedidorASP.MostrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-9 mx-auto">

            <div class="row">
                <div class="col-9">

                </div>
                <div class="col-3">
                    
                <asp:Button runat="server" ID="btnRecargarUsuarios" Text="Recargar Usuarios" CssClass="btn btn-success" OnClick="btnRecargarUsuarios_Click"/>
                </div>
            </div>

            <div class="form-inline mb-2">
                        
                            
                    <div class="form-group">
                       <label for="FltUsuarioDdl">Filtrar por Tipo de Usuario: </label>
                        <asp:DropDownList runat="server" ID="FltUsuarioDdl" CssClass="form-control form-select">

                            <asp:ListItem Text="Administrador" Value="01"></asp:ListItem> 
                            <asp:ListItem Text="Gerente" Value="02"></asp:ListItem>
                            <asp:ListItem Text="Empleado_Comun" Value="03"></asp:ListItem> 
                            
                        </asp:DropDownList>
                    </div>
    
                    <asp:Button runat="server" ID="btnFiltrarUsuario" Text="filtrar" CssClass="btn btn-primary d-inline" OnClick="btnFiltrarUsuario_Click"/>

                        
            </div>

            <div class="card">
                <div class="card-header bg-warning text-dark">
                    <h3>Lista de Usuarios</h3>
                </div>

                <div class="card-body">
                    
                    <asp:GridView CssClass="table table-hover table-bordered" 
                     OnRowCommand="grillaUsuarios_RowCommand" EmptyDataText="No existen Usuarios"
                     AutoGenerateColumns="false" runat="server" ID="grillaUsuarios">
                        <Columns>
                            <asp:BoundField DataField="Rut" HeaderText="Rut"/>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre"/>
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido"/>
                            <asp:BoundField DataField="TipoUsuario" HeaderText="Tipo de Usuario"/>
                            <asp:BoundField DataField="Correo" HeaderText="Correo Electrónico"/>
                            <asp:BoundField DataField="Contrasenia" HeaderText="Contraseña"/>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="elimina" CommandArgument='<%# Eval("Rut") %>' runat="server" CssClass="btn btn-danger" Text="Eliminar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                        
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
