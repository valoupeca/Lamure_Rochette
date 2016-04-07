using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClientWPF
{
    /// <summary>
    /// Logique d'interaction pour Gestion.xaml
    /// </summary>
    public partial class Gestion : Window, INotifyPropertyChanged
    {
        string ID;
        ServiceAgence.BienImmobilier bien = null;


        string
            DateMiseEnTransaction = null,
            Description = null,
            TypeBien = null,
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

        private Dictionary<string, object> _propertyValues = new Dictionary<string, object>();

        public event PropertyChangedEventHandler PropertyChanged;

        private object GetProperty([CallerMemberName] string propertyName = null)
        {
            if (_propertyValues.ContainsKey(propertyName)) return _propertyValues[propertyName];
            return null;

        }

        private bool SetProperty<T>(T newValue, [CallerMemberName] string propertyName = null)
        {
            T current = (T)GetProperty(propertyName);

            if (!EqualityComparer<T>.Default.Equals(current, newValue))
            {
                _propertyValues[propertyName] = newValue;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
                return true;
            }

            return false;
        }
        /*COMBO BOX*/

        public ServiceAgence.BienImmobilierBase.eTypeBien? Bienselect
        {
            get
            {
                if (GetProperty() == null)
                    return ServiceAgence.BienImmobilierBase.eTypeBien.Appartement;
                else
                    return (ServiceAgence.BienImmobilierBase.eTypeBien?)GetProperty();
            }
            set { SetProperty(value); }
        }

        public ServiceAgence.BienImmobilierBase.eTypeTransaction? TransacSelect
        {
            get
            {
                if (GetProperty() == null)
                    return ServiceAgence.BienImmobilierBase.eTypeTransaction.Location;
                else
                    return (ServiceAgence.BienImmobilierBase.eTypeTransaction?)GetProperty();
            }
            set { SetProperty(value); }
        }

        public ServiceAgence.BienImmobilierBase.eTypeChauffage? ChaufSelect
        {
            get
            {
                if (GetProperty() == null)
                    return ServiceAgence.BienImmobilierBase.eTypeChauffage.Aucun;
                else
                    return (ServiceAgence.BienImmobilierBase.eTypeChauffage?)GetProperty();
            }
            set { SetProperty(value); }
        }

        public ServiceAgence.BienImmobilierBase.eEnergieChauffage? EnergieSelect
        {
            get
            {
                if (GetProperty() == null)
                    return ServiceAgence.BienImmobilierBase.eEnergieChauffage.Aucun;
                else
                    return (ServiceAgence.BienImmobilierBase.eEnergieChauffage?)GetProperty();
            }
            set { SetProperty(value); }
        }
        /*TEXT BOX*/
        public string Titre1
        {
            get
            {
                if (GetProperty() == null)
                    return "Pas renseigné";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string Prix1
        {
            get
            {
                if (GetProperty() == null)
                    return "-1";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string Ville1
        {
            get
            {
                if (GetProperty() == null)
                    return "Pas renseigné";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string Adresse1
        {
            get
            {
                if (GetProperty() == null)
                    return "Pas renseigné";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string CodePostal1
        {
            get
            {
                if (GetProperty() == null)
                    return "-1";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string Surface1
        {
            get
            {
                if (GetProperty() == null)
                    return "-1";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string Nbetage1
        {
            get
            {
                if (GetProperty() == null)
                    return "-1";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string NbPiece1
        {
            get
            {
                if (GetProperty() == null)
                    return "-1";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string NumEtage1
        {
            get
            {
                if (GetProperty() == null)
                    return "-1";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string Description1
        {
            get
            {
                if (GetProperty() == null)
                    return "Pas renseigné";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string Charges1
        {
            get
            {
                if (GetProperty() == null)
                    return "-1";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }
        public string Photo1
        {
            get
            {
                if (GetProperty() == null)
                    return "Pas renseigné";
                else
                    return (string)GetProperty();
            }
            set { SetProperty(value); }
        }



        public Gestion()
        {
            this.DataContext = this;
            InitializeComponent();
        }

        public Gestion(string id)
        {
            this.DataContext = this;
            this.ID = id;
            InitializeComponent();
            Recuperation(id);
            Ajout_Texte();
        }


        public void AjoutBien(object sender, EventArgs e)
        {

            if (ID != "")
            {
                ModifBien(sender, e);
            }
            else
            {

                using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
                {
                    ServiceAgence.BienImmobilier bien = new ServiceAgence.BienImmobilier();

                    bien.Description = Description1;
                    bien.DateMiseEnTransaction = null;
                    bien.TypeTransaction = (ServiceAgence.BienImmobilierBase.eTypeTransaction)(Convert.ToInt16(TransacSelect));
                    bien.TypeBien = (ServiceAgence.BienImmobilierBase.eTypeBien)(Convert.ToInt16(Bienselect));
                    bien.TypeChauffage = (ServiceAgence.BienImmobilierBase.eTypeChauffage)(Convert.ToInt16(ChaufSelect));
                    bien.EnergieChauffage = (ServiceAgence.BienImmobilierBase.eEnergieChauffage)(Convert.ToInt16(EnergieSelect));
                    bien.Adresse = Adresse1;
                    bien.CodePostal = CodePostal1;
                    bien.Ville = Ville1.ToUpper();
                    bien.MontantCharges = Convert.ToDouble(Charges1);
                    bien.Prix = Convert.ToDouble(Prix1);
                    bien.Surface = Convert.ToDouble(Surface1);
                    bien.NbEtages = Convert.ToInt16(NbPiece1);
                    bien.NbPieces = Convert.ToInt16(NbPiece1);
                    bien.NumEtage = Convert.ToInt16(NumEtage1);
                    bien.Titre = Titre1;


                    client.AjouterBienImmobilier(bien);
                    this.Close();
                }
            }
        }


        public void ModifBien(object sender, EventArgs e)
        {

           using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
            {
                bien = client.LireDetailsBienImmobilier(ID).Bien;


                bien.Description = Description1;
                bien.DateMiseEnTransaction = null;
                bien.TypeTransaction = (ServiceAgence.BienImmobilierBase.eTypeTransaction)(Convert.ToInt16(TransacSelect));
                bien.TypeBien = (ServiceAgence.BienImmobilierBase.eTypeBien)(Convert.ToInt16(Bienselect));
                bien.TypeChauffage = (ServiceAgence.BienImmobilierBase.eTypeChauffage)(Convert.ToInt16(ChaufSelect));
                bien.EnergieChauffage = (ServiceAgence.BienImmobilierBase.eEnergieChauffage)(Convert.ToInt16(EnergieSelect));
                bien.Adresse = Adresse1;
                bien.CodePostal = CodePostal1;
                bien.Ville = Ville1.ToUpper();
                bien.MontantCharges = Convert.ToDouble(Charges1); 
                bien.Prix = Convert.ToDouble(Prix1); 
                bien.Surface = Convert.ToDouble(Surface1);
                bien.NbEtages = Convert.ToInt16(NbPiece1); 
                bien.NbPieces = Convert.ToInt16(NbPiece1);
                bien.NumEtage = Convert.ToInt16(NumEtage1); 
                bien.Titre = Titre1; 


                client.ModifierBienImmobilier(bien);
                this.Close();
            }

        }

        public void Ajout_Texte()
        {
            Description1 = Description;
            Adresse1 = Adresse;
            CodePostal1 = codePostal;
            Ville1 = Ville;
            Charges1 = MontantCharge.ToString();
            Prix1 = Prix.ToString();
            Surface1 = Surface.ToString();
            Nbetage1 = NbEtage.ToString();
            NbPiece1 = NbPiece.ToString();
            NumEtage1 = NumEtage.ToString();
            Titre1 = Titre;
            

        }

        public void Recuperation(string id)
        {
            using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
            {

                bien = client.LireDetailsBienImmobilier(ID).Bien;


                if (bien != null)
                {
                    if (bien.DateMiseEnTransaction.ToString() != "") DateMiseEnTransaction = bien.DateMiseEnTransaction.ToString(); else DateMiseEnTransaction = "pas renseigné";
                    if (bien.Description != "") Description = bien.Description; else Description = "Pas renseigné";
                    if (bien.DateTransaction.ToString() != "") DateTransaction = bien.DateTransaction.ToString(); else DateTransaction = "Pas renseigné";
                    if (bien.EnergieChauffage.ToString() != "") EnergieChauffage = bien.EnergieChauffage.ToString(); else EnergieChauffage = "Pas renseigné";
                    if (bien.TypeChauffage.ToString() != "") TypeChauffage = bien.TypeChauffage.ToString(); else TypeChauffage = "Pas renseigné";
                    if (bien.TypeTransaction.ToString() != "") TypeTransaction = bien.TypeTransaction.ToString(); else TypeTransaction = "Pas renseigné";
                    if (bien.Adresse != "") Adresse = bien.Adresse; else TypeChauffage = "Pas renseigné";
                    if (bien.CodePostal != "") codePostal = bien.CodePostal; else Adresse = "Pas renseigné";
                    if (bien.Ville != "") Ville = bien.Ville; else Ville = "Pas renseigné";
                    if (bien.MontantCharges != -1) MontantCharge = bien.MontantCharges; else MontantCharge = 0.0;
                    if (bien.Prix != -1) Prix = bien.Prix; else Prix = 0.0;
                    if (bien.Surface != -1) Surface = bien.Surface; else Surface = 0;
                    if (bien.NbEtages != -1) NbEtage = bien.NbEtages; else NbEtage = 0;
                    if (bien.NbPieces != -1) NbPiece = bien.NbPieces; else NbPiece = 0;
                    if (bien.NumEtage != -1) NumEtage = bien.NumEtage; else NumEtage = 0;
                    if (bien.Titre != "") Titre = bien.Titre; else Titre = "Pas renseigné";
                    if (bien.PhotoPrincipaleBase64 != "") Photo = bien.PhotoPrincipaleBase64; else TypeChauffage = "Pas renseigné";
                    if (bien.TypeBien.ToString() != "") TypeBien = bien.TypeBien.ToString(); else TypeBien = "Pas renseigné";

                }

            }
        }


    }
}
