// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
/*
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
*/
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
/*
double Distanse3DSpace(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distanse = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return distanse;
}

Console.Write("Inter the coordinates of point A on the X axis: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inter the coordinates of point A on the Y axis: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inter the coordinates of point A on the Z axis: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inter the coordinates of point B on the X axis: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inter the coordinates of point B on the Y axis: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inter the coordinates of point B on the Z axis: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Distanse3DSpace(x1,x2,y1,y2,z1,z2));
*/
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TableOfCubes(int num)
{
    while (num > 0)
    {
        Console.WriteLine("{0:f}            {1:f}", num, num * num * num);
        num--;
    }
}
Console.Write("Inter number: ");
int number = Convert.ToInt32(Console.ReadLine());
TableOfCubes(number);
