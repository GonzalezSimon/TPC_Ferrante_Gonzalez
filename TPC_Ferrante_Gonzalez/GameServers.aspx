<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameServers.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.GameServers" %>

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
                                    <asp:DropDownList ID="dlJuego" class="btn btn-secondary dropdown-toggle justify-content-center" Style="margin: 2rem; max-width: 95%" runat="server" OnSelectedIndexChanged="dlJuego_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                </div>
                                <div class="row">
                                    <div class="col-4">
                                        <asp:Image ID="imgJuego" runat="server" Style="max-width: 8vh" ImageUrl="~/ImgJuegos/ark.png" />
                                    </div>
                                    <div class="col-8">
                                        <asp:DropDownList ID="dlServicio" class="btn btn-secondary dropdown-toggle justify-content-center" Style="margin: 2rem; max-width: 95%" runat="server"></asp:DropDownList>

                                    </div>
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

