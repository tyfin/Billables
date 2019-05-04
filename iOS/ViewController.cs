using System;
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
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        partial void onButtonClick(UIButton sender)
        {
            bill.currentBill = float.Parse(billTF.Text);
            bill.currentAcc = float.Parse(accTF.Text);
            bill.vacationDays = int.Parse(vacationTF.Text);
            bill.firmHolidays = int.Parse(firmHolidayTF.Text);
            Console.WriteLine("Button clicked.");
            bill.Calculate();
            Console.WriteLine("Calculations run.");
            updateResults();
        }

        private void updateResults()
        {
            billYearLabel.Text = string.Format("{0}", bill.billRemaining);
            billDailyLabel.Text = string.Format("{0:N2}", bill.billDaily);
            accYearLabel.Text = string.Format("{0}", bill.accRemaining);
            accDailyLabel.Text = string.Format("{0:N2}", bill.accDaily);
        }
    }
}

