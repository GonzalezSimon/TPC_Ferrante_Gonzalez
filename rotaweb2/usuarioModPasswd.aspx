<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usuarioModPasswd.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.usuarioModPasswd" MasterPageFile="SideBar.Master"%>

<asp:Content ID="UsuarioModPasswd" ContentPlaceHolderID="Header" runat="server">

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
                            <h6 style="color: antiquewhite;">Contraseña de usuario:</h6>
                        </div>
                        <div class="row" style="padding-top: 1vh">

                            <asp:TextBox ID="txtPasswrd" runat="server" type="password" AutoComplete="off" placeholder="Nueva contraseña" Style=" margin-left: 1.5vh"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="rfvPass" runat="server" ErrorMessage="Ingrese y confirme su contraeña" ControlToValidate="txtPasswrd" EnableTheming="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="txtPasswrdConf" runat="server" type="password" AutoComplete="off" placeholder="Confirmar contraseña" Style=" margin-left: 1.5vh"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPassConf" runat="server" ErrorMessage="Ingrese y confirme su contraeña" ControlToValidate="txtPasswrdConf" EnableTheming="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="cvPasswords" ControlToCompare="txtPasswrd" ControlToValidate="txtPasswrdConf" runat="server" ErrorMessage="Las contraseñas no coinciden!" ForeColor="#CC0000"></asp:CompareValidator>
                        </div>

                        


                        <div style="text-align: center">
                    <asp:Button ID="btnEnviarUsuario" runat="server" class="btn btn-primary form-control clearfix" Style="margin-bottom: 2vh; justify-content: center;" Text="Cambiar Contraseña" OnClientClick="return validarPasswordCamb();" OnClick="btnEnviarUsuario_Click"/>
                </div>

                        <div class="col-1">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
