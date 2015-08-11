<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PanelControl.aspx.cs" Inherits="AplicacionWeb.Administradores.PanelControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <div id="divMenuPanelControl">
        <asp:LinkButton ID="linkModerar" runat="server" ClientIDMode="Static" CssClass="links" OnClick="linkModerar_Click">Moderar</asp:LinkButton>
        <asp:LinkButton ID="linkLimpiarNoAprobados" runat="server" ClientIDMode="Static" CssClass="links" OnClick="linkLimpiarNoAprobados_Click">Limpiar No Aprobados</asp:LinkButton>
        <asp:LinkButton ID="linkLimpiarAprobados" runat="server" ClientIDMode="Static" CssClass="links" OnClick="linkLimpiarAprobados_Click">Limpiar Aprobados</asp:LinkButton>        
    </div> <%-- end divMenuPanelControl --%>
    <div id="divOpciones" runat="server" visible="True">        
        <asp:RadioButton ID="rbRango" runat="server" Text="Rango" AutoPostBack="True" GroupName="Filtros" OnCheckedChanged="rbRango_CheckedChanged" />
        <asp:RadioButton ID="rbFecha" runat="server" Text="Fecha" AutoPostBack="True" GroupName="Filtros" OnCheckedChanged="rbFecha_CheckedChanged" />
        <div id="divOpcionesRango" runat="server">
            <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
            <asp:Button ID="btnLimpiarRango" runat="server" Text="Limpiar Por Rango" OnClick="btnLimpiarRango_Click" />
            <asp:RegularExpressionValidator ID="revCantidad" runat="server" ControlToValidate="txtCantidad" ErrorMessage="Sólo numeros" ValidationExpression="\d+"></asp:RegularExpressionValidator>
        </div> <%--end divOpcionesRango--%>
        <div id="divOpcionesFecha" runat="server">
            <asp:Calendar ID="calFechas" runat="server" Height="215px" Width="202px"></asp:Calendar>
            <asp:Button ID="btnLimpiarFecha" runat="server" Text="Limpiar Por Fecha" OnClick="btnLimpiarFecha_Click" />
        </div> <%--end divOpcionesFecha--%>
    </div> <%--end divOpciones--%>
    <asp:Panel runat="server" ID="pnlImagenes" />

</asp:Content>
