#pragma checksum "..\..\..\Windows\AddChangeWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F98F6FCF104D2191C24CBE8D4945806176E0A8F74616DE053C7C6374E89AF72B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NamordnikApp.Windows;
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


namespace NamordnikApp.Windows {
    
    
    /// <summary>
    /// AddChangeWindow
    /// </summary>
    public partial class AddChangeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PhotoImg;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddImageBtn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ArticleTb;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleTb;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeCb;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AmountTb;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WorkshopTb;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTb;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescrTb;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Windows\AddChangeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/NamordnikApp;component/windows/addchangewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddChangeWindow.xaml"
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
            this.PhotoImg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.AddImageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Windows\AddChangeWindow.xaml"
            this.AddImageBtn.Click += new System.Windows.RoutedEventHandler(this.AddImageBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ArticleTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\Windows\AddChangeWindow.xaml"
            this.ArticleTb.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.ArticleTb_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\Windows\AddChangeWindow.xaml"
            this.ArticleTb.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ArticleTb_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TitleTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TypeCb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.AmountTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\Windows\AddChangeWindow.xaml"
            this.AmountTb.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.AmountTb_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 70 "..\..\..\Windows\AddChangeWindow.xaml"
            this.AmountTb.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.AmountTb_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.WorkshopTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\Windows\AddChangeWindow.xaml"
            this.WorkshopTb.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.WorkshopTb_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 75 "..\..\..\Windows\AddChangeWindow.xaml"
            this.WorkshopTb.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.WorkshopTb_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PriceTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\..\Windows\AddChangeWindow.xaml"
            this.PriceTb.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.PriceTb_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 81 "..\..\..\Windows\AddChangeWindow.xaml"
            this.PriceTb.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PriceTb_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DescrTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\Windows\AddChangeWindow.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.DelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\Windows\AddChangeWindow.xaml"
            this.DelBtn.Click += new System.Windows.RoutedEventHandler(this.DelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

