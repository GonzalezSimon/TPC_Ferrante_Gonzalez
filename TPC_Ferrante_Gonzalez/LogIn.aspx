<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.LogIn" %>

<asp:Content ID="UsuariosHeader" ContentPlaceHolderID="Header" runat="server">
    <div class="container login" style="align-items:center; height:45rem">
        <div class="d-flex justify-content-center h-100 login" style="align-items:center">
            <div class="card login "style="min-height: 410px;min-width:350px; margin:5rem">
                <div class="card-header login">
                    <img src="Imgs/LogoLogin.png" style="max-width: 15rem;" />
                    <div class="d-flex justify-content-end social_icon login">
                        <span><i class="fab fa-facebook-square"></i></span>
                        <span><i class="fab fa-google-plus-square"></i></span>
                        <span><i class="fab fa-twitter-square"></i></span>
                    </div>
                </div>
                <div class="card-body login">
                    <form style="margin: 10px">
                        <div class="input-group form-group login" style="justify-content: center;">
                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-user login"></i></span>
                            </div>
                            <input type="text" class="form-control login" placeholder="Usuario">
                        </div>
                        <div class="input-group form-group login" style="justify-content: center;">
                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-key"></i></span>
                            </div>
                            <input type="password" class="form-control login" placeholder="Contraseña">
                        </div>
                        <div class="row align-items-center remember login" style="margin-left: 0.1px">
                            <input type="checkbox">Recuerdame
				
                        </div>
                        <div class="form-group login">
                            <input type="submit" value="Ingresar" class="btn float-right login_btn login">
                        </div>
                    </form>
                </div>
                <div class="card-footer login">
                    <div class="d-flex justify-content-center links login">
                        Todavía no tenes cuenta?<a href="#">Registrate</a>
                    </div>
                    <div class="d-flex justify-content-center login">
                        <a href="#">Olvidaste tu contraseña?</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
