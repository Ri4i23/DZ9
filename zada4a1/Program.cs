/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
    
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    
    N = 5 -> "5, 4, 3, 2, 1" */
    
int numberBegin = InputFunction("Введите значение M: ");
int numberConclusion = 1;

Console.WriteLine(OutputFunction(numberBegin, numberConclusion));

int InputFunction(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutputFunction(int numBegin, int numConclusion)
{
    if (numConclusion == numBegin)
    {
        return numConclusion;
    }
    Console.Write(OutputFunction(numBegin, numConclusion + 1) + ", ");
    return numConclusion;
}
