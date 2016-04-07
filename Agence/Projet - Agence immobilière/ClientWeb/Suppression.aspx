<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Suppression.aspx.cs" Inherits="ClientWeb.Suppression" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />

    <asp:Label ID="suppr" runat="server" Text="Vous vous apprétez à supprimer un bien"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Titr" runat="server" Text="Pas de titre pour ce bien" CssClass="recherche"></asp:Label>
    <br />
    
    <asp:Label ID="modifier" runat="server" Text="" CssClass="modifier"></asp:Label>
    <div id="descrp">
        <p id="detail">
            <asp:Image ID="supprPhoto" runat="server" Height="400px" Width="600px" />
            <br />
        </p>
        <p id="imgstl">
            <i class="material-icons">euro_symbol</i>&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Text="Prix (en €) : " Font-Bold="True"></asp:Label>
            <asp:TextBox ID="Prixan" runat="server" placeholder="Prix" CssClass="recherche"></asp:TextBox><br />
            <i class="material-icons">explore</i>&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Adresse : " Font-Bold="True"></asp:Label>
            <asp:TextBox ID="Adresseanc" runat="server" placeholder="Adresse" CssClass="recherche"></asp:TextBox><br />
            <i class="material-icons">explore</i>&nbsp;
        <asp:Label ID="Label9" runat="server" Text="Ville : " Font-Bold="True"></asp:Label>
            <asp:TextBox ID="Villeancienne" runat="server" Text="Ville" CssClass="recherche"></asp:TextBox>
            &nbsp;<asp:Label ID="Label8" runat="server" Text="Code Postal : " Font-Bold="True"></asp:Label>
            <asp:TextBox ID="CPanc" runat="server" Text="Code postal" CssClass="recherche"></asp:TextBox><br />
              
            <asp:Button ID="suppression" runat="server" CssClass="button" Text="Suprimer ce bien"/>
            <asp:LinkButton ID="goback" runat="server" CssClass="button" PostBackUrl="~/Admin.aspx" Text="Conserver ce bien"></asp:LinkButton>
     </p>
    </div>
</asp:Content>
