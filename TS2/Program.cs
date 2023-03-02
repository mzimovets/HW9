Console.Write("Введите значение M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int numN = int.Parse(Console.ReadLine());

void Numbers (int numM, int numN, int NumSum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {NumSum}"); 
        return;
    }
    NumSum = NumSum + (numM++);
    Numbers(numM, numN, NumSum);
}

Numbers(numM, numN, 0);