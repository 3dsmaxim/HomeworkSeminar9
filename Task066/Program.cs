Console.Clear();


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine("Введите целое, положительное число N");
string text = Console.ReadLine();
string[] textT = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int numberStart = int.Parse(textT[0]);
int numberEnd = int.Parse(textT[1]);

void NumberString(int start, int end)
{
    Console.Write($"{start}");
    if (start == end) return;
    Console.Write($", ");
    NumberString(start +1, end);
    
}
NumberString(numberStart, numberEnd);

