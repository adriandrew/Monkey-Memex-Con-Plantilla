<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PanelControl.aspx.cs" Inherits="AplicacionWeb.Administradores.PanelControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <div id="divMenuPanelControl">
        <asp:LinkButton ID="linkModerar" runat="server" ClientIDMode="Static" CssClass="links" OnClick="linkModerar_Click">Moderar</asp:LinkButton>
        <asp:LinkButton ID="linkLimpiarNoAprobados" runat="server" ClientIDMode="Static" CssClass="links" OnClick="linkLimpiarNoAprobados_Click">Limpiar No Aprobados</asp:LinkButton>
        <asp:LinkButton ID="linkLimpiarAprobados" runat="server" ClientIDMode="Static" CssClass="links" OnClick="linkLimpiarAprobados_Click">Limpiar Aprobados</asp:LinkButton>
    </div> <%-- end divMenuPanelControl --%>
    <asp:Panel runat="server" ID="pnlImagenes" />

</asp:Content>
