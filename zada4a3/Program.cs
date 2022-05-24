// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int InputFunction(string temp)
{
    Console.Write(temp);
    return Convert.ToInt32(Console.ReadLine());
}

int m = InputFunction("Введите число m ");
int n = InputFunction("Введите число n ");

if(m >= 0 && n >= 0)
{
    Console.WriteLine($"Вычисление равно : {AkkermanFunction(n, m)}");
}
else
{
    Console.WriteLine($"Вычисление Функции Аккермана не работает для отрицательных аргументов");
}

int AkkermanFunction(int n, int m)
{
    if (n == 0) 
        return m + 1;
    else if (n > 0 && m == 0) 
        return AkkermanFunction(n - 1, 1);
    else if (n > 0 && m > 0) 
        return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
    return AkkermanFunction(n,m);
}

   /* int InputFunction(string temp)
{
    Console.Write(temp);
    return Convert.ToInt32(Console.ReadLine());
}*/