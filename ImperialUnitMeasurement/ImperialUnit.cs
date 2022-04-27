using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialUnitMeasurement
{
   public class ImperialUnit : IMeasurement
    {
        public double ConvertFromBase(string input, double measurement)
        {
          double conversionRate= GetConversionRate(input);
            return conversionRate/ measurement;
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
        //Thou(th)
        //Inch (in) 1000 thous
        //Foot (ft) 12 inches
        //Yard (yd) 3 feet
        //Furlong (fur) 220 yards

        public string UnitConvertor(string input)
        {
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
