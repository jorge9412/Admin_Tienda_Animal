﻿#pragma checksum "..\..\..\..\Vistas\Content_ListaEnvios.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DDC74028F40A1F0A5BC8CB119E32EAE54D38205E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AdminAlmacen.Vistas;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace AdminAlmacen.Vistas {
    
    
    /// <summary>
    /// Content_ListaEnvios
    /// </summary>
    public partial class Content_ListaEnvios : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Vistas\Content_ListaEnvios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridEnvios;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Vistas\Content_ListaEnvios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridDatosEnvios;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Vistas\Content_ListaEnvios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegistrarEnvio;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Vistas\Content_ListaEnvios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_buscar_envio;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Vistas\Content_ListaEnvios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_buscar_envio;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AdminAlmacen;component/vistas/content_listaenvios.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vistas\Content_ListaEnvios.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GridEnvios = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.GridDatosEnvios = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.BtnRegistrarEnvio = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Vistas\Content_ListaEnvios.xaml"
            this.BtnRegistrarEnvio.Click += new System.Windows.RoutedEventHandler(this.irRegistroEnvioClik);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lbl_buscar_envio = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txt_buscar_envio = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\..\Vistas\Content_ListaEnvios.xaml"
            this.txt_buscar_envio.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_buscar_envio_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

