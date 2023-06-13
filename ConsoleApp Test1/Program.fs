// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#" 
Console.Write("Enter a value of X: "); // Display String Reminder
int x = Convert.ToInt32(Console.Readline()); // Similar to Scanner class (Read an input from the user)
Console.Write("Enter a Value of Y: ");
int y = Convert.ToInt32(Console.Readline());
if (x+y == 14) then Console.WriteLine("Hello World") // If condition is Right, Write Hello World on the screen
else 
if ((x+y != 14) && (x !=Y)) then Console.WriteLine("Wrong Answer!") // Do otherwise if the above is wrong
