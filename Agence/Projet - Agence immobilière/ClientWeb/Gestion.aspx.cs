using System;
using System.Collections.Generic;
using System.IO;

namespace ClientWeb
{
    public partial class Modifier : System.Web.UI.Page
    {
        string
          DateMiseEnTransaction = null,
          Description = null,
          DateTransaction = null,
          EnergieChauffage = null,
          TypeChauffage = null,
          TypeTransaction = null,
          Adresse = null,
          codePostal = null,
          Ville = null,
          Titre = null,
          Photo = null,
          TypeBien = null,
            prix = null;


        double
            MontantCharge = -1,
            Prix = -1,
            Surface = -1;

        int
            NbEtage = -1,
            NbPiece = -1,
            NumEtage = -1;

        public String FichierUpload
        {
            get { return (String)ViewState["fichierUpload"]; }
            set { ViewState["fichierUpload"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            ServiceAgence.BienImmobilier bien = null;

            using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
            {

                bien = client.LireDetailsBienImmobilier(Request.QueryString["id"]).Bien;


                if (bien != null)
                {
                    DateMiseEnTransaction = bien.DateMiseEnTransaction.ToString();
                    Description = bien.Description;
                    DateTransaction = bien.DateTransaction.ToString();
                    EnergieChauffage = bien.EnergieChauffage.ToString();
                    TypeChauffage = bien.TypeChauffage.ToString();
                    TypeTransaction = bien.TypeTransaction.ToString();
                    Adresse = bien.Adresse;
                    codePostal = bien.CodePostal;
                    Ville = bien.Ville;
                    MontantCharge = bien.MontantCharges;
                    Prix = bien.Prix;
                    Surface = bien.Surface;
                    NbEtage = bien.NbEtages;
                    NbPiece = bien.NbPieces;
                    NumEtage = bien.NumEtage;
                    Titre = bien.Titre;
                    Photo = bien.PhotoPrincipaleBase64;
                    TypeBien = bien.TypeBien.ToString();

                    if (this.IsPostBack)
                    {
                        String prix = Prixan.Text;
                        if (Descanc.Text != Description) bien.Description = Descanc.Text;
                        if (DateMiseEnTransacanc.Text != DateMiseEnTransaction) bien.DateMiseEnTransaction = Convert.ToDateTime(DateMiseEnTransacanc.Text);
                        if ((Convert.ToString(TypeTransacold.SelectedValue)) != TypeTransaction) bien.TypeTransaction = (ServiceAgence.BienImmobilierBase.eTypeTransaction)(Convert.ToInt16(TypeTransacold.SelectedValue));
                        if ((Convert.ToString(TypeBienanc.SelectedValue)) != TypeBien) bien.TypeBien = (ServiceAgence.BienImmobilierBase.eTypeBien)(Convert.ToInt16(TypeBienanc.SelectedValue));
                        if ((Convert.ToString(TypeChaufold.SelectedValue)) != TypeChauffage) bien.TypeChauffage = (ServiceAgence.BienImmobilierBase.eTypeChauffage)(Convert.ToInt16(TypeChaufold.SelectedValue));
                        if ((Convert.ToString(energiechauffold.SelectedValue)) != EnergieChauffage) bien.EnergieChauffage = (ServiceAgence.BienImmobilierBase.eEnergieChauffage)(Convert.ToInt16(energiechauffold.SelectedValue));
                        if (Adresseanc.Text != Adresse) bien.Adresse = Adresseanc.Text;
                        if (CPanc.Text != codePostal) bien.CodePostal = CPanc.Text;
                        if (Villeancienne.Text != Ville) bien.Ville = Villeancienne.Text.ToUpper();
                        if (MCanc.Text != MontantCharge.ToString()) bien.MontantCharges = Convert.ToDouble(MCanc.Text);
                        if (Prixan.Text != Prix.ToString()) bien.Prix = Convert.ToDouble(prix);  
                        if (Surfanc.Text != Surface.ToString()) bien.Surface = Convert.ToDouble(Surfanc.Text);
                        if (NbEtaanc.Text != NbEtage.ToString()) bien.NbEtages = Convert.ToInt16(NbEtaanc.Text);
                        if (NbPieanc.Text != NbPiece.ToString()) bien.NbPieces = Convert.ToInt16(NbPieanc.Text);
                        if (NumEtaanc.Text != NumEtage.ToString()) bien.NumEtage = Convert.ToInt16(NumEtaanc.Text);
                        if (trtbien.Text != Titre) bien.Titre = trtbien.Text;
                        //modification photo
                        if (!String.IsNullOrEmpty(FichierUpload))
                        {
                            //create a Bitmap
                            bien.PhotosBase64.Add(bitmapToBase64String(new System.Drawing.Bitmap(FichierUpload)));
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(photoencodé.Text)) { bien.PhotosBase64 = new List<string>(); bien.PhotosBase64.Add(Convert.ToString(photoencodé.Text)); } else { bien.PhotosBase64 = null; }
                        }
                        client.ModifierBienImmobilier(bien);

                        modifier.Text = "Vous avez modifié le bien";
                    }


                    this.photo1.Text = "Votre photo encodé en base64 ici";
                    // this.Valider.Text = "Valider les modification";
                    this.Descanc.Text = bien.Description;
                    this.DateMiseEnTransacanc.Text = bien.DateMiseEnTransaction.ToString();
                    this.photoencodé.Text = bien.PhotoPrincipaleBase64;
                    this.energiechauffold.Text = bien.EnergieChauffage.ToString();
                    this.TypeBienanc.Text = bien.TypeBien.ToString();
                    this.TypeTransacold.Text = bien.TypeTransaction.ToString();
                    this.TypeChaufold.Text = bien.TypeChauffage.ToString();
                    this.Adresseanc.Text = bien.Adresse;
                    this.CPanc.Text = bien.CodePostal;
                    this.Villeancienne.Text = bien.Ville;
                    this.MCanc.Text = bien.MontantCharges.ToString();
                    this.Prixan.Text = bien.Prix.ToString();
                    this.Surfanc.Text = bien.Surface.ToString();
                    this.NbEtaanc.Text = bien.NbEtages.ToString();
                    this.NbPieanc.Text = bien.NbPieces.ToString();
                    this.NumEtaanc.Text = bien.NumEtage.ToString();
                    this.trtbien.Text = bien.Titre;
                    this.phto.ImageUrl = "data:img/png;base64," + bien.PhotoPrincipaleBase64;
                    bien.PhotosBase64 = new List<string>();
                    if (String.IsNullOrEmpty(bien.PhotoPrincipaleBase64))
                    {
                        this.phto.ImageUrl = "./res/non_disponible.jpg";
                    }
                    else
                    {
                        this.phto.ImageUrl = "data:img/png;base64," + Photo;
                    }
                }


                else
                {
                    // this.Valider.Text = "Ajouter votre bien";

                    bien = new ServiceAgence.BienImmobilier();

                    if (this.IsPostBack)
                    {

                        if (String.IsNullOrEmpty(Prixan.Text)) prix = "0.0"; else prix = Prixan.Text;
                        if (!String.IsNullOrEmpty(Descanc.Text)) bien.Description = Descanc.Text; else bien.Description = null;
                        if (!String.IsNullOrEmpty(DateMiseEnTransacanc.Text)) bien.DateMiseEnTransaction = Convert.ToDateTime(DateMiseEnTransacanc.Text); else bien.DateMiseEnTransaction = null;

                        if (!String.IsNullOrEmpty(Convert.ToString(TypeTransacold.SelectedValue))) bien.TypeTransaction = (ServiceAgence.BienImmobilierBase.eTypeTransaction)(Convert.ToInt16(TypeTransacold.SelectedValue));
                        if (!String.IsNullOrEmpty(Convert.ToString(TypeBienanc.SelectedValue))) bien.TypeBien = (ServiceAgence.BienImmobilierBase.eTypeBien)(Convert.ToInt16(TypeBienanc.SelectedValue));
                        if (!String.IsNullOrEmpty(Convert.ToString(TypeChaufold.SelectedValue))) bien.TypeChauffage = (ServiceAgence.BienImmobilierBase.eTypeChauffage)(Convert.ToInt16(TypeChaufold.SelectedValue));
                        if (!String.IsNullOrEmpty(Convert.ToString(energiechauffold.SelectedValue))) bien.EnergieChauffage = (ServiceAgence.BienImmobilierBase.eEnergieChauffage)(Convert.ToInt16(energiechauffold.SelectedValue));
                        if (!String.IsNullOrEmpty(Adresseanc.Text)) bien.Adresse = Adresseanc.Text; else bien.Adresse = null;
                        if (!String.IsNullOrEmpty(CPanc.Text)) bien.CodePostal = CPanc.Text; else bien.CodePostal = null;
                        if (!String.IsNullOrEmpty(Villeancienne.Text)) bien.Ville = Villeancienne.Text.ToUpper(); else bien.Ville = null;
                        if (!String.IsNullOrEmpty(MCanc.Text)) bien.MontantCharges = Convert.ToDouble(MCanc.Text); else bien.MontantCharges = -1.0;
                        if (!String.IsNullOrEmpty(Prixan.Text)) bien.Prix = Convert.ToDouble(prix); else bien.Prix = -1.0;
                        if (!String.IsNullOrEmpty(Surfanc.Text)) bien.Surface = Convert.ToDouble(Surfanc.Text); else bien.Surface = -1;
                        if (!String.IsNullOrEmpty(NbEtaanc.Text)) bien.NbEtages = Convert.ToInt16(NbEtaanc.Text); else bien.NbEtages = -1;
                        if (!String.IsNullOrEmpty(NbPieanc.Text)) bien.NbPieces = Convert.ToInt16(NbPieanc.Text); else bien.NbPieces = -1;
                        if (!String.IsNullOrEmpty(NumEtaanc.Text)) bien.NumEtage = Convert.ToInt16(NumEtaanc.Text); else bien.NumEtage = -1;
                        if (!String.IsNullOrEmpty(trtbien.Text)) bien.Titre = trtbien.Text; else bien.Titre = null;
                        bien.PhotosBase64 = new List<string>();
                        if (!String.IsNullOrEmpty(FichierUpload))
                        {
                            //create a Bitmap
                            bien.PhotosBase64.Add(bitmapToBase64String(new System.Drawing.Bitmap(FichierUpload)));
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(photoencodé.Text)) { bien.PhotosBase64 = new List<string>(); bien.PhotosBase64.Add(Convert.ToString(photoencodé.Text)); } else { bien.PhotosBase64 = null; }
                        }


                        client.AjouterBienImmobilier(bien);


                        modifier.Text = "Vous avez ajouté un bien";
                    }

                    this.photo1.Text = "Entrez votre image PNG encodé en base64 svp et enlevez 'data:img/png;base64, -> lien d'un convertisseur ";
                }
            }

        }


        protected void Upload(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/ImgTmp/") + fileName);
                FichierUpload = Server.MapPath("~/ImgTmp/") + fileName;
                lblUpload.Text = "Votre image a été upload";
                //Response.Redirect("~/CreateImmobilier.aspx?file=" + fichierUpload);
            }
        }
            
        public static string bitmapToBase64String(System.Drawing.Bitmap img)
        {


            if (img == null) return "";
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteArray = stream.ToArray();
                return System.Convert.ToBase64String(byteArray);
            }
        }

    }

}

