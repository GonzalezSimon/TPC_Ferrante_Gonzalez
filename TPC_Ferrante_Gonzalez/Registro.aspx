﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <div class="container login" style="align-items: center; height: 45rem">
        <div class="d-flex justify-content-center h-100 login" style="align-items: center">
            <div class="card login" style="min-height: 95%; min-width: 60%; margin: 3rem">
                <div class="card-header login">
                    <div class="row justify-content-center">
                        <img src="Imgs/LogoLogin.png" style="max-width: 15rem;" />
                    </div>
                </div>
                <div class="card-body login">
                    <div style="margin: 10px">
                        <div class="input-group form-group login" style="justify-content: center;">
                            <div class="row">
                                <div class="col-6">
                                    <div class="input-group-prepend login ">
                                        <span class="input-group-text login"><i class="fas fa-user login"></i></span>
                                        <asp:TextBox ID="txtNombre" runat="server" class="form-control login" placeholder="Nombre" autocomplete="given-name"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Ingrese su nombre" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="col-6">
                                    <asp:TextBox ID="txtApellido" runat="server" class="form-control login" placeholder="Apellido" autocomplete="family-name"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="Ingrese su apellido" ControlToValidate="txtApellido"></asp:RequiredFieldValidator>
                                </div>
                            </div>

                        </div>
                        <div class="input-group form-group login" style="justify-content: center; margin-bottom: 1rem">

                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-user-ninja"></i></span>
                            </div>

                            <asp:TextBox ID="txtNombUsuario" runat="server" class="form-control login col-10" placeholder="Nombre de Usuario" autocomplete="username"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="Ingrese su nombre de usuario" ControlToValidate="txtNombUsuario"></asp:RequiredFieldValidator>

                        </div>
                        <div class="input-group form-group login" style="justify-content: center; margin-bottom: 1.5rem">

                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-phone-volume"></i></span>
                            </div>

                            <asp:TextBox ID="txtTelefono" runat="server" class="form-control login col-10" type="tel" placeholder="Telefono" autocomplete="current-password"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ErrorMessage="Ingrese un numero te telefono" ControlToValidate="txtTelefono"></asp:RequiredFieldValidator>

                        </div>
                        <div class="input-group form-group login" style="justify-content: center; margin-bottom: 1.5rem">
                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-at"></i></span>
                            </div>
                            <asp:TextBox ID="txtMail" runat="server" class="form-control login col-10" type="email" placeholder="Mail" autocomplete="email"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvMail" runat="server" ErrorMessage="Ingrese su mail" ControlToValidate="txtMail"></asp:RequiredFieldValidator>
                        </div>
                        <div class="input-group form-group login" style="justify-content: center; margin-bottom: 1.5rem">
                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-key"></i></span>
                            </div>
                            <asp:DropDownList ID="dwlLocalidad" runat="server"></asp:DropDownList>
                        </div>
                        <div class="input-group form-group login" style="justify-content: center; margin-bottom: 1.5rem">
                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-key"></i></span>
                            </div>
                            <asp:TextBox ID="txtPass" runat="server" class="form-control login col-10" type="password" placeholder="Contraseña" autocomplete="current-password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Ingrese su contraseña" ControlToValidate="txtPass"></asp:RequiredFieldValidator>

                        </div>
                        <div class="input-group form-group login" style="justify-content: center; margin-bottom: 1.5rem">
                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-camera-retro"></i></span>
                            </div>
                            <asp:FileUpload ID="fuImagenUsuario" runat="server" text="Elija su Imagen" class="form-control login col-10" />
                            <asp:RequiredFieldValidator ID="rfvImgUser" runat="server" ErrorMessage="Adjunte su imagen de usuario" ControlToValidate="fuImagenUsuario"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group login " style="margin-bottom: 1.5rem">
                            <div class="row justify-content-center">
                                <asp:Button ID="btnIngresar" runat="server" Text="Enviar" class="btn login_btn login" OnClick="btnIngresar_Click" />
                            </div>

                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>

