﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Xamarin.Forms;

namespace VoiceCommand
{
    public class App : Application
    {
        public App()
        {
            MainPage = new VoiceCommand.LoginPage();//new NavigationPage (new VoiceCommand.LoginPage());
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