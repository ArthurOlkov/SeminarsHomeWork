// Задача 1: Программа, которая принимает на вход трёхзначное число и 
//           на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
    return num / 10 % 10;
}

Console.Write("Inter number: ");
int digit = SecondDigit (Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Second digit is: " + digit);
