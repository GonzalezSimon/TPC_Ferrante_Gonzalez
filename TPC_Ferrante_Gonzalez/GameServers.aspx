<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameServers.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.GameServers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <style>
        .carousel-item{
            min-height:400px;
            background-size:cover;
            
        }
    </style>

    <div id="carouselExampleFade" class="carousel slide carousel-fade" style="z-index:-1000;" data-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="Imgs/BackGround/Valheim-Carousel-full-Screen.jpg" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
                <img src="Imgs/BackGround/7Dtd-Carousel-full-Screen.jpg" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
                <img src="Imgs/BackGround/ARK-Carousel-full-Screen.jpg" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
                <img src="Imgs/BackGround/CSGO-Carousel-full-Screen.jpg" class="d-block w-100" alt="...">
            </div>
        </div>
      
    </div>
    <div class="card-img-overlay">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="container login" style="align-items: center; ">
                    <div class="d-flex justify-content-center h-100 login" style="align-items: center">
                        <div class="card login"style="min-height: 30.5rem;min-width: 60%;height: 43rem;background-color: rgba(0,0,0,0.85) !important;">
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
                                                <div class="col-1"></div>
                                                <div class="col-md-4">

                                                    <asp:Image class="img-fluid rounded mx-auto d-block" ID="imgJuego" runat="server" Style="max-width: 100%" ImageUrl="~/ImgJuegos/ark.png" />

                                                </div>
                                                <div class="col-md-7 ">
                                                    <div class="card-body">
                                                        <asp:DropDownList ID="dlJuego" class="btn btn-secondary dropdown-toggle justify-content-center" Style="margin: 2rem; margin-left:0; min-width: 95%" runat="server" OnSelectedIndexChanged="dlJuego_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                                        <hr />
                                                        <asp:DropDownList ID="dlServicio" class="btn btn-secondary dropdown-toggle justify-content-center" Style="margin: 2rem; margin-left:0; min-width: 95%" runat="server"></asp:DropDownList>

                                                    </div>
                                                </div>
                                                
                                            </div>
                                        </div>
                                    </div>
                                    <div class=" row justify-content-center align-items-center minh-100">
                                        <asp:Button ID="btnEnviar" class="btn float-right login_btn login" Style="min-width: 100%" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                                    </div>
                                </div>
                                <!--<div class="card-body login">
                            <div class="col">
                                <div class="row">
                                  
                                </div>
                                <div class="row">
                                    <div class="col-4">
                                        
                                    </div>
                                    <div class="col-8">
                                        

                                    </div>
                                </div>
                                <div class="row">
                                  
                                </div>
                            </div>

                        </div>-->

                            </div>
                        </div>
                    </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>

