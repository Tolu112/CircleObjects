//CIRCLE OBJECTS
using CircleObjects;

Console.WriteLine("Welcome to the Cirle Objects Database!\n");

//Declare counter index
int CircleCount = 0;

//Program loop
bool runProgram = true;
while (runProgram)
{
    //Get radius from user and validate
    
    double input = Validator.Validator.GetUserNumberDouble("Please enter a radius: ");

    //Instantiate new object
    Circle circle = new Circle(input);

    //Display results
    Console.WriteLine("\nCircumference: " + circle.CalculateFormattedCircumference());
    Console.WriteLine("\nArea: " + circle.CalculateFormattedArea());

    //Add to circle count
    CircleCount++;

    //Ask user if they'd like to continue
    
    runProgram = Validator.Validator.GetContinue();
    Console.Clear();
}

Console.Write($" You created {CircleCount} Circle Objects(s). Goodbye!");



