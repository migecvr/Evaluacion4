<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="MedidorASP.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">

            <div class="row">
                <div class="col-9">

                </div>
                <div class="col-3">
                    
                <asp:Button runat="server" ID="btnRecargarLecturas" Text="Recargar Lecturas" CssClass="btn btn-success" OnClick="btnRecargarLecturas_Click"/>
                </div>
            </div>

            <div class="form-inline mb-2">
                        
                            
                    <div class="form-group">
                       <label for="FltecturaDdl">Filtrar por N° de serie Medidor: </label>
                        <asp:DropDownList runat="server" ID="FltLecturaDdl" CssClass="form-control form-select"></asp:DropDownList>
                    </div>
                             
                            

                        
                <asp:Button runat="server" ID="btnFiltrarLectura" Text="filtrar" CssClass="btn btn-primary d-inline" OnClick="btnFiltrarLectura_Click"/>

                        
            </div>

            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Listado de Lecturas</h3>
                </div>
                <div class="card-body">
                    
  
                    <asp:GridView CssClass="table table-hover table-bordered" 
                        
                        EmptyDataText="No existen Lecturas" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaLecturas">
                       <Columns>
                           <asp:BoundField DataField="Medidor.NumSerie" HeaderText="Medidor" />
                           <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                           <asp:BoundField DataField="Hora" HeaderText="Hora" />
                           <asp:BoundField DataField="Minuto" HeaderText="Minuto" />
                           <asp:BoundField DataField="Consumo" HeaderText="Consumo (Kwh)" />
                          
                       </Columns>
                    </asp:GridView>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
