﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="AplicacionWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Memex Monkey</title>    
    <link rel="stylesheet" type="text/css" href="Css/styles.css"/>
    <link rel="stylesheet" type="text/css" href="Css/iniciarSesion.css"/>
</head>
<body id="bodyIniciarSesion" background="Images/fondo.jpg">
    <form id="formularioIniciarSesion" runat="server" class="formulario">        
        <div id="principal">
            <section id="section">
                <section id="sectionContenido">
                    <div id="divLogin">
                        <asp:LoginView ID="LoginView" runat="server">
                            <AnonymousTemplate>
                                <asp:Login ID="Loginn" runat="server" Orientation="Horizontal" UserNameLabelText="Usuario:" FailureText="Error, intenta de nuevo por favor.">
                                    <LayoutTemplate>
                                        <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                                            <tr>
                                                <td>
                                                    <table cellpadding="0">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuario:</asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." ValidationGroup="ctl00$ctl02$Login">*</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="La contraseña es obligatoria." ToolTip="La contraseña es obligatoria." ValidationGroup="ctl00$ctl02$Login">*</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>&nbsp;</td>
                                                            <td>
                                                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Iniciar sesión" ValidationGroup="ctl00$ctl02$Login" BackColor="Black" BorderColor="Gray" ForeColor="White" Height="30px" Width="100px" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="6" style="color:Red;">
                                                                <asp:CheckBox ID="RememberMe" runat="server" ForeColor="Black" Text="Recordar la próxima vez." />
                                                                <asp:Literal ID="FailureText" runat="server"></asp:Literal>                                                                
                                                                <asp:LinkButton ID="LinkButton" runat="server" Font-Overline="False" PostBackUrl="Registrarse" OnClientClick="parent.CerrarFancyboxYRedireccionar('Registrarse');" CssClass="links"><p>Registrarse</p></asp:LinkButton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </LayoutTemplate>
                                </asp:Login>
<%--                                    <asp:LinkButton ID="lnkEnviarAporteNoMiembros" runat="server" PostBackUrl="Registrarse">Enviar Aporte</asp:LinkButton>--%>
                            </AnonymousTemplate>
                            <LoggedInTemplate>
                                Hola:
                                <asp:LoginName ID="LoginName" runat="server" />
                                <br />
                                <asp:LoginStatus ID="LoginStatus" runat="server" CssClass="links" />
                                <div id="prueba" runat="server"></div>
                                <asp:LinkButton ID="linkModerar" runat="server" ClientIDMode="Static" Font-Overline="False" PostBackUrl="PanelControl" OnClientClick="parent.CerrarFancyboxYRedireccionar('PanelControl');" CssClass="links" Visible="true"><p>Panel de Control</p></asp:LinkButton>
                                <%--<br />--%>
<%--                                    <asp:LinkButton ID="lnkEnviarAporteMiembros" runat="server" PostBackUrl="EnviarAporte">Enviar Aporte</asp:LinkButton>--%>
                            </LoggedInTemplate>
                        </asp:LoginView>                  
                </div> <%--end headerLogin--%>
                </section>
            </section> <%--end sectionContenido--%>
        </div> <%--end sectionContenido--%>
    </form>
</body>
</html>
