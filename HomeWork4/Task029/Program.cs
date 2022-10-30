int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] massiv8elements(int lenArray)
{
    int i = 0;
    int[] randomArray = new int[lenArray];
    while (i < randomArray.Length)
    {
        randomArray[i] = new Random().Next(1, 9);
        i++;
    }
    return randomArray;
}

int lenArray = ReadInt("Введите длинну массива: ");
int[] randomArray = massiv8elements(lenArray);
Console.WriteLine(string.Join(", ", randomArray));


