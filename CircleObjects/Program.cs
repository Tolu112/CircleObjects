
//Task: Calculate a circle’s circumference and area.


//The application prompts the user to enter a radius; the user may enter a decimal number.
using CircleObjects;
int inputcount = 0;

//Program Loop
bool loopChoice = true;
while (loopChoice)
{
    double input;
    while (true)//Loop to display error if the user enters invalid data and ask the user again for a radius.
    {
        //Prompt user for radius
        Console.Write("Please enter a radius: ");

        //To address valid data
        if (double.TryParse(Console.ReadLine(), out input))
        {
            inputcount++;
            break;
        }
        //To address invalid data
        else
        {
            Console.WriteLine("That was not a number, please try again.");
        }
    }
    Circle circle = new Circle(input);

    //Display circumference and area
    Console.WriteLine("\nCircumference: " + circle.CalculateFormattedCircumference());
    Console.WriteLine("\nArea: " + circle.CalculateFormattedArea());
   
    //Loop to continue
    while (true)
    {
        
        Console.Write("\nWould you like to continue? y/n: ");
        string choice1 = Console.ReadLine().ToLower().Trim();
        //if yes, go to beginning
        if (choice1 == "y")
        {
           
            break;
        }
        //if no, end program
        else if (choice1 == "n")
        {
            
            Console.WriteLine($"You created {inputcount} circle object(s). See you next time!");
            loopChoice = false;
            break;
        }
        //loop again if entry is not y or n
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
    
}


//The application displays an error if the user enters invalid data and asks the user again for a radius.
//When the user enters valid data, the application calculates the area and circumference of the circle and rounds to the nearest 2 decimal places and prints out both.
//The application asks the user whether they want to do another.
//The application displays a “goodbye” message that also indicates the number of circles the user built when the user chooses not to continue.

//Build Specifications:
//Create a class named Circle to store the data about this circle. This class should contain these constructors and methods:
//public Circle(double radius)
//public double CalculateCircumference()
//public string CalculateFormattedCircumference()
//public double CalculateArea()
//public string CalculateFormattedArea()
//private string FormatNumber(double x)
//Define a member called radius. This member should be private. 
//Define a property to get access to the class member : Radius
//For the value of pi, use the PI constant of the System.Math class.
//In the Main method, get the user input, create a Circle object, and display the circumference and area.

//Hints:
//Don't forget using statement
//Don’t mess up the formulas for circumference or area of a circle!

//Extra Challenges:
//Create a class named Validator and use its static methods to validate the data in this application.




