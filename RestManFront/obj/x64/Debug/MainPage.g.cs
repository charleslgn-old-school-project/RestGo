﻿#pragma checksum "C:\Users\cyril\source\repos\RestMan\RestMan\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1B93EBC4523BB133A9A92C7DB5C3B2B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestMan
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 10
                {
                    this.Principal = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // MainPage.xaml line 34
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4: // MainPage.xaml line 36
                {
                    this.Sousmenus = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.Sousmenus).SelectionChanged += this.Sousmenus_SelectionChanged;
                }
                break;
            case 5: // MainPage.xaml line 37
                {
                    this.Accueil = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6: // MainPage.xaml line 43
                {
                    this.Langue = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 7: // MainPage.xaml line 49
                {
                    this.Propos = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 8: // MainPage.xaml line 30
                {
                    this.Hamburger = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Hamburger).Click += this.Hamburger_Click;
                }
                break;
            case 9: // MainPage.xaml line 31
                {
                    this.Retour = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Retour).Click += this.Retour_Click;
                }
                break;
            case 10: // MainPage.xaml line 32
                {
                    this.Avant = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Avant).Click += this.Avant_Click;
                }
                break;
            case 11: // MainPage.xaml line 21
                {
                    this.Content = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 12: // MainPage.xaml line 22
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
