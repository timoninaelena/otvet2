int number = new Random().Next(100,1000);
Console.WriteLine(number);
int firstDigit = number / 100;
int remains = number % 100;
int SecondDigit = remains / 10;

Console.WriteLine(SecondDigit);

