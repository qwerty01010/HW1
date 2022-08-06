Console.WriteLine("Программа проверки максимального числа");
Console.WriteLine("Введите первое целое число ");
string? numberString = Console.ReadLine ();

int number = int.Parse(numberString!);

Console.WriteLine("Программа проверки");
Console.WriteLine("Введите второе целое число ");
string? numberString2 = Console.ReadLine ();

int number2 = int.Parse(numberString2!);

Console.WriteLine("Программа проверки");
Console.WriteLine("Введите третье целое число ");
string? numberString3 = Console.ReadLine ();

int number3 = int.Parse(numberString3!);


if (number > number2)

{
    if (number > number3) 
    {
      Console.Write ("Max number is " + number);
    }

}
else
{
     if (number2 > number3) 
    {
      Console.Write ("Max number is " + number2);
    }
    else
    {
        Console.Write ("Max number is " + number3);
    }
}