<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Gestion.aspx.cs" Inherits="ClientWeb.Modifier" %>
<%@ Register TagPrefix="ajaxToolkit" Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Label ID="Presentation" runat="server" Text="Si vous voulez modifier les valeurs c'est ici"></asp:Label>
     &nbsp;&nbsp;<asp:Label ID="modifier" runat="server" Text="" CssClass="modifier"></asp:Label>
    <br />
    <asp:Label ID="lblerreur" runat="server" Text=""></asp:Label>
    <asp:Label ID="photo1" runat="server" Text="" CssClass="textebien"></asp:Label>
   <a class="converter" target="_blank" href="https://www.base64-image.de/"><i class="fa fa-info-circle fa-3x"></i></a> 
    <asp:TextBox ID="photoencodé" runat="server" placeholder="photo" CssClass="recherche" Columns="100"></asp:TextBox>
    <br />
    <asp:Label ID="photoup" runat="server" Text="Ou télechargez une photo depuis votre pc"></asp:Label>
    <asp:FileUpload ID="FileUpload1" runat="server" /><asp:Button ID="up" runat="server" Text="Upload" OnClick="Upload" />
    <br />
    <asp:Label ID="lblUpload" runat="server" Text=""></asp:Label>
    <div id="descrp">
        <br />
        <asp:Label CssClass="titrebien" ID="tri" runat="server" Text="Titre du bien"></asp:Label><br />
        <asp:TextBox ID="trtbien" runat="server" placeholder="Titre du bien" CssClass="recherche" Columns="100" ></asp:TextBox>
        <br />
       
        <br />
        <p id="detail">
            <% if (phto.ImageUrl.ToString() != "")
                {  %><asp:Image ID="phto" runat="server" Height="400px" Width="600px" />
        </p>
        <% } %>
        <p id="imgstl">
            <i class="material-icons">euro_symbol</i>&nbsp;&nbsp;<asp:Label ID="Label11" runat="server" Text="Prix (en €) : " Font-Bold="True"></asp:Label><asp:TextBox ID="Prixan" runat="server" placeholder="Prix" CssClass="recherche"></asp:TextBox><br />
            <i class="material-icons">explore</i>&nbsp;<asp:Label ID="Label7" runat="server" Text="Adresse : " Font-Bold="True"></asp:Label><asp:TextBox ID="Adresseanc" runat="server" placeholder="Adresse" CssClass="recherche"></asp:TextBox><br />
            <i class="material-icons">explore</i>&nbsp;<asp:Label ID="Label9" runat="server" Text="Ville : " Font-Bold="True"></asp:Label><asp:TextBox ID="Villeancienne" runat="server" placeholder="Ville" CssClass="recherche"></asp:TextBox>
            &nbsp;<asp:Label ID="Label8" runat="server" Text="Code Postal : " Font-Bold="True"></asp:Label><asp:TextBox ID="CPanc" runat="server" placeholder="Code postal" CssClass="recherche"></asp:TextBox><br />
            <i class="material-icons">today</i>&nbsp;<asp:Label ID="datem" runat="server" Text="Date de mise en transaction (format:YYYY-MM-DD HH:MM:SS) : " Font-Bold="True"></asp:Label>
            
            <asp:TextBox CssClass="recherche" ID="DateMiseEnTransacanc" runat="server" placeholder="Date de mise en transaction"></asp:TextBox>
            <br />
            <i class="material-icons">payment</i>&nbsp;<asp:Label ID="Label4" runat="server" placeholder="Type de Transaction : " Font-Bold="True"></asp:Label>
            <asp:DropDownList ID="TypeTransacold" runat="server" ForeColor="red">
                <asp:ListItem Value="0">Vente</asp:ListItem>
                <asp:ListItem Value="1">Location</asp:ListItem>
            </asp:DropDownList><br />
            <br />
            <i class="material-icons">payment</i>&nbsp;<asp:Label ID="Label16" runat="server" placeholder="Type de Bien : " Font-Bold="True"></asp:Label>
            <asp:DropDownList ID="TypeBienanc" runat="server" ForeColor="red">
                <asp:ListItem Value="0">Appartement</asp:ListItem>
                <asp:ListItem Value="1">Maison</asp:ListItem>
                <asp:ListItem Value="2">Garage</asp:ListItem>
                <asp:ListItem Value="3">Terrain</asp:ListItem>
            </asp:DropDownList><br />
            <br />
           
            <i class="fa fa-fire fa-lg"></i>&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" placeholder="Energie de Chauffage : " Font-Bold="True"></asp:Label>
            <asp:DropDownList ID="energiechauffold" runat="server" ForeColor="red">
                <asp:ListItem Value="0">Aucun</asp:ListItem>
                <asp:ListItem Value="1">Fioul</asp:ListItem>
                <asp:ListItem Value="2">Gaz</asp:ListItem>
                <asp:ListItem Value="3">Electrique</asp:ListItem>
                <asp:ListItem Value="4">Bois</asp:ListItem>
            </asp:DropDownList>
            <%if (TypeChaufold.Text == "Individuel")
                { %><i class="fa fa-male fa-lg"></i><% }
                         else { %><i class="fa fa-users fa-lg"><% } %></i>&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" placeholder="Type de Chauffage : " Font-Bold="True"></asp:Label>
            <asp:DropDownList ID="TypeChaufold" runat="server" ForeColor="red">
                <asp:ListItem Value="0">Aucun</asp:ListItem>
                <asp:ListItem Value="1">Individuel</asp:ListItem>
                <asp:ListItem Value="2">Collectif</asp:ListItem>
            </asp:DropDownList><br />
            <br />
            <i class="material-icons">euro_symbol</i>&nbsp;<asp:Label ID="Label10" runat="server" Text="Montant des Charges : " Font-Bold="True"></asp:Label><asp:TextBox ID="MCanc" runat="server" placeholder="Montant charges" CssClass="recherche"></asp:TextBox><br />
            <br />
            <i class="material-icons">crop_square</i>&nbsp;<asp:Label ID="Label12" runat="server" Text="Surface (en m²) : " Font-Bold="True"></asp:Label><asp:TextBox ID="Surfanc" runat="server" placeholder="Surface" CssClass="recherche"></asp:TextBox><br />
            <br />
            <img src="./res/icone_stair.png" />&nbsp;<asp:Label ID="Label13" runat="server" Text="Nombres d'étages : " Font-Bold="True"></asp:Label><asp:TextBox ID="NbEtaanc" runat="server" placeholder="Nb etages" CssClass="recherche"></asp:TextBox><br />
            <br />
            <i class="material-icons">weekend</i>&nbsp;<asp:Label ID="Label14" runat="server" Text="Nombres de pièces : " Font-Bold="True"></asp:Label><asp:TextBox ID="NbPieanc" runat="server" placeholder="Nb Pieces" CssClass="recherche"></asp:TextBox>&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label15" runat="server" Text="Numéro d'étages : " Font-Bold="True"></asp:Label><asp:TextBox ID="NumEtaanc" runat="server" placeholder="Num etages" CssClass="recherche"></asp:TextBox><br />

        </p>
    </div>
    <br />
    <div id="biendetail">
        <asp:Label ID="Label1" runat="server" Text="Entrez votre description : " Font-Bold="True"></asp:Label><br />
        <asp:TextBox ID="Descanc" runat="server" placeholder="Description" CssClass="recherche" TextMode="multiline" Columns="150" Rows="4"></asp:TextBox><br />

    </div>
    <asp:Button ID="Validation" runat="server" Text="Valider" CssClass="button" />
     <br />



</asp:Content>

