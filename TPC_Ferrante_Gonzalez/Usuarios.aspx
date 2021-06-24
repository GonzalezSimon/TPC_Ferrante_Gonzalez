<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.Usuarios" %>

<asp:Content ID="UsuariosHeader" ContentPlaceHolderID="Header" runat="server">

    <div class="d-flex contenedor-sidebar" style="height: 45rem">
        <div class="bg-primary.sidebar-usuarios" style="margin: 5rem; background-color: rgba(0,0,0,0.7) !important;">
            <div class="logo">
                <img src="<%= usuario.URLimagen %>" alt="..." class="imglogo">
            </div>
            <div class="">
                <ul class="list-group list-group-flush">
                    <li class="list-group-item">Bienvenido <%=usuario.UserName%>!</li>
                    <li class="list-group-item">Nombre: <%=usuario.Nombre+" "+usuario.Apellido %></li>
                    <li class="list-group-item">Cantidad de Servicios: <%=list.Count.ToString() %></li>
                    <li class="list-group-item">Fecha creación de usuario: <%=usuario.FechaCreacion %></li>
                    <li class="list-group-item">Fecha creación de usuario: <%=usuario.FechaCreacion %></li>
                </ul>
                <a href="Home.aspx" class="opcoines">Homiado</a>
            </div>
        </div>

        <% foreach (Dominio.ServicioContratado item in list)
            { %>

        <div class="card" style="width: 25rem;margin: 6rem;margin-left: 2rem;margin-right: 2rem;border-bottom-right-radius: 10%;border-top-left-radius: 10%;background-color: rgba(0,0,0,0.7) !important;color: white;">

            <img src="http://rotahost.com.ar/wp-content/uploads/2020/10/cropped-20200407144605-2-2-1586272081.png" class="card-img-top" alt="..." style="height: 8rem;width: 22rem;margin: 5.8%;margin-top: -1.5rem;border-top-left-radius: 8%;border-top-right-radius: 8%;">
            <div class="card-body" style="height: 1rem; max-height: 7rem;">
                <h5 class="card-title"><% =item.Servicio.Descripcion %></h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
            </div>
            <ul class="list-group list-group-flush" style="height: 20rem; margin-top: 6rem;color:black">
                <li class="list-group-item">Fecha Inicio: <%=item.FechaCompra %></li>
                <li class="list-group-item">Fecha Fin: <%=item.FechaCancelacion %></li>
                <li class="list-group-item">Administrador: <% =item.Usuario.Nombre%> </li>
                <li class="list-group-item">Grupo Soporte: <% =item.GrupoSoporte%> </li>
            </ul>
            <div class="card-body">
                <a href="#" class="card-link">Crear Ticket Soporte</a>
                <a href="#" class="card-link">Dar de baja</a>
            </div>
        </div>

        <%}%>
    </div>
</asp:Content>

