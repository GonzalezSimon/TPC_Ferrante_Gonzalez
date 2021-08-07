<%@ Page Title="" Language="C#" MasterPageFile="SideBarAdmins.Master" AutoEventWireup="true" CodeBehind="CargaJuegos.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.CargaJuegos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <div class="container login" style="align-items: center; height: 45rem">
        <div class="d-flex justify-content-center h-100 login" style="align-items: center">
            <div class="card login" style="min-height: 80%; min-width: 60%; margin: 5rem">
                <div class="card-header login">
                    <div class="row justify-content-center">
                        <img src="Imgs/LogoLogin.png" style="max-width: 15rem;" />
                    </div>
                </div>
                <div class="card-body login">
                    <div style="margin: 10px">
                        <div class="input-group form-group login" style="justify-content: left;">
                            <div class="input-group-prepend login ">
                                <span class="input-group-text login"><i class="fas fa-user login"></i></span>
                            </div>
                                <asp:TextBox ID="txtNombre" runat="server" class="form-control login col-10" placeholder="Nombre del Juego" autocomplete="off"></asp:TextBox>

                        </div>
                        <div class="input-group form-group login" style="justify-content: left; margin-bottom: 2rem">

                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-user-ninja"></i></span>
                            </div>

                            <asp:TextBox ID="txtEmpresa" runat="server" class="form-control login col-10" placeholder="Nombre de la Empresa" autocomplete="username"></asp:TextBox>
                            <!--<input type="password" class="form-control login" placeholder="Contraseña">-->
                        </div>
                        <div class="input-group form-group login" style="justify-content: left; margin-bottom: 2rem">

                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-phone-volume"></i></span>
                            </div>
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            <!--<asp:TextBox ID="txtTelefono" runat="server" class="form-control login col-10" type="tel" placeholder="Telefono" autocomplete="current-password"></asp:TextBox>
                            -->
                        </div>
                        

                        <div class="form-group login">
                            <asp:Button ID="btnIngresar" runat="server" Text="Enviar" class="btn float-center login_btn login" OnClick="btnIngresar_Click" />

                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>

