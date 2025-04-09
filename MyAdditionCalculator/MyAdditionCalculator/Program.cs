// See https://aka.ms/new-console-template for more information

// datatype variableName = initial value;
int myNumber = 0;
int myNumber2 = 0;

// Prints out whatever is in side of ()
Console.WriteLine("Enter a  whole number!");


// takes the user input and stores it
// Variable with the name "userInput" and the data type "string"
// strings are used for text
String userInput = Console.ReadLine();
// myNumber = int.Parse(Console.ReadLine());
myNumber = int.Parse(userInput);

// Prints out whatever is in side of ()
Console.WriteLine("Enter a  whole number!");
userInput = Console.ReadLine();
myNumber2 = int.Parse(userInput);

int sum = myNumber + myNumber2;

// we are adding to string togehter and writing them onto the console
Console.WriteLine("The result of " + myNumber + " and " + myNumber2 + " is " + sum);
Console.ReadKey();
