Console.Clear();


// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое, положительное число N");
int number = int.Parse(Console.ReadLine());

void NumberString(int start, int num)
{
    Console.Write($"{start}");
    if (start == num) return;
    Console.Write($", ");
    NumberString(start +1, num);
    
}
NumberString(1, number);