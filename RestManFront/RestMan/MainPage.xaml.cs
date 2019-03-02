﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RestMan
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //Process back = new Process();
            //back.StartInfo.UseShellExecute = false;
            //back.StartInfo.RedirectStandardOutput = true;
            //back.StartInfo.FileName = @"C:\Users\Cyril Challouatte\GolandProjects\RestMan\RestManFront\RestMan\Assets\test.exe";
            //back.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            //string output = back.StandardOutput.ReadToEnd();
            //back.WaitForExit();
            hideRec();
        }

        private void hideRec()
        {
            Accueil.Padding = new Thickness(5, 5, 0, 5);
            Langue.Padding = new Thickness(5, 5, 0, 5);
            Propos.Padding = new Thickness(5, 5, 0, 5);
            RecAccueil.Visibility = Visibility.Collapsed;
            RecLangue.Visibility = Visibility.Collapsed;
            RecPropos.Visibility = Visibility.Collapsed;
        }

        private void Hamburger_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Sousmenus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            hideRec();
            if (Accueil.IsSelected)
            {
                Accueil.Padding = new Thickness(0, 5, 0, 5);
                Langue.Padding = new Thickness(5, 5, 0, 5);
                Propos.Padding = new Thickness(5, 5, 0, 5);
                RecAccueil.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Home));
            }
            if (Langue.IsSelected)
            {
                Accueil.Padding = new Thickness(5, 5, 0, 5);
                Langue.Padding = new Thickness(0, 5, 0, 5);
                Propos.Padding = new Thickness(5, 5, 0, 5);
                RecLangue.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Langue));
            }
            if (Propos.IsSelected)
            {
                Accueil.Padding = new Thickness(5, 5, 0, 5);
                Langue.Padding = new Thickness(5, 5, 0, 5);
                Propos.Padding = new Thickness(0, 5, 0, 5);
                RecPropos.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Propos));
            }
        }
    }
}
