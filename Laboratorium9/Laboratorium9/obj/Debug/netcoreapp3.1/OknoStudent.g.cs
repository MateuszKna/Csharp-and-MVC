#pragma checksum "..\..\..\OknoStudent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46475C23E466C5B1885D5E26ABEAE1287487717E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Laboratorium9;
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


namespace Laboratorium9 {
    
    
    /// <summary>
    /// OknoStudent
    /// </summary>
    public partial class OknoStudent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\OknoStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ImieT;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\OknoStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NazwiskoT;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\OknoStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NrT;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\OknoStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WydzialT;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\OknoStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PotwierdzenieB;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\OknoStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Limie;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\OknoStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lnazwisko;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\OknoStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lnr;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\OknoStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lwydzial;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Laboratorium9;component/oknostudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OknoStudent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ImieT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NazwiskoT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.NrT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.WydzialT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PotwierdzenieB = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\OknoStudent.xaml"
            this.PotwierdzenieB.Click += new System.Windows.RoutedEventHandler(this.PotwierdzenieB_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Limie = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Lnazwisko = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Lnr = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Lwydzial = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

