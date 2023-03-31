 int[] numbers = {6, 5, 7, 18, 29, 36};
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
    sum += numbers[i];
}
Console.WriteLine("cem = " + sum);
