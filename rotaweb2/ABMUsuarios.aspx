<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABMUsuarios.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.ABMUsuarios" MasterPageFile="SideBarAdmins.Master" %>

<asp:Content ID="ABMUsuarios" ContentPlaceHolderID="Header" runat="server">
    <div class="container-fluid">
        <div class="row">
           
            <div class="col-sm">
                <% foreach (Dominio.Usuario item in uList)
                    { %>
               <div class="card mb-3" style="max-width: 100%;margin:2rem;background-color: rgba(0,0,0,0.7) !important; color: white;"">
                <div class="row no-gutters">
                    <div class="col-4" style="display: flex">
                        <img src="<%=item.URLimagen %>" alt="..." style="max-width: 90%; align-items: center; margin: 10px">
                    </div>
                    <div class="col" style="display: flex">
                        <div class="card-body">
                            <h5 class="card-title"><% =item.UserName %></h5>
                            <p>Nombre: <%=item.Nombre %></p>
                            <p>Apellido:<%=item.Apellido %></p>
                            <p>E-Mail:  <% =item.Mail%></p>
                            <p>Tipo de Usuario: <% =item.Tipo.Nombre%></p>
                            <p>Localidad: <% =item.Localidad.Nombre%></p>

                        </div>
                    </div>
                    <div class="col-2">
                        <div class="row" style="width: 100%">
                            
                            <a href="ModUsuario.aspx?id=<%= item.Id %>" class="btn btn-outline-success my-2 my-sm-0 btnNavbar" Style="width: 100%; margin-left: 2rem;">Modificar</a>
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