using System;
namespace CircleObjects
{
    public class Circle
    {
        //Properties
        public double radius;
 

        //Constructor
        public Circle(double _radius)
        {
            radius = _radius;
        }

        //Methods

        double CalculateCircumference()
        {
            //double circumference = 2 * radius * Math.PI;
            return 2 * radius * Math.PI; 
        }
        public double CalculateArea()
        {
            //double area = Math.PI * Math.Pow(radius, 2);
            return Math.PI * Math.Pow(radius, 2);
        }

        private string FormatNumber(double x)
        {
           return Math.Round(x, 2).ToString();
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
    }

}

//public Circle(double radius)
//public double CalculateCircumference()
//public string CalculateFormattedCircumference()
//public double CalculateArea()
//public string CalculateFormattedArea()
//private string FormatNumber(double x): 