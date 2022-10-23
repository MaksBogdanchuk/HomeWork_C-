Console.Clear();

void FindingTheSecondDigit()
{
    Console.WriteLine("Введите любое трёхзначное число:");
    int numA = Convert.ToInt32(Console.ReadLine());
    if (numA >= -999 && numA <= 999) // защита от пользователя который не вводт 3-х значное число!
    {
        int dozens = (numA % 100) / 10;
        Console.WriteLine("Вторая цифра в числе " + numA + ", это " + dozens);
    }
    else
    {
        Console.WriteLine("Введено не трёхзначное число!Введите трёхзначное число!");
        FindingTheSecondDigit();
    }
}

FindingTheSecondDigit();