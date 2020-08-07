using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.OpenTok.Service;

namespace OpenTokExemplo
{
    public partial class IniciarPage : ContentPage
    {
        public IniciarPage()
        {
            InitializeComponent();
        }

        private void NavegarChat(object sender, EventArgs e)
        {
            if (!CrossOpenTok.Current.TryStartSession())
            {
                return;
            }
            Navigation.PushAsync(new MainPage());
            
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TestePagina());
        }
    }
}
