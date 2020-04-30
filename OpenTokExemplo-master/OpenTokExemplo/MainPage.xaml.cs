using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.OpenTok.Service;

namespace OpenTokExemplo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage,INotifyPropertyChanged
    {
        private bool _abreBarra = false;
        public bool AbreBarra
        {
            get { return _abreBarra; }
            set {
                _abreBarra = value;
                OnPropertyChanged("AbreBarra");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

       
        public MainPage()
        {
            InitializeComponent();
            
            NavigationPage.SetHasBackButton(this, false);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnEndCall(object sender, EventArgs e)
        {
            CrossOpenTok.Current.EndSession();
            Navigation.PopAsync();
            
        }

        private void OnSwapCamera(object sender, EventArgs e)
        {
            CrossOpenTok.Current.CycleCamera();
        }
        private void OnCamera(object sender, EventArgs e)
        {
            CrossOpenTok.Current.IsVideoPublishingEnabled = !CrossOpenTok.Current.IsVideoPublishingEnabled;
        }
        private void OnMicrofone(object sender, EventArgs e)
        {
            CrossOpenTok.Current.IsAudioPublishingEnabled = !CrossOpenTok.Current.IsAudioPublishingEnabled;
        }
        private void OnAbreMenu(object sender, EventArgs e)
        {
            _abreBarra = !_abreBarra;
            Botoes.IsEnabled = AbreBarra;
            Botoes.IsVisible = AbreBarra;
            Debug.WriteLine(_abreBarra.ToString());
        }
        
    }
}
