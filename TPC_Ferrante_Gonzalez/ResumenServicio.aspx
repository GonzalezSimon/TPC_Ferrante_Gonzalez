<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResumenServicio.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.ResumenServicio" MasterPageFile="Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container login" style="align-items: center; height: 45rem">
                <div class="d-flex justify-content-center h-100 login" style="align-items: center">
                    <div class="card login" style="min-height: 95%; min-width: 60%; margin: 3rem">
                        <div class="card-header login">
                            <div class="row justify-content-center">
                                <img src="Imgs/LogoLogin.png" style="max-width: 15rem;" />
                            </div>
                        </div>
                        <div class="card-body login">
                            <div class="col">
                                <div class="row">
                                    <asp:Label ID="lblDescripcion" runat="server" Text="Label"></asp:Label>
                                </div>
                                <div class="row">
                                    <div class="col-4">
                                        <asp:Image ID="imgJuego" runat="server" Style="max-width: 8vh" ImageUrl="~/ImgJuegos/ark.png" />
                                    </div>
                                    <div class="col-8">
                                        <div class="col-4">
                                             <asp:Label ID="lblSlots" runat="server" Text="Label"></asp:Label>
                                        </div>
                                        <div class="col-4">
                                             <asp:Label ID="lblPrecio" runat="server" Text="Label"></asp:Label>
                                        </div>
                                    </div
                                </div>
                                <div class="row">
                                    <asp:Button ID="btnEnviar" class="btn float-right login_btn login" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>