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
    /// Logique d'interaction pour Recherche_Avancee.xaml
    /// </summary>
    public partial class Recherche_Avancee : Window, INotifyPropertyChanged
    {


        public Recherche_Avancee()
        {
            this.DataContext = this;
            InitializeComponent();
        }

        public Double prxmin { get; set; }
        public Double prxmax { get; set; }
        public Double sufmin { get; set; }
        public Double sufmax { get; set; }
        public int nbpiecemin { get; set; }
        public int nbpiecemax { get; set; }
        public int nueta1 { get; set; }
        public int nueta2 { get; set; }
        public String villes { get; set; }
        public ServiceAgence.BienImmobilierBase.eTypeTransaction transac { get; set; }
        public ServiceAgence.BienImmobilierBase.eTypeBien bien { get; set; }
        public ServiceAgence.BienImmobilierBase.eEnergieChauffage chauff { get; set; }
        public ServiceAgence.BienImmobilierBase.eTypeChauffage energ { get; set; }


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

        private void Recherche_S(object sender, RoutedEventArgs e)
        {
            
            if (prixmin.Text != "") { prxmin = Convert.ToDouble(this.prixmin.Text);  } else { prxmin = -1;  }
            if (prixmax.Text != "") { prxmax = Convert.ToDouble(this.prixmax.Text); } else { prxmax = -1; }
            if (surfmin.Text != "") { sufmin = Convert.ToDouble(this.surfmin.Text); } else { sufmin = -1; }
            if (surfmax.Text != "") { sufmax = Convert.ToDouble(this.surfmax.Text); } else { sufmax = -1; }
            if (nombrepiecemin.Text != "") { nbpiecemin = Convert.ToInt16(this.nombrepiecemin.Text); } else { nbpiecemin = -1; }
            if (nombrepiecemax.Text != "") { nbpiecemax = Convert.ToInt16(this.nombrepiecemax.Text); } else { nbpiecemax = -1; }
            if (etagemin.Text != "") { nueta1 = Convert.ToInt16(this.etagemin.Text); } else { nueta1 = -1; }
            if (etagemax.Text != "") { nueta2 = Convert.ToInt16(this.etagemax.Text); } else { nueta2 = -1; }
            if (ville.Text != "") { villes = ville.Text; } else { villes = null; }
            if (Bienselect != null) { bien = (ServiceAgence.BienImmobilierBase.eTypeBien)this.Bienselect; }
            if (TransacSelect != null) { transac = (ServiceAgence.BienImmobilierBase.eTypeTransaction)this.TransacSelect; } 
            if (EnergieSelect != null) { energ = (ServiceAgence.BienImmobilierBase.eTypeChauffage)this.EnergieSelect; } 
            if (ChaufSelect != null) { chauff = (ServiceAgence.BienImmobilierBase.eEnergieChauffage)this.ChaufSelect; } 
                this.Close();

        }


    }
}
