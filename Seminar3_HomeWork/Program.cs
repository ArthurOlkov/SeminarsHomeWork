// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

void Palindrome(int num)
{
    while (num > 99999 || num < 10000)
    {
        Console.Write("E R R O R! Inter a five-digit number for check: ");
        num = Convert.ToInt32(Console.ReadLine());
    }

    if ((num / 1000) == ((num % 10) * 10) + (num % 100 / 10))
    {
        Console.WriteLine("The number is a palindrome!");
    }
    else
    {
        Console.WriteLine("The number is not a palindrome!");
    }
}

Console.Write("Inter a five-digit number for check: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.