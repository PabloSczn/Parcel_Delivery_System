﻿#pragma checksum "..\..\TransferParcels.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B3506491E1E36D8464DC3B1B6A2DD70AE9D6316AD7D2EE74187559F2CDF6E065"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Coursework02;
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
using System.Windows.Shell;


namespace Presentation {
    
    
    /// <summary>
    /// TransferParcels
    /// </summary>
    public partial class TransferParcels : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\TransferParcels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LstCouriers1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\TransferParcels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LstCouriers2;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\TransferParcels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Transfer;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\TransferParcels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Home;
        
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
            System.Uri resourceLocater = new System.Uri("/Coursework02;component/transferparcels.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TransferParcels.xaml"
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
            this.LstCouriers1 = ((System.Windows.Controls.ListBox)(target));
            
            #line 10 "..\..\TransferParcels.xaml"
            this.LstCouriers1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LstCouriers1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LstCouriers2 = ((System.Windows.Controls.ListBox)(target));
            
            #line 11 "..\..\TransferParcels.xaml"
            this.LstCouriers2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LstCouriers2_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_Transfer = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\TransferParcels.xaml"
            this.Btn_Transfer.Click += new System.Windows.RoutedEventHandler(this.Btn_Transfer_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn_Home = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\TransferParcels.xaml"
            this.Btn_Home.Click += new System.Windows.RoutedEventHandler(this.Btn_Home_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
