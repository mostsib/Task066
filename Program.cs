// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число  M:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите натуральное число  N:");
int number2 = int.Parse(Console.ReadLine());


void GapNumberSum (int number1, int number2, int sum)
{
    if (number1 > number2) 
    {
        Console.WriteLine($"Сумма натуральных элементов в заданном промежутке: {sum}"); 
        return;
    }
    sum = sum + (number1++);
    GapNumberSum(number1, number2, sum);
}

GapNumberSum(number1, number2, 0);