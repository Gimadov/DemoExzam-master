﻿#pragma checksum "..\..\..\View\AddAgentPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DB591D68905CB4E55710BA18B441FD5735084AE16001C08FB59937678C41B489"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DemoExzam.View;
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


namespace DemoExzam.View {
    
    
    /// <summary>
    /// AddAgentPage
    /// </summary>
    public partial class AddAgentPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\AddAgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\AddAgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleTxt;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\AddAgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeProduct;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\AddAgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ArticleNum;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\AddAgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountHumProd;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\AddAgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumbProd;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\AddAgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MinCostFA;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\AddAgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image LogoFrame;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\AddAgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\View\AddAgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/DemoExzam;component/view/addagentpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AddAgentPage.xaml"
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
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\View\AddAgentPage.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TitleTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TypeProduct = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.ArticleNum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CountHumProd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.NumbProd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.MinCostFA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.LogoFrame = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.LogoBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\View\AddAgentPage.xaml"
            this.LogoBtn.Click += new System.Windows.RoutedEventHandler(this.LogoBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AddNewProduct = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\View\AddAgentPage.xaml"
            this.AddNewProduct.Click += new System.Windows.RoutedEventHandler(this.AddAgentBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

