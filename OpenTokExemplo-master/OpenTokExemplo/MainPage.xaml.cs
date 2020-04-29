﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainPage : ContentPage
    {
        bool InserePublisher = true;
        
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }


        private void OnEndCall(object sender, EventArgs e)
        {
            CrossOpenTok.Current.EndSession();
            CrossOpenTok.Current.MessageReceived -= OnMessageReceived;
            Navigation.PopAsync();
            
        }

        private void OnMessage(object sender, EventArgs e)
        {
            CrossOpenTok.Current.SendMessageAsync($"Path.GetRandomFileName: {Path.GetRandomFileName()}");
        }

        private void OnSwapCamera(object sender, EventArgs e)
        {
            CrossOpenTok.Current.CycleCamera();
        }

        private void OnMessageReceived(string message)
        {
            DisplayAlert("Random message received", message, "OK");
        }
        private void OnCamera(object sender, EventArgs e)
        {
            if (CrossOpenTok.Current.IsVideoPublishingEnabled == true)
                CrossOpenTok.Current.IsVideoPublishingEnabled = false;
            else
                CrossOpenTok.Current.IsVideoPublishingEnabled = true;
        }
        private void OnMicrofone(object sender, EventArgs e)
        {
            if (CrossOpenTok.Current.IsAudioPublishingEnabled == true)
                CrossOpenTok.Current.IsAudioPublishingEnabled = false;
            else
                CrossOpenTok.Current.IsAudioPublishingEnabled = true;
        }
        
    }
}
