<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedidorASP.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">

            <div class="row">
                <div class="col-9">

                </div>
                <div class="col-3">
                    
                <asp:Button runat="server" ID="btnRecargarMedidores" Text="Recargar Medidores" CssClass="btn btn-success" OnClick="btnRecargarMedidores_Click"/>
                </div>
            </div>

            <div class="form-inline mb-2">
                        
                            
                    <div class="form-group">
                       <label for="FltMedidorDdl">Filtrar por Tipo de Medidor: </label>
                        <asp:DropDownList runat="server" ID="FltMedidorDdl" CssClass="form-control form-select">

                            <asp:ListItem Text="Empresa" Value="01"></asp:ListItem> 
                            <asp:ListItem Text="Cliente" Value="02"></asp:ListItem> 
                            
                        </asp:DropDownList>
                    </div>
    
                    <asp:Button runat="server" ID="btnFiltrarMedidor" Text="filtrar" CssClass="btn btn-primary d-inline" OnClick="btnFiltrarMedidor_Click"/>

                        
            </div>

            <div class="card">
                <div class="card-header bg-success text-white">
                    <h3>Lista de Medidores</h3>
                </div>

                <div class="card-body">

                    

                    <asp:GridView CssClass="table table-hover table-bordered" 
                     OnRowCommand="grillaMedidores_RowCommand" EmptyDataText="No existen Medidores"
                     AutoGenerateColumns="false" runat="server" ID="grillaMedidores">
                        <Columns>
                            <asp:BoundField DataField="NumSerie" HeaderText="Numero de Serie"/>
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo"/>

                            
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
