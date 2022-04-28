using ImperialUnitMeasurement.Core;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace ImperialUnitMeasurement
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
           .AddSingleton<IMeasurement, ImperialLengthUnitsConvertor>()
           .BuildServiceProvider();
            var measurementService = serviceProvider.GetService<IMeasurement>();


            Console.WriteLine("Units that can be converted are: Inch,Yard,Furlong, Foot, Thou.");
            Console.WriteLine("-----------------------------------------------------------------------");            
            Console.WriteLine("Enter valid unit and value to be converted such as:  2 inch in furlong or 2 in in fur.");
            while (true)
            {                 
                try
                {
                        string[] input = Console.ReadLine().Split();
                        var inputValue = double.Parse(input[0]);
                        var inputUnit = (input[1]);                        
                        string st = (input[2]);
                        var desiresInputunit = (input[3]);                    

                        var desiredInputvalue =  measurementService.Convert(inputUnit, inputValue, desiresInputunit);
                        Console.WriteLine($"{inputValue} {inputUnit} => {desiredInputvalue} {desiresInputunit} ");                                   

                }
                catch
                {

                    Console.WriteLine("Enter valid unit and input value");
                }
               
            }           

            }
         
        }
} //va

