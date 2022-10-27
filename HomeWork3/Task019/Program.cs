// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите положительное пятизначное число, а мы определим является ли число палиндромом");
string numFive = Console.ReadLine()!;
int len = numFive.Length;

if (len == 5)
{
    if (numFive[0] == numFive[4] && numFive[1] == numFive[3])
    {
        Console.WriteLine("Число " + numFive + " является палиндромом");
    }

    else
    {
        Console.WriteLine("Число " + numFive + " не является палиндромом");
    }
}

else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
