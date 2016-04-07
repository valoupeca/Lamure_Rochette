using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace ClientWeb
{
    public partial class Detail : System.Web.UI.Page
    {

        string
            DateMiseEnTransaction = null,
            Description = null,
            DateTransaction = null,
            EnergieChauffage = null,
            TypeChauffage = null,
            TypeTransaction = null,
            TransactionEffectue = null,
            Adresse = null,
            codePostal = null,
            Ville = null,
            Titre = null,
            Photo = null,
            Bien = null;


        double
            MontantCharge = -1,
            Prix = -1,
            Surface = -1;

        int
            NbEtage = -1,
            NbPiece = -1,
            NumEtage = -1;



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
                    TransactionEffectue = bien.TransactionEffectuee.ToString();
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
                    Bien = bien.TypeBien.ToString();


                    this.bi1.Text = Bien;
                    this.Desc.Text = Description;
                   this.DateTransac.Text = DateTransaction;
                    this.EnergieChauf.Text = EnergieChauffage;
                    this.TypeTransac.Text = TypeTransaction;
                    this.TypeChauf.Text = TypeChauffage;
                    this.TransactionEf.Text = TransactionEffectue;
                    this.Adr.Text = Adresse;
                    this.CP.Text = codePostal;
                    this.Vl.Text = Ville;
                    this.MC.Text = MontantCharge.ToString() + " €";
                    this.Pr.Text = Prix.ToString() + " €";
                    this.Surf.Text = Surface.ToString();
                    this.NbEta.Text = NbEtage.ToString();
                    this.NbPie.Text = NbPiece.ToString();
                    this.NumEta.Text = NumEtage.ToString();
                    this.Titr.Text = Titre;
                    this.phto.ImageUrl = "data:img/png;base64," + Photo;

                    if (String.IsNullOrEmpty(Photo))
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
                    this.lblerreur.Text = "Le bien choisie n'existe pas , veuillez en sélectionner un autre";
                }
            }

        }



        protected void EnvoyerMail_onClick(object sender, EventArgs e)
        {

            String mail = mailind.Text.ToString();
            String msg = msgenvoie.Text.ToString();

            MailMessage message = new MailMessage();
            MailAddress expediteur = new MailAddress("siteasp.projet@gmail.com");
            MailAddress destinataire = new MailAddress(mail);
            MailAddress destinataireCC = new MailAddress(mail);
            MailAddress destinataireBCC = new MailAddress(mail);

            // Adresse mail de l'expediteur
            message.From = expediteur;
            // Adresse mail du destinataire
            message.To.Add(destinataire);
            // Adresse mail du destinataire en copie
            message.CC.Add(destinataireCC);
            // Adresse mail du destinataire en copie cachée
            message.Bcc.Add(destinataireBCC);
            // Sujet
            message.Subject = "Renseignement";
            // Corps
            message.Body = (msg);


            // Client SMTP
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("siteasp.projet@gmail.com", "aqwzsxedc123");

            try
            {
                client.Send(message);
            }
            catch (SmtpFailedRecipientsException ex)
            {
                for (int i = 0; i < ex.InnerExceptions.Length; i++)
                {
                    SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                    if (status == SmtpStatusCode.MailboxBusy ||
                        status == SmtpStatusCode.MailboxUnavailable)
                    {
                        Console.WriteLine("Delivery failed - retrying in 5 seconds.");
                        System.Threading.Thread.Sleep(5000);
                        client.Send(message);
                    }
                    else
                    {
                        Console.WriteLine("Failed to deliver message to {0}",
                            ex.InnerExceptions[i].FailedRecipient);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in RetryIfBusy(): {0}",
                        ex.ToString());
            }


        }

    }
}