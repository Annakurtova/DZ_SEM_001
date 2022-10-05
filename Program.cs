// Напишите программу, которая на вход принимает целое число и выдает, является ли оно четным
/*
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else{ 
    Console.WriteLine("Число нечетное");
}
*/

// Напишите программу, которая на вход принимает три числа и выдает максимальное из них
/*
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    (num1 = max);
}
else if (num1 < num2)
{
    (num2 = max);
}
if (num2 > num3){
    (num2 = max);
}
else (num3 = max);
{
    Console.WriteLine($"Наибольшее число равно {max}");
}
*/

// Напишите программу, которая на вход принимает 2 числа и выдает, какое из них большее, а какое меньшее
/*
Console.Write("Enter first number");
int num1 = int.Parse(ConsoleReadLine());
Console.Write("Enter second number");
int num2 = int.Parse(ConsoleReadLine());

if (num1 > num2)
{
    Console.WriteLine("First number bigger than second");
}
else if (num1 < num2)
{
    Console.WriteLine("Second number bigger than first number")
}
else
{
    Console.WriteLine("Числа равны");
}
*/

// Напишите программу. которая на вход принимает число Н, а на выходе показывает все четные числа от 1 до Н

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
int a = 1;

while ((a < num) && (a % 2 == 0) )
{
    Console.WriteLine(a);
    a++;
}