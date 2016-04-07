﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientWeb
{
    public partial class Recherche_Simple : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ServiceAgence.BienImmobilierBase> liste = null;

            using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
            {

                ServiceAgence.CriteresRechercheBiensImmobiliers criteres = new ServiceAgence.CriteresRechercheBiensImmobiliers();
                criteres.DateMiseEnTransaction1 = null;
                criteres.DateMiseEnTransaction2 = null;
                criteres.DateTransaction1 = null;
                criteres.DateTransaction2 = null;
                criteres.EnergieChauffage = null;
                criteres.MontantCharges1 = -1;
                criteres.MontantCharges2 = -1;
                criteres.NbEtages1 = -1;
                criteres.NbEtages2 = -1;
                criteres.NbPieces1 = -1;
                criteres.NbPieces2 = -1;
                criteres.NumEtage1 = -1;
                criteres.NumEtage2 = -1;
                criteres.Prix1 = -1;
                criteres.Prix2 = -1;
                criteres.Surface1 = -1;
                criteres.Surface2 = -1;
                criteres.TransactionEffectuee = null;
                criteres.TypeBien = null;
                criteres.TypeChauffage = null;
                criteres.TypeTransaction = null;

                if (this.IsPostBack)
                {
                    if ((prixmax1.Text) == "") criteres.Prix2 = -1; else criteres.Prix2 = Convert.ToDouble(prixmax1.Text);
                    if ((Convert.ToInt16(TypeBien1.SelectedValue)) == -1) criteres.TypeBien = null; else criteres.TypeBien = (ServiceAgence.BienImmobilierBase.eTypeBien)(Convert.ToInt16(TypeBien1.SelectedValue));
                    if ((Convert.ToInt16(Typetransac.SelectedValue)) == -1) criteres.TypeTransaction = null; else criteres.TypeTransaction = (ServiceAgence.BienImmobilierBase.eTypeTransaction)(Convert.ToInt16(Typetransac.SelectedValue));
                    if (localisation1.Text == "") criteres.Ville = null; else criteres.Ville = Convert.ToString(localisation1.Text.ToUpper());


                }



                ServiceAgence.ResultatListeBiensImmobiliers resultat = client.LireListeBiensImmobiliers(criteres, null, null);

                if (resultat.SuccesExecution)
                {
                    liste = resultat.Liste.List;

                }
                else
                {
                    liste = new List<ServiceAgence.BienImmobilierBase>();
                    this.lblErreurs.Text = resultat.ErreursBloquantes.ToString();
                }
            }
            this.rpResultats.DataSource = liste;
            this.rpResultats.DataBind();
        }



      

    }
}