<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="True" CodeBehind="Tickets.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.Tickets" MaintainScrollPositionOnPostback="True" %>



<asp:Content ID="Tickets" ContentPlaceHolderID="Header" runat="server">
    <div class="d-flex contenedor-sidebar">
        <div class="bg-primary sidebar-usuarios">
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
                <a href="TicketsPendientes.aspx" class="opcoines">TicketsPendientes</a>
                <a href="Tickets.aspx" class="opcoines">Historico Tickets</a>


                <!-- sidebar-search  -->
      <div class="sidebar-menu">
        <ul>
          <li class="header-menu">
            <span>General</span>
          </li>
          <li class="sidebar-dropdown">
            <a href="#">
              <i class="fa fa-tachometer-alt"></i>
              <span>Dashboard</span>
              <span class="badge badge-pill badge-warning">New</span>
            </a>
            <div class="sidebar-submenu">
              <ul>
                <li>
                  <a href="#">Dashboard 1
                    <span class="badge badge-pill badge-success">Pro</span>
                  </a>
                </li>
                <li>
                  <a href="#">Dashboard 2</a>
                </li>
                <li>
                  <a href="#">Dashboard 3</a>
                </li>
              </ul>
            </div>
          </li>
          <li class="sidebar-dropdown">
            <a href="#">
              <i class="fa fa-shopping-cart"></i>
              <span>E-commerce</span>
              <span class="badge badge-pill badge-danger">3</span>
            </a>
            <div class="sidebar-submenu">
              <ul>
                <li>
                  <a href="#">Products

                  </a>
                </li>
                <li>
                  <a href="#">Orders</a>
                </li>
                <li>
                  <a href="#">Credit cart</a>
                </li>
              </ul>
            </div>
          </li>
          <li class="sidebar-dropdown">
            <a href="#">
              <i class="far fa-gem"></i>
              <span>Components</span>
            </a>
            <div class="sidebar-submenu">
              <ul>
                <li>
                  <a href="#">General</a>
                </li>
                <li>
                  <a href="#">Panels</a>
                </li>
                <li>
                  <a href="#">Tables</a>
                </li>
                <li>
                  <a href="#">Icons</a>
                </li>
                <li>
                  <a href="#">Forms</a>
                </li>
              </ul>
            </div>
          </li>
          <li class="sidebar-dropdown">
            <a href="#">
              <i class="fa fa-chart-line"></i>
              <span>Charts</span>
            </a>
            <div class="sidebar-submenu">
              <ul>
                <li>
                  <a href="#">Pie chart</a>
                </li>
                <li>
                  <a href="#">Line chart</a>
                </li>
                <li>
                  <a href="#">Bar chart</a>
                </li>
                <li>
                  <a href="#">Histogram</a>
                </li>
              </ul>
            </div>
          </li>
          <li class="sidebar-dropdown">
            <a href="#">
              <i class="fa fa-globe"></i>
              <span>Maps</span>
            </a>
            <div class="sidebar-submenu">
              <ul>
                <li>
                  <a href="#">Google maps</a>
                </li>
                <li>
                  <a href="#">Open street map</a>
                </li>
              </ul>
            </div>
          </li>
          <li class="header-menu">
            <span>Extra</span>
          </li>
          <li>
            <a href="#">
              <i class="fa fa-book"></i>
              <span>Documentation</span>
              <span class="badge badge-pill badge-primary">Beta</span>
            </a>
          </li>
          <li>
            <a href="#">
              <i class="fa fa-calendar"></i>
              <span>Calendar</span>
            </a>
          </li>
          <li>
            <a href="#">
              <i class="fa fa-folder"></i>
              <span>Examples</span>
            </a>
          </li>
        </ul>
      </div>
      <!-- sidebar-menu  -->




            </div>
        </div>
       

        


        <div class="table-responsive">
            <asp:GridView ID="TicketGrid" CssClass="table table-bordered table-hover table-responsive tickets" AlternatingRowStyle-BackColor="#b5b5b5" runat="server" AutoGenerateColumns="False" DataSourceID="odsTickets" HorizontalAlign="Center" BackColor="White" BorderColor="#003366" BorderStyle="Double" ForeColor="#002346" OnSelectedIndexChanged="TicketGrid_SelectedIndexChanged1" ShowHeaderWhenEmpty="True" AllowPaging="True" AllowSorting="True" CellPadding="5" CellSpacing="5" ShowFooter="True">
                <AlternatingRowStyle BackColor="#B5B5B5"></AlternatingRowStyle>
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="GrupoSoporte" HeaderText="GrupoSoporte" SortExpression="GrupoSoporte" />
                    <asp:BoundField DataField="Usuario.Id" HeaderText="Usuario" SortExpression="Usuario" />
                    <asp:BoundField DataField="FechaApertura" HeaderText="FechaApertura" SortExpression="FechaApertura" />
                    <asp:BoundField DataField="FechaCierre" HeaderText="FechaCierre" SortExpression="FechaCierre" ApplyFormatInEditMode="True" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                    <asp:BoundField DataField="Solucion" HeaderText="Solucion" SortExpression="Solucion" ApplyFormatInEditMode="True" />
                    <asp:BoundField DataField="EstadoTicket" HeaderText="EstadoTicket" SortExpression="EstadoTicket" ApplyFormatInEditMode="True" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" ApplyFormatInEditMode="True" />
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
