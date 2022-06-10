// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

//int number;

Console.WriteLine("Введите число: ");


int number = Convert.ToInt32(Console.ReadLine());


if (number < 100)
    Console.WriteLine("Третьего числа нет!");
else{
    string str = number.ToString();
    Console.WriteLine(str[2]);
}
