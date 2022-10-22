Console.Clear();
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A % 2 == 0)
{
    Console.WriteLine("Число " + A + " является четным");
}
else
{
    Console.WriteLine("Число " + A + " является нечетным");
}
