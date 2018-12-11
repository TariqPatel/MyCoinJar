// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MyCoinJarApp.iOS.Views
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CoinAddToJarButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CoinAmountDescriptionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CoinAmountLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CoinErrorLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UINavigationBar CoinNavigationBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView CoinPickerView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CoinResetJarButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CoinAddToJarButton != null) {
                CoinAddToJarButton.Dispose ();
                CoinAddToJarButton = null;
            }

            if (CoinAmountDescriptionLabel != null) {
                CoinAmountDescriptionLabel.Dispose ();
                CoinAmountDescriptionLabel = null;
            }

            if (CoinAmountLabel != null) {
                CoinAmountLabel.Dispose ();
                CoinAmountLabel = null;
            }

            if (CoinErrorLabel != null) {
                CoinErrorLabel.Dispose ();
                CoinErrorLabel = null;
            }

            if (CoinNavigationBar != null) {
                CoinNavigationBar.Dispose ();
                CoinNavigationBar = null;
            }

            if (CoinPickerView != null) {
                CoinPickerView.Dispose ();
                CoinPickerView = null;
            }

            if (CoinResetJarButton != null) {
                CoinResetJarButton.Dispose ();
                CoinResetJarButton = null;
            }
        }
    }
}