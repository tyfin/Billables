using System;
using System.Linq;
using Billables.Models;
using UIKit;

namespace Billables.iOS
{
    public partial class ViewController : UIViewController
    {

        Billable bill = new Billable(0.0f, 0.0f, 0, 0);

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Keyboard dismissal
            var g = new UITapGestureRecognizer(() => View.EndEditing(true));
            View.AddGestureRecognizer(g);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        partial void onButtonClick(UIButton sender)
        {

            //Dismiss keyboard
            View.EndEditing(true);

            // Prevents crashing if any of the fields are empty.  Find a more elegant solution.
            if (new[] {billTF.Text, accTF.Text, vacationTF.Text, firmHolidayTF.Text }.Contains(""))
            {
                return;
            }

            // Update
            updateModel();
            updateResults();
        }

        private void updateModel()
        {
            bill.currentBill = float.Parse(billTF.Text);
            bill.currentAcc = float.Parse(accTF.Text);
            bill.vacationDays = int.Parse(vacationTF.Text);
            bill.firmHolidays = int.Parse(firmHolidayTF.Text);
            bill.Calculate();
        }

        private void updateResults()
        {
            billYearLabel.Text = string.Format("{0}", bill.billRemaining);
            billDailyLabel.Text = string.Format("{0:N1}", bill.billDaily);
            accYearLabel.Text = string.Format("{0}", bill.accRemaining);
            accDailyLabel.Text = string.Format("{0:N1}", bill.accDaily);
        }
    }
}

