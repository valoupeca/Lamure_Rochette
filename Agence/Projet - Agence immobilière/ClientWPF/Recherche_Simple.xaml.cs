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
    /// Logique d'interaction pour Recherche_Simple.xaml
    /// </summary>
    public partial class Recherche_Simple : Window, INotifyPropertyChanged
    {

        public Recherche_Simple()
        {
            this.DataContext = this;
            InitializeComponent();
        }

        public Double prix { get; set; }
        public int rempli { get; set; }
        public String ville { get; set; }
        public ServiceAgence.BienImmobilierBase.eTypeTransaction transac { get; set; }
        public ServiceAgence.BienImmobilierBase.eTypeBien bien { get; set; }


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


        private void Recherche_S(object sender, RoutedEventArgs e)
        {
            
            if (prixentre.Text != "") { prix = Convert.ToDouble(this.prixentre.Text); } else { prix = -1; }
            if (villeentre.Text != "") { ville = this.villeentre.Text; rempli += 1; } else { ville = null; }
            if (Bienselect != null) { bien = (ServiceAgence.BienImmobilierBase.eTypeBien)this.Bienselect; }
            if (TransacSelect != null) { transac = (ServiceAgence.BienImmobilierBase.eTypeTransaction)this.TransacSelect;}
            this.Close();

        }


    }
}
