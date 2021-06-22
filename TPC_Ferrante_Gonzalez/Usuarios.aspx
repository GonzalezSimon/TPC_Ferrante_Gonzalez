<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.Usuarios" %>

<asp:Content ID="UsuariosHeader" ContentPlaceHolderID="Header" runat="server">

    <div class="di-flex contenedor-sidebar">
        <div class="bg-primary.sidebar-usuarios">
            <div class="logo">
                <img src="<%= usuario.URLimagen %>" alt="..." class="imglogo">
            </div>
            <div class="">
                <ul class="list-group list-group-flush">
                                <li class="list-group-item">Bienvenido <%= usuario.Apellido%> <%=usuario.Nombre%>!</li>
                                <li class="list-group-item">Fecha creación de usuario: <%=usuario.FechaCreacion %></li>
                                <li class="list-group-item">A third item</li>
                            </ul>
                <a href="Home.aspx" class="opcoines">Homiado</a>
            </div>
        </div>
    </div>

    </asp:Content>
<asp:Content ID="ServiciosParaUsuario" ContentPlaceHolderID="MainContent" runat="server">


    <% foreach (Dominio.ServicioContratado item in list)
        { %>
    <div class="marginCard">
            <table>
                <tr>
                    <td>
                        <div class="card" style="width: 18rem; margin: 0rem 2rem;">
                            <img src="http://rotahost.com.ar/wp-content/uploads/2020/10/cropped-ss_ccc4ce6edd4c454b6ce7b0757e633b63aa93921d.1920x1080_1-1.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title"><% =item.Servicio.Descripcion %></h5>
                                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            </div>
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item">Fecha Inicio <%=item.FechaCompra %></li>
                                <li class="list-group-item">Fecha Fin <%=item.FechaCancelacion %></li>
                                <li class="list-group-item">Administrador <% =item.Usuario.Nombre%> </li>
                                <li class="list-group-item">Grupo Soporte <% =item.GrupoSoporte%> </li>
                            </ul>
                            <div class="card-body">
                                <a href="#" class="card-link">Crear Ticket Soporte</a>
                                <a href="#" class="card-link">Dar de baja</a>
                            </div>
                        </div>
                    </td>
                    </tr>
                </table>
        </div>
        <%}%>
        </asp:Content>
