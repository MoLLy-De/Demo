﻿#pragma checksum "..\..\EfitOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "987A01FF0D6970D20B1DE0775FD9C57A59A28E87E6BBB04359014592FBAD055E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AF_WPF;
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


namespace AF_WPF {
    
    
    /// <summary>
    /// EfitOrder
    /// </summary>
    public partial class EfitOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\EfitOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ProductPanel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\EfitOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ArticleText;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\EfitOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameText;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\EfitOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionText;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\EfitOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProviderBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\EfitOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ManufactureText;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\EfitOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpBut;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\EfitOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelBut;
        
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
            System.Uri resourceLocater = new System.Uri("/AF_WPF;component/efitorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EfitOrder.xaml"
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
            this.ProductPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.ArticleText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.NameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DescriptionText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ProviderBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ManufactureText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.UpBut = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\EfitOrder.xaml"
            this.UpBut.Click += new System.Windows.RoutedEventHandler(this.UpBut_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DelBut = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\EfitOrder.xaml"
            this.DelBut.Click += new System.Windows.RoutedEventHandler(this.DelBut_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

