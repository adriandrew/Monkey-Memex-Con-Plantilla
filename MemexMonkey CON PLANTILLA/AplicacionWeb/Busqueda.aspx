<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="AplicacionWeb.Busqueda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <div id="imagenesBusqueda" class="busqueda" runat="server"></div>
    <asp:Panel runat="server" ID="pnlImagenesBusqueda" />

    <%--Plugin de Facebook--%>
    <%--Ponerlo al final para optimizar la carga del website en el servidor.--%>

    <div id="fb-root"></div>
    <script>(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/es_LA/sdk.js#xfbml=1&version=v2.0";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>

    <%--Termina plugin de Facebook--%>

</asp:Content>
