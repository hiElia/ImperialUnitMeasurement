using System;

namespace ImperialUnitMeasurement
{
    class Program
    {


        static void Main(string[] args)
        {
            //do
            //{

            //} while (true);

            //var reply = "";
            //if (string.IsNullOrEmpty(reply))
            //{
            //    throw new Exception("No valid numbers are entered.");
            //}
            Console.WriteLine("Enter valid unit or q to quit");

            while (true)
            {
               
                
                try
                {

                   

                        string[] input = Console.ReadLine().Split();
                        var inputUnit = (input[0]);
                        var inputValue = double.Parse(input[1]);
                        var To = (input[2]);
                        var desiresInputunit = (input[3]);

                        var desiredInputvalue = Convert(inputUnit, inputValue, desiresInputunit);
                        Console.WriteLine($" =>{desiredInputvalue} {desiresInputunit}");






                    

                }
                catch
                {

                    Console.WriteLine("Enter valid  value");
                }
            }
          
           
            
          

          
            
          
            
              
           
          


           


           

            }
            public static double Convert(string input, double inputvalue, string desiredInput)
            {
                var counter = new ImperialUnit();
                var validatedUnitFrom = counter.UnitConvertor(input);

                var valueInBase = counter.ConvertToBase(validatedUnitFrom, inputvalue);

                var validatedUnitTo = counter.UnitConvertor(desiredInput);
                return counter.ConvertFromBase(validatedUnitTo, valueInBase);



            }
        }
    }

