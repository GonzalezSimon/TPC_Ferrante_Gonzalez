<%@ Page Title="Tickets" Language="C#" MasterPageFile="~/SideBar.Master" AutoEventWireup="true" CodeBehind="TicketeraUsuarios.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.TicketeraUsuarios" %>

<asp:Content ID="TKUsuarios" ContentPlaceHolderID="Header" runat="server">
    <div class="col clearfix" style="background-color: rgba(0,0,0,0.8) !important; width: 100%; height: 100%; max-height: 95%; min-height: 761px; min-width: 460px;">
        <div class="row tkUsGeneral">
            <div class="col-1">
            </div>
            <div class="col-10 colPrincipal">
                <asp:UpdatePanel ID="UPDListas" runat="server">
                    <ContentTemplate>
                        <div class="row primera" style="margin: auto; padding: 2rem;padding-left:0">
                    <div class="col-10" style="padding-left:0">
                        <div class="row titulos ">
                            <div class="col-5">
                                <asp:Label ID="Label1" runat="server" class="align-items-center" Text="Susscripciones" Style="padding-bottom: 1rem; color: antiquewhite;"></asp:Label>
                            </div>
                            <div class="col-6">
                               <!-- <asp:Label runat="server" Text="Alias:" Style="padding:2rem;padding-bottom: 1rem; color: antiquewhite;"></asp:Label>-->
                            </div>
                        </div>
                        <div class="row controles">
                            <asp:DropDownList ID="lstSubs" class="btn btn-secondary dropdown-toggle col-5" runat="server" AutoPostBack="True" placeholder="Elija su subscripcion..." Style="width: auto;margin:1rem; max-width: 100%" OnSelectedIndexChanged="lstSubs_SelectedIndexChanged"></asp:DropDownList>

                            <asp:Label ID="lblAlias" runat="server" Text="Subscripciones" Style="padding-bottom: 1rem; color: antiquewhite;"></asp:Label>
                        </div>
                    </div>
                </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="row segunda" style="margin: auto; padding: 2rem;padding-left:0">
                    <div class="col">
                        <div class="row titulos" style="padding-left:0">
                            <asp:Label ID="lblTitulo" runat="server" Text="Titulo" Style="padding-bottom: 1rem;color:whitesmoke"></asp:Label>
                        </div>
                        <div class="row controles">
                            <asp:TextBox ID="txtTitulo" class="btn btn-light dropdown-toggle " runat="server" placeholder="Su problema..." Style="width: 50%; max-width: 80%;
                       color:dimgrey;text-align: left;"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row tercera" style="margin: auto;">
                    <div class="col">
                        <div class="row titulos">
                            <asp:Label ID="Label3" runat="server" Text="Descripcion" Style="padding-bottom: 1rem; color: antiquewhite;"></asp:Label>
                        </div>
                        <div class="row controles">
                            <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Class="text-ticket" Style="height: 18rem;width:100%"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row cuarta" style="margin: auto; padding: 2rem">
                    <div class="col">
                        <div style="text-align: center">
                            <asp:Button ID="btnEnviar" runat="server" class="btn btn-primary form-control" OnClick="btnEnviar_Click" Text="Enviar" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-1">
            </div>
        </div>
    </div>

</asp:Content>

