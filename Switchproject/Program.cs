// Program that asks what day it is
// List options
Console.WriteLine("What day is it? Pick a number");
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
// Decides which day is inputed
switch (day)
{
    case "1":
        Console.WriteLine("Aack! I hate Mondays");
        break;
    case "2":
        Console.WriteLine("It's Tuesday");
        break;
    case "3":
        Console.WriteLine("Hump Daaaay!");
        break;
    case "4":
        Console.WriteLine("It's Thursday!");
        break;
    case "5":
        Console.WriteLine("TGIF");
        break;
    case "6":
        Console.WriteLine("It's the weekend!");
        break;
    case "7":
        Console.WriteLine("It's the weekend!");
        break;
    default:
        Console.WriteLine($"{day} Is not a day");
        break;
}
