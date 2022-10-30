int ToDegree(int a, int b, int result)
{
    int i = 1;
    while (i <= b)
    {
        result = result * a;
        i++;
    }
    return result;
}


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int numA = ReadInt("Введите число A: ");
int numB = ReadInt("Введите число B: ");
int result = 1;
Console.WriteLine($"Число A = {numA} в степени числа B = {numB}, равно {ToDegree(numA, numB, result)}");