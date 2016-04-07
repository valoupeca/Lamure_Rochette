<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Recherche_Simple.aspx.cs" Inherits="ClientWeb.Recherche_Simple" %>
<%@ Register TagPrefix="asp" Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Pour votre recherche,sélectionnez vos critères">
    </asp:Label>
    <br />

    <h2>Recherche simple</h2>
    <i class="material-icons">payment</i>&nbsp;<asp:Label ID="typetranvoulu" runat="server" Text="Type de transaction"></asp:Label>
    <asp:DropDownList ID="Typetransac" runat="server" ForeColor="red">
        <asp:ListItem Value="-1">Tout</asp:ListItem>
        <asp:ListItem Value="0">Vente</asp:ListItem>
        <asp:ListItem Value="1">Location</asp:ListItem>
    </asp:DropDownList>
   &nbsp;&nbsp;
    <i class="fa fa-home fa-2x"></i>&nbsp;<asp:Label ID="bienvoulu" runat="server" Text="Votre type de bien"></asp:Label>
    <asp:DropDownList ID="TypeBien1" runat="server" ForeColor="red">
        <asp:ListItem Value="-1">Tout</asp:ListItem>
        <asp:ListItem Value="0">Appartement</asp:ListItem>
        <asp:ListItem Value="1">Maison</asp:ListItem>
        <asp:ListItem Value="2">Garage</asp:ListItem>
        <asp:ListItem Value="3">Terrain</asp:ListItem>
    </asp:DropDownList>
   &nbsp;&nbsp;
    <asp:Label ID="indicatifprix" runat="server" Text="Entrer votre tarif de prix"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="prixmax1" CssClass="recherche"  runat="server" placeholder="Prix maximum"></asp:TextBox>
    &nbsp;&nbsp;
    <asp:Label ID="indicloc" runat="server" Text="Votre ville souhaité"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="localisation1" CssClass="recherche"  runat="server" placeholder="Localisation"></asp:TextBox>
    &nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Valider" CssClass="button"/><br />

    <asp:Label ID="lblErreurs" runat="server" Text=""></asp:Label><br /><br />

  <div id="alldata">

        <asp:Repeater ID="rpResultats" runat="server">
            <ItemTemplate>
                <div class="all">
                    <div id="photo" style="background-image: url('<%#(string)Eval("PhotoPrincipaleBase64") != "" && Eval("PhotoPrincipaleBase64") != null ? "data:img/png;base64," + Eval("PhotoPrincipaleBase64") : "./res/non_disponible.jpg"%>'); height: 250px; width: 250px; border: 1px solid black;">
                        <h3 id="titreimg"><%# Eval("Titre") %></h3>
                    </div>
                    <div class="data">
                        <p><i class="fa fa-home"></i>&nbsp;&nbsp;<%# Eval("TypeBien") %></p>
                        <p><i class="material-icons">payment</i>&nbsp;&nbsp;<%# Eval("TypeTransaction") %></p>
                        <p><i class="fa fa-globe"></i>&nbsp;&nbsp;<%# Eval("Ville") %></p>
                        <p><i class="material-icons">euro_symbol</i>&nbsp;&nbsp;<%# Eval("Prix") %></p>
                        <i class="material-icons">search</i><a href="Detail.aspx?id=<%# Eval("Id") %>">More details</a><br /><br />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>

</asp:Content>
