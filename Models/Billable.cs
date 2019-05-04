using System;

namespace Billables.Models
{
    public class Billable
    {

        public float currentBill { get; set; }
        public float currentAcc { get; set; }
        public int vacationDays { get; set; }
        public int firmHolidays { get; set; }
        private int days { get; set; }

        public float billRemaining { get; set; }
        public float billDaily { get; set; }
        public float accRemaining { get; set; }
        public float accDaily { get; set; }

        public Billable(float billables, float accountables, int vacation, int holidays)
        {
            currentBill = billables;
            currentAcc = accountables;
            vacationDays = vacation;
            firmHolidays = holidays;
        }

        private int DaysRemaining()
        {
            int days = 0;
            DateTime startDate = DateTime.Now;
            DateTime endDate = new DateTime(startDate.Year, 12, 31);

            while (startDate <= endDate)
            {
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    days++;
                    System.Diagnostics.Debug.WriteLine("Day added: {0}", startDate);
                }
                startDate = startDate.AddDays(1);
            }

            return days;
        }

        public void Calculate()
        {
            days = DaysRemaining() - vacationDays - firmHolidays;
            billRemaining = 2000 - currentBill;
            billDaily = billRemaining / days;
            accRemaining = 200 - currentAcc;
            accDaily = accRemaining / days;
        }

    }
}
