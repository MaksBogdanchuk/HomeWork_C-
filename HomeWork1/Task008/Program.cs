Console.Clear();
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int count = 1;

Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + A);
while (count <= A)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
    }
    count++;
}
if (A <= 1)
{
    Console.WriteLine("Нет чётных чисел!");
}




