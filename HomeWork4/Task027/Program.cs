int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

int SumNumbers(int n, int len, int sum)
{
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

int numA = ReadInt("Введите число: ");
int len = NumberLen(numA);
int sum = 0;
Console.WriteLine($"Сумма цифр в числе {numA} = {SumNumbers(numA, len, sum)}");

