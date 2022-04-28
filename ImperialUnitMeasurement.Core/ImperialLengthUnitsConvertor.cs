using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialUnitMeasurement.Core
{
    
    public class ImperialLengthUnitsConvertor : IMeasurement
    {
        public double Convert(string input, double inputvalue, string desiredInput)
        {
        

                var validatedUnitFrom = UnitConvertor(input);

                var valueInBase = ConvertToBase(validatedUnitFrom, inputvalue);

                var validatedUnitTo = UnitConvertor(desiredInput);
                return ConvertFromBase(validatedUnitTo, valueInBase);



            
        }

        public double ConvertFromBase(string input, double measurement)
        {
            double conversionRate = GetConversionRate(input);
            return measurement / conversionRate;
        }

        public double ConvertToBase(string input, double measurement)
        {
            double conversionRate = GetConversionRate(input);
            return conversionRate * measurement;
        }

        public double GetConversionRate(string name)
        {

            double conversionRate = 1;
            switch (name)
            {
                case "thou":
                    break;
                case "inch":
                    conversionRate *= 1000;
                    break;
                case "foot":
                    conversionRate *= 1000 * 12;
                    break;
                case "yard":
                    conversionRate *= 1000 * 12 * 3;
                    break;
                case "furlong":
                    conversionRate *= 1000 * 12 * 3 * 220;
                    break;

            }
            return conversionRate;
        }

        public string UnitConvertor(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                throw new Exception("No valid input  entered.");
            }

            input = input.ToLowerInvariant();
            switch (input)
            {
                case "Th":
                case "thou":
                    return "thous";
                case "inch":
                case "in":
                    return "inch";
                case "foot":
                case "ft":
                    return "foot";
                case "yard":
                case "yr":
                    return "yard";
                case "furlong":
                case "fur":
                    return "furlong";
                default:
                    throw new ArgumentException($"{input} is not valid input");
            }
           
        }
       
    }
}
