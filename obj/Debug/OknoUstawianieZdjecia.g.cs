﻿#pragma checksum "..\..\OknoUstawianieZdjecia.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5B2BA58BC49744B7C9591E37BF4EF9385C35B1E28FF60A2595DF4C1A4D414E2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Hotel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Hotel {
    
    
    /// <summary>
    /// OknoUstawianieZdjecia
    /// </summary>
    public partial class OknoUstawianieZdjecia : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\OknoUstawianieZdjecia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sciezka_zdjecia;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\OknoUstawianieZdjecia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ustaw_zdjecie;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\OknoUstawianieZdjecia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Powrot;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\OknoUstawianieZdjecia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Usun_zdjecie;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Hotel;component/oknoustawianiezdjecia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OknoUstawianieZdjecia.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Sciezka_zdjecia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Ustaw_zdjecie = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\OknoUstawianieZdjecia.xaml"
            this.Ustaw_zdjecie.Click += new System.Windows.RoutedEventHandler(this.Ustaw_zdjecie_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Powrot = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\OknoUstawianieZdjecia.xaml"
            this.Powrot.Click += new System.Windows.RoutedEventHandler(this.Powrot_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Usun_zdjecie = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\OknoUstawianieZdjecia.xaml"
            this.Usun_zdjecie.Click += new System.Windows.RoutedEventHandler(this.Usun_zdjecie_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

