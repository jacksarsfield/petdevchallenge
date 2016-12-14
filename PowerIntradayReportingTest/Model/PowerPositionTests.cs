using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerIntradayReporting.Model;

namespace PowerIntradayReportingTest.Model
{
    [TestClass]
    public class PowerPositionTests
    {
        [TestMethod]
        public void WillCreatePositionForTheRequiredNumberOfPeriods()
        {
            var date = new DateTime(2015, 6, 3);
            var position = new PowerPosition(date);

            Assert.AreEqual(date, position.Date);
            Assert.AreEqual(24, position.Periods.Length);
        }

        [TestMethod]
        public void WillSetThePeriodDateTimeToReflect()
        {
            var date = new DateTime(2015, 6, 3);
            var position = new PowerPosition(date);

            Assert.AreEqual(24, position.Periods.Length);
            Assert.AreEqual(new DateTime(2015, 6, 2, 23, 0, 0), position.Periods[0].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 0, 0, 0), position.Periods[1].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 1, 0, 0), position.Periods[2].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 2, 0, 0), position.Periods[3].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 3, 0, 0), position.Periods[4].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 4, 0, 0), position.Periods[5].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 5, 0, 0), position.Periods[6].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 6, 0, 0), position.Periods[7].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 7, 0, 0), position.Periods[8].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 8, 0, 0), position.Periods[9].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 9, 0, 0), position.Periods[10].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 10, 0, 0), position.Periods[11].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 11, 0, 0), position.Periods[12].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 12, 0, 0), position.Periods[13].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 13, 0, 0), position.Periods[14].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 14, 0, 0), position.Periods[15].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 15, 0, 0), position.Periods[16].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 16, 0, 0), position.Periods[17].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 17, 0, 0), position.Periods[18].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 18, 0, 0), position.Periods[19].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 19, 0, 0), position.Periods[20].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 20, 0, 0), position.Periods[21].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 21, 0, 0), position.Periods[22].PeriodDateTime);
            Assert.AreEqual(new DateTime(2015, 6, 3, 22, 0, 0), position.Periods[23].PeriodDateTime);
        }

        [TestMethod]
        public void WhenShortDayWillCreatePositionForTheRequiredNumberOfPeriods()
        {
            var date = new DateTime(2016, 3, 27);
            var position = new PowerPosition(date);

            Assert.AreEqual(date, position.Date);
            Assert.AreEqual(23, position.Periods.Length);
        }

        [TestMethod]
        public void WhenShortDayWillSetThePeriodDateTimeToReflect()
        {
            var date = new DateTime(2016, 3, 27);
            var position = new PowerPosition(date);

            Assert.AreEqual(23, position.Periods.Length);
            Assert.AreEqual(new DateTime(2016, 3, 26, 23, 0, 0), position.Periods[0].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 0, 0, 0), position.Periods[1].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 2, 0, 0), position.Periods[2].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 3, 0, 0), position.Periods[3].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 4, 0, 0), position.Periods[4].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 5, 0, 0), position.Periods[5].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 6, 0, 0), position.Periods[6].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 7, 0, 0), position.Periods[7].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 8, 0, 0), position.Periods[8].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 9, 0, 0), position.Periods[9].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 10, 0, 0), position.Periods[10].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 11, 0, 0), position.Periods[11].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 12, 0, 0), position.Periods[12].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 13, 0, 0), position.Periods[13].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 14, 0, 0), position.Periods[14].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 15, 0, 0), position.Periods[15].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 16, 0, 0), position.Periods[16].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 17, 0, 0), position.Periods[17].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 18, 0, 0), position.Periods[18].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 19, 0, 0), position.Periods[19].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 20, 0, 0), position.Periods[20].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 21, 0, 0), position.Periods[21].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 3, 27, 22, 0, 0), position.Periods[22].PeriodDateTime);
        }

        [TestMethod]
        public void WhenLongDayWillCreatePositionForTheRequiredNumberOfPeriods()
        {
            var date = new DateTime(2016, 10, 30);
            var position = new PowerPosition(date);

            Assert.AreEqual(date, position.Date);
            Assert.AreEqual(25, position.Periods.Length);
        }

        [TestMethod]
        public void WhenLongDayWillSetThePeriodDateTimeToReflect()
        {
            var date = new DateTime(2016, 10, 30);
            var position = new PowerPosition(date);

            Assert.AreEqual(25, position.Periods.Length);
            Assert.AreEqual(new DateTime(2016, 10, 29, 23, 0, 0), position.Periods[0].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 0, 0, 0), position.Periods[1].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 1, 0, 0), position.Periods[2].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 1, 0, 0), position.Periods[3].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 2, 0, 0), position.Periods[4].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 3, 0, 0), position.Periods[5].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 4, 0, 0), position.Periods[6].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 5, 0, 0), position.Periods[7].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 6, 0, 0), position.Periods[8].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 7, 0, 0), position.Periods[9].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 8, 0, 0), position.Periods[10].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 9, 0, 0), position.Periods[11].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 10, 0, 0), position.Periods[12].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 11, 0, 0), position.Periods[13].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 12, 0, 0), position.Periods[14].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 13, 0, 0), position.Periods[15].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 14, 0, 0), position.Periods[16].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 15, 0, 0), position.Periods[17].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 16, 0, 0), position.Periods[18].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 17, 0, 0), position.Periods[19].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 18, 0, 0), position.Periods[20].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 19, 0, 0), position.Periods[21].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 20, 0, 0), position.Periods[22].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 21, 0, 0), position.Periods[23].PeriodDateTime);
            Assert.AreEqual(new DateTime(2016, 10, 30, 22, 0, 0), position.Periods[24].PeriodDateTime);
        }
    }
}