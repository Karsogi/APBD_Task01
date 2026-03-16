Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
if(!int.TryParse(input, out int number))
{
    Console.WriteLine("Invalid number!");
    return;
}