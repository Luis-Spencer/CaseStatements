﻿int day;
Console.WriteLine("Please enter a number between 1 and 7");
try
{
    day = Convert.ToInt32(Console.ReadLine());

    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;

        default:
            Console.WriteLine("Only numbers between 1 and 7 are valid");
            break;
    }
}
catch
{
    Console.WriteLine("Incorrect format please enter a NUMBER between 1 and 7");
}
Console.ReadKey();