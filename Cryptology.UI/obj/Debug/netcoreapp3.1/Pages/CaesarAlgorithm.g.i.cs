﻿#pragma checksum "..\..\..\..\Pages\CaesarAlgorithm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F9DE8653CFF853FA13FA369CE7CB1A52A05FFEBF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cryptology.UI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using System.Windows.Shell;


namespace Cryptology.UI {
    
    
    /// <summary>
    /// CaesarAlgorithmPage
    /// </summary>
    public partial class CaesarAlgorithmPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbInputText;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOutputText;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbShift;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbMode;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProcess;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnalyze;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDetails;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Cryptology.UI;component/pages/caesaralgorithm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbInputText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbOutputText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbShift = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cbMode = ((System.Windows.Controls.CheckBox)(target));
            
            #line 83 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
            this.cbMode.Click += new System.Windows.RoutedEventHandler(this.CbModeClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnProcess = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
            this.btnProcess.Click += new System.Windows.RoutedEventHandler(this.BtnProcessClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAnalyze = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
            this.btnAnalyze.Click += new System.Windows.RoutedEventHandler(this.BtnAnalyzeClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDetails = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\..\Pages\CaesarAlgorithm.xaml"
            this.btnDetails.Click += new System.Windows.RoutedEventHandler(this.BtnDetailsClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

