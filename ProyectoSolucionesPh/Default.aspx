<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoSolucionesPh._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:GridView ID="gvdAlumnos" runat ="server" AutoGenerateColumns="true">

        </asp:GridView>

    </div>

</asp:Content>
