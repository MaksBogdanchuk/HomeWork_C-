Console.Clear();




void DayOfTheWeekWeekend()
{
    Console.WriteLine("Введите день недели(от 1 до 7):");
    int numA = Convert.ToInt32(Console.ReadLine());
    if (numA >= 1 && numA <= 5)
    {
        Console.WriteLine(numA + " день недели - не выходной!");
    }
    else if (numA >= 6 && numA <= 7)
    {
        Console.WriteLine(numA + " день недели - выходной!");
    }
    else
    {
        Console.WriteLine("В неделе 7 дней!");
        DayOfTheWeekWeekend();
    }
}

DayOfTheWeekWeekend();
