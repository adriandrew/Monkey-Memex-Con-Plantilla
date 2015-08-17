<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarUsuarios.aspx.cs" Inherits="AplicacionWeb.PuertaTrasera.AdministrarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div id="divIniciarSesionEstatico" runat="server">
        <asp:TextBox ID="txtUsuario" runat="server" Text="Usuario"></asp:TextBox>
        <asp:TextBox ID="txtContraseña" runat="server" Text="Contraseña" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar Sesión" OnClick="btnIniciarSesion_Click" />
    </div>
    <div id="divContenidoSecreto" runat="server">
        <asp:Button ID="btnCambiarAAdministrador" runat="server" Text="Cambiar Usuario A Administrador" OnClick="btnCambiarAAdministrador_Click" />
        <asp:Button ID="btnCambiarAMiembro" runat="server" Text="Cambiar Usuario A Miembro" OnClick="btnCambiarAMiembro_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Usuario" OnClick="btnEliminar_Click" />
        <asp:CreateUserWizard ID="CreateUserWizard" runat="server" OnCreatedUser="CreateUserWizard_CreatedUser" ClientIDMode="Static" OnContinueButtonClick="CreateUserWizard_ContinueButtonClick">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
        </asp:CreateUserWizard>
        <div id="divGridUsuarios">
            <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
        </div>
    </div>
</asp:Content>
