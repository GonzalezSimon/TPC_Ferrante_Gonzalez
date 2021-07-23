<%@ Page Language="C#" MasterPageFile="~/SideBar.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.Usuarios" %>

<asp:Content ID="UsuariosHeader" ContentPlaceHolderID="Header" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="card-group">
                <% foreach (Dominio.ServicioContratado item in list)
                    { %>
                <div class="card mb-3" style="min-width: 20rem;max-width: 20rem; margin: 2rem; background-color: rgba(0,0,0,0.7) !important; color: white;">
                    <img src="<%=item.Servicio.URLServicio %>" alt="..." style="max-width: 90%; align-items: center; margin: 10px">
                    <div class="card-body">
                        <h5 class="card-title"><% =item.GrupoSoporte %></h5>
                        <p>Servicio: <%=item.Servicio.Descripcion %></p>
                        <p>Fecha Inicio: <%=item.FechaCompra %></p>
                        <p>Fecha Fin:<%=item.FechaCancelacion %></p>
                        <p>Administrador:  <% =item.Usuario.Nombre%></p>
                        <p>Grupo Soporte: <% =item.GrupoSoporte%></p>
                        <hr />
                        <div class="row" style="width: 100%">
                            <asp:Button ID="Button5" runat="server" Text="Ticket Soporte" class="btn btn-outline-success my-2 my-sm-0 btnNavbar" Style="width: 100%; margin-left: 2rem;" />
                        </div>
                        <div class="row" style="width: 100%">
                            <asp:Button ID="Button6" runat="server" Text="Dar de baja" class="btn btn-outline-success my-2 my-sm-0 btnNavbar" Style="width: 100%; margin-left: 2rem;" />
                        </div>
                    </div>
                </div>
                <%}%>
                <div class="card mb-3" style="min-width: 20rem;max-width: 20rem; margin: 2rem; background-color: rgba(0,0,0,0.7) !important; color: white;">
                    <img src="Imgs/LogoLogin.png" alt="..." style="max-width: 90%; align-items: center; margin: 10px">
                    <div class="card-body">

                        <hr />
                        <div class="row" style="width: 100%">
                            <asp:Button ID="btnNuevoGameServer" runat="server" Text="Start Gaming" class="btn btn-outline-success my-2 my-sm-0 btnNavbar" Style="width: 100%; margin-left: 2rem;" OnClick="btnNuevoGameServer_Click" />
                        </div>
                        
                    </div>
                </div>
            </div>

        </div>

    </div>



</asp:Content>

