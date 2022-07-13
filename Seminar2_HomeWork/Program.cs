// Задача 1: Программа, которая принимает на вход трёхзначное число и 
//           на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)
{
    return num / 10 % 10;
}

Console.Write("Inter number: ");
int digit = SecondDigit (Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Second digit is: " + digit);
*/
// Задача 2: Программа, которая выводит третью цифру заданного числа или 
//           сообщает, что третьей цифры нет.

string ThirdDigit(string num)
{
    if (num.Length > 2)
    {
        return Console.WriteLine(num[2]);
    }
    
}

Console.WriteLine("Inter number: ");
int number = Convert.ToInt32(Console.ReadLine());
ThirdDigit(Convert.ToString(number));