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
/*
void ThirdDigit(int num)
{
    string number = Convert.ToString(num);

    if (number.Length > 2)
    {
        Console.WriteLine("Third digit is " + number[2]);
    }
    else
    {
        Console.WriteLine("Third digit is not!");
    }

}

Console.Write("Inter number: ");
int number = Convert.ToInt32(Console.ReadLine());
ThirdDigit(number);
*/

// Задача 3: Напишите программу, которая принимает на вход цифру, 
//           обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void DayOfWeek(int num)
{
    if (num == 0 || num > 7)
    {
        Console.WriteLine("You entered the wrong number!");
    }
    else
    {
            if (num < 6)
        {
            Console.WriteLine("No!");
        }
        else
        {
            Console.WriteLine("Yes!");
        }
    }
}
Console.Write("Inter number: ");
int number = Convert.ToInt32(Console.ReadLine());
DayOfWeek(number);
*/

// Задача 4: Принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
/*
void EvenNumbers(int num)
{
    if ((num % 2) == 0)                     
    {
        while (num > 0)
        {
            Console.WriteLine(num);
            num = num - 2;
        }
    }
    else
    {
        num--;
        while (num > 0)
        {
            Console.WriteLine(num);
            num = num - 2;
        }
    }
}

Console.Write("Inter number: ");
int number = Convert.ToInt32(Console.ReadLine());
EvenNumbers(number);
*/

// Задача 5: Принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

void EvenOrNotEven(int num)
{
    if ((num % 2) == 0)                      
    {
        Console.WriteLine("Четное число!");
    }
    else
    {
        Console.WriteLine("Нечетное число!");
    }
    
}

Console.Write("Inter number: ");
int number = Convert.ToInt32(Console.ReadLine());
EvenOrNotEven(number);