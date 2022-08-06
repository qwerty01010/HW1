Console.WriteLine("Программа вывода четных числа");
Console.WriteLine("Введите число ");
string? numberString = Console.ReadLine ();

int number = int.Parse(numberString!);

int i = 0;

if (number < 0) 
{
  int number1 = number * -1;
  while (i <= number1) 

  {
    int x = i%2;

    if (x == 1) 
    { i++; }

    else 
    if ( i == 0 ) {Console.WriteLine (i++);}
    else { Console.WriteLine ( "-" + i++); };

  }

}
else 
{

 while (i <= number) 

 {
   int x = i%2;

    if (x == 1) 
     { i++; }

    else 
      { Console.WriteLine (i++); }
  
  }
}