int i = 1;

Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine());

while (i<=num)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i++;
}