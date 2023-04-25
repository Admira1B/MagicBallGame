﻿#pragma checksum "..\..\GameWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C466A53D3ED665F7B3A2C990490EC3EB5886BC702C8142F93D18A91CB21454ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GameMagicBall;
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


namespace GameMagicBall {
    
    
    /// <summary>
    /// GameWindow
    /// </summary>
    public partial class GameWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 198 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HideWindowButton;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MainMenuButton;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StatisticCheckButton;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MagicBall0;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MagicBall1;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuestionTextBlock;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MessengeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuestionTextBox;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResultButton;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ContinueButton;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView StatisticsListView;
        
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
            System.Uri resourceLocater = new System.Uri("/GameMagicBall;component/gamewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GameWindow.xaml"
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
            
            #line 8 "..\..\GameWindow.xaml"
            ((GameMagicBall.GameWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.GameWindow_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.HideWindowButton = ((System.Windows.Controls.Button)(target));
            
            #line 198 "..\..\GameWindow.xaml"
            this.HideWindowButton.Click += new System.Windows.RoutedEventHandler(this.HideWindowButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 199 "..\..\GameWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MainMenuButton = ((System.Windows.Controls.Button)(target));
            
            #line 202 "..\..\GameWindow.xaml"
            this.MainMenuButton.Click += new System.Windows.RoutedEventHandler(this.MainMenuButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StatisticCheckButton = ((System.Windows.Controls.Button)(target));
            
            #line 203 "..\..\GameWindow.xaml"
            this.StatisticCheckButton.Click += new System.Windows.RoutedEventHandler(this.StatisticCheckButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MagicBall0 = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.MagicBall1 = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.QuestionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.MessengeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.QuestionTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 210 "..\..\GameWindow.xaml"
            this.QuestionTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.QuestionTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ResultButton = ((System.Windows.Controls.Button)(target));
            
            #line 213 "..\..\GameWindow.xaml"
            this.ResultButton.Click += new System.Windows.RoutedEventHandler(this.ResultButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ContinueButton = ((System.Windows.Controls.Button)(target));
            
            #line 214 "..\..\GameWindow.xaml"
            this.ContinueButton.Click += new System.Windows.RoutedEventHandler(this.ContinueButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.StatisticsListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

