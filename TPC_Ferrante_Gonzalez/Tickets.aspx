﻿<%@ Page Language="C#" MasterPageFile="~/SideBar.Master" AutoEventWireup="True" CodeBehind="Tickets.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.Tickets" MaintainScrollPositionOnPostback="True" %>



<asp:Content ID="Tickets" ContentPlaceHolderID="Header" runat="server">
    <div class="d-flex contenedor-sidebar">
        <!--<div class="bg-primary sidebar-usuarios">
            <div class="logo">
                <img src="<%= usuario.URLimagen %>" alt="..." class="imglogo">
            </div>
            <div class="">
                <ul class="list-group list-group-flush">
                    <li class="list-group-item">Bienvenido <%=usuario.FechaCreacion %> <%=usuario.Nombre%>!</li>
                    <li class="list-group-item">Fecha creación de usuario: <%=usuario.FechaCreacion %></li>
                    <li class="list-group-item">A third item</li>
                </ul>
                <a href="Home.aspx" class="opcoines">Homiado</a>
            </div>
        </div>-->

        <div class="table-responsive"style="margin-top:8rem">
            <asp:GridView ID="TicketGrid" CssClass="table table-bordered table-hover table-responsive tickets" AlternatingRowStyle-BackColor="#b5b5b5" runat="server" AutoGenerateColumns="False" DataSourceID="odsTickets" HorizontalAlign="Center" BackColor="White" BorderColor="#003366" BorderStyle="Double" ForeColor="#002346" OnSelectedIndexChanged="TicketGrid_SelectedIndexChanged1" ShowHeaderWhenEmpty="True" AllowPaging="True" AllowSorting="True" CellPadding="5" CellSpacing="5" ShowFooter="True">
                <AlternatingRowStyle BackColor="#B5B5B5"></AlternatingRowStyle>
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="GrupoSoporte" HeaderText="GrupoSoporte" SortExpression="GrupoSoporte" />
                    <asp:BoundField DataField="Usuario.Id" HeaderText="Usuario" SortExpression="Usuario" />
                    <asp:BoundField DataField="FechaApertura" HeaderText="FechaApertura" SortExpression="FechaApertura" />
                    <asp:BoundField DataField="FechaCierre" HeaderText="FechaCierre" SortExpression="FechaCierre" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                    <asp:BoundField DataField="Solucion" HeaderText="Solucion" SortExpression="Solucion" />
                    <asp:BoundField DataField="EstadoTicket" HeaderText="EstadoTicket" SortExpression="EstadoTicket" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                    <asp:ButtonField CommandName="Select" Text="ELBOTON" />
                </Columns>
                <HeaderStyle ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle VerticalAlign="Middle" />
            </asp:GridView>
            <asp:ObjectDataSource ID="odsTickets" runat="server" SelectMethod="listar" TypeName="Negocio.NegocioTicket">
                <SelectParameters>
                    <asp:Parameter Name="consulta" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>

    </div>


    <div class="card" style="text-align: center;">

        <asp:Label ID="lblSolucion" runat="server" Text="Solucionar Ticket: " CssClass="custom-control-label col-sm-2"></asp:Label>

        <div class="col-sm-10">
            <asp:TextBox ID="txtSolucion" runat="server" TextMode="MultiLine" CssClass="form-control text-ticket"></asp:TextBox>
        </div>
        <div style="text-align: center">
            <asp:Button ID="Solucionar" runat="server" CssClass="btn btn-primary form-control" OnClick="btnSolucionar_Click" Text="Solucionar" />
        </div>
    </div>
</asp:Content>
