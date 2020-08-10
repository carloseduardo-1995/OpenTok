using System;
using Xamarin.Forms;
using Xamarin.Forms.OpenTok.Service;
using Xamarin.Forms.Xaml;

namespace OpenTokExemplo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            CrossOpenTok.Current.ApiKey = "46685512";
            CrossOpenTok.Current.SessionId = "1_MX40NjY4NTUxMn5-MTU4ODAwNDU0NjE0NH5IMjFEZ1RUQTAxTEU4T2M0SURnRnRKMFd-fg";
            CrossOpenTok.Current.UserToken = "T1==cGFydG5lcl9pZD00NjY4NTUxMiZzaWc9ZjVhN2U4NWNmNjFjYTg0MDgyNTExNGMwNWZiNmJmOTFmNTJiN2U4MDpzZXNzaW9uX2lkPTFfTVg0ME5qWTROVFV4TW41LU1UVTRPREF3TkRVME5qRTBOSDVJTWpGRVoxUlVRVEF4VEVVNFQyTTBTVVJuUm5SS01GZC1mZyZjcmVhdGVfdGltZT0xNTg4MDA0NTYyJm5vbmNlPTAuNDQ2OTU0OTY0NTg4MTEyMSZyb2xlPXB1Ymxpc2hlciZleHBpcmVfdGltZT0xNTg4NjA5MzYxJmluaXRpYWxfbGF5b3V0X2NsYXNzX2xpc3Q9";

            MainPage = new NavigationPage( new TestePagina());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
