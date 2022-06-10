// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня: ");

int numberOfDay = Convert.ToInt32(Console.ReadLine());

if (numberOfDay > 7 || numberOfDay < 1)
    Console.WriteLine(-1);
    else if (numberOfDay == 6 || numberOfDay == 7){
        Console.Write(numberOfDay);
        Console.WriteLine(" день недели является выходным.");
    } else{
        Console.Write(numberOfDay);
        Console.WriteLine(" день недели является будним днем.");
    }

