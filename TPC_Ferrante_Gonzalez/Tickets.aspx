<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tickets.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.Tickets" %>

<asp:Content ID="AdminHeader" ContentPlaceHolderID="Header" runat="server">
    <div class="d-flex contenedor-sidebar">
        <div class="bg-primary sidebar-usuarios">
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
    
    <div class="table-responsive">
        <asp:GridView ID="TicketGrid" CssClass="table table-bordered table-hover table-responsive tickets" AlternatingRowStyle-BackColor="#b5b5b5" runat="server" AutoGenerateColumns="False" DataSourceID="odsTickets" HorizontalAlign="Center" BackColor="White" BorderColor="#003366" BorderStyle="Double" ForeColor="#002346" OnSelectedIndexChanged="TicketGrid_SelectedIndexChanged" ShowHeaderWhenEmpty="True" AllowPaging="True" AllowSorting="True" CellPadding="5" CellSpacing="5" ShowFooter="True">
<AlternatingRowStyle BackColor="#B5B5B5"></AlternatingRowStyle>
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Numero Ticket" SortExpression="Id" />
                <asp:BoundField DataField="GrupoSoporte" HeaderText="GrupoSoporte" SortExpression="GrupoSoporte" />
                <asp:BoundField DataField="FechaApertura" HeaderText="Fecha Apertura" SortExpression="FechaApertura" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="FechaCierre" HeaderText="Fecha Cierre" SortExpression="FechaCierre" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" SortExpression="Descripcion" />
                <asp:BoundField DataField="Solucion" HeaderText="Solución" SortExpression="Solucion" />
                <asp:BoundField DataField="EstadoTicket" HeaderText="Estado Ticket" SortExpression="EstadoTicket" />
                <asp:ButtonField Text="<i class='fa fa-reply'> Solucionar</i>" ControlStyle-CssClass="btn btn-primary"><ControlStyle CssClass="btn btn-primary"></ControlStyle>
                </asp:ButtonField>
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


            <div class="card" style="text-align:center;">

                <asp:Label ID="lblSolucion" runat="server" Text="Solucionar Ticket: " CssClass="custom-control-label col-sm-2"></asp:Label>

            <div class="col-sm-10">
                <asp:TextBox ID="txtSolucion" runat="server" TextMode="MultiLine" CssClass="form-control text-ticket"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvSolucion" runat="server" ErrorMessage="Campo Obligatorio" Display="None" ControlToValidate="txtSolucion"></asp:RequiredFieldValidator>
            </div>
            <div style="text-align:center">
                <asp:Button ID="btnSolucionar" runat="server" Text="Solucionar" CssClass="btn btn-primary form-control" OnClick="btnSolucionar_Click"/>
            </div>

            </div>

</asp:Content>
