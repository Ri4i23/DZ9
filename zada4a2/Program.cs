/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int numBegin = InputFunction("Введите значение N ");
int numConclusion = InputFunction("Введите значение M ");

int InputFunction(string temp)
{
    Console.Write(temp);
    return Convert.ToInt32(Console.ReadLine());
}

int result = RecursSum(numBegin,numConclusion);
Console.WriteLine(result + " ");

int RecursSum(int n,int m)
{
    if (n <= m)

        return n;

    return n + RecursSum(n - 1,m);
}
