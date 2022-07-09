//Задача 1:Принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

/*
int num1, num2, max, min;     // переменные

Console.Write("Введите первое число: ");    // ввод первого числа
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");    // ввод второго числа
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)                             // решение
{
    max = num1;
    min = num2;
    Console.WriteLine("Max = " + max);
    Console.WriteLine("Min = " + min);
}
else
{
    min = num1;
    max = num2;
    Console.WriteLine("Max = " + max);
    Console.WriteLine("Min = " + min);    
}
*/

// Задача 2:Принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

/*
int num1, num2, num3, max, max1;

Console.Write("Введите первое число: ");    // ввод первого числа
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");    // ввод второго числа
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");    // ввод третьего числа
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)                             // решение
{
    max1 = num1;
    if (max1 > num3)
    {
        max = max1;
        Console.WriteLine("Max = " + max);
    }
    else
    {
        max = num3;
        Console.WriteLine("Max = " + max);
    }
}
else
{
    if (num2 > num3)
    {
        max = num2;
        Console.WriteLine("Max = " + max);
    }
    else
    {
        max = num3;
        Console.WriteLine("Max = " + max);
    }
}
*/

// Задача 3: Принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
/*
int num;    // переменная

Console.Write("Введите число: ");    // ввод числа
num = Convert.ToInt32(Console.ReadLine());

if ((num % 2) == 0)                      // решение
{
    Console.WriteLine("Четное число!");
}
else
{
    Console.WriteLine("Нечетное число!");
}
*/

// Задача 4: Принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int num;

Console.Write("Введите число: ");    // ввод числа
num = Convert.ToInt32(Console.ReadLine());

if ((num % 2) == 0)                      // решение
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