﻿

#pragma checksum "C:\GitHub\Projects\MySelfies-Windows8.1\MySelfies.Windows\Views\SmallTilesListPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E88F39BF3271874C20DF9C70AC19F0AD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySelfies.Views
{
    partial class SmallTilesListPage : global::MySelfies.PageBase
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::MySelfies.Controls.PageHeaderControl Header; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock Title; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid ContentHost; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ContentPresenter ContentHostSnapped; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState SnappedView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState FullscreenView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Views/SmallTilesListPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            Header = (global::MySelfies.Controls.PageHeaderControl)this.FindName("Header");
            Title = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("Title");
            ContentHost = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("ContentHost");
            ContentHostSnapped = (global::Windows.UI.Xaml.Controls.ContentPresenter)this.FindName("ContentHostSnapped");
            SnappedView = (global::Windows.UI.Xaml.VisualState)this.FindName("SnappedView");
            FullscreenView = (global::Windows.UI.Xaml.VisualState)this.FindName("FullscreenView");
        }
    }
}



