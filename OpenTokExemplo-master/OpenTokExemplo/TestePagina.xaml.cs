using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OpenTokExemplo
{
    public partial class TestePagina : ContentPage
    {
        bool TestaSpotify;
        bool TestaCalm;
        public TestePagina()
        {
            InitializeComponent();
            Testa();
        }

        public async Task Testa()
        {
            TestaSpotify = await Launcher.CanOpenAsync("spotify:");
            if (TestaSpotify)
                SpotifyLab.Text = "(Available)";
            else
                SpotifyLab.Text = "(Install)";

            TestaCalm = await Launcher.CanOpenAsync("calm://");
            if (TestaCalm)
                CalmLab.Text = "(Available)";
            else
                CalmLab.Text = "(Install)";
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Abre_Spotify();

        }
        private async Task Abre_Spotify()
        {

            if (TestaSpotify)
            {
                await Launcher.OpenAsync("spotify:track:0pNeVovbiZHkulpGeOx1Gj");
            }
            else
            {
                if (Device.RuntimePlatform == Device.Android)
                    await Launcher.OpenAsync("http://play.google.com/store/apps/details?id=com.spotify.music");
                else
                    await Launcher.OpenAsync("https://appstore.com/spotify/id324684580");
            }
        }

        async void Calm_Button(System.Object sender, System.EventArgs e)
        {

            if (TestaCalm)
            {
                await Launcher.OpenAsync("calm://");
            }
            else
            {
                if (Device.RuntimePlatform == Device.Android)
                    await Launcher.OpenAsync("http://play.google.com/store/apps/details?id=com.calm.android");
                else
                    await Launcher.OpenAsync("https://appstore.com/calm/id571800810");
            }
        }
    }
}
