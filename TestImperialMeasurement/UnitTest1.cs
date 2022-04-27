using ImperialUnitMeasurement;
using System;
using Xunit;

namespace TestImperialMeasurement
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //        Thou (th)
            //Inch (in) 1000 thous
            //Foot (ft) 12 inches
            //Yard (yd) 3 feet
            //Furlong (fur) 220 yards
            // arrang
            var unit = new ImperialUnit();
            //var p = new Program();
            var input = "THOU";
            var inputValue = 1000;
            var desiredUnit = "INch";

            // Act
            var valueInDesiredUnit = Program.Convert(input, inputValue, desiredUnit);

            Assert.Equal(2, valueInDesiredUnit);

        }
    }
}
