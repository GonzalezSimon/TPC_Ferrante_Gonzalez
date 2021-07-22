<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModUsuario.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.ModUsuario" MasterPageFile="SideBarAdmins.Master" %>

<asp:Content ID="ModUsuario" ContentPlaceHolderID="Header" runat="server">

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
                            <h6 style="color: antiquewhite;">Nombre de usuario:</h6>
                            <asp:Label ID="lblUsernName" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">
                            

                            <asp:TextBox ID="txtUserName" runat="server" placeholder="Nuevo nombre de Usuario" Style=" margin-left: 1.5vh"></asp:TextBox>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Contraseña de usuario:</h6>
                            <asp:Label ID="lblPassword" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">

                            <asp:TextBox ID="txtPasswrd" runat="server" type="password" placeholder="Nueva contraseña" Style=" margin-left: 1.5vh"></asp:TextBox>
                            <asp:TextBox ID="txtPasswrdConf" runat="server" placeholder="Confirmar contraseña" Style=" margin-left: 1.5vh"></asp:TextBox>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Nombre del usuario:</h6>
                            <asp:Label ID="lblNombre" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">


                            <asp:TextBox ID="txtNombre" runat="server" placeholder="Nuevo nombre" Style=" margin-left: 1.5vh"></asp:TextBox>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Apellido de usuario:</h6>
                            <asp:Label ID="lblApellido" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">


                            <asp:TextBox ID="txtApellido" runat="server" placeholder="Nuevo apellido" Style=" margin-left: 1.5vh"></asp:TextBox>
                        </div>


                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Telefono de usuario:</h6>
                            <asp:Label ID="lblTelefono" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">


                            <asp:TextBox ID="txtTelefono" runat="server" placeholder="Nuevo telefono" Style=" margin-left: 1.5vh"></asp:TextBox>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Mail de usuario:</h6>
                            <asp:Label ID="lblMail" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">


                            <asp:TextBox ID="txtMail" runat="server" placeholder="Nuevo mail" Style=" margin-left: 1.5vh"></asp:TextBox>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Localidad de usuario:</h6>
                            <asp:Label ID="lblLocalidad" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">
                            <h6 style="color: antiquewhite;">Modificar Localidad de usuario:(hay que buscar otra forma, capas un + para agregar localidades, o un trigger en la db)</h6>

                            <asp:TextBox ID="txtLocalidad" runat="server" placeholder="Nueva localidad" Style=" margin-left: 1.5vh"></asp:TextBox>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Tipo de usuario actual:</h6>
                            <asp:Label ID="lblTipoUsuario" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">
                            <h6 style="color: antiquewhite;">Modificar tipo de usuario:</h6>
                            <asp:DropDownList ID="lstModTipoUsuario" class="btn btn-secondary dropdown-toggle" runat="server" placeholder="Elija su subscripcion..." Style="width: auto; max-width: 100%; margin-left: 3vh;">
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Estado del servicio:</h6>
                            <asp:Label ID="lblEstadoUsuario" runat="server" Text="Vigencia" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">
                            <h6 style="color: antiquewhite;">Modificar Estado:</h6>
                            <asp:CheckBox ID="cbxEstadoUsuario" runat="server" />
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
