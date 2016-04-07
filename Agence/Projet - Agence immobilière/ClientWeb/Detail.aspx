<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="ClientWeb.Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblerreur" runat="server" Text=""></asp:Label>
    <div id="descrp">
        <br />
        <asp:Label CssClass="titrebien" ID="Titr" runat="server" Text=""></asp:Label>
        <br />
        <p  id="detail"><asp:Image ID="phto" runat="server" Height="400px" style="margin-top: 0px" Width="600px" /></p>
        <p id="imgstl">
            <i class="fa fa-home fa-2x"></i>&nbsp;<asp:Label ID="bienvoulu" runat="server" Text="Votre type de bien : "></asp:Label><asp:Label ID="bi1" runat="server" Text="" CssClass="txtimg"></asp:Label>
            <br />
            <i class="material-icons">euro_symbol</i>&nbsp;<asp:Label ID="Label11" runat="server" Text="Prix (en €) : " Font-Bold="True"></asp:Label><asp:Label ID="Pr" runat="server" Text="" CssClass="txtimg"></asp:Label><br />
            <i class="material-icons">explore</i>&nbsp;<asp:Label ID="Label7" runat="server" Text="Adresse : " Font-Bold="True"></asp:Label><asp:Label ID="Adr" runat="server" Text=""  CssClass="txtimg"></asp:Label><br />
            <i class="material-icons">explore</i>&nbsp;<asp:Label ID="Label9" runat="server" Text="Ville : " Font-Bold="True"></asp:Label><asp:Label ID="Vl" runat="server" Text=""  CssClass="txtimg"></asp:Label>
            &nbsp;<asp:Label ID="Label8" runat="server" Text="Code Postal : " Font-Bold="True"></asp:Label><asp:Label ID="CP" runat="server" Text=""  CssClass="txtimg"></asp:Label><br />
            <i class="material-icons">payment</i>&nbsp;<asp:Label ID="Label4" runat="server" Text="Type de Transaction : " Font-Bold="True"></asp:Label><asp:Label ID="TypeTransac" runat="server" Text="" CssClass="textebien"></asp:Label><br />
            <i class="material-icons">today</i>&nbsp;<asp:Label ID="Label2" runat="server" Text="Date de transaction : " Font-Bold="True"></asp:Label><asp:Label ID="DateTransac" runat="server" Text="" CssClass="textebien"></asp:Label><br /><br />
            <i class="fa fa-fire fa-lg"></i>&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Energie de Chauffage : " Font-Bold="True"></asp:Label><asp:Label ID="EnergieChauf" runat="server" Text="" CssClass="textebien"></asp:Label>&nbsp;&nbsp;&nbsp;
            <%if (TypeChauf.Text == "Individuel"){ %><i class="fa fa-male fa-lg"></i><% } else { %><i class="fa fa-users fa-lg"><% } %></i>&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Type de Chauffage : " Font-Bold="True"></asp:Label><asp:Label ID="TypeChauf" runat="server" Text="" CssClass="textebien"></asp:Label><br /><br />
            <asp:Label ID="Label6" runat="server" Text="Transaction Effectuée : " Font-Bold="True"></asp:Label><asp:Label ID="TransactionEf" runat="server" Text="" CssClass="textebien"></asp:Label><br /><br />
            <i class="material-icons">euro_symbol</i>&nbsp;<asp:Label ID="Label10" runat="server" Text="Montant des Charges : " Font-Bold="True"></asp:Label><asp:Label ID="MC" runat="server" Text="" CssClass="textebien"></asp:Label><br /><br />
            <i class="material-icons">crop_square</i>&nbsp;<asp:Label ID="Label12" runat="server" Text="Surface (en m²) : " Font-Bold="True"></asp:Label><asp:Label ID="Surf" runat="server" Text="" CssClass="textebien"></asp:Label><br /><br />
            <img src="./res/icone_stair.png" />&nbsp;<asp:Label ID="Label13" runat="server" Text="Nombres d'étages : " Font-Bold="True"></asp:Label><asp:Label ID="NbEta" runat="server" Text="" CssClass="textebien"></asp:Label><br /><br />
            <i class="material-icons">weekend</i>&nbsp;<asp:Label ID="Label14" runat="server" Text="Nombres de pièces : " Font-Bold="True"></asp:Label><asp:Label ID="NbPie" runat="server" Text="" CssClass="textebien"></asp:Label>&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label15" runat="server" Text="Numéro d'étages : " Font-Bold="True"></asp:Label><asp:Label ID="NumEta" runat="server" Text="" CssClass="textebien"></asp:Label><br />
        
        </p>
    </div>
    <br />
    <div id="biendetail">
      
         <asp:Label ID="Label1" runat="server" Text="Description du bien : " Font-Bold="True"></asp:Label><asp:Label ID="Desc" runat="server" Text="" CssClass="textebien"></asp:Label><br />
        
    </div>
      <asp:Label ID="mailenvoie" runat="server" Text ="Nous Contacter :"></asp:Label><br />
     <i class="fa fa-at"></i>&nbsp;&nbsp;<asp:TextBox ID="mailind" runat="server" placeholder="Votre mail" CssClass="recherche"></asp:TextBox><br />
      <i class="fa fa-envelope"></i>&nbsp;&nbsp;<br /><asp:TextBox ID="msgenvoie" runat="server" placeholder="Votre message" CssClass="recherche" TextMode="multiline" Columns="150" Rows="4"></asp:TextBox><br />
      <i class="fa fa-envelope"></i>&nbsp;&nbsp;<asp:Button ID="envoie" runat="server" Text="Email" OnClick="EnvoyerMail_onClick" />

</asp:Content>
