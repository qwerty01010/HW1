Console.WriteLine("Программа проверки максимального числа");
Console.WriteLine("Введите первое целое число ");
string? numberString = Console.ReadLine ();

int number = int.Parse(numberString!);

Console.WriteLine("Программа проверки");
Console.WriteLine("Введите второе целое число ");
string? numberString2 = Console.ReadLine ();

int number2 = int.Parse(numberString2!);

if (number > number2)

{
    Console.Write ("Max number is " + number);
}

else
{
     Console.Write ("Max number is " + number2);
}