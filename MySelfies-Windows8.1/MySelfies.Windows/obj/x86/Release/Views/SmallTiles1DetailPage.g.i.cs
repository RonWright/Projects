﻿

#pragma checksum "C:\Projects\MySelfies-Windows8.1\MySelfies.Windows\Views\SmallTiles1DetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "287EC2580C1FC7400C817039575CF13C"
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
    partial class SmallTiles1DetailPage : global::MySelfies.PageBase
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState SnappedView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState FullscreenView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ContentPresenter ContentHost; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ContentPresenter ContentHostSnapped; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Views/SmallTiles1DetailPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            SnappedView = (global::Windows.UI.Xaml.VisualState)this.FindName("SnappedView");
            FullscreenView = (global::Windows.UI.Xaml.VisualState)this.FindName("FullscreenView");
            ContentHost = (global::Windows.UI.Xaml.Controls.ContentPresenter)this.FindName("ContentHost");
            ContentHostSnapped = (global::Windows.UI.Xaml.Controls.ContentPresenter)this.FindName("ContentHostSnapped");
        }
    }
}



