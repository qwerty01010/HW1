Console.WriteLine("Программа проверки четности числа");
Console.WriteLine("Введите целое число ");
string? numberString = Console.ReadLine ();

int number = int.Parse(numberString!);

int x = number%2;

if (x == 1)

{
    
  Console.Write (number + " - это нечетное число");

}
else
{
   Console.Write (number + " - это четное число");
}