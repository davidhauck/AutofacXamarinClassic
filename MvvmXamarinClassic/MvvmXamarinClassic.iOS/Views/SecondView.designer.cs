// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MvvmXamarinClassic.iOS.Views
{
    [Register ("SecondView")]
    partial class SecondView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TextField != null) {
                TextField.Dispose ();
                TextField = null;
            }
        }
    }
}