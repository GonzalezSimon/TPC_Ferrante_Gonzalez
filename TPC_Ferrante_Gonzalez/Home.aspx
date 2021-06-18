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
                    <img src="http://rotahost.com.ar/wp-content/uploads/2020/10/cropped-20200407144605-2-2-1586272081.png" class="d-block w-100" alt="...">
                    <div class="carousel-caption d-none d-md-block">
                        <h5>First slide label</h5>
                        <p>Some representative placeholder content for the first slide.</p>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="http://rotahost.com.ar/wp-content/uploads/2020/10/cropped-ss_ccc4ce6edd4c454b6ce7b0757e633b63aa93921d.1920x1080_1-1.png" class="d-block w-100" alt="...">
                    <div class="carousel-caption d-none d-md-block">
                        <h5>Second slide label</h5>
                        <p>Some representative placeholder content for the second slide.</p>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="http://rotahost.com.ar/wp-content/uploads/2020/10/cropped-ss_ccc4ce6edd4c454b6ce7b0757e633b63aa93921d.1920x1080_1-1.png" class="d-block w-100" alt="...">
                    <div class="carousel-caption d-none d-md-block">
                        <h5>Third slide label</h5>
                        <p>Some representative placeholder content for the third slide.</p>
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
</asp:Content>