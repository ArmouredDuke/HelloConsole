int numA = new Random().Next(1, 10); // new Random().Next(min, max-1) в данном случае будет числовой ряд от 1 до 9, ибо int
Console.WriteLine(numA);
int numB = new Random().Next(1, 10);
Console.WriteLine(numB);
int result = numA + numB;
Console.WriteLine(result);