﻿#pragma checksum "..\..\..\..\TriviaGame\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43FCF33037E150D94354A1543FB31E97F0CF612B"
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
using TriviaGame;


namespace TriviaGame {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\TriviaGame\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtQuestion;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\TriviaGame\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.UniformGrid QuestionsArea;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\TriviaGame\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton A1;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\TriviaGame\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton A2;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\TriviaGame\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton A3;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\TriviaGame\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton A4;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\TriviaGame\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel EndScreen;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\TriviaGame\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CorrectCount;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\TriviaGame\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNext;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GameClient;component/triviagame/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\TriviaGame\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtQuestion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.QuestionsArea = ((System.Windows.Controls.Primitives.UniformGrid)(target));
            return;
            case 3:
            this.A1 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.A2 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.A3 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.A4 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.EndScreen = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.CorrectCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\TriviaGame\MainWindow.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.btnConfirmAnswer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
