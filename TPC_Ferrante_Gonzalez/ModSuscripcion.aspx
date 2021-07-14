<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModSuscripcion.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.ModSuscripcion" MasterPageFile="SideBar.Master" %>

<asp:Content ID="ModSuscripcion" ContentPlaceHolderID="Header" runat="server">

    <div class="col clearfix" style="background-color: rgba(0,0,0,0.8) !important; width: 100%; height: 100%; max-height: 95%; min-height: 761px; min-width: 460px;">
        <div class="row">
            <div class="col-1">
            </div>
            <div class="col-8">
                <div class="row" style="margin: auto; padding: 2rem">
                    <div class="col-6">
                        <div class="row">
                            <asp:Label ID="lblModificarSub" runat="server" Text="Modificar Suscripción" Style="padding-bottom: 1rem; color: antiquewhite;"></asp:Label>
                        </div>
                        <div class="row">
                            <asp:DropDownList ID="lstSubs" class="btn btn-secondary dropdown-toggle" runat="server" AutoPostBack="false" placeholder="Elija su subscripcion..." Style="width: auto; max-width: 100%"></asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row" style="margin: auto; padding: 2rem">
                    <div class="col">
                        <div class="row">
                            <asp:Label ID="Label2" runat="server" Text="Titulo" Style="padding-bottom: 1rem; color: antiquewhite;"></asp:Label>
                        </div>
                        <div class="row">
                            <asp:TextBox ID="txtTitulo" class="btn btn-light dropdown-toggle " runat="server" placeholder="Su problema..." Style="width: 50%; max-width: 80%; text-align: left; color: antiquewhite;"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row" style="margin: auto;">
                    <div class="col">
                        <div class="row">
                            <asp:Label ID="Label3" runat="server" Text="Descripcion" Style="padding-bottom: 1rem; color: antiquewhite;"></asp:Label>
                        </div>
                        <div class="row">
                            <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Class="text-ticket" Style="height: 18rem"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row" style="margin: auto; padding: 2rem">
                    <div class="col">
                        <div style="text-align: center">
                            <asp:Button ID="btnEnviar" runat="server" class="btn btn-primary form-control" Text="Enviar" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-1">
            </div>
        </div>
    </div>

</asp:Content>
