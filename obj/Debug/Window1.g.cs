﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BFF528C4020A7A4DEA3F5DD7586BB585"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace WPFCSharpWebCam {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPFCSharpWebCam.Window1 mainWindow;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntStart;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl MyTabController;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgVideo;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgVideo1;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbStat;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtbStat;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntStop;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFCSharpWebCam;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            this.mainWindow = ((WPFCSharpWebCam.Window1)(target));
            
            #line 8 "..\..\Window1.xaml"
            this.mainWindow.Loaded += new System.Windows.RoutedEventHandler(this.mainWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bntStart = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Window1.xaml"
            this.bntStart.Click += new System.Windows.RoutedEventHandler(this.bntStart_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MyTabController = ((System.Windows.Controls.TabControl)(target));
            return;
            case 4:
            this.imgVideo = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.imgVideo1 = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.lbStat = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtbStat = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.bntStop = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\Window1.xaml"
            this.bntStop.Click += new System.Windows.RoutedEventHandler(this.bntStop_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
