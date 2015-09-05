<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AporteEnviado.aspx.cs" Inherits="AplicacionWeb.Miembros.AporteEnviado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    
    <div id="principalAporte">
        <asp:Label ID="lblGracias" runat="server" ClientIDMode="Static" Text="Gracias por enviar tu aporte. Lo vamos a filtrar y te prometo que si es lo suficientemente bueno se publicará en breve.
            Quieres enviar otro aporte o volver a la pagina principal?
        "></asp:Label>
    
        <asp:HyperLink ID="hlEnviarAporte" runat="server" ClientIDMode="Static" CssClass="links" NavigateUrl="../EnviarAporte">Volver a Enviar Aporte</asp:HyperLink>
        <asp:HyperLink ID="hlPaginaPrincipal" runat="server" ClientIDMode="Static" CssClass="links" NavigateUrl="../Inicio">Volver a Principal</asp:HyperLink>
    </div>

</asp:Content>
