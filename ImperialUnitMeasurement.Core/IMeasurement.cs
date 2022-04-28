using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialUnitMeasurement
{
    public interface IMeasurement
    {
        public string UnitConvertor(string input);
        public double GetConversionRate(string name);
        public double ConvertFromBase(string input, double measurement);
        public double ConvertToBase(string input, double measurement);
        public double Convert(string input, double inputvalue, string desiredInput);
    }
}
