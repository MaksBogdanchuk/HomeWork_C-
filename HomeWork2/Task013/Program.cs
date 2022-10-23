Console.Clear();

Console.WriteLine("Введите любое число:");
int numA = Convert.ToInt32(Console.ReadLine());


void FindingTheThirdDigit()
{
    if (numA >= -100 && numA >= 100) // защита от пользователя который вводит 2-ухзначное число!
    {
        while (numA >= -1000 && numA >= 1000) // не могу допереть,как сделать нахождение 3-ей цифры в отрицательном числе... Не работает с отрицательными числами.
        {
            numA = numA / 10;
        }
        int Third = numA % 10;
        Console.WriteLine("Третья цифра в числе, это " + Third);
    }

    else
    {
        Console.WriteLine("В числе " + numA + " нет третьей цифры!");
    }
}

FindingTheThirdDigit();
