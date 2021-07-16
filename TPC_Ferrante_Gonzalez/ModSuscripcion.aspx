<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModSuscripcion.aspx.cs" Inherits="TPC_Ferrante_Gonzalez.ModSuscripcion" MasterPageFile="SideBar.Master" %>

<asp:Content ID="ModSuscripcion" ContentPlaceHolderID="Header" runat="server">

    <div class="col clearfix" style="background-color: rgba(0,0,0,0.8) !important; width: 100%; height: 100%; max-height: 95%; min-height: 761px; min-width: 460px;">
        <div class="row">
            <div class="col-1">
            </div>
            <div class="col-10">
                <div class="row" style="justify-content: center; margin: auto; padding: 2rem">
                    <div class="col-8">
                        <div class="row" style="padding-top: 3vh">
                            <asp:Label ID="lblModificarSub" runat="server" Text="Modificar Suscripción" Style="padding-bottom: 1rem; color: antiquewhite; font-size: large;"></asp:Label>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Servicio actual:</h6>
                            <asp:Label ID="lblDescripcionActual" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">
                            <h6 style="color: antiquewhite;">Modificar Servicio:</h6>
                            <asp:DropDownList ID="lstModSub" class="btn btn-secondary dropdown-toggle" runat="server" placeholder="Elija su subscripcion..." Style="width: auto; max-width: 100%; margin-left: 3vh;">
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Alias actual:</h6>
                            <asp:Label ID="lblAlias" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">
                            <h6 style="color: antiquewhite;">Modificar Alias:</h6>

                            <asp:TextBox ID="txtAlias" runat="server"></asp:TextBox>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Usuario actual:</h6>
                            <asp:Label ID="lblUsuario" runat="server" Text="desc" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">
                            <h6 style="color: antiquewhite;">Modificar Usuario:</h6>
                            <asp:DropDownList ID="lstModUsuario" class="btn btn-secondary dropdown-toggle" runat="server" placeholder="Elija su subscripcion..." Style="width: auto; max-width: 100%; margin-left: 3vh;">
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Delegado 1 actual:</h6>
                            <asp:Label ID="lblDelUno" runat="server" Text="Sin delegado supervisor" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">
                            <h6 style="color: antiquewhite;">Modificar Delegado:</h6>
                            <asp:DropDownList ID="lstModDelUno" class="btn btn-secondary dropdown-toggle" runat="server" placeholder="Elija su subscripcion..." Style="width: auto; max-width: 100%; margin-left: 3vh;">
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Delegado 2 actual:</h6>
                            <asp:Label ID="lblDelDos" runat="server" Text="Sin delegado supervisor" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">
                            <h6 style="color: antiquewhite;">Modificar Delegado:</h6>
                            <asp:DropDownList ID="lstModDelDos" class="btn btn-secondary dropdown-toggle" runat="server" placeholder="Elija su subscripcion..." Style="width: auto; max-width: 100%; margin-left: 3vh;">
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Fecha de Inicio del Servicio:</h6>
                            <asp:Label ID="lblFechaInicio" runat="server" Text="test" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh; padding-left: 1vh;">
                            <h6 style="color: antiquewhite;">Modificar fecha inicio:</h6>
                            <asp:Calendar ID="dateInicio" runat="server" Style="margin-left: 1vh; padding-left: 1vh; padding-top: 1vh; padding-bottom: 1vh;" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                <WeekendDayStyle BackColor="#CCCCFF" />
                            </asp:Calendar>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Fecha de fin del Servicio:</h6>
                            <asp:Label ID="lblFechaFin" runat="server" Text="test" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh; padding-left: 1vh;">
                            <h6 style="color: antiquewhite;">Modificar fecha fin:</h6>
                            <asp:Calendar ID="dateFin" runat="server" Style="margin-left: 1vH; padding-left: 1vh; padding-top: 1vh; padding-bottom: 1vh;" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                <WeekendDayStyle BackColor="#CCCCFF" />
                            </asp:Calendar>
                        </div>

                        <div class="row" style="padding-top: 3vh">
                            <h6 style="color: antiquewhite;">Estado del servicio:</h6>
                            <asp:Label ID="lblEstado" runat="server" Text="Vigencia" Style="padding-bottom: 0rem; justify-content: center; color: antiquewhite; padding-left: 1.5vh;"></asp:Label>
                        </div>
                        <div class="row" style="padding-top: 1vh">
                            <h6 style="color: antiquewhite;">Modificar Estado:</h6>
                            <asp:CheckBox ID="cbxEstado" runat="server" />
                        </div>


                    </div>
                </div>

                <div style="text-align: center">
                    <asp:Button ID="btnEnviar" runat="server" class="btn btn-primary form-control clearfix" Style="margin-bottom: 2vh; justify-content: center;" Text="Modificar Servicio" OnClick="btnEnviar_Click" />
                </div>
            </div>
            <div class="col-1"></div>
        </div>
    </div>

</asp:Content>
