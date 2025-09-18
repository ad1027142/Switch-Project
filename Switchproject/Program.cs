// Program that asks what day it is
// List options
Console.WriteLine("What day is it?");
Console.WriteLine("1) Monday");
Console.WriteLine("2) Tuesday");
Console.WriteLine("3) Wednesday");
Console.WriteLine("4) Thursday");
Console.WriteLine("5) Friday");
Console.WriteLine("6) Saturday");
Console.WriteLine("7) Sunday");
// Gives a place to insert text after a blank line
Console.WriteLine();
Console.Write(">> ");
string day = Console.ReadLine() + "";
Console.WriteLine();
switch (day)
{
    case "Monday":
        Console.WriteLine("Aack! I hate Mondays");
        break;
    case "Tuesday":
        Console.WriteLine("It's Tuesday");
        break;
    case "Wednesday":
        Console.WriteLine("Hump Daaaay!");
        break;
    case "Thursday":
        Console.WriteLine("It's Thursday!");
        break;
    case "Friday":
        Console.WriteLine("TGIF");
        break;
    case "Saturday":
        Console.WriteLine("It's the weekend!");
        break;
    case "Sunday":
        Console.WriteLine("It's the weekend!");
        break;
    default:
        Console.WriteLine($"{day} Is not a day");
        break;
}