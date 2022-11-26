Console.Clear();


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Number(int num)
{
    while (num < 0)
    {
        Console.WriteLine("Неверный ввод");
        Console.Write("Введите повтоно целое положительное : ");
        num = int.Parse(Console.ReadLine());
    }
    return num;
}

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    else if (m > 0 && n > 0) return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    return n + 1; // без этой записи матеится   
}


Console.Write("Введите целое положительное m: ");
int numberM = Number(int.Parse(Console.ReadLine()));


Console.Write("Введите целое положительное n: ");
int numberN = Number(int.Parse(Console.ReadLine()));

int result = FunctionAkkerman(numberM, numberN);

Console.WriteLine(result);

// Ничего не понял;
// Что это? 
// Зачем это?
// Где применять?
// Как вывели?
// Принцип  дернул с "Определение" с "вики" отсюда https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
// НО! работает.  Проверил по табличке она там же)))

