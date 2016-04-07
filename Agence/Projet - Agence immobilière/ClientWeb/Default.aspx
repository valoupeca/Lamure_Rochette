<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClientWeb.Default" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="scriptManagerMaster"
                   EnablePageMethods="True"
                   EnableScriptLocalization="True"
                   EnableScriptGlobalization="True"
                   runat="server" />

    <h3>Bienvenue sur le site de notre agence immboliere</h3>
    <h1>Que voulez-vous faire</h1>
  
    <div class="footer-group">
        <h3>Vous souhaitez acheter?</h3>

        <a class="button" href="Recherche_Simple.aspx">Recherche simple</a>

        <a class="button" href="Recherche_Avancee.aspx">Recherche avancée</a>
    </div>
    <div class="accueilphoto">
        <img class="accueilphoto" src="./res/Bourg.png" />
        <img class="accueilphoto" src="./res/securitas.png" />
        <img class="accueilphoto" src="./res/logo-region-rhone-alpes.png" />
        <img class="accueilphoto" src="./res/StépanePlazaImmobilier.png" />
        <br />
        <br />
    </div>
    <div id="contact">
        <a class="test" href="https://www.facebook.com/stephaneplazaimmobilierlyonSaxe/?fref=ts"><i class="fa fa-facebook-square fa-2x">  Facebook</i></a>&nbsp;&nbsp;
        <a class="test" href="https://twitter.com/PlazaImmoParis5?lang=fr"><i class="fa fa-twitter-square fa-2x">  Twitter</i></a>&nbsp;&nbsp;
        <a class="test" href="https://www.facebook.com/stephaneplazaimmobilierlyonSaxe/?fref=ts"><i class="fa fa-instagram fa-2x">  Instagram</i></a>&nbsp;&nbsp;
    </div>


</asp:Content>
