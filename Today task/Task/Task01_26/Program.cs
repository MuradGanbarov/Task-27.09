//Task 1
//Console.WriteLine("Please input first digit");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input second digit");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input third digit");
//int num3 = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input fourth digit");
//int num4 = int.Parse(Console.ReadLine());
//int summ = num + num2 + num3 + num4;
//Console.WriteLine("The amout of these digits");
//Console.WriteLine(summ);

//Task 2
//int num = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int num3 = int.Parse(Console.ReadLine());

//if (num != num2 && num != num3 && num2 != num3 )
//{
//    Console.WriteLine("Digits with difference");
//}

//else
//{
//    Console.WriteLine("Digits without difference");
//}

//Task 3 code was writted by me

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//a += 1;
//b -= 1;
//Console.WriteLine("a =" = a);
//Console.WriteLine("b =" = b);

//Task 3 code writted with google's help
//Console.WriteLine("input a digit");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("input b digit");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("a: " + a);
//Console.WriteLine("b: " + b);

//int temp = a;
//a = b;
//b = temp;
//Console.WriteLine("After changing:");
//Console.WriteLine("a: " + a);
//Console.WriteLine("b: " + b);

//Task 4
Console.WriteLine("Please input your age");
byte age = byte.Parse(Console.ReadLine());
Console.WriteLine("Do you have student id?");
bool student_id = bool.Parse(Console.ReadLine());

if (age <= 12 || age >= 60)
{
    Console.WriteLine("Price for your ticket is 5 AZN and you have discount");
}

else if (age >= 13 && age <= 59)
{
    if (student_id)
    {
        Console.WriteLine("Price for your ticket is 7.5 AZN");
    }
    else
    {
        Console.WriteLine("Price for your ticket is 10 AZN and you have no discount");
    }
}