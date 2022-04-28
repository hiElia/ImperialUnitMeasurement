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
            
            var unit = new ImperialLengthUnitsConvertor();
            
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
           
            var unit = new ImperialLengthUnitsConvertor();       
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
          
            var unit = new ImperialLengthUnitsConvertor();         
            var input = "thou";
            var inputValue = 1;
            var desiredUnit = "in";

            //// Act
            var valueInDesiredUnit = unit.Convert(input, inputValue, desiredUnit);

            Assert.Equal(0.001, valueInDesiredUnit, 3);

        }
    }
}
