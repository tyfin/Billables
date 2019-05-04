// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Billables.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UILabel accDailyLabel { get; set; }


        [Outlet]
        UIKit.UITextField accTF { get; set; }


        [Outlet]
        UIKit.UILabel accYearLabel { get; set; }


        [Outlet]
        UIKit.UILabel billDailyLabel { get; set; }


        [Outlet]
        UIKit.UITextField billTF { get; set; }


        [Outlet]
        UIKit.UILabel billYearLabel { get; set; }


        [Outlet]
        UIKit.UIButton Button { get; set; }


        [Outlet]
        UIKit.UITextField firmHolidayTF { get; set; }


        [Outlet]
        UIKit.UITextField vacationTF { get; set; }


        [Action ("onButtonClick:")]
        partial void onButtonClick (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (accDailyLabel != null) {
                accDailyLabel.Dispose ();
                accDailyLabel = null;
            }

            if (accTF != null) {
                accTF.Dispose ();
                accTF = null;
            }

            if (accYearLabel != null) {
                accYearLabel.Dispose ();
                accYearLabel = null;
            }

            if (billDailyLabel != null) {
                billDailyLabel.Dispose ();
                billDailyLabel = null;
            }

            if (billTF != null) {
                billTF.Dispose ();
                billTF = null;
            }

            if (billYearLabel != null) {
                billYearLabel.Dispose ();
                billYearLabel = null;
            }

            if (firmHolidayTF != null) {
                firmHolidayTF.Dispose ();
                firmHolidayTF = null;
            }

            if (vacationTF != null) {
                vacationTF.Dispose ();
                vacationTF = null;
            }
        }
    }
}