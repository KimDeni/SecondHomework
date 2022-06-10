// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int secondValue = ((number % 100) / 10);

Console.WriteLine(secondValue);