int[] MethodCube(int a)
{
    int i = 0;
    int[] cube = new int[a];
    while (i < a)
    {
        cube[i] = (i + 1) * (i + 1) * (i + 1);
        i++;
    }
    return cube;
}
Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
int[] cube = MethodCube(a);
Console.WriteLine(string.Join(", ", cube));



