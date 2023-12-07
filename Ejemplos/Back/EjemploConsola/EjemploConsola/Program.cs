// See https://aka.ms/new-console-template for more information
// How to write in the console:
Console.WriteLine("Hello, World!");
Console.WriteLine("My name is Pedro.");

Console.WriteLine("Please type your name.");
// How to read from the console. 
var myValue = Console.ReadLine();

Console.WriteLine("The value was: " + myValue);

//Control structures. 

// Conditional
var num = 4;
if (num == 5) // Evaluates an expression.
{
    // When the expression is true ...
    Console.WriteLine("The number was equal to 5");
}
else
{
    // When the expression is false...
    Console.WriteLine("The number was not equal to 5");
}

// Loops
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"iteration number: {i} -  {num} with the value {myValue}");
}

var num2 = 0;
while (num2 != 4)
{
    Console.WriteLine("The number was " + num2);
    num2++;
}