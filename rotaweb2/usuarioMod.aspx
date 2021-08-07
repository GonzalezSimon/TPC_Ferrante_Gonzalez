<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usuarioMod.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.usuarioMod" MasterPageFile="SideBar.Master" %>

<asp:Content ID="UsuarioModSelf" ContentPlaceHolderID="Header" runat="server">

     <div class="col clearfix" style="background-color: rgba(0,0,0,0.8) !important; width: 100%; height: 100%; max-height: 95%; min-height: 761px; min-width: 460px;">
        <div class="row">
            <div class="col-1">
            </div>
            <div class="col-10">
                <div class="row" style="justify-content: center; margin: auto; padding: 2rem">
                    <div class="col-8">
                        <div class="row" style="padding-top: 3vh">
                            <asp:Label ID="lblModificarSub" runat="server" Text="Modificar Usuario" Style="padding-bottom: 1rem; color: antiquewhite; font-size: large;"></asp:Label>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Nombre del usuario:</h6>
                            <asp:Label ID="lblNombre" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">

                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-id-card"></i></span>
                            </div>

                            <asp:TextBox ID="txtNombre" runat="server" placeholder="Nuevo nombre" Style=" margin-left: 0vh"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Ingrese su Nombre" ControlToValidate="txtNombre" EnableTheming="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Apellido de usuario:</h6>
                            <asp:Label ID="lblApellido" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">

                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-id-card-alt"></i></span>
                            </div>
                            <asp:TextBox ID="txtApellido" runat="server" placeholder="Nuevo apellido" Style=" margin-left: 0vh"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="rfvApe" runat="server" ErrorMessage="Ingrese su Apellido" ControlToValidate="txtApellido" EnableTheming="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </div>


                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Telefono de usuario:</h6>
                            <asp:Label ID="lblTelefono" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">

                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-phone"></i></span>
                            </div>
                            <asp:TextBox ID="txtTelefono" runat="server" placeholder="Nuevo telefono" Style=" margin-left: 0vh"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="rfvTel" runat="server" ErrorMessage="Ingrese un Telefono" ControlToValidate="txtTelefono" EnableTheming="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </div>

                        <div class="row" style="padding-top: 3vh">

                            

                            <h6 style="color: antiquewhite;">Mail de usuario:</h6>
                            <asp:Label ID="lblMail" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">

                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-mail-bulk"></i></span>
                            </div>
                            <asp:TextBox ID="txtMail" runat="server" placeholder="Nuevo mail" Style=" margin-left: 0vh"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvMail" runat="server" ErrorMessage="Ingrese un Mail Valido" ControlToValidate="txtMail" EnableTheming="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </div>


                        <div class="row" style="padding-top: 3vh; justify-content:center;">
                            <img class="img-responsive img-rounded" style="max-width: 12rem; max-height: 12rem;" src="<%=usuario.URLimagen %>" alt="https://raw.githubusercontent.com/azouaoui-med/pro-sidebar-template/gh-pages/src/img/user.jpg">
                        </div>
                        <div class="row" style="padding-top:1vh;"></div>


                        <div class="input-group form-group login" style="justify-content: center; margin-bottom: 1.5rem; padding-top: 3vh">
                            <div class="input-group-prepend login">
                                <span class="input-group-text login"><i class="fas fa-camera-retro"></i></span>
                            </div>
                            <asp:FileUpload ID="fuImagenUsuario" runat="server" text="Elija su Imagen" class="form-control login col-10"/>

                        </div>


                        <div style="text-align: center">
                    <asp:Button ID="btnEnviarUsuario" runat="server" class="btn btn-primary form-control clearfix" Style="margin-bottom: 2vh; justify-content: center;" Text="Modificar Usuario" OnClick="btnEnviarUsuario_Click" />
                </div>

                        <div class="col-1">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>