Console.WriteLine("Hello, World!");
string sentence = "Hello, World!";
int i = 0;
int count = 0;
while (i < sentence.Length)
{
    if (sentence[i] == ' ' || sentence[i] == ',' || sentence[i] == '!')
    {
        i++;
    }

    else
    {
        i++;
        count++;
    }
}
Console.WriteLine(count);