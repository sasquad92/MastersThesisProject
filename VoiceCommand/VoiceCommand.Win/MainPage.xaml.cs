﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibServ;

namespace VoiceCommand.Win
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Microphone mic = new Microphone();
        WitAiServ wit = new WitAiServ();

        // on wit.ai button clicked
        private void OnRecord( object sender, RoutedEventArgs e )
        {
            mic.ListDevices();
            mic.RecordAndSaveWin();
            //mic.RecordAndPlay();
        }

        private async void OnStop( object sender, RoutedEventArgs e )
        {
            mic.StopRecording();
            byte[] audioFile = mic.ProcessSpeech();
            await wit.SendItem( audioFile );
        }
    }
}
