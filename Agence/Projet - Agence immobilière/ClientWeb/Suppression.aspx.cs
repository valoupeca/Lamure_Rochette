using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientWeb
{
    public partial class Suppression : System.Web.UI.Page
    {

        string
            Adresse = null,
            codePostal = null,
            Ville = null,
            Titre = null,
            Photo = null;

        double Prix = -1;

        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceAgence.BienImmobilier bien = null;

            using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
            {

                bien = client.LireDetailsBienImmobilier(Request.QueryString["id"]).Bien;


                if (bien != null)
                {
                    Adresse = bien.Adresse;
                    codePostal = bien.CodePostal;
                    Ville = bien.Ville;
                    Prix = bien.Prix;
                    Titre = bien.Titre;
                    Photo = bien.PhotoPrincipaleBase64;

                    if (this.IsPostBack)
                    {
                        client.SupprimerBienImmobilier(Request.QueryString["id"]);
                        Server.Transfer("Admin.aspx",true);
                    }




                    this.Adresseanc.Text = bien.Adresse;
                    this.CPanc.Text = bien.CodePostal;
                    this.Villeancienne.Text = bien.Ville;
                    this.Prixan.Text = bien.Prix.ToString() + "€";
                    this.Titr.Text = bien.Titre;
                    if (String.IsNullOrEmpty(bien.PhotoPrincipaleBase64))
                    {
                        this.supprPhoto.ImageUrl = "./res/non_disponible.jpg";
                    }
                    else
                    {
                        this.supprPhoto.ImageUrl = "data:img/png;base64," + Photo;
                    }
                  


                }
                else
                { 
}
            }
        }
    }
}