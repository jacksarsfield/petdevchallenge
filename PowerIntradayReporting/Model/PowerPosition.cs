using System;
using System.Collections.Generic;
using PowerIntradayReporting.Constant;

namespace PowerIntradayReporting.Model
{
    public class PowerPosition
    {
        public PowerPosition(DateTime date)
        {
            var tzi = TimeZoneInfo.FindSystemTimeZoneById(ReportConstants.GmtStandardTime);

            Date = date;
            var start = TimeZoneInfo.ConvertTimeToUtc(date.AddHours(-1), tzi);
            var end = TimeZoneInfo.ConvertTimeToUtc(date.AddHours(-1).AddDays(1), tzi);

            var periods = new List<PowerPositionPeriod>();
            while(start < end)
            {
                periods.Add(new PowerPositionPeriod { PeriodDateTime = TimeZoneInfo.ConvertTimeFromUtc(start, tzi) });
                start = start.AddHours(1);
            }

            Periods = periods.ToArray();
        }

        public DateTime Date { get; private set; }
        public PowerPositionPeriod[] Periods { get; private set; }
    }
}