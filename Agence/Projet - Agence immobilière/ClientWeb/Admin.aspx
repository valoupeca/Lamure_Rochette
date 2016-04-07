<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="ClientWeb.Admin" %>

<%@ Register TagPrefix="ajaxToolkit" Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="search">
        <i class="fa fa-search fa-2x"></i>&nbsp;&nbsp;<asp:Label ID="indrechercher" runat="server" Text="Tapez vos critères de recherches ici"></asp:Label>&nbsp;&nbsp;<i class="fa fa-arrow-down fa"></i>
        <br />
        <asp:Label ID="titrbien" runat="server" Text="Le titre du bien"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="recherchetitre" runat="server" Text="" CssClass="recherche" Columns="20" placeholder="Titre du bien"></asp:TextBox>&nbsp;&nbsp;
        <asp:Label ID="prixbien" runat="server" Text="Le prix du bien"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="prixbienrech" runat="server" Text="" CssClass="recherche" Columns="20" placeholder="Prix du bien"></asp:TextBox><br />
        
        <asp:Label ID="typebien" runat="server" Text="Le type de bien du bien"></asp:Label>&nbsp;&nbsp; 
        <asp:DropDownList ID="TypeBien1" runat="server" ForeColor="Tomato">
            <asp:ListItem Value="-1">Tout</asp:ListItem>
            <asp:ListItem Value="0">Appartement</asp:ListItem>
            <asp:ListItem Value="1">Maison</asp:ListItem>
            <asp:ListItem Value="2">Garage</asp:ListItem>
            <asp:ListItem Value="3">Terrain</asp:ListItem>
        </asp:DropDownList><br />
        <br />
        <asp:Label ID="villerecher" runat="server" Text="Le Ville du bien"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="vilrecher" runat="server" Text="" CssClass="recherche" Columns="20" placeholder="Ville du bien"></asp:TextBox>&nbsp;&nbsp;
        <asp:Label ID="cdpt" runat="server" Text="Le code postal du bien"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="cdptrecher" runat="server" Text="" CssClass="recherche" Columns="20" placeholder="Code Postal du bien"></asp:TextBox><br />
            
        <asp:Button ID="Button1" runat="server" Text="Valider" CssClass="button" /><br />

    </section>

    <br />
    <br />
    <a id="admintab" href="Gestion.aspx"><i class="fa fa-plus-circle fa-3x"></i>&nbsp;Ajouter un bien</a>
    <br />
    <br />
    <asp:Label ID="pastrouvé" runat="server" Text="" CssClass="pastrouv"></asp:Label>
    <asp:GridView ID="gvResultats" runat="server" AutoGenerateColumns="false" CssClass="admin">
        <Columns>
            <asp:BoundField DataField="Titre" ReadOnly="True"
                SortExpression="Titre" HeaderText="Titre" />
            <asp:BoundField DataField="Prix" ReadOnly="True"
                SortExpression="Prix" HeaderText="Prix" />
            <asp:BoundField DataField="TypeBien" ReadOnly="True"
                SortExpression="TypeBien" HeaderText="Type de Bien" />
            <asp:BoundField DataField="Ville" ReadOnly="True"
                SortExpression="Ville" HeaderText="Ville" />
            <asp:BoundField DataField="CodePostal" ReadOnly="True"
                SortExpression="CodePostal" HeaderText="Code Postal" />

            <asp:TemplateField>
                <HeaderTemplate>Image</HeaderTemplate>
                <ItemTemplate>
                    <img height="200" width="250" src="<%#(String) Eval("PhotoPrincipaleBase64") != "" ? "data:img/png;base64," + Eval("PhotoPrincipaleBase64") : "./res/noImage.jpg" %>" alt="" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
                <HeaderTemplate>Modifier</HeaderTemplate>
                <ItemTemplate>

                    <a id="admintab" href="Gestion.aspx?id=<%# Eval("Id") %>"><i class="fa fa-pencil-square-o fa-3x"></i>&nbsp;Modifier un bien</a>

                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>Supprimer</HeaderTemplate>
                <ItemTemplate>

                    <a id="admintab" href="Suppression.aspx?id=<%# Eval("Id") %>"><i class="fa fa-trash fa-3x"></i>&nbsp;Supprimer un bien</a>
                    
                </ItemTemplate>
            </asp:TemplateField>


        </Columns>
    </asp:GridView>


</asp:Content>
