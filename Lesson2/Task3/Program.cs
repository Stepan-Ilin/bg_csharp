// int n = 10;
int[] array = { 1, 6, 4, 9, 7, 1, 4, 7, 3, 8 };
int i = 0;
while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write(array[i] + " ");
    }
    i++;
}