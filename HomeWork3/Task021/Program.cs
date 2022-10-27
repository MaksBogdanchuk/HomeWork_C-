/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 

Решение:
1. Ввод значений
2. Вычисление расстояния между точками
3. Печать результата

*/

/* Console.WriteLine("Введите координаты двух точек, а мы рассчитаем расстояние между ними в 3D пространстве");
double Xa = 6;
double Xb = 4;
double Ya = 4;
double Yb = 7;
double Za = 7;
double Zb = 5;
double result = Math.Round(Math.Sqrt(Math.Pow((Xa - Xb), 2) + Math.Pow((Ya - Yb), 2) + Math.Pow((Za - Zb), 2)), 2);
Console.WriteLine(result);
*/


double EnteringText(string text)
{
    Console.Write(text + ": ");
    double Entering = Convert.ToDouble(Console.ReadLine());
    return Entering;
}


void PrintResult(double Xa, double Xb, double Ya, double Yb, double Za, double Zb, double result)
{
    string print = $"|Расстояние между точками A ({Xa}, {Ya}, {Za}) и B ({Xb}, {Yb}, {Zb})| = {Math.Round(result, 2)}";
    Console.WriteLine(print);
}


double ResultDistance(double Xa, double Xb, double Ya, double Yb, double Za, double Zb)
{
    double x = Math.Pow((Xa - Xb), 2);
    double y = Math.Pow((Ya - Yb), 2);
    double z = Math.Pow((Za - Zb), 2);
    double result = Math.Sqrt(x + y + z);
    return result;
}

double Xa = EnteringText("Введите координаты Xa");
double Xb = EnteringText("Введите координаты Xb");
double Ya = EnteringText("Введите координаты Ya");
double Yb = EnteringText("Введите координаты Yb");
double Za = EnteringText("Введите координаты Za");
double Zb = EnteringText("Введите координаты Zb");
double result = ResultDistance(Xa, Xb, Ya, Yb, Za, Zb);
PrintResult(Xa, Xb, Ya, Yb, Za, Zb, result);

