<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABMSuscripciones.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.ABMSuscripciones" MasterPageFile="SideBarAdmins.Master" %>

<asp:Content ID="ABMSuscripciones" ContentPlaceHolderID="Header" runat="server">
    <div class="container-fluid">
        <div class="row">
           
            <div class="col-sm">
                <% foreach (Dominio.ServicioContratado item in list)
                    { %>
               <div class="card mb-3" style="max-width: 100%;margin:2rem;background-color: rgba(0,0,0,0.7) !important; color: white;"">
                <div class="row no-gutters">
                    <div class="col-4" style="display: flex">
                        <img src="<%=item.Servicio.URLServicio %>" alt="..." style="max-width: 90%; align-items: center; margin: 10px">
                    </div>
                    <div class="col" style="display: flex">
                        <div class="card-body">
                            <h5 class="card-title"><% =item.Servicio.Descripcion %></h5>
                            <p>Fecha Inicio: <%=item.FechaCompra %></p>
                            <p>Fecha Fin:<%=item.FechaCancelacion %></p>
                            <p>Administrador:  <% =item.Usuario.Nombre%></p>
                            <p>Alias servicio: <% =item.GrupoSoporte%></p>

                        </div>
                    </div>
                    <div class="col-2">
                        <div class="row" style="width: 100%">
                            
                            <a href="ModSuscripcion.aspx?id=<%= item.Id %>" class="btn btn-outline-success my-2 my-sm-0 btnNavbar" Style="width: 100%; margin-left: 2rem;">Modificar</a>
                        </div>
                        <div class="row" style="width: 100%">
                            <asp:Button ID="Baja" runat="server" Text="Dar de baja" class="btn btn-outline-success my-2 my-sm-0 btnNavbar" Style="width: 100%; margin-left: 2rem;" />
                        </div>
                    </div>
                </div>
               </div>

                <%}%>

                </div>
            </div>
        </div>
</asp:Content>
