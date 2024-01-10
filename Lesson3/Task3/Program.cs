void ZeroEvenElement(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}

int[] array = { 14, 46, 8, 9, 33 };
ZeroEvenElement(array);
PrintArray(array);
