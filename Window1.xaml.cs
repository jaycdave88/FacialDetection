﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCSharpWebCam
{
    /// <summary>
    /// Design by Pongsakorn Poosankam
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        WebCam webcam;
        private void mainWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
           
        }

        private void bntStart_Click(object sender, RoutedEventArgs e)
        {
            if (MyTabController.SelectedIndex == 0)
            {
                webcam = new WebCam();
                webcam.InitializeWebCam(ref imgVideo);
            }
            else if(MyTabController.SelectedIndex == 1)
            {
                webcam = new WebCam();
                webcam.InitializeWebCam(ref imgVideo1);
            }

            webcam.Start();
        }

        private void bntStop_Click(object sender, RoutedEventArgs e)
        {
            webcam.Stop();
        }
    }
}
