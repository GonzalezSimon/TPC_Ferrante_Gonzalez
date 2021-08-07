<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.Home" %>

<asp:Content ID="HomeHeader" ContentPlaceHolderID="Header" runat="server">
<div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
                <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
                <li data-target="#carouselExampleCaptions" data-slide-to="1"></li>
                <li data-target="#carouselExampleCaptions" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner" javascript=".carousel('cycle')">
                <div class="carousel-item active" >
                    <img src="Imgs/BackGround/Valheim-Carousel-full-Screen.jpg" class="d-block w-100" alt="...">
                    <div class="carousel-caption d-none d-md-block">
                        <h5></h5>
                        <p></p>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="Imgs/BackGround/ARK-Carousel-full-Screen.jpg" class="d-block w-100" alt="...">
                    <div class="carousel-caption d-none d-md-block">
                        <h5></h5>
                        <p></p>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="Imgs/BackGround/7Dtd-Carousel-full-Screen.jpg" class="d-block w-100" alt="...">
                    <div class="carousel-caption d-none d-md-block">
                        <h5></h5>
                        <p></p>
                    </div>
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>

        
    </asp:Content>
<asp:Content ID="Servicios" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container login " style="align-items: center; height: 45rem; min-width:150vh">
                <div class="d-flex justify-content-center h-100 login" style="align-items: center">
                    <div class="card login" style="min-height: 95%; min-width: 85%; margin: 2rem">
                        <div class="card-header login">
                            <div class="row justify-content-center">
                                <img src="Imgs/LogoLogin.png" style="max-width: 15rem;" />
                            </div>
                        </div>
                        <div class="card-body login">
                            <div class="col">
                                <div class="row">
                                    <div class="card text-white bg-dark mb-3" style="min-width: 100%;">
                                        <div class="row justify-content-center align-items-center minh-100">
                                            <div class="col-md-12 ">
                                                <div class="card-body">

                                                    <p class="card-text">
                                                         <h2>Somos ese hosting que estabas buscando</h2>
                                                    </p>
                                                    <p class="card-text">
                                                        <h4>En ROTA HOST, brindamos un servicio de excelencia sin elevar tus costos, es por eso que contamos con todos los recursos para que tengas una experiencia única.
Contamos con atención personalizada, para poder obtener el mejor soporte sin importar el juego que elijas.
Nuestro Data Center esta úbicado en Argentina, de esa manera la experiencia será lo mas fluido posible, y así podrás explotar el 100% de tus habilidades.</h4>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                 </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


</asp:Content>