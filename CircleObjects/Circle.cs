using System;
namespace CircleObjects
{
    public class Circle
    {
        //Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
 
        //Property
        public double Radius;


        //METHODS

        //Method to calculate circumference
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        //Method to calculate Area
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        //Private helper method to format radius to 2 decimal places
        private string FormatNumber(double rad)
        {
            return Math.Round(rad, 2).ToString();
        }

        //Method to format circumference to 2 decimal places
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        //Method to format Area to 2 decimal places
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
    }
}

