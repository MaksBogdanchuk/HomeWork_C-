int[] array = { 1, 3, 15, 1, 456, 45, 123, 13, 15, 15, 12, 4, 158, 15, 9, 45, 156, 665, 15, 1478, 9, 6, 4 };

int n = array.Length;
int find = 15;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

