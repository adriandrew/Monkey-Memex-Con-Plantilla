﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnviarAporte.aspx.cs" Inherits="AplicacionWeb.Miembros.EnviarAporte" %>
<%@ Register src="../Controles/SubirArchivo.ascx" tagname="ucSubirArchivo" tagprefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:RadioButtonList ID="rblEscoger" runat="server" Height="16px" OnSelectedIndexChanged="rblEscoger_SelectedIndexChanged" RepeatDirection="Horizontal" Width="502px" AutoPostBack="True">
        <asp:ListItem Selected="True">Imagen</asp:ListItem>
        <asp:ListItem>Enlace</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <uc:ucSubirArchivo ID="ucSubirArchivo" runat="server" />
    <br />
    <asp:Label ID="lblEnlaceExterno" runat="server" Text="Enlace Externo" Visible="False"></asp:Label>
    <asp:TextBox ID="txtEnlaceExterno" runat="server" Width="296px" Visible="False"></asp:TextBox>
    <asp:RegularExpressionValidator ID="revEnlaceExterno" runat="server" ControlToValidate="txtEnlaceExterno" ErrorMessage="Enlace no valido" ForeColor="Red" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" Visible="False"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="rfvEnlaceExterno" runat="server" ControlToValidate="txtEnlaceExterno" ErrorMessage="Requerido" ForeColor="Red" Visible="False"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="lblTituloImagen" runat="server" Text="Título de Imagen"></asp:Label>
    <asp:TextBox ID="txtTituloImagen" runat="server" Width="296px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvTituloImagen" runat="server" ControlToValidate="txtTituloImagen" ErrorMessage="Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
    <asp:DropDownList ID="ddlCategoria" runat="server" Height="29px" Width="201px">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="lblEtiquetasBasicas" runat="server" Text="Etiquetas Basicas"></asp:Label>
    <asp:TextBox ID="txtPersonaje" runat="server" Width="237px" ForeColor="Gray">#personaje1 #personaje2</asp:TextBox>
    <asp:TextBox ID="txtEquipo" runat="server" Width="200px" ForeColor="Gray">#equipo1 #equipo2</asp:TextBox>
    <asp:TextBox ID="txtCompeticion" runat="server" Width="145px" ForeColor="Gray">#competicion</asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvPersonaje" runat="server" ControlToValidate="txtPersonaje" ErrorMessage="Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="rfvEquipo" runat="server" ControlToValidate="txtEquipo" ErrorMessage="Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="rfvCompeticion" runat="server" ControlToValidate="txtCompeticion" ErrorMessage="Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="lblEtiquetasOpcionales" runat="server" Text="Etiquetas Opcionales"></asp:Label>
    <asp:TextBox ID="txtEtiquetasOpcionales" runat="server" Width="296px" ForeColor="Gray">#etiquetas opcionales #memex fan</asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnEnviarAporte" runat="server" OnClick="btnEnviarAporte_Click" Text="Enviar Aporte" Height="30px" Width="120px" />
    <asp:Button ID="btnReiniciar" runat="server" Text="Reiniciar" OnClick="btnReiniciar_Click" Height="30px" Width="100px" />
    <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="False"></asp:Label>
    </asp:Content>
