using Microsoft.VisualBasic;
using System.Xml.Schema;


namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Mercedes";
            myCar.Model = "AMG";
            myCar.Year = 2023;

            var Bmw = new Car()
            {
                Make = "BMW",
                Model = "M4",
                Year = 2002

            };

            

            var chevy = new Car("Chevy", "Impala", 1969);

            var carList = new List<Car>() { myCar, Bmw, chevy};

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        
    
    
        

            
            
        


            
        }
    }
}
