﻿#pragma checksum "..\..\Admin-Panel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76F64D3947C48850CAE7D3AE55C84B448E94E97197DFD99485C8AA9B2BCC9B51"
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
using System.Windows.Shell;
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// Admin_Panel
    /// </summary>
    public partial class Admin_Panel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Admin-Panel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmployees;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Admin-Panel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBooks;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Admin-Panel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMoneyBank;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Admin-Panel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border EmploeePanel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Admin-Panel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddEmploee;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Admin-Panel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminateEmployee;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Admin-Panel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeposit;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/admin-panel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admin-Panel.xaml"
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
            this.btnEmployees = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Admin-Panel.xaml"
            this.btnEmployees.Click += new System.Windows.RoutedEventHandler(this.btnEmployees_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnBooks = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Admin-Panel.xaml"
            this.btnBooks.Click += new System.Windows.RoutedEventHandler(this.btnBooks_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnMoneyBank = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Admin-Panel.xaml"
            this.btnMoneyBank.Click += new System.Windows.RoutedEventHandler(this.btnMoneyBank_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EmploeePanel = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.btnAddEmploee = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.btnEliminateEmployee = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnDeposit = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

