Console.Clear();

void FindingTheThirdDigit()
{
    Console.WriteLine("Введите любое число:");
    int numA = Convert.ToInt32(Console.ReadLine());
    if (numA <= -100 || numA >= 100) // защита от пользователя который вводит 2-ухзначное число!
    {
        int numB = numA;
        while (numB <= -1000 || numB >= 1000) // не могу допереть,как сделать нахождение 3-ей цифры в отрицательном числе... Не работает с отрицательными числами.
        {
            numB = numB / 10;
        }
        int Third = numB % 10;
        Console.WriteLine("Третья цифра в числе " + numA + " , это " + Math.Abs(Third));
    }

    else
    {
        Console.WriteLine("В числе " + numA + " нет третьей цифры!");
        FindingTheThirdDigit();
    }
}

FindingTheThirdDigit();
