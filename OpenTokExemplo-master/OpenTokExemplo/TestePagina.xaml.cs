using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OpenTokExemplo
{
    public partial class TestePagina : ContentPage
    {
        public TestePagina()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Abre_Spotify();

        }
        private async Task Abre_Spotify()
        {
            var supportsUri = await Launcher.CanOpenAsync("spotify:");
            if (supportsUri)
            {
                await Launcher.OpenAsync("spotify:");
            }
            else
            {
                if (Device.RuntimePlatform == Device.Android)
                    await Launcher.OpenAsync("http://play.google.com/store/apps/details?id=com.spotify.music");
                else
                    await Launcher.OpenAsync("http://appstore.com/spotify");
            }
        }

        async void Calm_Button(System.Object sender, System.EventArgs e)
        {
            var supportsUri = await Launcher.CanOpenAsync("calm://");
            if (supportsUri)
            {
                await Launcher.OpenAsync("calm://");
            }
            else
            {
                if (Device.RuntimePlatform == Device.Android)
                    await Launcher.OpenAsync("http://play.google.com/store/apps/details?id=com.calm.android");
                else
                    await Launcher.OpenAsync("http://appstore.com/calm");
            }
        }

        async void Podcast_Button(System.Object sender, System.EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                var supportsUri = await Launcher.CanOpenAsync("http://podcasts.google.com");
                if (supportsUri)
                {
                    await Launcher.OpenAsync("http://podcasts.google.com");
                }
                else
                {
                    await Launcher.OpenAsync("http://play.google.com/store/apps/details?id=com.google.android.apps.podcasts");
                }
            }
        }
    }
}
