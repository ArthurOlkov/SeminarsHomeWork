// Задача 1: Программа, которая принимает на вход трёхзначное число и 
//           на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
    return num / 10 % 10;
}

Console.Write("Inter number: ");
int digit = SecondDigit (Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Second digit is: " + digit);

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
/*
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
*/

// Задача 6: Принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
void MaxNumber(int num1, int num2, int num3)
{
    if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.WriteLine("Max = " + num1);
        }
        else
        {
            Console.WriteLine("Max = " + num3);
        }
    }
    else
    {
        if (num2 > num3)
        {
            Console.WriteLine("Max = " + num2);
        }
        else
        {
            Console.WriteLine("Max = " + num3);
        }
    }
}

Console.Write("Введите первое число: ");    // ввод первого числа
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");    // ввод второго числа
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");    // ввод третьего числа
int num3 = Convert.ToInt32(Console.ReadLine());

MaxNumber(num1, num2, num3);
*/

//Задача 7: Принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
void MaxAndMinNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.WriteLine("Max = " + num1);
        Console.WriteLine("Min = " + num2);
    }
    else
    {
        Console.WriteLine("Max = " + num2);
        Console.WriteLine("Min = " + num1);
    }
}

Console.Write("Введите первое число: ");    // ввод первого числа
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");    // ввод второго числа
int num2 = Convert.ToInt32(Console.ReadLine());

MaxAndMinNumbers(num1, num2);
*/