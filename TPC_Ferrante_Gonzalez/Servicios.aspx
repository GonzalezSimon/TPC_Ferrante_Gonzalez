<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.Servicios" %>

<asp:Content ID="ServiciosHeader" ContentPlaceHolderID="Header" runat="server">

    <div id="carousel-Servicios" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleCaptions" data-slide-to="1"></li>
            <li data-target="#carouselExampleCaptions" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" <!--javascript=".carousel('cycle')"-->>
            <div class="carousel-item active">
                <img src="Imgs/Valheim4.jpg" class="d-block w-100" alt="...">
                <div class="carousel-caption d-none d-md-block">
                    <h5>First slide label</h5>
                    <p>Some representative placeholder content for the first slide.</p>
                </div>
            </div>
            <div class="carousel-item">
                <img src="Imgs/ARKSurvival.jpg" class="d-block w-100" alt="...">
                <div class="carousel-caption d-none d-md-block">
                    <h5>Second slide label</h5>
                    <p>Some representative placeholder content for the second slide.</p>
                </div>
            </div>
            <div class="carousel-item">
                <img src="Imgs/7daystoday.jpg" class="d-block w-100" alt="...">
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

    <div>

        <div class="marginCard">


            <table>
                <tr>
                    <td>



                        <div class="card" style="width: 18rem; margin: 0rem 2rem;">
                            <img src="http://rotahost.com.ar/wp-content/uploads/2020/10/cropped-ss_ccc4ce6edd4c454b6ce7b0757e633b63aa93921d.1920x1080_1-1.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Card title</h5>
                                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            </div>
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item">An item</li>
                                <li class="list-group-item">A second item</li>
                                <li class="list-group-item">A third item</li>
                            </ul>
                            <div class="card-body">
                                <a href="#" class="card-link">Card link</a>
                                <a href="#" class="card-link">Another link</a>
                            </div>
                        </div>


                    </td>

                    <td>
                        <div class="card" style="width: 18rem;">
                            <img src="http://rotahost.com.ar/wp-content/uploads/2020/10/cropped-ss_ccc4ce6edd4c454b6ce7b0757e633b63aa93921d.1920x1080_1-1.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Card title</h5>
                                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            </div>
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item">An item</li>
                                <li class="list-group-item">A second item</li>
                                <li class="list-group-item">A third item</li>
                            </ul>
                            <div class="card-body">
                                <a href="#" class="card-link"><i class="fas fa-car"></i></a>
                                <a href="#" class="card-link">Another link</a>
                            </div>
                        </div>


                    </td>

                </tr>



            </table>
        </div>


    </div>
    <script src="JavaScript/functions.js" type="text/javascript"></script>
</asp:Content>
