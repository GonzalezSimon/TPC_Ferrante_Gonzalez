﻿<%@ Page Language="C#" MasterPageFile="~/SideBar.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.Usuarios" %>

<asp:Content ID="UsuariosHeader" ContentPlaceHolderID="Header" runat="server">

    <div class="container-fluid">
        <div class="row">
           
            <div class="col-sm">
                <% foreach (Dominio.ServicioContratado item in list)
                    { %>
               <div class="card mb-3" style="max-width: 100%;margin:2rem;background-color: rgba(0,0,0,0.7) !important; color: white;"">
                <div class="row no-gutters">
                    <div class="col-4" style="display: flex">
                        <img src="http://rotahost.com.ar/wp-content/uploads/2020/10/cropped-20200407144605-2-2-1586272081.png" alt="..." style="max-width: 90%; align-items: center; margin: 10px">
                    </div>
                    <div class="col" style="display: flex">
                        <div class="card-body">
                            <h5 class="card-title"><% =item.Servicio.Descripcion %></h5>
                            <p>Fecha Inicio: <%=item.FechaCompra %></p>
                            <p>Fecha Fin:<%=item.FechaCancelacion %></p>
                            <p>Administrador:  <% =item.Usuario.Nombre%></p>
                            <p>Grupo Soporte: <% =item.GrupoSoporte%>></p>
                        </div>
                    </div>
                    <div class="col-2">
                        <div class="row" style="width: 100%">
                            <asp:Button ID="Button1" runat="server" Text="Ticket Soporte" class="btn btn-outline-success my-2 my-sm-0 btnNavbar" Style="width: 100%; margin-left: 2rem;" />
                        </div>
                        <div class="row" style="width: 100%">
                            <asp:Button ID="Button2" runat="server" Text="Dar de baja" class="btn btn-outline-success my-2 my-sm-0 btnNavbar" Style="width: 100%; margin-left: 2rem;" />
                        </div>
                    </div>
                </div>
               </div>

                <%}%>
                <div class="card mb-3" style="max-width: 100%;margin:2rem;background-color: rgba(0,0,0,0.7) !important; color: white;"">
                <div class="row no-gutters">
                    <div class="col-4" style="display: flex">
                        <img src="Imgs/LogoLogin.png" alt="..." style="max-width: 90%; align-items: center; margin: 10px">
                    </div>
                    <div class="col" style="display: flex">
                        <div class="card-body">
                            <h5 class="card-title"><% %></h5>
                            <p>Fecha Inicio: <%%></p>
                            <p>Fecha Fin:<% %></p>
                            <p>Administrador:  <% %></p>
                            <p>Grupo Soporte: <% %>></p>
                        </div>
                    </div>
                    <div class="col-2">
                        <div class="row" style="width: 100%">
                            <asp:Button ID="Button3" runat="server" Text="Ticket Soporte" class="btn btn-outline-success my-2 my-sm-0 btnNavbar" Style="width: 100%; margin-left: 2rem;" />
                        </div>
                        <div class="row" style="width: 100%">
                            <asp:Button ID="Button4" runat="server" Text="Dar de baja" class="btn btn-outline-success my-2 my-sm-0 btnNavbar" Style="width: 100%; margin-left: 2rem;" />
                        </div>
                    </div>
                </div>
               </div>
            </div>


        </div>
    </div>

</asp:Content>

