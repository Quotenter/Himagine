﻿

#pragma checksum "C:\Users\tomoki_2\Documents\Visual Studio 2013\Projects\SYNAPSE\SYNAPSE\TimeLine.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BBB7387C7D1DCCF6DC23BC45D56A192D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SYNAPSE
{
    partial class TimeLine : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 22 "..\..\TimeLine.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.MenuFlyoutItem_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 23 "..\..\TimeLine.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.MenuFlyoutItem_Click_1;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 62 "..\..\TimeLine.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyUp += this.TweetDone;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 63 "..\..\TimeLine.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.TweetButton_clik;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


