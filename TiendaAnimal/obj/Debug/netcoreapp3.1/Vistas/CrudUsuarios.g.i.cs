﻿#pragma checksum "..\..\..\..\Vistas\CrudUsuarios.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3D0B050E99CA92B89F049E18960B4BC7BED1015C"
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
    /// CrudUsuarios
    /// </summary>
    public partial class CrudUsuarios : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\Vistas\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_nombres;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Vistas\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_apellidos;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Vistas\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_cedula;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Vistas\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_correo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Vistas\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_usuario;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Vistas\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_contraseña;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Vistas\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_guardar_editar_usuario;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Vistas\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cerrar_actualizar;
        
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
            System.Uri resourceLocater = new System.Uri("/AdminAlmacen;V1.0.0.0;component/vistas/crudusuarios.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vistas\CrudUsuarios.xaml"
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
            this.txt_nombres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_apellidos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_cedula = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_correo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_usuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txt_contraseña = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btn_guardar_editar_usuario = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Vistas\CrudUsuarios.xaml"
            this.btn_guardar_editar_usuario.Click += new System.Windows.RoutedEventHandler(this.btn_actualizar);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_cerrar_actualizar = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Vistas\CrudUsuarios.xaml"
            this.btn_cerrar_actualizar.Click += new System.Windows.RoutedEventHandler(this.btn_cerrar);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

