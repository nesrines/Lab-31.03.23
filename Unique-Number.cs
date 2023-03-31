int[] numbers = { 1, 1, 2, 2, 3, 4, 5, 5, 7, 8, 8, 9, 9 };

for (int i = 0; i < numbers.Length; i++)
{
    bool x = true;
    for (int r = 0; r < numbers.Length; r++)
    {
        if (r != i && numbers[r] == numbers[i])
        {
            x = false;
            break;
        }
    }

    if (x == true)
    {
        Console.WriteLine(numbers[i]);
    }
}