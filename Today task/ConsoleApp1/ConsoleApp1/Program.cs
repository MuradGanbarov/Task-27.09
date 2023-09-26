Console.WriteLine("Please input your age");
byte age = byte.Parse(Console.ReadLine());
Console.WriteLine("Do you have student id?");
bool studen_id = bool.Parse(Console.ReadLine());

if (age <= 12 && age >= 60)
{
    if (studen_id == false)
    {
        Console.WriteLine("Price for your ticket is 5 and you have discount");
    }
}

else if (age >= 13 && age <= 59)
{

    if (studen_id == false)
    {
        Console.WriteLine("Price for your ticket is 10 AZN and you have no discount");
    } 
}

else
{
    Console.WriteLine("Price for your ticket is 5 and you have discount");
}

Console.WriteLine(".")