using ImperialUnitMeasurement;
using ImperialUnitMeasurement.Core;
using System;
using Xunit;

namespace TestImperialMeasurement
{
    public class UnitTest1
    {
        [Fact]
        public void Convert_1FurlongToYard_Return220()
        {
            //        Thou (th)
            //Inch (in) 1000 thous
            //Foot (ft) 12 inches
            //Yard (yd) 3 feet
            //Furlong (fur) 220 yards
            // arrang
            var unit = new ImperialLengthUnitsConvertor();
            //var p = new Program();
            var input = "Fur";
            var inputValue = 1;
            var desiredUnit = "Yard";

            //// Act
            var valueInDesiredUnit = unit.Convert(input, inputValue, desiredUnit);

            Assert.Equal(221, valueInDesiredUnit, 1);

        }
        [Fact]
        public void Convert_oneFootToInch_Return12()
        {
            //        Thou (th)
            //Inch (in) 1000 thous
            //Foot (ft) 12 inches
            //Yard (yd) 3 feet
            //Furlong (fur) 220 yards
            // arrang
            var unit = new ImperialLengthUnitsConvertor();
            //var p = new Program();
            var input = "ft";
            var inputValue = 1;
            var desiredUnit = "in";

            //// Act
            var valueInDesiredUnit = unit.Convert(input, inputValue, desiredUnit);

            Assert.Equal(12, valueInDesiredUnit, 1);

        }
        [Fact]
        public void Convert_OnethouToInch_Return0001()
        {
            //        Thou (th)
            //Inch (in) 1000 thous
            //Foot (ft) 12 inches
            //Yard (yd) 3 feet
            //Furlong (fur) 220 yards
            // arrang
            var unit = new ImperialLengthUnitsConvertor();
            //var p = new Program();
            var input = "thou";
            var inputValue = 1;
            var desiredUnit = "in";

            //// Act
            var valueInDesiredUnit = unit.Convert(input, inputValue, desiredUnit);

            Assert.Equal(0.001, valueInDesiredUnit, 3);

        }
    }
}
