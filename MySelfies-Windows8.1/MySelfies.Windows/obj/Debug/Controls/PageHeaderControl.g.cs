﻿

#pragma checksum "C:\Projects\MySelfies-Windows8.1\MySelfies.Windows\Controls\PageHeaderControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A1F2C34FE788F265D219DAE25F4B8ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySelfies.Controls
{
    partial class PageHeaderControl : global::Windows.UI.Xaml.Controls.UserControl, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 60 "..\..\Controls\PageHeaderControl.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBackButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 26 "..\..\Controls\PageHeaderControl.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBackButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


