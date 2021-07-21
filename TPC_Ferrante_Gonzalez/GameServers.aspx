<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameServers.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.GameServers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <div class="row">
        <div class="col-4">
            <asp:Image ID="imgJuego" runat="server" Style="height: 100px; width: 100px" />
        </div>
        <div class="col8">
           <asp:DataList ID="DataList1" runat="server">
               
           </asp:DataList>
        </div>
        
    </div>

</asp:Content>

