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
                                </div>
                                <div class="row">
                                    <div class="card text-white bg-dark mb-3" style="min-width: 100%;">
                                        <div class="row justify-content-center align-items-center minh-100">
                                            <div class="col-md-4">
                                                
                                                    <asp:Image class="img-fluid rounded mx-auto d-block" ID="imgJuego" runat="server" Style="max-width: 100%" ImageUrl="~/ImgJuegos/ark.png" />
                                                
                                            </div>
                                            <div class="col-md-8 ">
                                                <div class="card-body">
                                                    <asp:Label ID="lblDescripcion" class="card-title" runat="server" Text="Label"></asp:Label>
                                                    <hr />
                                                    <p class="card-text">
                                                         <asp:Label ID="Label1" class="card-title" runat="server" Text="Slots:"></asp:Label>
                                                        <asp:Label ID="lblSlots" runat="server" Text="Label"></asp:Label>
                                                    </p>
                                                    <p class="card-text">
                                                        <asp:Label ID="Label2" class="card-title" runat="server" Text="Precio:"></asp:Label>
                                                        <hr />
                                                        <asp:Label ID="lblPrecio" style="font-size:30px;color:yellow" runat="server" Text="Label"></asp:Label>
                                                        <p>
                                                        </p>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                   
                                </div>
                                <div class=" row justify-content-center align-items-center minh-100">
                                    <asp:Button ID="btnEnviar" class="btn float-right login_btn login" style="min-width:100%" runat="server" Text="Mercado Pago" OnClick="btnEnviar_Click" />
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
