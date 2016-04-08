using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace ClientWPF
{
    /// <summary>
    /// Logique d'interaction pour Gestion.xaml
    /// </summary>
    public partial class Gestion : Window, INotifyPropertyChanged
    {
        string ID;
        public BitmapImage Photo { get; private set; }


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

        public Gestion()
        {
            this.DataContext = this;
            InitializeComponent();
            this.RecupBien = new ServiceAgence.BienImmobilier();

        }

        public Gestion(string id)
        {
            this.DataContext = this;
            this.ID = id;
            InitializeComponent();
            this.RecupBien = new ServiceAgence.BienImmobilier();
        }

        public ServiceAgence.BienImmobilier RecupBien
        {
            get
            {
                return (ServiceAgence.BienImmobilier)GetProperty();
            }
            set
            {
                SetProperty(value);

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
            {
                if (ID != null)
                {
                    RecupBien = client.LireDetailsBienImmobilier(ID).Bien;
                }
                else
                {
                    RecupBien = new ServiceAgence.BienImmobilier();
                    RecupBien.PhotosBase64 = new ObservableCollection<string>();

                }
            }
        }

        public void AjoutBien(object sender, EventArgs e)
        {

            if (ID != null)
            {
                ModifBien(sender, e);
            }
            else
            {

                using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
                {
                   

                    client.AjouterBienImmobilier(RecupBien);
                    this.Close();
                }
            }
        }


        public void ModifBien(object sender, EventArgs e)
        {
           

            using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
            {
               
                
                client.ModifierBienImmobilier(RecupBien);
                this.Close();
            }

        }

      
        //Ajout d'un photo - Code de Thérence Brune
        private void LoadPhoto_Click(object sender, RoutedEventArgs e)
        {
            
            BitmapImage no = new BitmapImage();
            Microsoft.Win32.OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir la photo";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(op.FileName);
                double[] sizeImage = getRatioImage(bmp);
                if (sizeImage == null)
                {
                    return;
                }
                bmp = new System.Drawing.Bitmap(bmp, new System.Drawing.Size((int)sizeImage[0], (int)sizeImage[1]));
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                no.BeginInit();
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                no.StreamSource = stream;
                no.EndInit();
                Photo = no;

                RecupBien.PhotosBase64.Add(BitmapToBase64(no));
              

            }
        }


        #region Outils
        public string BitmapToBase64(BitmapImage bi)
        {
            MemoryStream ms = new MemoryStream();
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bi));
            encoder.Save(ms);
            byte[] bitmapdata = ms.ToArray();

            return Convert.ToBase64String(bitmapdata);
        }
        private double[] getRatioImage(System.Drawing.Bitmap bmp)
        {
            double[] tmp = new double[2];
            double ratio = ((double)bmp.Width / (double)bmp.Height);
            double targetHeight;
            /*le 250 c'est la valeur min que vous voulez en taille de photo(250*250)*/
            if (Math.Max(bmp.Width, bmp.Height) <= 250)
            {
                return null;
            }
            double targetWidth = targetHeight = Math.Max(bmp.Width, bmp.Height);
            if (ratio == 1)
            {
                targetHeight = 250;
                targetWidth = 250;
            }
            else if (ratio < 1)
            {
                targetHeight = 250;
                targetWidth = 250 * ratio;
            }
            else
            {
                targetHeight = 250 / ratio;
                targetWidth = 250;
            }
            tmp[0] = targetWidth;
            tmp[1] = targetHeight;
            return tmp;
        }

        #endregion



    }

    

}

