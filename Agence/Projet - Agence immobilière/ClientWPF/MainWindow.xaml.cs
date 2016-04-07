using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace ClientWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged

    {

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

        public ServiceAgence.ResultatBienImmobilier Bien
        {
            get { return (ServiceAgence.ResultatBienImmobilier)GetProperty(); }
            set
            {
                SetProperty(value);
            }
        }


        public ServiceAgence.ListeBiensImmobiliers ListeBien
        {
            get
            {
                return (ServiceAgence.ListeBiensImmobiliers)GetProperty();
            }
            set
            {
                SetProperty(value);

            }
        }

        public ServiceAgence.BienImmobilierBase Detail
        {
            get
            {
                return (ServiceAgence.BienImmobilierBase)GetProperty();
            }
            set
            {
                SetProperty(value);
                if (value == null)
                    return;
                string id = Convert.ToString(value.Id);

                using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
                {
                    Bien = client.LireDetailsBienImmobilier(id);
                    //Bien.Bien.Code
                }
            }

        }


        public MainWindow()
        {

            this.DataContext = this;
            InitializeComponent();
            this.ListeBien = new ServiceAgence.ListeBiensImmobiliers();


        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

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

                ServiceAgence.ResultatListeBiensImmobiliers resultat = client.LireListeBiensImmobiliers(criteres, null, null);

                if (resultat.SuccesExecution)
                {
                    this.ListeBien = resultat.Liste;
                }

            }
        }

        private void Ajout_Click(object sender, RoutedEventArgs e)
        {
            Gestion fenetre = new Gestion();
            fenetre.ShowDialog();
            Window_Loaded(sender, e);

        }

        private void Recherche_Click(object sender, RoutedEventArgs e)
        {
            Recherche_Simple fenetre = new Recherche_Simple();
            fenetre.ShowDialog();
            String ville = fenetre.ville.ToUpper();
            Double prix = fenetre.prix;
            ServiceAgence.BienImmobilierBase.eTypeTransaction transac = fenetre.transac;
            ServiceAgence.BienImmobilierBase.eTypeBien bien = fenetre.bien;

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
                criteres.Prix2 = prix;
                criteres.Surface1 = -1;
                criteres.Surface2 = -1;
                criteres.TransactionEffectuee = null;
                criteres.TypeBien = bien;
                criteres.TypeChauffage = null;
                criteres.TypeTransaction = transac;
                criteres.Ville = ville;

                ServiceAgence.ResultatListeBiensImmobiliers resultat = client.LireListeBiensImmobiliers(criteres, null, null);

                if (resultat.SuccesExecution)
                {
                    this.ListeBien = resultat.Liste;
                }

            }


        }
        private void Recherche2_Click(object sender, RoutedEventArgs e)
        {
            Recherche_Avancee fenetre = new Recherche_Avancee();
            fenetre.ShowDialog();
            String ville = fenetre.villes.ToUpper();
            ServiceAgence.BienImmobilierBase.eEnergieChauffage chauff = fenetre.chauff;
            ServiceAgence.BienImmobilierBase.eTypeTransaction transac = fenetre.transac;
            ServiceAgence.BienImmobilierBase.eTypeBien bien = fenetre.bien;
            ServiceAgence.BienImmobilierBase.eTypeChauffage typechauff = fenetre.energ;
            Double prixmin = fenetre.prxmin;
            Double prixmax = fenetre.prxmax;
            Double surfmin = fenetre.sufmin;
            Double surfmax = fenetre.sufmax;
            int piecemin = fenetre.nbpiecemin;
            int piecemax = fenetre.nbpiecemax;
            int etagemin = fenetre.nueta1;
            int etagemax = fenetre.nueta2;

            using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
            {

                ServiceAgence.CriteresRechercheBiensImmobiliers criteres = new ServiceAgence.CriteresRechercheBiensImmobiliers();
                criteres.DateMiseEnTransaction1 = null;
                criteres.DateMiseEnTransaction2 = null;
                criteres.DateTransaction1 = null;
                criteres.DateTransaction2 = null;
                criteres.EnergieChauffage = chauff;
                criteres.MontantCharges1 = -1;
                criteres.MontantCharges2 = -1;
                criteres.NbEtages1 = etagemin;
                criteres.NbEtages2 = etagemax;
                criteres.NbPieces1 = piecemin;
                criteres.NbPieces2 = piecemax;
                criteres.NumEtage1 = -1;
                criteres.NumEtage2 = -1;
                criteres.Prix1 = prixmin;
                criteres.Prix2 = prixmax;
                criteres.Surface1 = surfmin;
                criteres.Surface2 = surfmax;
                criteres.TransactionEffectuee = null;
                criteres.TypeBien = bien;
                criteres.TypeChauffage = typechauff;
                criteres.TypeTransaction = transac;
                criteres.Ville = ville;

                ServiceAgence.ResultatListeBiensImmobiliers resultat = client.LireListeBiensImmobiliers(criteres, null, null);

                if (resultat.SuccesExecution)
                {
                    this.ListeBien = resultat.Liste;
                }



            }
        }

        
        private void Modifier(object sender, RoutedEventArgs e)
        {
            String id = ((Button)sender).Tag.ToString();
            Gestion fenetre = new Gestion(id);
            fenetre.ShowDialog();


        }

        private void Supprimer(object sender, RoutedEventArgs e)
        {
            String id = ((Button)sender).Tag.ToString();
            using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
            {
                client.SupprimerBienImmobilier(id);
            }

            Window_Loaded(sender, e);


        }


    }
}
